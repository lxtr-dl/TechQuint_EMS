using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechQuint_EMS
{
    public partial class Admin_Dashboard : Form
    {
        private Button selectedNavButton = null;
        private readonly Color navHighlightColor = Color.Teal; // Highlight color
        private readonly Color navDefaultBackColor = Color.Black;
        private readonly Color navDefaultForeColor = Color.White;
        private readonly Color navHighlightForeColor = Color.Black;

        public Admin_Dashboard()
        {
            InitializeComponent();  
        }

        // Locations of the Main Buttons (Dashboard, Employee, Department, Payroll)
        private void dashboard_ad_btn_Click(object sender, EventArgs e)
        {
            SetSelectedNavButton(dashboard_ad_btn);
            Admin_Dashboard start = new Admin_Dashboard();
            start.Show();
            this.Hide();
        }

        private void register_ad_btn_Click_1(object sender, EventArgs e)
        {
            SetSelectedNavButton(register_ad_btn);
            employee_page start = new employee_page();
            start.Show();
            this.Hide();
        }

        private void department_btn_Click(object sender, EventArgs e)
        {
            SetSelectedNavButton(department_btn);
            dept_page start = new dept_page();
            start.Show();
            this.Hide();
        }

        private void payroll_ad_btn_Click(object sender, EventArgs e)
        {
            SetSelectedNavButton(payroll_ad_btn);
            payroll_page start = new payroll_page();
            start.Show();
            this.Hide();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Welcome_Page start = new Welcome_Page();
            start.Show();
            this.Hide();
        }

        private void aBOUTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            about_page start = new about_page();
            start.Show();
            this.Hide();
        }

        // Hover of the Main Buttons (Dashboard, Employee, Department, Payroll)
        private void dashboard_ad_btn_MouseEnter(object sender, EventArgs e)
        {
            if (selectedNavButton != dashboard_ad_btn)
            {
                dashboard_ad_btn.BackColor = navHighlightColor;
                dashboard_ad_btn.ForeColor = navHighlightForeColor;
            }
        }

        private void dashboard_ad_btn_MouseLeave(object sender, EventArgs e)
        {
            if (selectedNavButton != dashboard_ad_btn)
            {
                dashboard_ad_btn.BackColor = navDefaultBackColor;
                dashboard_ad_btn.ForeColor = navDefaultForeColor;
            }
        }

        private void register_ad_btn_MouseEnter(object sender, EventArgs e)
        {
            if (selectedNavButton != register_ad_btn)
            {
                register_ad_btn.BackColor = navHighlightColor;
                register_ad_btn.ForeColor = navHighlightForeColor;
            }
        }

        private void register_ad_btn_MouseLeave(object sender, EventArgs e)
        {
            if (selectedNavButton != register_ad_btn)
            {
                register_ad_btn.BackColor = navDefaultBackColor;
                register_ad_btn.ForeColor = navDefaultForeColor;
            }
        }

        private void department_btn_MouseEnter(object sender, EventArgs e)
        {
            if (selectedNavButton != department_btn)
            {
                department_btn.BackColor = navHighlightColor;
                department_btn.ForeColor = navHighlightForeColor;
            }
        }

        private void department_btn_MouseLeave(object sender, EventArgs e)
        {
            if (selectedNavButton != department_btn)
            {
                department_btn.BackColor = navDefaultBackColor;
                department_btn.ForeColor = navDefaultForeColor;
            }
        }

        private void payroll_ad_btn_MouseEnter(object sender, EventArgs e)
        {
            if (selectedNavButton != payroll_ad_btn)
            {
                payroll_ad_btn.BackColor = navHighlightColor;
                payroll_ad_btn.ForeColor = navHighlightForeColor;
            }
        }

        private void payroll_ad_btn_MouseLeave(object sender, EventArgs e)
        {
            if (selectedNavButton != payroll_ad_btn)
            {
                payroll_ad_btn.BackColor = navDefaultBackColor;
                payroll_ad_btn.ForeColor = navDefaultForeColor;
            }
        }

        // Circle Admin Profile Picture
        public void MakePictureBoxCircular(PictureBox picBox)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, picBox.Width, picBox.Height);
            picBox.Region = new Region(path);
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            MakePictureBoxCircular(admin_profilepic);
            MakeRoundedCorners(adminprofile_panel, 10);
            MakeRoundedCorners(emp_panel, 20);
            MakeRoundedCorners(dept_panel, 20);
            MakeRoundedCorners(payroll_panel, 20);
            MakeRoundedCorners(empcount_panel, 20);
            MakeRoundedCorners(panel7, 20);

            LoadTotalEmployees();
            LoadTotalDepartments();
            LoadDepartmentChart();
            LoadPendingPayrollCount();
            LoadRecentActions();

            SetSelectedNavButton(dashboard_ad_btn);
        }

        // Rounded Corners 
        public void MakeRoundedCorners(Panel panel, int cornerRadius)
        {
            Rectangle bounds = new Rectangle(0, 0, panel.Width, panel.Height);
            GraphicsPath path = new GraphicsPath();

            int diameter = cornerRadius * 2;

            path.StartFigure();
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90); // Top left
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90); // Top right
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90); // Bottom right
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90); // Bottom left
            path.CloseFigure();

            panel.Region = new Region(path);
        }

        // Displays the About and Logout Button
        private void adminprofile_panel_Click(object sender, EventArgs e)
        {
            contextMenuStrip_About_Logout.Show(Cursor.Position);
        }

        private void LoadTotalEmployees()
        {
            try
            {
                DatabaseConnection dbConn = new DatabaseConnection();
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM techquint.emp_info";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    int total = Convert.ToInt32(cmd.ExecuteScalar());

                    label9.Text = total.ToString(); // Set to your label for employee count
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading total employees: " + ex.Message);
            }
        }

        private void LoadTotalDepartments()
        {
            try
            {
                DatabaseConnection dbConn = new DatabaseConnection();
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM techquint.depts_table"; // ✅ Correct schema and table
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    int totalDepartments = Convert.ToInt32(cmd.ExecuteScalar());

                    label8.Text = totalDepartments.ToString(); // ✅ Make sure label8 is the one for departments
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading total departments: " + ex.Message);
            }
        }

        private void LoadDepartmentChart()
        {
            try
            {
                DatabaseConnection dbConn = new DatabaseConnection();
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT Department, COUNT(*) AS Total
                             FROM techquint.emp_info
                             GROUP BY Department";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    chart1.Series.Clear(); // Clear old data

                    var series = new System.Windows.Forms.DataVisualization.Charting.Series("Employees per Department");
                    series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    series.IsValueShownAsLabel = true;
                    series.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                    while (reader.Read())
                    {
                        string department = reader.GetString("Department");
                        int count = reader.GetInt32("Total");

                        series.Points.AddXY(department, count);
                    }

                    chart1.Series.Add(series);

                    // Styling (optional)
                    var area = chart1.ChartAreas[0];
                    area.AxisX.Title = "Department";
                    area.AxisY.Title = "Employee Count";
                    area.AxisX.MajorGrid.LineColor = Color.LightGray;
                    area.AxisY.MajorGrid.LineColor = Color.LightGray;
                    chart1.BackColor = Color.Transparent;
                    chart1.Legends.Clear(); // Optional: remove legend
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading department chart: " + ex.Message);
            }
        }

        public void LoadPendingPayrollCount()
        {
            try
            {
                DatabaseConnection dbConn = new DatabaseConnection();
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();
                    string currentMonth = DateTime.Now.ToString("MMMM yyyy");

                    // Query: Count all employees
                    string totalEmployeesQuery = "SELECT COUNT(*) FROM techquint.emp_info";
                    MySqlCommand totalCmd = new MySqlCommand(totalEmployeesQuery, conn);
                    int totalEmployees = Convert.ToInt32(totalCmd.ExecuteScalar());

                    // Query: Count employees who already have payroll for this month
                    string paidEmployeesQuery = "SELECT COUNT(DISTINCT EmpID) FROM techquint.emp_salary WHERE PayrollMonth = @PayrollMonth";
                    MySqlCommand paidCmd = new MySqlCommand(paidEmployeesQuery, conn);
                    paidCmd.Parameters.AddWithValue("@PayrollMonth", currentMonth);
                    int paidCount = Convert.ToInt32(paidCmd.ExecuteScalar());

                    int pendingCount = totalEmployees - paidCount;

                    label7.Text = pendingCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading pending payrolls: " + ex.Message);
            }
        }

        public static void SaveActionToDB(string action)
        {
            DatabaseConnection dbConn = new DatabaseConnection();
            using (MySqlConnection conn = dbConn.GetConnection())
            {
                string query = "INSERT INTO techquint.recent_actions (action_text, action_time) VALUES (@action, NOW())";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@action", action);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            // Load the recent actions in the dashboard after saving a new action
            var dashboardForm = Application.OpenForms.OfType<Admin_Dashboard>().FirstOrDefault();
            if (dashboardForm != null)
            {
                dashboardForm.LoadRecentActions();  // Call LoadRecentActions to update UI
            }
        }


        public void LoadRecentActions()
        {
            listBox1.Items.Clear();

            DatabaseConnection dbConn = new DatabaseConnection();
            using (MySqlConnection conn = dbConn.GetConnection())
            {
                string query = "SELECT action_text, action_time FROM techquint.recent_actions ORDER BY action_time DESC LIMIT 10";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string action = reader.GetString("action_text");
                        DateTime time = reader.GetDateTime("action_time");

                        listBox1.Items.Add($"{time:hh:mm tt} - {action}");
                    }
                }
            }
        }

        private void SetSelectedNavButton(Button btn)
        {
            // Reset previous selected button
            if (selectedNavButton != null)
            {
                selectedNavButton.BackColor = navDefaultBackColor;
                selectedNavButton.ForeColor = navDefaultForeColor;
            }

            // Set new selected button
            selectedNavButton = btn;
            selectedNavButton.BackColor = navHighlightColor;
            selectedNavButton.ForeColor = navHighlightForeColor;
        }

       
        private void label7_Click(object sender, EventArgs e)
        {
            // Check if an instance of pendingpayroll is already open
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is pendingpayroll)
                {
                    openForm.BringToFront();
                    return; // Exit the method if the form is already open
                }
            }

            pendingpayroll start = new pendingpayroll();
            start.Show();
        }
    }
}
