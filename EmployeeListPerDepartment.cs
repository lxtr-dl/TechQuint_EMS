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
    public partial class EmployeeListPerDepartment : Form
    {

        public EmployeeListPerDepartment()
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

        // Overloaded constructor that loads employee data by department
        public EmployeeListPerDepartment(string deptName, DataTable employeeData)
        {
            InitializeComponent();

            this.deptName = deptName;
            deptNameLabel.Text = $"{deptName} Department Employees";
            EmployeeListDataGridPerDept.DataSource = employeeData;

            // Hide the Department column if it exists
            if (EmployeeListDataGridPerDept.Columns.Contains("Department"))
            {
                EmployeeListDataGridPerDept.Columns["Department"].Visible = false;
            }

            EmployeeListDataGridPerDept.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LoadAllDepartments();
        }

        private DeptMiniButtons selectedDeptCard = null;
        private readonly Color deptHighlightColor = Color.FromArgb(73, 163, 160);
        private readonly Color deptDefaultBackColor = Color.FromArgb(49, 92, 98);
        private readonly Color deptDefaultForeColor = Color.White;
        private readonly Color deptHighlightForeColor = Color.FromArgb(49, 92, 98);

        // Loads all departments as mini buttons into the flow layout panel
        private void LoadAllDepartments()
        {
            flowLayoutPanel1.Controls.Clear();

            // Add fixed "All" card
            DeptMiniButtons allCard = new DeptMiniButtons();
            allCard.SetDepartmentInfo("All");
            allCard.DepartmentClicked += HandleDepartmentCardClick;
            allCard.MouseEnter += DeptCard_MouseEnter;
            allCard.MouseLeave += DeptCard_MouseLeave;
            allCard.Click += DeptCard_Click;
            allCard.BackColor = deptDefaultBackColor;
            allCard.ForeColor = deptDefaultForeColor;

            // Highlight "All" if selected
            if (deptName == "All")
                SetSelectedDeptCard(allCard);

            flowLayoutPanel1.Controls.Add(allCard);

            // Load other department names from the database, depts_table
            string query = "SELECT DepartmentName FROM techquint.depts_table";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string deptName = reader["DepartmentName"].ToString();

                        DeptMiniButtons deptCard = new DeptMiniButtons();
                        deptCard.SetDepartmentInfo(deptName);
                        deptCard.DepartmentClicked += HandleDepartmentCardClick;
                        deptCard.MouseEnter += DeptCard_MouseEnter;
                        deptCard.MouseLeave += DeptCard_MouseLeave;
                        deptCard.Click += DeptCard_Click;
                        deptCard.BackColor = deptDefaultBackColor;
                        deptCard.ForeColor = deptDefaultForeColor;

                        if (this.deptName == deptName)
                            SetSelectedDeptCard(deptCard);

                        flowLayoutPanel1.Controls.Add(deptCard);
                    }
                }
            }
        }

        // Highlight on hover
        private void DeptCard_MouseEnter(object sender, EventArgs e)
        {
            if (sender is DeptMiniButtons card && card != selectedDeptCard)
            {
                card.BackColor = deptHighlightColor;
                card.ForeColor = deptHighlightForeColor;
            }
        }

        // Remove highlight on leave
        private void DeptCard_MouseLeave(object sender, EventArgs e)
        {
            if (sender is DeptMiniButtons card && card != selectedDeptCard)
            {
                card.BackColor = deptDefaultBackColor;
                card.ForeColor = deptDefaultForeColor;
            }
        }

        private void DeptCard_Click(object sender, EventArgs e)
        {
            var card = sender as DeptMiniButtons;

            if (selectedDeptCard != null && selectedDeptCard != card)
            {
                // Revert old selected card
                selectedDeptCard.BackColor = deptDefaultBackColor;
                selectedDeptCard.ForeColor = deptDefaultForeColor;
            }

            // Set new selected card
            selectedDeptCard = card;
            selectedDeptCard.BackColor = deptHighlightColor;
            selectedDeptCard.ForeColor = deptHighlightForeColor;
        }

        private void EmployeeListPerDepartment_Load(object sender, EventArgs e)
        {
            SetSelectedNavButton(department_btn);
            LoadAllDepartments();
            MakePictureBoxCircular(admin_profilepic);
            MakeRoundedCorners(adminprofile_panel, 10);

            if (EmployeeListDataGridPerDept.Columns.Contains("Image"))
            {
                ((DataGridViewImageColumn)EmployeeListDataGridPerDept.Columns["Image"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
        }

        private void SetSelectedDeptCard(DeptMiniButtons card)
        {
            if (selectedDeptCard != null && selectedDeptCard != card)
            {
                selectedDeptCard.BackColor = deptDefaultBackColor;
                selectedDeptCard.ForeColor = deptDefaultForeColor;
                selectedDeptCard.Invalidate();
            }

            selectedDeptCard = card;
            selectedDeptCard.BackColor = deptHighlightColor;
            selectedDeptCard.ForeColor = deptHighlightForeColor;
            selectedDeptCard.Invalidate();
        }

        // Handles click event for each department card
        private void HandleDepartmentCardClick(object sender, string deptName)
        {
            DeptCard_Click(sender, EventArgs.Empty);

            if (deptName == "All")
            {
                dept_page allForm = new dept_page();
                allForm.Show();
                this.Close();
            }
            else
            {
                LoadEmployeesOfDepartment(deptName);
            }
        }

        // Loads employees of a specific department from the Database, emp_info
        private void LoadEmployeesOfDepartment(string deptName)
        {
            string query = "SELECT * FROM emp_info WHERE Department = @dept";

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@dept", deptName);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        

                        deptNameLabel.Text = $"{deptName} Department Employees";
                        EmployeeListDataGridPerDept.DataSource = dt;

                        //code for image
                        if (EmployeeListDataGridPerDept.Columns.Contains("Image"))
                        {
                            ((DataGridViewImageColumn)EmployeeListDataGridPerDept.Columns["Image"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                        }

                        if (EmployeeListDataGridPerDept.Columns.Contains("Department"))
                        {
                            EmployeeListDataGridPerDept.Columns["Department"].Visible = false;
                        }
                    }
                }
            }
        }

        int currentRow = 0;
        private string deptName = "";
        private Button selectedNavButton = null;
        private readonly Color navHighlightColor = Color.Teal;
        private readonly Color navDefaultBackColor = Color.Black;
        private readonly Color navDefaultForeColor = Color.White;
        private readonly Color navHighlightForeColor = Color.Black;


        // Opens print preview for employees for department
        private void Print_btn_Click(object sender, EventArgs e)
        {
            currentRow = 0;
            PrintEmployeePerDepartment.DefaultPageSettings.Landscape = true;
            printPreviewDialog1.Document = PrintEmployeePerDepartment;
            printPreviewDialog1.ShowDialog();
        }

        // Handles actual print rendering of employee list per department
        private void PrintEmployeePerDepartment_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Define fonts and size used in printing a file
            Font headerFont = new Font("Arial", 20, FontStyle.Bold);
            Font columnFont = new Font("Arial", 11, FontStyle.Bold);
            Font cellFont = new Font("Arial", 11);

            int x = 50;
            int y = 100;
            int rowHeight = 70;

            // Define column widths for each column in the DataGridView
            int[] columnWidths = { 80, 220, 120, 150, 100, 100, 130 };

            // Displays the title at the top of the page
            e.Graphics.DrawString($"{deptName} Department Employees", headerFont, Brushes.Black, new PointF(300, 50));

            for (int i = 0; i < EmployeeListDataGridPerDept.Columns.Count; i++)
            {
                int colWidth = columnWidths.Length > i ? columnWidths[i] : 100;
                e.Graphics.DrawRectangle(Pens.Black, x, y, colWidth, rowHeight);
                e.Graphics.DrawString(EmployeeListDataGridPerDept.Columns[i].HeaderText, columnFont, Brushes.Black, new RectangleF(x + 3, y + 5, colWidth, rowHeight));
                x += colWidth;
            }

            y += rowHeight;
            x = 50;

            while (currentRow < EmployeeListDataGridPerDept.Rows.Count)
            {
                DataGridViewRow row = EmployeeListDataGridPerDept.Rows[currentRow];
                if (row.IsNewRow) { currentRow++; continue; }

                for (int j = 0; j < row.Cells.Count; j++)
                {
                    int colWidth = columnWidths.Length > j ? columnWidths[j] : 100;
                    object rawValue = row.Cells[j].Value;
                    e.Graphics.DrawRectangle(Pens.Black, x, y, colWidth, rowHeight);

                    if (EmployeeListDataGridPerDept.Columns[j].HeaderText == "Image" && rawValue != DBNull.Value)
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
