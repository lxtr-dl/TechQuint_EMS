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
    public partial class Welcome_Page : Form
    {
        public Welcome_Page()
        {
            InitializeComponent();
        }

        private void Welcome_Page_Click(object sender, EventArgs e)
        {
            Admin_Login_Page start = new Admin_Login_Page();
            start.Show();
            this.Hide(); 
        }

        private void Welcome_Page_Load(object sender, EventArgs e)
        {

        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            Admin_Login_Page start = new Admin_Login_Page();
            start.Show();
            this.Hide();
        }

        private void emp_btn_Click(object sender, EventArgs e)
        {
            Emp_Login_Page start = new Emp_Login_Page();
            start.Show();
            this.Hide();
        }

        private void admin_btn_MouseEnter(object sender, EventArgs e)
        {
            admin_btn.BackColor = Color.Teal;
            admin_btn.ForeColor = Color.White;
        }

        private void admin_btn_MouseLeave(object sender, EventArgs e)
        {
            admin_btn.BackColor = Color.FromArgb(73, 163, 160);
            admin_btn.ForeColor = Color.White;
        }

        private void emp_btn_MouseEnter(object sender, EventArgs e)
        {
            emp_btn.BackColor = Color.Teal;
            emp_btn.ForeColor = Color.White;
        }

        private void emp_btn_MouseLeave(object sender, EventArgs e)
        {
            emp_btn.BackColor = Color.FromArgb(73, 163, 160);
            emp_btn.ForeColor = Color.White;
        }

        
    }
}
