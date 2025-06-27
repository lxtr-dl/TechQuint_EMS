using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechQuint_EMS
{
    public partial class Emp_Login_Page : Form
    {
        public Emp_Login_Page()
        {
            InitializeComponent();

            this.Load += Emp_Login_Page_Load;
            dateHired_picker.ValueChanged += dateHired_picker_ValueChanged;
        }

        public static class CurrentSession
        {
            public static string EmpID { get; set; }
            public static string EmployeeName { get; set; }
        }

        private void emp_login_btn_Click(object sender, EventArgs e)
        {
            string empID = empID_txt.Text.Trim();

            if (dateHired_picker.CustomFormat == " ")
            {
                MessageBox.Show("Please select your Date Hired.", "Missing Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime dateHired = dateHired_picker.Value;
            string formattedDate = dateHired.ToString("yyyy-MM-dd");

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                //1
                string query = "SELECT COUNT(*) FROM techquint.emp_info WHERE EmpID = @EmpID AND DATE(DateHired) = DATE(@DateHired)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EmpID", empID);
                    cmd.Parameters.AddWithValue("@DateHired", formattedDate);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        CurrentSession.EmpID = empID;
                        //2
                        string nameQuery = "SELECT Name FROM techquint.emp_info WHERE EmpID = @EmpID AND DATE(DateHired) = DATE(@DateHired)";
                        using (MySqlCommand nameCmd = new MySqlCommand(nameQuery, conn))
                        {
                            nameCmd.Parameters.AddWithValue("@EmpID", empID);
                            nameCmd.Parameters.AddWithValue("@DateHired", formattedDate);
                            string employeeName = Convert.ToString(nameCmd.ExecuteScalar());

                            CurrentSession.EmployeeName = employeeName;

                            employee_dashboard_page start = new employee_dashboard_page(employeeName);
                            start.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Employee Number or Date Hired.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Welcome_Page start = new Welcome_Page();
            start.Show();
            this.Hide();
        }

        private void Emp_Login_Page_Load(object sender, EventArgs e)
        {
            dateHired_picker.Format = DateTimePickerFormat.Custom;
            dateHired_picker.CustomFormat = " "; 
        }

        private void dateHired_picker_ValueChanged(object sender, EventArgs e)
        {
            dateHired_picker.CustomFormat = "MM-dd-yyyy";
        }
    }
}