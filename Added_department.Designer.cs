namespace TechQuint_EMS
{
    partial class Added_department
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Added_department));
            this.lblDeptName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmpCount = new System.Windows.Forms.Label();
            this.menustrip_edit_delete = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.menustrip_edit_delete)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeptName
            // 
            this.lblDeptName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDeptName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptName.ForeColor = System.Drawing.Color.White;
            this.lblDeptName.Location = new System.Drawing.Point(0, 0);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(267, 62);
            this.lblDeptName.TabIndex = 0;
            this.lblDeptName.Text = "Department";
            this.lblDeptName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Employees:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmpCount
            // 
            this.lblEmpCount.AutoSize = true;
            this.lblEmpCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpCount.ForeColor = System.Drawing.Color.White;
            this.lblEmpCount.Location = new System.Drawing.Point(197, 85);
            this.lblEmpCount.Name = "lblEmpCount";
            this.lblEmpCount.Size = new System.Drawing.Size(26, 29);
            this.lblEmpCount.TabIndex = 4;
            this.lblEmpCount.Text = "0";
            // 
            // menustrip_edit_delete
            // 
            this.menustrip_edit_delete.Image = ((System.Drawing.Image)(resources.GetObject("menustrip_edit_delete.Image")));
            this.menustrip_edit_delete.Location = new System.Drawing.Point(247, 6);
            this.menustrip_edit_delete.Name = "menustrip_edit_delete";
            this.menustrip_edit_delete.Size = new System.Drawing.Size(10, 22);
            this.menustrip_edit_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menustrip_edit_delete.TabIndex = 2;
            this.menustrip_edit_delete.TabStop = false;
            this.menustrip_edit_delete.Click += new System.EventHandler(this.menustrip_edit_delete_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 56);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDeptName);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 62);
            this.panel1.TabIndex = 5;
            // 
            // Added_department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEmpCount);
            this.Controls.Add(this.menustrip_edit_delete);
            this.Controls.Add(this.label2);
            this.Name = "Added_department";
            this.Size = new System.Drawing.Size(267, 145);
            this.Click += new System.EventHandler(this.Added_department_Click);
            this.MouseEnter += new System.EventHandler(this.Added_department_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Added_department_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.menustrip_edit_delete)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeptName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox menustrip_edit_delete;
        private System.Windows.Forms.Label lblEmpCount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}
