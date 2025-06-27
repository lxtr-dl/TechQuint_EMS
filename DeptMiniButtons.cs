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
    public partial class DeptMiniButtons : UserControl
    {
        // Event that will be triggered when this department
        public event EventHandler<string> DepartmentClicked;

        private string departmentName;

        public DeptMiniButtons()
        {
            InitializeComponent();

            // Trigger department click from control or label
            this.Click += OnDeptCardClicked;
            MiniDeptName.Click += OnDeptCardClicked;

            // Forward hover events from the label
            MiniDeptName.MouseEnter += (s, e) => this.OnMouseEnter(e);
            MiniDeptName.MouseLeave += (s, e) => this.OnMouseLeave(e);
        }

        // Sets the department name to be displayed and stored
        public void SetDepartmentInfo(string departmentName)
        {
            this.departmentName = departmentName;
            MiniDeptName.Text = departmentName;
        }

        // When the card or label is clicked, this method is called
        private void OnDeptCardClicked(object sender, EventArgs e)
        {
            // It tells them which department was clicked by sending the department name.
            DepartmentClicked?.Invoke(this, departmentName);
        }

        private void ApplyRoundedCorners()
        {
            int radius = 8;

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(this.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(this.Width - radius * 2, this.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(0, this.Height - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseAllFigures();
            this.Region = new Region(path);
        }

        private void DeptMiniButtons_Load(object sender, EventArgs e)
        {
            ApplyRoundedCorners();
        }

    }
}
