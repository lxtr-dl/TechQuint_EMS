using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TechQuint_EMS
{
    public partial class payroll_page : Form
    {
        // Store employees' name and daily rate keyed by EmpID
        private Dictionary<string, string> employeeData = new Dictionary<string, string>();
        private Dictionary<string, decimal> dailyRates = new Dictionary<string, decimal>();
        private System.Windows.Forms.Button selectedNavButton = null;
        private readonly Color navHighlightColor = Color.Teal; // Highlight color
        private readonly Color navDefaultBackColor = Color.Black;
        private readonly Color navDefaultForeColor = Color.White;
        private readonly Color navHighlightForeColor = Color.Black;

        public payroll_page()
        {
            InitializeComponent();

            emp_name_txt.ReadOnly = true;
            emp_rate_txt.ReadOnly = true;

            tax_txt.ReadOnly = true;
            philhealth_txt.ReadOnly = true;
            sss_txt.ReadOnly = true;

            gross_salary_txt.ReadOnly = true;
            deductions_txt.ReadOnly = true;
            net_salary_txt.ReadOnly = true;

        }

        // Navigation button clicks
        private void dashboard_ad_btn_Click(object sender, EventArgs e)
        {
            SetSelectedNavButton(dashboard_ad_btn);
            Admin_Dashboard start = new Admin_Dashboard();
            start.Show();
            this.Hide();
        }

        private void register_ad_btn_Click(object sender, EventArgs e)
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

        private void aBOUTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            about_page start = new about_page();
            start.Show();
            this.Hide();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Welcome_Page start = new Welcome_Page();
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

        private void payroll_page_Load(object sender, EventArgs e)
        {
            MakePictureBoxCircular(admin_profilepic);
            MakeRoundedCorners(adminprofile_panel, 10);
            LoadEmployeeIDs();

            emp_ID_comboBox.SelectedIndex = -1;
            emp_ID_comboBox.SelectedIndexChanged += emp_ID_comboBox_SelectedIndexChanged_1;

            payment_method_combobox.Items.Clear();
            payment_method_combobox.Items.AddRange(new string[] { "Gcash", "Maya", "Bank Transfer" });
            payment_method_combobox.SelectedIndex = -1;

            ClearPayrollInputs();
            EnablePayrollInputs(true);
            SetSelectedNavButton(payroll_ad_btn);
        }

        private void LoadEmployeeIDs()
        {
            string query = "SELECT EmpID, Name, DailyRate, Image FROM techquint.emp_info";

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        emp_ID_comboBox.Items.Clear();
                        employeeData.Clear();
                        dailyRates.Clear();

                        while (reader.Read())
                        {
                            string empID = reader["EmpID"].ToString();
                            string name = reader["Name"].ToString();
                            decimal dailyRate = reader.GetDecimal(reader.GetOrdinal("DailyRate"));

                            employeeData[empID] = name;
                            dailyRates[empID] = dailyRate;

                            emp_ID_comboBox.Items.Add(empID);
                        }
                    }
                }
            }
        }

        private void emp_ID_comboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (emp_ID_comboBox.SelectedItem == null)
            {
                ClearPayrollInputs();
                EnablePayrollInputs(true);
                emp_name_txt.Text = "";
                emp_rate_txt.Text = "";
                return;
            }

            string selectedEmpID = emp_ID_comboBox.SelectedItem.ToString();

            if (employeeData.TryGetValue(selectedEmpID, out string name))
                emp_name_txt.Text = name;
            else
                emp_name_txt.Text = "";

            if (dailyRates.TryGetValue(selectedEmpID, out decimal rate))
                emp_rate_txt.Text = rate.ToString("F2");
            else
                emp_rate_txt.Text = "";

            LoadEmployeeImage(selectedEmpID);

            if (IsPayrollSavedForCurrentMonth(selectedEmpID, out PayrollData savedPayroll))
            {
                // Load saved payroll data and disable editing
                days_worked_txt.Text = savedPayroll.DaysWorked.ToString();
                payment_method_combobox.SelectedItem = savedPayroll.PaymentMethod;

                philhealth_txt.Text = savedPayroll.PhilHealth.ToString("F2");
                sss_txt.Text = savedPayroll.SSS.ToString("F2");
                tax_txt.Text = savedPayroll.Tax.ToString("F2");
                gross_salary_txt.Text = savedPayroll.GrossSalary.ToString("F2");
                deductions_txt.Text = savedPayroll.TotalDeduction.ToString("F2");
                net_salary_txt.Text = savedPayroll.NetSalary.ToString("F2");

                EnablePayrollInputs(false);
            }
            else
            {
                ClearPayrollInputs();
                EnablePayrollInputs(true);
            }
        }

        private void ClearPayrollInputs()
        {
            days_worked_txt.Text = "";
            payment_method_combobox.SelectedIndex = -1;

            philhealth_txt.Text = "";
            sss_txt.Text = "";
            tax_txt.Text = "";

            gross_salary_txt.Text = "";
            deductions_txt.Text = "";
            net_salary_txt.Text = "";
        }

        private void EnablePayrollInputs(bool enable)
        {
            days_worked_txt.ReadOnly = !enable;
            payment_method_combobox.Enabled = enable;
        }

        private void LoadEmployeeImage(string empID)
        {
            string query = "SELECT Image FROM techquint.emp_info WHERE EmpID = @EmpID";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EmpID", empID);
                    object imgObj = cmd.ExecuteScalar();

                    if (imgObj != null && imgObj != DBNull.Value)
                    {
                        byte[] imgBytes = (byte[])imgObj;
                        using (MemoryStream ms = new MemoryStream(imgBytes))
                        {
                            img_pb.Image = Image.FromStream(ms);
                        }
                    }
                }
            }
        }

        private bool IsPayrollSavedForCurrentMonth(string empID, out PayrollData payrollData)
        {
            payrollData = null;
            string month = DateTime.Now.ToString("MMMM yyyy");

            string query = "SELECT DayWorked, PaymentMethod, GrossSalary, PhilHealth, SSS, Tax, TotalDeduction, NetSalary " +
                           "FROM techquint.emp_salary WHERE EmpID = @EmpID AND PayrollMonth = @PayrollMonth";

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EmpID", empID);
                    cmd.Parameters.AddWithValue("@PayrollMonth", month);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            payrollData = new PayrollData
                            {
                                DaysWorked = reader.GetInt32("DayWorked"),
                                PaymentMethod = reader.GetString("PaymentMethod"),
                                GrossSalary = reader.GetDecimal("GrossSalary"),
                                PhilHealth = reader.GetDecimal("PhilHealth"),
                                SSS = reader.GetDecimal("SSS"),
                                Tax = reader.GetDecimal("Tax"),
                                TotalDeduction = reader.GetDecimal("TotalDeduction"),
                                NetSalary = reader.GetDecimal("NetSalary")
                            };
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private class PayrollData
        {
            public int DaysWorked { get; set; }
            public string PaymentMethod { get; set; }
            public decimal GrossSalary { get; set; }
            public decimal PhilHealth { get; set; }
            public decimal SSS { get; set; }
            public decimal Tax { get; set; }
            public decimal TotalDeduction { get; set; }
            public decimal NetSalary { get; set; }
        }


        // Payroll calculation logic
        private void InputFieldsChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(emp_rate_txt.Text, out decimal dailyRate) &&
                int.TryParse(days_worked_txt.Text, out int daysWorked))
            {
                // Gross Salary Formula
                decimal grossSalary = dailyRate * daysWorked;

                // Deductions Calculations
                decimal philHealth = grossSalary * 0.05m;
                decimal sss = grossSalary * 0.02m;
                decimal tax = grossSalary * 0.15m;

                // Total Deductions Computation
                decimal totalDeductions = philHealth + sss + tax;

                // Net Salary Computation
                decimal netSalary = grossSalary - totalDeductions;

                // Display calculated results 
                philhealth_txt.Text = philHealth.ToString("F2");
                sss_txt.Text = sss.ToString("F2");
                tax_txt.Text = tax.ToString("F2");

                gross_salary_txt.Text = grossSalary.ToString("F2");
                deductions_txt.Text = totalDeductions.ToString("F2");
                net_salary_txt.Text = netSalary.ToString("F2");
            }
            else
            {
                // If inputs are not valid, clear the result fields
                philhealth_txt.Text = "";
                sss_txt.Text = "";
                tax_txt.Text = "";
                gross_salary_txt.Text = "";
                deductions_txt.Text = "";
                net_salary_txt.Text = "";
            }
        }

        private void days_worked_txt_TextChanged(object sender, EventArgs e)
        {
            InputFieldsChanged(sender, e);
        }

        private void PrintSalaryRecipt_PrintPage(object sender, PrintPageEventArgs e)
        {
            float y = 100;
            float pageWidth = e.PageBounds.Width;
            Font titleFont = new Font("Arial", 24, FontStyle.Bold);
            Font subHeaderFont = new Font("Arial", 14, FontStyle.Bold);
            Font labelFont = new Font("Arial", 12, FontStyle.Regular);
            Font valueFont = new Font("Arial", 12, FontStyle.Regular);
            Brush labelBrush = Brushes.Black;
            Brush valueBrush = Brushes.Blue;

            string title = "Payroll Summary";
            SizeF titleSize = e.Graphics.MeasureString(title, titleFont);
            float titleX = (pageWidth - titleSize.Width) / 2;
            e.Graphics.DrawString(title, titleFont, labelBrush, titleX, y);
            y += titleSize.Height + 10;

            string payrollMonth = DateTime.Now.ToString("MMMM yyyy") + " Payroll";
            SizeF monthSize = e.Graphics.MeasureString(payrollMonth, subHeaderFont);
            float monthX = (pageWidth - monthSize.Width) / 2;
            e.Graphics.DrawString(payrollMonth, subHeaderFont, labelBrush, monthX, y);
            y += monthSize.Height + 30;

            float leftMargin = e.MarginBounds.Left;
            float rightMargin = e.MarginBounds.Right;
            float valueX = rightMargin - 150;

            void DrawLabelAndValue(string label, string value, float yPos)
            {
                e.Graphics.DrawString(label, labelFont, labelBrush, leftMargin, yPos);
                SizeF valueSize = e.Graphics.MeasureString(value, valueFont);
                e.Graphics.DrawString(value, valueFont, valueBrush, valueX - valueSize.Width, yPos);
            }

            DrawLabelAndValue("Employee ID: ", emp_ID_comboBox.SelectedItem?.ToString() ?? "", y); y += 30;
            DrawLabelAndValue("Employee Name: ", emp_name_txt.Text, y); y += 30;
            DrawLabelAndValue("Daily Rate: ", emp_rate_txt.Text, y); y += 30;
            DrawLabelAndValue("Days Worked: ", days_worked_txt.Text, y); y += 30;
            DrawLabelAndValue("Payment Method: ", payment_method_combobox.SelectedItem?.ToString() ?? "", y); y += 30;

            y += 20;

            DrawLabelAndValue("Gross Salary: ", gross_salary_txt.Text, y); y += 30;
            DrawLabelAndValue("PhilHealth: ", philhealth_txt.Text, y); y += 30;
            DrawLabelAndValue("SSS: ", sss_txt.Text, y); y += 30;
            DrawLabelAndValue("Tax: ", tax_txt.Text, y); y += 30;
            DrawLabelAndValue("Total Deductions: ", deductions_txt.Text, y); y += 30;
            DrawLabelAndValue("Net Salary: ", net_salary_txt.Text, y);
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = PrintSalaryRecipt;
            printPreviewDialog1.ShowDialog();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            // Validate inputs as before...

            string empID = emp_ID_comboBox.SelectedItem.ToString();
            string month = DateTime.Now.ToString("MMMM yyyy");

            if (IsPayrollSavedForCurrentMonth(empID, out _))
            {
                MessageBox.Show("Payroll for this employee for the current month already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Collect payroll data...
            decimal grossSalary = decimal.Parse(gross_salary_txt.Text);
            decimal philHealth = decimal.Parse(philhealth_txt.Text);
            decimal sss = decimal.Parse(sss_txt.Text);
            decimal tax = decimal.Parse(tax_txt.Text);
            decimal totalDeductions = decimal.Parse(deductions_txt.Text);
            decimal netSalary = decimal.Parse(net_salary_txt.Text);
            string paymentMethod = payment_method_combobox.SelectedItem.ToString();
            int daysWorked = int.Parse(days_worked_txt.Text);

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();

                // Insert payroll data into emp_salary table
                string insertQuery = "INSERT INTO techquint.emp_salary (EmpID, DailyRate, GrossSalary, PhilHealth, SSS, Tax, TotalDeduction, NetSalary, PaymentMethod, PayrollMonth, DayWorked) " +
                                     "VALUES (@EmpID, @DailyRate, @GrossSalary, @PhilHealth, @SSS, @Tax, @TotalDeduction, @NetSalary, @PaymentMethod, @PayrollMonth, @DayWorked)";

                using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@EmpID", empID);
                    insertCmd.Parameters.AddWithValue("@DailyRate", decimal.Parse(emp_rate_txt.Text));
                    insertCmd.Parameters.AddWithValue("@GrossSalary", grossSalary);
                    insertCmd.Parameters.AddWithValue("@PhilHealth", philHealth);
                    insertCmd.Parameters.AddWithValue("@SSS", sss);
                    insertCmd.Parameters.AddWithValue("@Tax", tax);
                    insertCmd.Parameters.AddWithValue("@TotalDeduction", totalDeductions);
                    insertCmd.Parameters.AddWithValue("@NetSalary", netSalary);
                    insertCmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                    insertCmd.Parameters.AddWithValue("@PayrollMonth", month);
                    insertCmd.Parameters.AddWithValue("@DayWorked", daysWorked);

                    int rowsAffected = insertCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Log action in recent_actions table
                        string actionText = $"Paid salary to Employee ID: {empID} for {month}";
                        Admin_Dashboard.SaveActionToDB(actionText);  // Call the SaveActionToDB method from Admin_Dashboard

                        MessageBox.Show("Payroll information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear inputs and reset UI after saving
                        ClearPayrollInputs();
                        EnablePayrollInputs(true);
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while saving the payroll information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        // Circle Admin Profile Picture
        public void MakePictureBoxCircular(PictureBox picBox)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, picBox.Width, picBox.Height);
            picBox.Region = new Region(path);
        }

        // Rounded Corners of Admin Profile Picture Panel
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

        private void SetSelectedNavButton(System.Windows.Forms.Button btn)
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
    }
}
