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
    public partial class Admin_Login_Page : Form
    {
        public Admin_Login_Page()
        {
            InitializeComponent();
        }

        // Set Username and Password
        private void admin_login_btn_Click(object sender, EventArgs e)
        {
            string Username = "admin";
            string Password = "password";

            if (admin_user.Text == Username && admin_pass.Text == Password)
            {
                Admin_Dashboard start = new Admin_Dashboard();
                start.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials!");
            }
        }

        // Display the password in letetrs
        private void showpass_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            admin_pass.UseSystemPasswordChar = !showpass_checkbox.Checked;
        }


        private void Admin_Login_Page_Load(object sender, EventArgs e)
        {
            admin_pass.UseSystemPasswordChar = true;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Welcome_Page start = new Welcome_Page();
            start.Show();
            this.Hide();
        }
    }
}
