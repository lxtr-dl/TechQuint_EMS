using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TechQuint_EMS.Emp_Login_Page;

namespace TechQuint_EMS
{

    public partial class employee_dashboard_page : Form
    {
        private Button selectedNavButton = null;
        private readonly Color navHighlightColor = Color.Teal; 
        private readonly Color navDefaultBackColor = Color.Black;
        private readonly Color navDefaultForeColor = Color.White;
        private readonly Color navHighlightForeColor = Color.White;

        private DateTime timeIn; 
        private DateTime timeOut; 

        
        // Buttons
        private void profile_btn_Click(object sender, EventArgs e)
        {
            SetSelectedNavButton(profile_btn);
            emp_profile_page start = new emp_profile_page();
            start.Show();
            this.Hide();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            SetSelectedNavButton(logout_btn);
            Welcome_Page start = new Welcome_Page();
            start.Show();
            this.Hide();
        }


        private void timelog_btn_Click(object sender, EventArgs e)
        {
            SetSelectedNavButton(timelog_btn);
        }


        // Buttons Hover
        private void timelog_btn_MouseEnter(object sender, EventArgs e)
        {
            if (selectedNavButton != timelog_btn)
            {
                timelog_btn.BackColor = navHighlightColor;
                timelog_btn.ForeColor = navHighlightForeColor;
            }
        }

        private void timelog_btn_MouseLeave(object sender, EventArgs e)
        {
            if (selectedNavButton != timelog_btn)
            {
                timelog_btn.BackColor = navDefaultBackColor;
                timelog_btn.ForeColor = navDefaultForeColor;
            }
        }

        private void profile_btn_MouseEnter(object sender, EventArgs e)
        {
            if (selectedNavButton != profile_btn)
            {
                profile_btn.BackColor = navHighlightColor;
                profile_btn.ForeColor = navHighlightForeColor;
            }
        }

        private void profile_btn_MouseLeave(object sender, EventArgs e)
        {
            if (selectedNavButton != profile_btn)
            {
                profile_btn.BackColor = navDefaultBackColor;
                profile_btn.ForeColor = navDefaultForeColor;
            }
        }

        private void logout_btn_MouseEnter(object sender, EventArgs e)
        {
            if (selectedNavButton != logout_btn)
            {
                logout_btn.BackColor = navHighlightColor;
                logout_btn.ForeColor = navHighlightForeColor;
            }
        }

        private void logout_btn_MouseLeave(object sender, EventArgs e)
        {
            if (selectedNavButton != logout_btn)
            {
                logout_btn.BackColor = navDefaultBackColor;
                logout_btn.ForeColor = navDefaultForeColor;
            }
        }

        private void TimeIn_btn_MouseEnter(object sender, EventArgs e)
        {
            TimeIn_btn.BackColor = Color.Teal;
            TimeIn_btn.ForeColor = Color.White;
        }

        private void TimeIn_btn_MouseLeave(object sender, EventArgs e)
        {
            TimeIn_btn.BackColor = Color.FromArgb(73, 163, 160);
            TimeIn_btn.ForeColor = Color.White;
        }

        private void TimeOut_btn_MouseEnter(object sender, EventArgs e)
        {
            TimeOut_btn.BackColor = Color.Teal;
            TimeOut_btn.ForeColor = Color.White;
        }

        private void TimeOut_btn_MouseLeave(object sender, EventArgs e)
        {
            TimeOut_btn.BackColor = Color.FromArgb(73, 163, 160);
            TimeOut_btn.ForeColor = Color.White;
        }

        private void SetSelectedNavButton(Button btn)
        {
            if (selectedNavButton != null)
            {
                selectedNavButton.BackColor = navDefaultBackColor;
                selectedNavButton.ForeColor = navDefaultForeColor;
            }

            selectedNavButton = btn;
            selectedNavButton.BackColor = navHighlightColor;
            selectedNavButton.ForeColor = navHighlightForeColor;
        }
        public employee_dashboard_page(string employeeName)
        {
            InitializeComponent();

            emp_name.Text = employeeName;
            LoadProfilePicture(employeeName);

            current_time_timein.Tick += current_time_timein_Tick;
            current_time_timein.Start();

            current_time_timeout.Tick += current_time_timeout_Tick;
            current_time_timeout.Start();

            currentdate_timer.Start();
        }

        private void employee_dashboard_page_Load(object sender, EventArgs e)
        {
            MakePictureBoxCircular(emp_profilepic);
            SetSelectedNavButton(timelog_btn);
            LoadLoggedTime();

            if (HasLoggedBothTimeInAndOut())
            {
                // Already logged in and out
                TimeIn_btn.Enabled = false;
                TimeOut_btn.Enabled = false;
                current_time_timein.Stop();
                current_time_timeout.Stop();
            }
            else if (HasOnlyTimeIn())
            {
                // Only TimeIn logged — allow TimeOut
                TimeIn_btn.Enabled = false;
                TimeOut_btn.Enabled = true;
                current_time_timein.Stop();
            }
            else
            {
                // No logs today — start fresh
                TimeIn_btn.Enabled = true;
                TimeOut_btn.Enabled = false;
            }

        }

        // Circle Employee Profile Picture
        public void MakePictureBoxCircular(PictureBox picBox)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, picBox.Width, picBox.Height);
            picBox.Region = new Region(path);
        }

        private void LoadProfilePicture(string employeeName)
        {
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();

                string query = "SELECT Image FROM emp_info WHERE Name = @EmployeeName";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EmployeeName", employeeName);
                    byte[] imageBytes = cmd.ExecuteScalar() as byte[];

                    if (imageBytes != null)
                    {
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            emp_profilepic.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        emp_profilepic.Image = Properties.Resources.AddPic;
                    }
                }
            }
        }

        private bool HasOnlyTimeIn()
        {
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();

                string empID = CurrentSession.EmpID;
                string query = "SELECT COUNT(*) FROM techquint.time_log WHERE EmpID = @EmpID AND DateMonth = @DateMonth AND TimeIn IS NOT NULL AND TimeOut IS NULL";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EmpID", empID);
                    cmd.Parameters.AddWithValue("@DateMonth", DateTime.Now.Date);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private bool HasLoggedBothTimeInAndOut()
        {
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();

                string empID = CurrentSession.EmpID;
                string query = "SELECT COUNT(*) FROM techquint.time_log WHERE EmpID = @EmpID AND DateMonth = @DateMonth AND TimeIn IS NOT NULL AND TimeOut IS NOT NULL";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EmpID", empID);
                    cmd.Parameters.AddWithValue("@DateMonth", DateTime.Now.Date);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        //Timers that displays the current time and date
        private void current_time_timein_Tick(object sender, EventArgs e)
        {
            time_in.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void current_time_timeout_Tick(object sender, EventArgs e)
        {
            time_out.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void currentdate_timer_Tick(object sender, EventArgs e)
        {
            current_date.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
        }


        private void TimeIn_btn_Click(object sender, EventArgs e)
        {
            // Check if employee has already clicked TimeIn today
            if (HasLoggedTimeToday())
            {
                MessageBox.Show("You have already logged time today. Please click Time Out to finish your shift.");
                return;
            }

            timeIn = DateTime.Now;
            current_time_timein.Stop();

            // Save the TimeIn to the database
            SaveTimeLog(timeIn, null); 

            // Disable the TimeIn button and enable the TimeOut button
            TimeIn_btn.Enabled = false;
            TimeOut_btn.Enabled = true;
        }

        private void TimeOut_btn_Click(object sender, EventArgs e)
        {
            // Check if TimeIn exists but TimeOut doesn't
            if (!HasOnlyTimeIn())
            {
                MessageBox.Show("You must click Time In before clicking Time Out.");
                return;
            }

            timeOut = DateTime.Now;
            current_time_timeout.Stop();

            // Save the TimeOut to the database
            SaveTimeLog(null, timeOut);

            // Disable the TimeOut button
            TimeOut_btn.Enabled = false;
        }

        private void LoadLoggedTime()
        {
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();

                string empID = CurrentSession.EmpID;

                string query = "SELECT TimeIn, TimeOut FROM techquint.time_log WHERE EmpID = @EmpID AND DateMonth = @DateMonth LIMIT 1";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EmpID", empID);
                    cmd.Parameters.AddWithValue("@DateMonth", DateTime.Now.Date);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                TimeSpan timeInValue = (TimeSpan)reader["TimeIn"];
                                time_in.Text = DateTime.Today.Add(timeInValue).ToString("hh:mm:ss tt");
                            }

                            if (!reader.IsDBNull(1))
                            {
                                TimeSpan timeOutValue = (TimeSpan)reader["TimeOut"];
                                time_out.Text = DateTime.Today.Add(timeOutValue).ToString("hh:mm:ss tt");
                            }
                        }
                    }
                }
            }
        }

        private bool HasLoggedTimeToday()
        {
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();

                string empID = CurrentSession.EmpID;

                string query = "SELECT COUNT(*) FROM techquint.time_log WHERE EmpID = @EmpID AND DateMonth = @DateMonth AND TimeIn IS NOT NULL AND TimeOut IS NOT NULL";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EmpID", empID);
                    cmd.Parameters.AddWithValue("@DateMonth", DateTime.Now.Date);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void SaveTimeLog(DateTime? timeIn, DateTime? timeOut)
        {
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                string empID = CurrentSession.EmpID;
                DateTime today = DateTime.Now.Date;

                // INSERT TIME IN
                if (timeIn.HasValue && !timeOut.HasValue)
                {
                    // Check if record already exists
                    string checkQuery = "SELECT COUNT(*) FROM techquint.time_log WHERE EmpID = @EmpID AND DateMonth = @DateMonth";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@EmpID", empID);
                        checkCmd.Parameters.AddWithValue("@DateMonth", today);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count == 0)
                        {
                            // Safe to insert
                            string insertQuery = "INSERT INTO techquint.time_log (EmpID, TimeIn, TimeOut, DateMonth) VALUES (@EmpID, @TimeIn, NULL, @DateMonth)";
                            using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@EmpID", empID);
                                cmd.Parameters.AddWithValue("@TimeIn", timeIn.Value);
                                cmd.Parameters.AddWithValue("@DateMonth", today);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Time In already exists for today.");
                        }
                    }
                }
                // UPDATE TIME OUT
                else if (timeOut.HasValue && !timeIn.HasValue)
                {
                    string updateQuery = "UPDATE techquint.time_log SET TimeOut = @TimeOut WHERE EmpID = @EmpID AND DateMonth = @DateMonth AND TimeOut IS NULL";
                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@EmpID", empID);
                        cmd.Parameters.AddWithValue("@TimeOut", timeOut.Value);
                        cmd.Parameters.AddWithValue("@DateMonth", today);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }

}