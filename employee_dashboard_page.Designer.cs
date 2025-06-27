namespace TechQuint_EMS
{
    partial class employee_dashboard_page
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employee_dashboard_page));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.emp_profilepic = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.emp_name = new System.Windows.Forms.Label();
            this.timelog_btn = new System.Windows.Forms.Button();
            this.profile_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TimeIn_btn = new System.Windows.Forms.Button();
            this.time_in = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TimeOut_btn = new System.Windows.Forms.Button();
            this.time_out = new System.Windows.Forms.Label();
            this.current_date = new System.Windows.Forms.Label();
            this.current_time_timein = new System.Windows.Forms.Timer(this.components);
            this.current_time_timeout = new System.Windows.Forms.Timer(this.components);
            this.currentdate_timer = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emp_profilepic)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(243, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(966, 63);
            this.panel2.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::TechQuint_EMS.Properties.Resources.TechQuint_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(13, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::TechQuint_EMS.Properties.Resources.TechQuint_name;
            this.pictureBox2.Location = new System.Drawing.Point(94, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Welcome,";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.emp_profilepic);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.timelog_btn);
            this.panel1.Controls.Add(this.profile_btn);
            this.panel1.Controls.Add(this.logout_btn);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 691);
            this.panel1.TabIndex = 10;
            // 
            // emp_profilepic
            // 
            this.emp_profilepic.Image = global::TechQuint_EMS.Properties.Resources.AddPic;
            this.emp_profilepic.Location = new System.Drawing.Point(42, 26);
            this.emp_profilepic.Name = "emp_profilepic";
            this.emp_profilepic.Size = new System.Drawing.Size(160, 135);
            this.emp_profilepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emp_profilepic.TabIndex = 38;
            this.emp_profilepic.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.emp_name);
            this.panel3.Location = new System.Drawing.Point(1, 198);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 47);
            this.panel3.TabIndex = 22;
            // 
            // emp_name
            // 
            this.emp_name.BackColor = System.Drawing.Color.Transparent;
            this.emp_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.emp_name.Location = new System.Drawing.Point(0, 0);
            this.emp_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emp_name.MaximumSize = new System.Drawing.Size(244, 47);
            this.emp_name.Name = "emp_name";
            this.emp_name.Size = new System.Drawing.Size(244, 47);
            this.emp_name.TabIndex = 21;
            this.emp_name.Text = "Employee";
            this.emp_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timelog_btn
            // 
            this.timelog_btn.BackColor = System.Drawing.Color.Black;
            this.timelog_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.timelog_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelog_btn.ForeColor = System.Drawing.Color.White;
            this.timelog_btn.Image = ((System.Drawing.Image)(resources.GetObject("timelog_btn.Image")));
            this.timelog_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.timelog_btn.Location = new System.Drawing.Point(0, 264);
            this.timelog_btn.Margin = new System.Windows.Forms.Padding(4);
            this.timelog_btn.Name = "timelog_btn";
            this.timelog_btn.Size = new System.Drawing.Size(241, 69);
            this.timelog_btn.TabIndex = 23;
            this.timelog_btn.Text = "Time Log";
            this.timelog_btn.UseVisualStyleBackColor = false;
            this.timelog_btn.Click += new System.EventHandler(this.timelog_btn_Click);
            this.timelog_btn.MouseEnter += new System.EventHandler(this.timelog_btn_MouseEnter);
            this.timelog_btn.MouseLeave += new System.EventHandler(this.timelog_btn_MouseLeave);
            // 
            // profile_btn
            // 
            this.profile_btn.BackColor = System.Drawing.Color.Black;
            this.profile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.profile_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_btn.ForeColor = System.Drawing.Color.White;
            this.profile_btn.Image = ((System.Drawing.Image)(resources.GetObject("profile_btn.Image")));
            this.profile_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profile_btn.Location = new System.Drawing.Point(0, 340);
            this.profile_btn.Margin = new System.Windows.Forms.Padding(4);
            this.profile_btn.Name = "profile_btn";
            this.profile_btn.Size = new System.Drawing.Size(241, 69);
            this.profile_btn.TabIndex = 24;
            this.profile_btn.Text = "Profile";
            this.profile_btn.UseVisualStyleBackColor = false;
            this.profile_btn.Click += new System.EventHandler(this.profile_btn_Click);
            this.profile_btn.MouseEnter += new System.EventHandler(this.profile_btn_MouseEnter);
            this.profile_btn.MouseLeave += new System.EventHandler(this.profile_btn_MouseLeave);
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.Black;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Image = global::TechQuint_EMS.Properties.Resources.payroll_logo1;
            this.logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_btn.Location = new System.Drawing.Point(4, 594);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(4);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(241, 89);
            this.logout_btn.TabIndex = 26;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            this.logout_btn.MouseEnter += new System.EventHandler(this.logout_btn_MouseEnter);
            this.logout_btn.MouseLeave += new System.EventHandler(this.logout_btn_MouseLeave);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.time_in);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Location = new System.Drawing.Point(324, 138);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(343, 279);
            this.panel7.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
            this.panel5.Controls.Add(this.TimeIn_btn);
            this.panel5.Location = new System.Drawing.Point(192, 213);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(136, 54);
            this.panel5.TabIndex = 6;
            // 
            // TimeIn_btn
            // 
            this.TimeIn_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(163)))), ((int)(((byte)(160)))));
            this.TimeIn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeIn_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeIn_btn.ForeColor = System.Drawing.Color.White;
            this.TimeIn_btn.Location = new System.Drawing.Point(-11, -7);
            this.TimeIn_btn.Name = "TimeIn_btn";
            this.TimeIn_btn.Size = new System.Drawing.Size(159, 69);
            this.TimeIn_btn.TabIndex = 0;
            this.TimeIn_btn.Text = "TIME IN";
            this.TimeIn_btn.UseVisualStyleBackColor = false;
            this.TimeIn_btn.Click += new System.EventHandler(this.TimeIn_btn_Click);
            this.TimeIn_btn.MouseEnter += new System.EventHandler(this.TimeIn_btn_MouseEnter);
            this.TimeIn_btn.MouseLeave += new System.EventHandler(this.TimeIn_btn_MouseLeave);
            // 
            // time_in
            // 
            this.time_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.time_in.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_in.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.time_in.Location = new System.Drawing.Point(0, 85);
            this.time_in.Name = "time_in";
            this.time_in.Size = new System.Drawing.Size(343, 107);
            this.time_in.TabIndex = 5;
            this.time_in.Text = "00:00:00 AM";
            this.time_in.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(0, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(343, 41);
            this.label11.TabIndex = 4;
            this.label11.Text = "LOG TIME IN";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOG TIME OUT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.time_out);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(754, 138);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(343, 279);
            this.panel4.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
            this.panel6.Controls.Add(this.TimeOut_btn);
            this.panel6.Location = new System.Drawing.Point(190, 213);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(136, 54);
            this.panel6.TabIndex = 7;
            // 
            // TimeOut_btn
            // 
            this.TimeOut_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(163)))), ((int)(((byte)(160)))));
            this.TimeOut_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeOut_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeOut_btn.ForeColor = System.Drawing.Color.White;
            this.TimeOut_btn.Location = new System.Drawing.Point(-11, -7);
            this.TimeOut_btn.Name = "TimeOut_btn";
            this.TimeOut_btn.Size = new System.Drawing.Size(159, 69);
            this.TimeOut_btn.TabIndex = 0;
            this.TimeOut_btn.Text = "TIME OUT";
            this.TimeOut_btn.UseVisualStyleBackColor = false;
            this.TimeOut_btn.Click += new System.EventHandler(this.TimeOut_btn_Click);
            this.TimeOut_btn.MouseEnter += new System.EventHandler(this.TimeOut_btn_MouseEnter);
            this.TimeOut_btn.MouseLeave += new System.EventHandler(this.TimeOut_btn_MouseLeave);
            // 
            // time_out
            // 
            this.time_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.time_out.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_out.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.time_out.Location = new System.Drawing.Point(0, 85);
            this.time_out.Name = "time_out";
            this.time_out.Size = new System.Drawing.Size(343, 107);
            this.time_out.TabIndex = 6;
            this.time_out.Text = "00:00:00 AM";
            this.time_out.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // current_date
            // 
            this.current_date.AutoSize = true;
            this.current_date.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.current_date.Location = new System.Drawing.Point(260, 71);
            this.current_date.Name = "current_date";
            this.current_date.Size = new System.Drawing.Size(339, 59);
            this.current_date.TabIndex = 6;
            this.current_date.Text = "CURRENT DATE";
            // 
            // current_time_timein
            // 
            this.current_time_timein.Interval = 1000;
            this.current_time_timein.Tick += new System.EventHandler(this.current_time_timein_Tick);
            // 
            // current_time_timeout
            // 
            this.current_time_timeout.Interval = 1000;
            // 
            // currentdate_timer
            // 
            this.currentdate_timer.Interval = 1000;
            this.currentdate_timer.Tick += new System.EventHandler(this.currentdate_timer_Tick);
            // 
            // employee_dashboard_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(1207, 676);
            this.Controls.Add(this.current_date);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1225, 723);
            this.MinimumSize = new System.Drawing.Size(1225, 723);
            this.Name = "employee_dashboard_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.employee_dashboard_page_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emp_profilepic)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button timelog_btn;
        private System.Windows.Forms.Label emp_name;
        private System.Windows.Forms.Button profile_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox emp_profilepic;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label time_in;
        private System.Windows.Forms.Label time_out;
        private System.Windows.Forms.Label current_date;
        private System.Windows.Forms.Timer current_time_timein;
        private System.Windows.Forms.Timer current_time_timeout;
        private System.Windows.Forms.Timer currentdate_timer;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button TimeIn_btn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button TimeOut_btn;
    }
}