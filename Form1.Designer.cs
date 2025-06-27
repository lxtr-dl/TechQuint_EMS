namespace TechQuint_EMS
{
    partial class Welcome_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome_Page));
            this.panel1 = new System.Windows.Forms.Panel();
            this.admin_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.emp_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.admin_btn);
            this.panel1.Location = new System.Drawing.Point(190, 463);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 135);
            this.panel1.TabIndex = 4;
            // 
            // admin_btn
            // 
            this.admin_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(163)))), ((int)(((byte)(160)))));
            this.admin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.admin_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_btn.ForeColor = System.Drawing.Color.White;
            this.admin_btn.Location = new System.Drawing.Point(-10, -7);
            this.admin_btn.Name = "admin_btn";
            this.admin_btn.Size = new System.Drawing.Size(306, 152);
            this.admin_btn.TabIndex = 0;
            this.admin_btn.Text = "ADMIN";
            this.admin_btn.UseVisualStyleBackColor = false;
            this.admin_btn.Click += new System.EventHandler(this.admin_btn_Click);
            this.admin_btn.MouseEnter += new System.EventHandler(this.admin_btn_MouseEnter);
            this.admin_btn.MouseLeave += new System.EventHandler(this.admin_btn_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.emp_btn);
            this.panel2.Location = new System.Drawing.Point(732, 463);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 135);
            this.panel2.TabIndex = 5;
            // 
            // emp_btn
            // 
            this.emp_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(163)))), ((int)(((byte)(160)))));
            this.emp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.emp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_btn.ForeColor = System.Drawing.Color.White;
            this.emp_btn.Location = new System.Drawing.Point(-12, -7);
            this.emp_btn.Name = "emp_btn";
            this.emp_btn.Size = new System.Drawing.Size(307, 152);
            this.emp_btn.TabIndex = 1;
            this.emp_btn.Text = "EMPLOYEE";
            this.emp_btn.UseVisualStyleBackColor = false;
            this.emp_btn.Click += new System.EventHandler(this.emp_btn_Click);
            this.emp_btn.MouseEnter += new System.EventHandler(this.emp_btn_MouseEnter);
            this.emp_btn.MouseLeave += new System.EventHandler(this.emp_btn_MouseLeave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1209, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login as";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TechQuint_EMS.Properties.Resources.TechQuint_name;
            this.pictureBox2.Location = new System.Drawing.Point(385, 288);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(437, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TechQuint_EMS.Properties.Resources.TechQuint_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(471, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Welcome_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(1207, 675);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1225, 722);
            this.MinimumSize = new System.Drawing.Size(1225, 722);
            this.Name = "Welcome_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Load += new System.EventHandler(this.Welcome_Page_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button admin_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button emp_btn;
        private System.Windows.Forms.Label label1;
    }
}

