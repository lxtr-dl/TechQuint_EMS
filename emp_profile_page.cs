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

namespace TechQuint_EMS
{
    public partial class emp_profile_page : Form
    {
        private Button selectedNavButton = null;
        private readonly Color navHighlightColor = Color.Teal; // Highlight color
        private readonly Color navDefaultBackColor = Color.Black;
        private readonly Color navDefaultForeColor = Color.White;
        private readonly Color navHighlightForeColor = Color.White;

        public emp_profile_page()
        {
            InitializeComponent();
            emp_name.Text = Emp_Login_Page.CurrentSession.EmployeeName;
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

        //Buttons
        private void timelog_btn_Click(object sender, EventArgs e)
        {
            SetSelectedNavButton(timelog_btn);
            string employeeName = Emp_Login_Page.CurrentSession.EmployeeName;
            employee_dashboard_page start = new employee_dashboard_page(employeeName);
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

        private void profile_btn_Click(object sender, EventArgs e)
        {
            SetSelectedNavButton(profile_btn);
        }

        //Buttons Hover
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

        private void LoadPayrollInfo(string empID, string payrollMonth)
        {
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM techquint.emp_salary WHERE EmpID = @EmpID AND PayrollMonth = @PayrollMonth";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EmpID", empID);
                    cmd.Parameters.AddWithValue("@PayrollMonth", payrollMonth);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            emp_rate_txt.Text = reader["DailyRate"].ToString();
                            days_worked_txt.Text = reader["DayWorked"].ToString();
                            payment_method_combobox.Text = reader["PaymentMethod"].ToString();
                            philhealth_txt.Text = reader["Philhealth"].ToString();
                            sss_txt.Text = reader["SSS"].ToString();
                            tax_txt.Text = reader["Tax"].ToString();
                            gross_salary_txt.Text = reader["GrossSalary"].ToString();
                            deductions_txt.Text = reader["TotalDeduction"].ToString();
                            net_salary_txt.Text = reader["NetSalary"].ToString();
                        }
                        else
                        {
                            ClearPayrollFields();
                            MessageBox.Show("No payroll data found for selected month.");
                        }
                    }
                }
            }
        }

        private void LoadEmployeeInfo(string empID)
        {
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM techquint.emp_info WHERE EmpID = @EmpID";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EmpID", empID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            emp_id_txt.Text = reader["EmpID"].ToString();
                            emp_name_txt.Text = reader["Name"].ToString();
                            emp_phonenum_txt.Text = reader["PhoneNumber"].ToString();
                            emp_email_txt.Text = reader["Email"].ToString();
                            emp_department_combo.Text = reader["Department"].ToString();
                            emp_rate_txt.Text = reader["DailyRate"].ToString();
                            dateTimePicker1.Value = Convert.ToDateTime(reader["DateHired"]);

                            if (!reader.IsDBNull(reader.GetOrdinal("Image")))
                            {
                                byte[] imageData = (byte[])reader["Image"];
                                using (MemoryStream ms = new MemoryStream(imageData))
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
            }
        }

        private void emp_profile_page_Load(object sender, EventArgs e)
        {
            string empID = Emp_Login_Page.CurrentSession.EmpID;
            string payrollMonth = dateTimePicker2.Value.ToString("MMMM yyyy");

            emp_name.Text = Emp_Login_Page.CurrentSession.EmployeeName;
            DisableEditingControls();
            LoadEmployeeInfo(empID);
            LoadPayrollInfo(empID, payrollMonth);

            MakePictureBoxCircular(emp_profilepic);
            SetSelectedNavButton(profile_btn);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string empID = Emp_Login_Page.CurrentSession.EmpID;
            string payrollMonth = dateTimePicker2.Value.ToString("MMMM yyyy");
            LoadPayrollInfo(empID, payrollMonth);
        }
        private void ClearPayrollFields()
        {
            emp_rate_txt.Text = "";
            days_worked_txt.Text = "";
            payment_method_combobox.Text = "";
            philhealth_txt.Text = "";
            sss_txt.Text = "";
            tax_txt.Text = "";
            gross_salary_txt.Text = "";
            deductions_txt.Text = "";
            net_salary_txt.Text = "";
        }
        private void DisableEditingControls()
        {
            emp_id_txt.ReadOnly = true;
            emp_name_txt.ReadOnly = true;
            emp_phonenum_txt.ReadOnly = true;
            emp_email_txt.ReadOnly = true;
            emp_rate_txt.ReadOnly = true;
            days_worked_txt.ReadOnly = true;
            philhealth_txt.ReadOnly = true;
            sss_txt.ReadOnly = true;
            tax_txt.ReadOnly = true;
            gross_salary_txt.ReadOnly = true;
            deductions_txt.ReadOnly = true;
            net_salary_txt.ReadOnly = true;

            emp_department_combo.Enabled = false;
            payment_method_combobox.Enabled = false;

            dateTimePicker1.Enabled = false;

            dateTimePicker2.Enabled = true;
        }

        // Circle Employee Profile Picture
        public void MakePictureBoxCircular(PictureBox picBox)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, picBox.Width, picBox.Height);
            picBox.Region = new Region(path);
        }
    }
}
