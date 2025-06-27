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
    public partial class edit_dept : Form
    {
        // Store the original name of the department being edited
        private string _oldDeptName;

        public edit_dept(string currentDeptName)
        {
            InitializeComponent();

            // Save the OldeDeptName into current name for reference in update
            _oldDeptName = currentDeptName;

            EditedDeptname_txt.Text = currentDeptName; 
        }

        // Cancel Button
        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // When the Save button is clicked, update the department name
        private void SaveEditDept_btn_Click(object sender, EventArgs e)
        {
            // Get the new name entered by the user
            string newDeptName = EditedDeptname_txt.Text.Trim();

            if (string.IsNullOrWhiteSpace(newDeptName))
            {
                MessageBox.Show("Please enter a valid department name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new DatabaseConnection().GetConnection())
                {
                    conn.Open();

                    // Update the department name in the departments table
                    string updateQuery = "UPDATE techquint.depts_table SET DepartmentName = @newName WHERE DepartmentName = @oldName";
                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@newName", newDeptName);
                        cmd.Parameters.AddWithValue("@oldName", _oldDeptName); // Make sure this is passed from the constructor
                        cmd.ExecuteNonQuery();
                    }

                    // Update department name in all employees associated with this department
                    string updateEmpQuery = "UPDATE emp_info SET Department = @newName WHERE Department = @oldName";
                    using (MySqlCommand cmd = new MySqlCommand(updateEmpQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@newName", newDeptName);
                        cmd.Parameters.AddWithValue("@oldName", _oldDeptName);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Department name updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Automatically Refreshes the Form
                this.Close();

                //recent actions code
                Admin_Dashboard.SaveActionToDB($"Renamed department: {_oldDeptName} ➝ {newDeptName}");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating department: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
