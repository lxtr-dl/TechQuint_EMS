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
    public partial class Added_department : UserControl
    {
        private Color originalBackColor;


        public Added_department()
        {
            InitializeComponent();
        }


        // It initializes the displayed values
        public void SetDepartmentInfo(string departmentName, int employeeCount)
        {
            lblDeptName.Text = departmentName;
            lblEmpCount.Text = $"{employeeCount}";
        }

        // Delete Button
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string deptName = lblDeptName.Text;

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete the department '{deptName}'?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (MySqlConnection conn = new DatabaseConnection().GetConnection())
                {
                    conn.Open();

                    // Department will only be deleted if it has 0 employee
                    // Check if department has zero employees
                    string checkCountQuery = "SELECT NumberOfEmployees FROM techquint.depts_table WHERE DepartmentName = @dept";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkCountQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@dept", deptName);
                        object countObj = checkCmd.ExecuteScalar();

                        if (countObj == null)
                        {
                            MessageBox.Show("Department not found in the database.");
                            return;
                        }

                        int count = Convert.ToInt32(countObj);
                        if (count > 0)
                        {
                            MessageBox.Show("Cannot delete this department because it has registered employees.");
                            return;
                        }
                    }

                    // If Department has 0 employees, the department name will be deleted
                    // Delete department
                    string deleteQuery = "DELETE FROM techquint.depts_table WHERE DepartmentName = @dept";
                    using (MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@dept", deptName);
                        deleteCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Department deleted successfully.");
                    this.Parent.Controls.Remove(this); // Remove UI card from dept_page


                }
            }
        }

        // Edit Button, it allows admin to edit the name of the department
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentDeptName = lblDeptName.Text.Trim();

            // Displays the edit_dept form
            edit_dept start = new edit_dept(currentDeptName);
            if (start.ShowDialog() == DialogResult.OK)
            {
                // Refresh parent form after rename
                Form parent = this.FindForm();
                if (parent is dept_page dp)
                {
                    dp.LoadDepartmentCards();
                }
            }
        }

        // 3 Dots Button, it displays the button for edit and delete
        private void menustrip_edit_delete_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position);
        }

        // User Conreol serves as Buttons, it displays the datagrid per department
        private void Added_department_Click(object sender, EventArgs e)
        {
            ShowEmployeesInThisDepartment();
            this.Hide();
        }

        // Retrieves all employee records from the database that belong to a specific department
        // Display of datagrid in the EmployeeListPerDepartment Form
        private void ShowEmployeesInThisDepartment()
        {
            string deptName = lblDeptName.Text;

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                string query = "SELECT EmpID, Name, Email, PhoneNumber, DailyRate, DateHired, Image FROM emp_info WHERE Department = @dept";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@dept", deptName);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Create a new form to show the employees of the selected department
                        EmployeeListPerDepartment employeeForm = new EmployeeListPerDepartment(deptName, dt);

                        // 🛠 Fix: Ensure image column is displayed properly
                        if (employeeForm.EmployeeListDataGridPerDept.Columns.Contains("Image"))
                        {
                            var imgCol = employeeForm.EmployeeListDataGridPerDept.Columns["Image"] as DataGridViewImageColumn;
                            if (imgCol != null)
                                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                        }

                        employeeForm.Show();

                        // Hide the parent form (dept_page), not the user control
                        Form parentForm = this.FindForm();
                        if (parentForm != null)
                        {
                            parentForm.Hide();
                        }
                    }
                }
            }
        }

        private void Added_department_MouseEnter(object sender, EventArgs e)
        {
            if (originalBackColor == Color.FromArgb(49, 92, 98))
                originalBackColor = this.BackColor;

            this.BackColor = Color.Teal; // Or any color you want on hover
        }


        private void Added_department_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(49, 92, 98);
        }
    }
}
