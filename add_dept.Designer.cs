namespace TechQuint_EMS
{
    partial class add_dept
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.AddDept_btn = new System.Windows.Forms.Button();
            this.deptname_txt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Department";
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_btn.Location = new System.Drawing.Point(-8, -8);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(144, 61);
            this.cancel_btn.TabIndex = 2;
            this.cancel_btn.Text = "CANCEL";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // AddDept_btn
            // 
            this.AddDept_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
            this.AddDept_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDept_btn.ForeColor = System.Drawing.Color.White;
            this.AddDept_btn.Location = new System.Drawing.Point(-14, -6);
            this.AddDept_btn.Name = "AddDept_btn";
            this.AddDept_btn.Size = new System.Drawing.Size(159, 56);
            this.AddDept_btn.TabIndex = 3;
            this.AddDept_btn.Text = "ADD";
            this.AddDept_btn.UseVisualStyleBackColor = false;
            this.AddDept_btn.Click += new System.EventHandler(this.AddDept_btn_Click);
            // 
            // deptname_txt
            // 
            this.deptname_txt.BackColor = System.Drawing.Color.White;
            this.deptname_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptname_txt.Location = new System.Drawing.Point(32, 86);
            this.deptname_txt.Name = "deptname_txt";
            this.deptname_txt.Size = new System.Drawing.Size(448, 41);
            this.deptname_txt.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddDept_btn);
            this.panel1.Location = new System.Drawing.Point(312, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 43);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cancel_btn);
            this.panel2.Location = new System.Drawing.Point(69, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 43);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(522, 56);
            this.panel3.TabIndex = 7;
            // 
            // add_dept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(522, 217);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deptname_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(522, 217);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(522, 217);
            this.Name = "add_dept";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button AddDept_btn;
        private System.Windows.Forms.TextBox deptname_txt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}