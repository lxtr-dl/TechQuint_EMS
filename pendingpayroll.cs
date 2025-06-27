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
    public partial class pendingpayroll : Form
    {
        public pendingpayroll()
        {
            InitializeComponent();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadPendingPayrollEmployees()
        {
            try
            {
                DatabaseConnection dbConn = new DatabaseConnection();
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();
                    string currentMonthYear = DateTime.Now.ToString("MMMM yyyy");

                    // Query: Get all employee IDs who do not have payroll for this month
                    string query = @"
                    SELECT EmpID 
                    FROM techquint.emp_info 
                    WHERE EmpID NOT IN (
                    SELECT DISTINCT EmpID 
                    FROM techquint.emp_salary 
                    WHERE PayrollMonth = @PayrollMonth
                )";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PayrollMonth", currentMonthYear);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    listBox1.Items.Clear();  // Clear previous items in the ListBox

                    // Display the current month and year at the top
                    listBox1.Items.Add(currentMonthYear);

                    // Add the employee numbers to the ListBox, formatted with leading zeros
                    while (reader.Read())
                    {
                        int empId = reader.GetInt32("EmpID");
                        listBox1.Items.Add(empId.ToString("D3"));  // Format as 3-digit number (001, 002, etc.)
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading pending payroll employees: " + ex.Message);
            }
        }

        private void pendingpayroll_Load(object sender, EventArgs e)
        {
            LoadPendingPayrollEmployees();
        }
    }
}
