using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
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
    public partial class dept_page : Form
    {
        private Button selectedNavButton = null;
        private readonly Color navHighlightColor = Color.Teal; // Highlight color
        private readonly Color navDefaultBackColor = Color.Black;
        private readonly Color navDefaultForeColor = Color.White;
        private readonly Color navHighlightForeColor = Color.Black;

        public dept_page()
        {
            InitializeComponent();
        }

        // Locations of the Main Buttons (Dashboard, Employee, Department, Payroll)
        private void dashboard_ad_btn_Click_1(object sender, EventArgs e)
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
            payroll_page start = new payroll_page();
            start.Show();
            this.Hide();
        }

        private void aBOUTToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            SetSelectedNavButton(payroll_ad_btn);
            about_page start = new about_page();
            start.Show();
            this.Hide();
        }

        private void lOGOUTToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        // Add Department Button, displays the add_dept form
        private void AddDept_btn_Click(object sender, EventArgs e)
        {
            add_dept start = new add_dept();

            if (start.ShowDialog() == DialogResult.OK)
            {
                LoadDepartmentCards();
            }
        }

        //fetches all departments from the database and creates a visual card for each one
        public void LoadDepartmentCards()
        {
            // Clear old department cards
            // This ensures you don't duplicate cards every time this method is called.
            DeptList.Controls.Clear(); 

            string query = "SELECT * FROM techquint.depts_table";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string deptName = reader["DepartmentName"].ToString();
                        int empCount = Convert.ToInt32(reader["NumberOfEmployees"]);

                        Added_department deptCard = new Added_department();
                        deptCard.SetDepartmentInfo(deptName, empCount);

                        // Apply rounded corners
                        int radius = 8;
                        System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                        path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
                        path.AddArc(deptCard.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
                        path.AddArc(deptCard.Width - radius * 2, deptCard.Height - radius * 2, radius * 2, radius * 2, 0, 90);
                        path.AddArc(0, deptCard.Height - radius * 2, radius * 2, radius * 2, 90, 90);
                        path.CloseAllFigures();
                        deptCard.Region = new Region(path);

                        // Set margin and anchoring
                        deptCard.Margin = new Padding(10); // spacing between cards
                        deptCard.Anchor = AnchorStyles.Top;

                        // Add to container
                        DeptList.Controls.Add(deptCard);
                    }
                }
            }
        }

        // Displays department cards when the department page is loaded 
        private void dept_page_Load(object sender, EventArgs e)
        {
            SetSelectedNavButton(department_btn);
            LoadDepartmentCards();
            MakePictureBoxCircular(admin_profilepic);
            MakeRoundedCorners(adminprofile_panel, 10);

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
    }
}
