using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechQuint_EMS
{
    public partial class employee_page : Form
    {
        private Button selectedNavButton = null;
        private readonly Color navHighlightColor = Color.Teal; // Highlight color
        private readonly Color navDefaultBackColor = Color.Black;
        private readonly Color navDefaultForeColor = Color.White;
        private readonly Color navHighlightForeColor = Color.Black;

        public employee_page()
        {
            InitializeComponent();
            printDoc.PrintPage += new PrintPageEventHandler(PrintSelectedData_PrintPage);
        }


        // Locations of the Main Buttons (Dashboard, Employee, Department, Payroll)
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

        // Import Button, allows the admin to choose and display an image in the PictureBox
        private void import_img_Click(object sender, EventArgs e) 
        {
            // Create an OpenFileDialog to let the user browse for an image file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                img_pb.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        // Add Button
        private void add_btn_Click(object sender, EventArgs e) 
        {
            // Get input values from the form
            string empid = emp_id_txt.Text.Trim();
            string name = emp_name_txt.Text;
            string number = emp_phonenum_txt.Text;
            string email = emp_email_txt.Text;
            string department = emp_department_combo.Text;
            int dailyrate = int.Parse(emp_rate_txt.Text);
            DateTime dateHired = dateTimePicker1.Value;

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();

                // Check if EmpID already exists
                string checkQuery = "SELECT COUNT(*) FROM techquint.emp_info WHERE EmpID = @EmpID";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@EmpID", empid);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Employee ID already exists. Please enter a unique Employee ID.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Convert uploaded image to byte array for database storage
                byte[] imageBytes;
                if (img_pb.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (Bitmap bmp = new Bitmap(img_pb.Image))
                        {
                            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        }
                        imageBytes = ms.ToArray();
                    }
                }
                else
                {
                    imageBytes = null;
                }

                // Insert employee record into emp_info table //2
                string query = "INSERT INTO techquint.emp_info (EmpID, Name, PhoneNumber, Email, Department, DailyRate, DateHired, Image) " +
                               "VALUES(@EmpID, @Name, @PhoneNumber, @Email, @Department, @DailyRate, @DateHired, @Image)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EmpID", empid);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@PhoneNumber", number);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Department", department);
                    cmd.Parameters.AddWithValue("@DailyRate", dailyrate);
                    cmd.Parameters.AddWithValue("@DateHired", dateHired);
                    cmd.Parameters.AddWithValue("@Image", imageBytes);
                    cmd.ExecuteNonQuery();
                }

                // Update department employee count in the database, depts_table 
                string updateCount = "UPDATE techquint.depts_table SET NumberOfEmployees = NumberOfEmployees + 1 WHERE DepartmentName = @dept";
                using (MySqlCommand updateCmd = new MySqlCommand(updateCount, conn))
                {
                    updateCmd.Parameters.AddWithValue("@dept", department);
                    updateCmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record Added Successfully!");
            LoadData();

            //code for recent action
            Admin_Dashboard.SaveActionToDB("Added new employee: " + name);
        }


        // Update Button
        private void update_btn_Click(object sender, EventArgs e) 
        {
            // Get updated values from the form fields
            string empid = emp_id_txt.Text;
            string name = emp_name_txt.Text;
            string number = emp_phonenum_txt.Text;
            string email = emp_email_txt.Text;
            string newDepartment = emp_department_combo.Text;
            int dailyrate = int.Parse(emp_rate_txt.Text);
            DateTime dateHired = dateTimePicker1.Value;

            // Convert the uploaded image to a byte array for saving to the database
            byte[] imageBytes;
            if (img_pb.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    using (Bitmap bmp = new Bitmap(img_pb.Image))
                    {
                        bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    }
                    imageBytes = ms.ToArray();
                }
            }
            else
            {
                imageBytes = null;
            }

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();

                // Get the employee's current department from the database
                string oldDept = "";
                string getOldDeptQuery = "SELECT Department FROM emp_info WHERE EmpID = @EmpID";
                using (MySqlCommand getOldDeptCmd = new MySqlCommand(getOldDeptQuery, conn))
                {
                    getOldDeptCmd.Parameters.AddWithValue("@EmpID", empid);
                    using (MySqlDataReader reader = getOldDeptCmd.ExecuteReader())
                    {
                        if (reader.Read())
                            oldDept = reader["Department"].ToString();
                    }
                }

                // Update employee details in emp_info //3
                string updateEmpQuery = "UPDATE techquint.emp_info SET Name=@Name, PhoneNumber=@PhoneNumber, Email=@Email, " +
                    "Department=@Department, DailyRate=@DailyRate, DateHired=@DateHired, Image=@Image WHERE EmpID=@EmpID";

                using (MySqlCommand cmd = new MySqlCommand(updateEmpQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@EmpID", empid);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@PhoneNumber", number);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Department", newDepartment);
                    cmd.Parameters.AddWithValue("@DailyRate", dailyrate);
                    cmd.Parameters.AddWithValue("@DateHired", dateHired);
                    cmd.Parameters.AddWithValue("@Image", imageBytes);
                    cmd.ExecuteNonQuery();
                }

                // If the department was changed, update counts of employee
                if (oldDept != newDepartment)
                {
                    // Decrease the employee count of the old department 
                    string decreaseOld = "UPDATE techquint.depts_table SET NumberOfEmployees = NumberOfEmployees - 1 WHERE DepartmentName = @oldDept";
                    using (MySqlCommand cmd = new MySqlCommand(decreaseOld, conn))
                    {
                        cmd.Parameters.AddWithValue("@oldDept", oldDept);
                        cmd.ExecuteNonQuery();
                    }

                    // Increase the employee count of the new department
                    string increaseNew = "UPDATE techquint.depts_table SET NumberOfEmployees = NumberOfEmployees + 1 WHERE DepartmentName = @newDept";
                    using (MySqlCommand cmd = new MySqlCommand(increaseNew, conn))
                    {
                        cmd.Parameters.AddWithValue("@newDept", newDepartment);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Record Updated Successfully!");
                LoadData();

                //code for recent actions
                Admin_Dashboard.SaveActionToDB("Updated employee: " + name);

            }
        }

        // Delete Button
        private void delete_btn_Click(object sender, EventArgs e) 
        {
            string empid = emp_id_txt.Text;
            string department = ""; 

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();

                // Gets the department of the employee to be deleted
                string getDeptQuery = "SELECT Department FROM emp_info WHERE EmpID = @EmpID";
                using (MySqlCommand getDeptCmd = new MySqlCommand(getDeptQuery, conn))
                {
                    getDeptCmd.Parameters.AddWithValue("@EmpID", empid);
                    using (MySqlDataReader reader = getDeptCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            department = reader["Department"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Employee not found.");
                            return;
                        }
                    }
                }

                // Delete the employee record
                string deleteQuery = "DELETE FROM emp_info WHERE EmpID = @EmpID";
                using (MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn))
                {
                    deleteCmd.Parameters.AddWithValue("@EmpID", empid);
                    deleteCmd.ExecuteNonQuery();
                }

                // Decrease the employee count in the department
                string updateDeptCount = "UPDATE techquint.depts_table SET NumberOfEmployees = NumberOfEmployees - 1 WHERE DepartmentName = @Department";
                using (MySqlCommand updateCmd = new MySqlCommand(updateDeptCount, conn))
                {
                    updateCmd.Parameters.AddWithValue("@Department", department);
                    updateCmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record Deleted Successfully!");
            LoadData();

            //code for recent action
            Admin_Dashboard.SaveActionToDB("Deleted employee with ID: " + empid);
        }

        // Clear Button
        private void clear_btn_Click(object sender, EventArgs e) 
        {
            emp_id_txt.Text = "";
            emp_name_txt.Text = "";
            emp_phonenum_txt.Text = "";
            emp_email_txt.Text = "";
            emp_department_combo.SelectedIndex = -1;
            emp_rate_txt.Text = "";
            img_pb.Image = null;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = " ";
            img_pb.Image = Properties.Resources.AddPic;
        }

        // Reads data from the selected row of the Datagrid
        private void dataGridView1_SelectionChanged(object sender, EventArgs e) 
        {
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[0];

                    emp_id_txt.Text = row.Cells["EmpID"].Value.ToString();
                    emp_name_txt.Text = row.Cells["Name"].Value.ToString();
                    emp_phonenum_txt.Text = row.Cells["PhoneNumber"].Value.ToString();
                    emp_email_txt.Text = row.Cells["Email"].Value.ToString();
                    emp_department_combo.Text = row.Cells["Department"].Value.ToString();
                    emp_rate_txt.Text = row.Cells["DailyRate"].Value.ToString();

                    if (row.Cells["DateHired"].Value != DBNull.Value)
                    {
                        dateTimePicker1.Format = DateTimePickerFormat.Short;
                        dateTimePicker1.Value = Convert.ToDateTime(row.Cells["DateHired"].Value);
                    }
                    else
                    {
                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        dateTimePicker1.CustomFormat = " ";
                    }

                    if (row.Cells["Image"].Value != DBNull.Value)
                    {
                        byte[] imgBytes = (byte[])row.Cells["Image"].Value;
                        using (MemoryStream ms = new MemoryStream(imgBytes))
                        {
                            img_pb.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        img_pb.Image = null;
                    }
                }
            }
        }

        private void employee_page_Load(object sender, EventArgs e)
        {
            SetSelectedNavButton(register_ad_btn);
            MakePictureBoxCircular(admin_profilepic);
            MakeRoundedCorners(adminprofile_panel, 10);

            // Load all employee records from the database and display them in the DataGridView.
            LoadData();


            // When a row in the DataGridView is selected, display that employee's info in the form fields.
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = " "; 
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;

            dataGridView1.DataError += (s, ev) =>
            {
                ev.ThrowException = false;
            };

            // Round Edged of the Registration Panel
            MakeRoundedCorners(registration_panel, 20); 

            //Load all department names into the ComboBox for department selection
            LoadDepartmentsToCombo();
        }

        // Add each department name to the ComboBox
        private void LoadDepartmentsToCombo()
        {
            // Clear all existing items in the department combo box to avoid duplicates.
            emp_department_combo.Items.Clear();

            // Get all teh department name from teh depts_table
            string query = "SELECT DepartmentName FROM techquint.depts_table";

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Loop through the result and add each department name to the combo box.
                        emp_department_combo.Items.Add(reader["DepartmentName"].ToString());
                    }
                }
            }
        }

        // Date Fortmat in the Datagrid into mm/dd/yyyy
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
        }

        // Loads employee data from the database and displays it in the Datagrid
        private void LoadData()
        {
            string query = "SELECT * FROM emp_info";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        foreach (DataRow row in dt.Rows)
                        {
                            if (row["Image"] == DBNull.Value)
                            {
                                row["Image"] = DBNull.Value;
                            }
                        }

                        dataGridView1.DataSource = dt;

                        if (dataGridView1.Columns.Contains("DateHired"))
                        {
                            dataGridView1.Columns["DateHired"].DefaultCellStyle.Format = "MM/dd/yyyy";
                        }

                        DataGridViewImageColumn imgCol = (DataGridViewImageColumn)dataGridView1.Columns["Image"];
                        imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    }
                }
            }

        }

        // Rounded Edges 
        private void MakeRoundedCorners(Panel picBox, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            Rectangle bounds = new Rectangle(0, 0, picBox.Width, picBox.Height);
            int diameter = radius * 2;

            path.StartFigure();
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90); // top-left
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90); // top-right
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90); // bottom-right
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90); // bottom-left
            path.CloseFigure();
            picBox.Region = new Region(path);


        }


        // Print All Function
        // Keeps track of the current row being printed across multiple pages
        int currentRow = 0;
        private void PrintAllEmp_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Define fonts and size used in printing a file
            Font headerFont = new Font("Arial", 20, FontStyle.Bold);
            Font columnFont = new Font("Arial", 11, FontStyle.Bold);
            Font cellFont = new Font("Arial", 11);

            int x = 50;
            int y = 100;

            // Height of each row including space for images
            int rowHeight = 70;

            // Define column widths for each column in the DataGridView
            int[] columnWidths = { 80, 220, 120, 150, 100, 100, 130 };

            // Displays the title at the top of the page
            e.Graphics.DrawString("Employee List", headerFont, Brushes.Black, new PointF(450, 50));

            // Print column headers
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                int colWidth = columnWidths.Length > i ? columnWidths[i] : 100;
                e.Graphics.DrawRectangle(Pens.Black, x, y, colWidth, rowHeight);
                e.Graphics.DrawString(dataGridView1.Columns[i].HeaderText, columnFont, Brushes.Black, new RectangleF(x + 3, y + 5, colWidth, rowHeight));
                x += colWidth;
            }

            // Move to the next row for data
            y += rowHeight;
            x = 50;

            // Loop through rows of the DataGridView
            while (currentRow < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[currentRow];
                if (row.IsNewRow) { currentRow++; continue; }

                for (int j = 0; j < row.Cells.Count; j++)
                {
                    int colWidth = columnWidths.Length > j ? columnWidths[j] : 100;
                    object rawValue = row.Cells[j].Value;
                    e.Graphics.DrawRectangle(Pens.Black, x, y, colWidth, rowHeight);

                    if (dataGridView1.Columns[j].HeaderText == "Image" && rawValue != DBNull.Value)
                    {
                        try
                        {
                            byte[] imgBytes = (byte[])rawValue;
                            using (MemoryStream ms = new MemoryStream(imgBytes))
                            {
                                Image empImage = Image.FromStream(ms);
                                e.Graphics.DrawImage(empImage, new Rectangle(x + 5, y + 5, 60, 60));
                            }
                        }
                        catch
                        {
                            e.Graphics.DrawString("Invalid Img", cellFont, Brushes.Red, new PointF(x + 3, y + 20));
                        }
                    }
                    else
                    {
                        string cellText;

                        if (j == 6 && DateTime.TryParse(rawValue?.ToString(), out DateTime parsedDate))
                        {
                            cellText = parsedDate.ToString("MM/dd/yyyy");
                        }
                        else
                        {
                            cellText = rawValue?.ToString() ?? "";
                        }

                        e.Graphics.DrawString(cellText, cellFont, Brushes.Black, new RectangleF(x + 3, y + 5, colWidth, rowHeight));
                    }
                    x += colWidth;
                }

                y += rowHeight;
                x = 50;

                if (y + rowHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
                currentRow++;
            }
            e.HasMorePages = false;
        }

        // Print All Informations in the Datagrid
        private void PrintAll_btn_Click(object sender, EventArgs e)
        {
            currentRow = 0;
            PrintAllEmp.DefaultPageSettings.Landscape = true;
            printPreviewDialog1.Document = PrintAllEmp;
            printPreviewDialog1.ShowDialog();
        }

        PrintDocument printDoc = new PrintDocument();
        string selectedRowData = "";
        Image selectedRowImage = null;

        // Print Selected Employees Information
        private void PrintSelected_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                selectedRowData =
                    $"Employee ID: {row.Cells["EmpID"].Value}\n" +
                    $"Name: {row.Cells["Name"].Value}\n" +
                    $"Phone Number: {row.Cells["PhoneNumber"].Value}\n" +
                    $"Email: {row.Cells["Email"].Value}\n" +
                    $"Department: {row.Cells["Department"].Value}\n" +
                    $"Daily Rate: {row.Cells["DailyRate"].Value}\n" +
                    $"Date Hired: {Convert.ToDateTime(row.Cells["DateHired"].Value):MM/dd/yyyy}";

                // Load image
                if (row.Cells["Image"].Value != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])row.Cells["Image"].Value;
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        selectedRowImage = Image.FromStream(ms);
                    }
                }
                else
                {
                    selectedRowImage = null;
                }

                PrintPreviewDialog previewDialog = new PrintPreviewDialog();
                previewDialog.Document = printDoc;
                previewDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row first.", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Print Selected Employee
        private void PrintSelectedData_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Title
            string title = "Employee Profile";
            Font titleFont = new Font("Arial", 22, FontStyle.Bold);
            e.Graphics.DrawString(title, titleFont, Brushes.Black, new PointF(310, 50)); // adjust x and y

            // Text Details
            Font font = new Font("Arial", 16);
            float lineHeight = font.GetHeight(e.Graphics) + 10;
            float xText = 80;
            float yText = 100 + titleFont.GetHeight(e.Graphics) + 20;

            // Draw text
            foreach (string line in selectedRowData.Split('\n'))
            {
                e.Graphics.DrawString(line, font, Brushes.Black, xText, yText);
                yText += lineHeight;
            }

            // Draw image if available
            if (selectedRowImage != null)
            {
                float imageX = 540;
                float imageY = 150;
                int imgWidth = 250;
                int imgHeight = 250;

                e.Graphics.DrawImage(selectedRowImage, imageX, imageY, imgWidth, imgHeight);
            }
        }

        // Displays the About and Logout Button
        private void adminprofile_panel_Click(object sender, EventArgs e)
        {
            contextMenuStrip_About_Logout.Show(Cursor.Position);

        }
       
        // Circle Admin Profile Picture
        public void MakePictureBoxCircular(PictureBox picBox)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, picBox.Width, picBox.Height);
            picBox.Region = new Region(path);
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
    }
}
