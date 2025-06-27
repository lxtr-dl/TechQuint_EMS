using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
using MySql.Data.MySqlClient;

namespace TechQuint_EMS
{
    public partial class add_dept : Form
    {
        
        public add_dept()
        {
            InitializeComponent();
        }

        // Add Button
        private void AddDept_btn_Click(object sender, EventArgs e)
        {
            string deptName = deptname_txt.Text.Trim();

            if (string.IsNullOrEmpty(deptName))
            {
                MessageBox.Show("Please enter a department name.");
                return;
            }

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();

                // Check if department already exists
                string checkQuery = "SELECT COUNT(*) FROM techquint.depts_table WHERE DepartmentName = @name";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@name", deptName);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Department name already exists. Please enter a different name.", "Duplicate Department", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Exit to prevent duplicate insert
                    }
                }

                // Insert new department if no duplicate found
                string insertQuery = "INSERT INTO techquint.depts_table (DepartmentName, NumberOfEmployees) VALUES (@name, 0)";
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@name", deptName);
                    cmd.ExecuteNonQuery();
                }
            }


            //code for recent action
            Admin_Dashboard.SaveActionToDB("Added new department: " + deptName);


            MessageBox.Show("Department added successfully!");
            this.DialogResult = DialogResult.OK; // Automatically refresh the form or parent window
            this.Close();

        }

        // Cancel Button
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    
}
