namespace TechQuint_EMS
{
    partial class employee_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employee_page));
            this.panel2 = new System.Windows.Forms.Panel();
            this.adminprofile_panel = new System.Windows.Forms.Panel();
            this.admin_profilepic = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashboard_ad_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.register_ad_btn = new System.Windows.Forms.Button();
            this.payroll_ad_btn = new System.Windows.Forms.Button();
            this.department_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.registration_panel = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.img_pb = new System.Windows.Forms.PictureBox();
            this.import_img = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.emp_email_txt = new System.Windows.Forms.TextBox();
            this.emp_phonenum_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.emp_id_txt = new System.Windows.Forms.TextBox();
            this.emp_name_txt = new System.Windows.Forms.TextBox();
            this.emp_department_combo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.emp_rate_txt = new System.Windows.Forms.TextBox();
            this.PrintSelected_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.PrintAll_btn = new System.Windows.Forms.Button();
            this.PrintAllEmp = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.PrintSelectedData = new System.Drawing.Printing.PrintDocument();
            this.contextMenuStrip_About_Logout = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aBOUTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.adminprofile_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_profilepic)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.registration_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_pb)).BeginInit();
            this.contextMenuStrip_About_Logout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
            this.panel2.Controls.Add(this.adminprofile_panel);
            this.panel2.Location = new System.Drawing.Point(243, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(966, 63);
            this.panel2.TabIndex = 3;
            // 
            // adminprofile_panel
            // 
            this.adminprofile_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(163)))), ((int)(((byte)(160)))));
            this.adminprofile_panel.Controls.Add(this.admin_profilepic);
            this.adminprofile_panel.Controls.Add(this.label3);
            this.adminprofile_panel.Controls.Add(this.label4);
            this.adminprofile_panel.Location = new System.Drawing.Point(769, 6);
            this.adminprofile_panel.Name = "adminprofile_panel";
            this.adminprofile_panel.Size = new System.Drawing.Size(175, 51);
            this.adminprofile_panel.TabIndex = 41;
            this.adminprofile_panel.Click += new System.EventHandler(this.adminprofile_panel_Click);
            // 
            // admin_profilepic
            // 
            this.admin_profilepic.Image = global::TechQuint_EMS.Properties.Resources.AddPic;
            this.admin_profilepic.Location = new System.Drawing.Point(108, 5);
            this.admin_profilepic.Name = "admin_profilepic";
            this.admin_profilepic.Size = new System.Drawing.Size(49, 42);
            this.admin_profilepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.admin_profilepic.TabIndex = 38;
            this.admin_profilepic.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Welcome,";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Admin!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dashboard_ad_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.register_ad_btn);
            this.panel1.Controls.Add(this.payroll_ad_btn);
            this.panel1.Controls.Add(this.department_btn);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 691);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::TechQuint_EMS.Properties.Resources.TechQuint_name;
            this.pictureBox2.Location = new System.Drawing.Point(66, 122);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::TechQuint_EMS.Properties.Resources.TechQuint_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(54, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // dashboard_ad_btn
            // 
            this.dashboard_ad_btn.BackColor = System.Drawing.Color.Black;
            this.dashboard_ad_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dashboard_ad_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_ad_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_ad_btn.Image = global::TechQuint_EMS.Properties.Resources.dashboard_logo21;
            this.dashboard_ad_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_ad_btn.Location = new System.Drawing.Point(0, 213);
            this.dashboard_ad_btn.Margin = new System.Windows.Forms.Padding(4);
            this.dashboard_ad_btn.Name = "dashboard_ad_btn";
            this.dashboard_ad_btn.Size = new System.Drawing.Size(241, 69);
            this.dashboard_ad_btn.TabIndex = 23;
            this.dashboard_ad_btn.Text = "     Dashboard";
            this.dashboard_ad_btn.UseVisualStyleBackColor = false;
            this.dashboard_ad_btn.Click += new System.EventHandler(this.dashboard_ad_btn_Click);
            this.dashboard_ad_btn.MouseEnter += new System.EventHandler(this.dashboard_ad_btn_MouseEnter);
            this.dashboard_ad_btn.MouseLeave += new System.EventHandler(this.dashboard_ad_btn_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(87, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Admin";
            // 
            // register_ad_btn
            // 
            this.register_ad_btn.BackColor = System.Drawing.Color.Black;
            this.register_ad_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.register_ad_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_ad_btn.ForeColor = System.Drawing.Color.White;
            this.register_ad_btn.Image = global::TechQuint_EMS.Properties.Resources.emp_logo1;
            this.register_ad_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.register_ad_btn.Location = new System.Drawing.Point(0, 289);
            this.register_ad_btn.Margin = new System.Windows.Forms.Padding(4);
            this.register_ad_btn.Name = "register_ad_btn";
            this.register_ad_btn.Size = new System.Drawing.Size(241, 69);
            this.register_ad_btn.TabIndex = 24;
            this.register_ad_btn.Text = "     Employees";
            this.register_ad_btn.UseVisualStyleBackColor = false;
            this.register_ad_btn.Click += new System.EventHandler(this.register_ad_btn_Click);
            this.register_ad_btn.MouseEnter += new System.EventHandler(this.register_ad_btn_MouseEnter);
            this.register_ad_btn.MouseLeave += new System.EventHandler(this.register_ad_btn_MouseLeave);
            // 
            // payroll_ad_btn
            // 
            this.payroll_ad_btn.BackColor = System.Drawing.Color.Black;
            this.payroll_ad_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.payroll_ad_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payroll_ad_btn.ForeColor = System.Drawing.Color.White;
            this.payroll_ad_btn.Image = global::TechQuint_EMS.Properties.Resources.payroll_logo1;
            this.payroll_ad_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.payroll_ad_btn.Location = new System.Drawing.Point(0, 436);
            this.payroll_ad_btn.Margin = new System.Windows.Forms.Padding(4);
            this.payroll_ad_btn.Name = "payroll_ad_btn";
            this.payroll_ad_btn.Size = new System.Drawing.Size(241, 89);
            this.payroll_ad_btn.TabIndex = 26;
            this.payroll_ad_btn.Text = "           Payroll";
            this.payroll_ad_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.payroll_ad_btn.UseVisualStyleBackColor = false;
            this.payroll_ad_btn.Click += new System.EventHandler(this.payroll_ad_btn_Click);
            this.payroll_ad_btn.MouseEnter += new System.EventHandler(this.payroll_ad_btn_MouseEnter);
            this.payroll_ad_btn.MouseLeave += new System.EventHandler(this.payroll_ad_btn_MouseLeave);
            // 
            // department_btn
            // 
            this.department_btn.BackColor = System.Drawing.Color.Black;
            this.department_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.department_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department_btn.ForeColor = System.Drawing.Color.White;
            this.department_btn.Image = global::TechQuint_EMS.Properties.Resources.dept_logo1;
            this.department_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.department_btn.Location = new System.Drawing.Point(0, 358);
            this.department_btn.Margin = new System.Windows.Forms.Padding(4);
            this.department_btn.Name = "department_btn";
            this.department_btn.Size = new System.Drawing.Size(241, 82);
            this.department_btn.TabIndex = 25;
            this.department_btn.Text = "      Department";
            this.department_btn.UseVisualStyleBackColor = false;
            this.department_btn.Click += new System.EventHandler(this.department_btn_Click);
            this.department_btn.MouseEnter += new System.EventHandler(this.department_btn_MouseEnter);
            this.department_btn.MouseLeave += new System.EventHandler(this.department_btn_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employees’ Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(254, 115);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(940, 220);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // registration_panel
            // 
            this.registration_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
            this.registration_panel.Controls.Add(this.dateTimePicker1);
            this.registration_panel.Controls.Add(this.label6);
            this.registration_panel.Controls.Add(this.img_pb);
            this.registration_panel.Controls.Add(this.import_img);
            this.registration_panel.Controls.Add(this.label13);
            this.registration_panel.Controls.Add(this.label5);
            this.registration_panel.Controls.Add(this.emp_email_txt);
            this.registration_panel.Controls.Add(this.emp_phonenum_txt);
            this.registration_panel.Controls.Add(this.label7);
            this.registration_panel.Controls.Add(this.label8);
            this.registration_panel.Controls.Add(this.emp_id_txt);
            this.registration_panel.Controls.Add(this.emp_name_txt);
            this.registration_panel.Controls.Add(this.emp_department_combo);
            this.registration_panel.Controls.Add(this.label12);
            this.registration_panel.Controls.Add(this.label11);
            this.registration_panel.Controls.Add(this.label9);
            this.registration_panel.Controls.Add(this.emp_rate_txt);
            this.registration_panel.Location = new System.Drawing.Point(254, 344);
            this.registration_panel.Margin = new System.Windows.Forms.Padding(4);
            this.registration_panel.Name = "registration_panel";
            this.registration_panel.Size = new System.Drawing.Size(940, 262);
            this.registration_panel.TabIndex = 36;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(541, 214);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(386, 27);
            this.dateTimePicker1.TabIndex = 39;
            this.dateTimePicker1.Value = new System.DateTime(2025, 5, 17, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(536, 179);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 25);
            this.label6.TabIndex = 38;
            this.label6.Text = "Date Hired:";
            // 
            // img_pb
            // 
            this.img_pb.Image = global::TechQuint_EMS.Properties.Resources.AddPic;
            this.img_pb.Location = new System.Drawing.Point(24, 53);
            this.img_pb.Name = "img_pb";
            this.img_pb.Size = new System.Drawing.Size(166, 143);
            this.img_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_pb.TabIndex = 37;
            this.img_pb.TabStop = false;
            // 
            // import_img
            // 
            this.import_img.Location = new System.Drawing.Point(46, 204);
            this.import_img.Margin = new System.Windows.Forms.Padding(4);
            this.import_img.Name = "import_img";
            this.import_img.Size = new System.Drawing.Size(118, 47);
            this.import_img.TabIndex = 36;
            this.import_img.Text = "IMPORT";
            this.import_img.UseVisualStyleBackColor = true;
            this.import_img.Click += new System.EventHandler(this.import_img_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(4, 5);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(279, 41);
            this.label13.TabIndex = 35;
            this.label13.Text = "Register Employee";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(203, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Employee ID:";
            // 
            // emp_email_txt
            // 
            this.emp_email_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_email_txt.Location = new System.Drawing.Point(537, 55);
            this.emp_email_txt.Margin = new System.Windows.Forms.Padding(4);
            this.emp_email_txt.Name = "emp_email_txt";
            this.emp_email_txt.Size = new System.Drawing.Size(390, 30);
            this.emp_email_txt.TabIndex = 35;
            // 
            // emp_phonenum_txt
            // 
            this.emp_phonenum_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_phonenum_txt.Location = new System.Drawing.Point(206, 218);
            this.emp_phonenum_txt.Margin = new System.Windows.Forms.Padding(4);
            this.emp_phonenum_txt.Name = "emp_phonenum_txt";
            this.emp_phonenum_txt.Size = new System.Drawing.Size(219, 30);
            this.emp_phonenum_txt.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(204, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Name:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(204, 189);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Phone Number: ";
            // 
            // emp_id_txt
            // 
            this.emp_id_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_id_txt.Location = new System.Drawing.Point(206, 83);
            this.emp_id_txt.Margin = new System.Windows.Forms.Padding(4);
            this.emp_id_txt.Name = "emp_id_txt";
            this.emp_id_txt.Size = new System.Drawing.Size(219, 30);
            this.emp_id_txt.TabIndex = 21;
            // 
            // emp_name_txt
            // 
            this.emp_name_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_name_txt.Location = new System.Drawing.Point(206, 147);
            this.emp_name_txt.Margin = new System.Windows.Forms.Padding(4);
            this.emp_name_txt.Name = "emp_name_txt";
            this.emp_name_txt.Size = new System.Drawing.Size(299, 30);
            this.emp_name_txt.TabIndex = 22;
            // 
            // emp_department_combo
            // 
            this.emp_department_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_department_combo.FormattingEnabled = true;
            this.emp_department_combo.Items.AddRange(new object[] {
            "Development ",
            "Design ",
            "Marketing ",
            "Finance",
            "Admin/HR"});
            this.emp_department_combo.Location = new System.Drawing.Point(537, 130);
            this.emp_department_combo.Margin = new System.Windows.Forms.Padding(4);
            this.emp_department_combo.Name = "emp_department_combo";
            this.emp_department_combo.Size = new System.Drawing.Size(219, 33);
            this.emp_department_combo.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(778, 100);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 25);
            this.label12.TabIndex = 20;
            this.label12.Text = "Daily Rate: ";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(531, 21);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 25);
            this.label11.TabIndex = 19;
            this.label11.Text = "Email Address:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(532, 97);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Department:";
            // 
            // emp_rate_txt
            // 
            this.emp_rate_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_rate_txt.Location = new System.Drawing.Point(782, 133);
            this.emp_rate_txt.Margin = new System.Windows.Forms.Padding(4);
            this.emp_rate_txt.Name = "emp_rate_txt";
            this.emp_rate_txt.Size = new System.Drawing.Size(145, 30);
            this.emp_rate_txt.TabIndex = 25;
            // 
            // PrintSelected_btn
            // 
            this.PrintSelected_btn.Location = new System.Drawing.Point(1037, 614);
            this.PrintSelected_btn.Margin = new System.Windows.Forms.Padding(4);
            this.PrintSelected_btn.Name = "PrintSelected_btn";
            this.PrintSelected_btn.Size = new System.Drawing.Size(131, 47);
            this.PrintSelected_btn.TabIndex = 40;
            this.PrintSelected_btn.Text = "PRINT";
            this.PrintSelected_btn.UseVisualStyleBackColor = true;
            this.PrintSelected_btn.Click += new System.EventHandler(this.PrintSelected_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(617, 614);
            this.clear_btn.Margin = new System.Windows.Forms.Padding(4);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(118, 47);
            this.clear_btn.TabIndex = 41;
            this.clear_btn.Text = "CLEAR";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.update_btn.Location = new System.Drawing.Point(266, 614);
            this.update_btn.Margin = new System.Windows.Forms.Padding(4);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(118, 47);
            this.update_btn.TabIndex = 39;
            this.update_btn.Text = "UPDATE";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(439, 614);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(4);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(118, 47);
            this.delete_btn.TabIndex = 38;
            this.delete_btn.Text = "DELETE";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(791, 614);
            this.add_btn.Margin = new System.Windows.Forms.Padding(4);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(118, 47);
            this.add_btn.TabIndex = 37;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // PrintAll_btn
            // 
            this.PrintAll_btn.Location = new System.Drawing.Point(1063, 70);
            this.PrintAll_btn.Margin = new System.Windows.Forms.Padding(4);
            this.PrintAll_btn.Name = "PrintAll_btn";
            this.PrintAll_btn.Size = new System.Drawing.Size(131, 35);
            this.PrintAll_btn.TabIndex = 42;
            this.PrintAll_btn.Text = "PRINT ALL";
            this.PrintAll_btn.UseVisualStyleBackColor = true;
            this.PrintAll_btn.Click += new System.EventHandler(this.PrintAll_btn_Click);
            // 
            // PrintAllEmp
            // 
            this.PrintAllEmp.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintAllEmp_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.PrintAllEmp;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // PrintSelectedData
            // 
            this.PrintSelectedData.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintSelectedData_PrintPage);
            // 
            // contextMenuStrip_About_Logout
            // 
            this.contextMenuStrip_About_Logout.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.contextMenuStrip_About_Logout.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_About_Logout.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBOUTToolStripMenuItem1,
            this.lOGOUTToolStripMenuItem});
            this.contextMenuStrip_About_Logout.Name = "contextMenuStrip1";
            this.contextMenuStrip_About_Logout.Size = new System.Drawing.Size(139, 56);
            // 
            // aBOUTToolStripMenuItem1
            // 
            this.aBOUTToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("aBOUTToolStripMenuItem1.Image")));
            this.aBOUTToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(163)))), ((int)(((byte)(160)))));
            this.aBOUTToolStripMenuItem1.Name = "aBOUTToolStripMenuItem1";
            this.aBOUTToolStripMenuItem1.Size = new System.Drawing.Size(138, 26);
            this.aBOUTToolStripMenuItem1.Text = "ABOUT";
            this.aBOUTToolStripMenuItem1.Click += new System.EventHandler(this.aBOUTToolStripMenuItem1_Click);
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lOGOUTToolStripMenuItem.Image")));
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // employee_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(1207, 676);
            this.Controls.Add(this.PrintAll_btn);
            this.Controls.Add(this.PrintSelected_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.registration_panel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1225, 723);
            this.MinimumSize = new System.Drawing.Size(1225, 723);
            this.Name = "employee_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.employee_page_Load);
            this.panel2.ResumeLayout(false);
            this.adminprofile_panel.ResumeLayout(false);
            this.adminprofile_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_profilepic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.registration_panel.ResumeLayout(false);
            this.registration_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_pb)).EndInit();
            this.contextMenuStrip_About_Logout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dashboard_ad_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button register_ad_btn;
        private System.Windows.Forms.Button payroll_ad_btn;
        private System.Windows.Forms.Button department_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel registration_panel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox img_pb;
        private System.Windows.Forms.Button import_img;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emp_email_txt;
        private System.Windows.Forms.TextBox emp_phonenum_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox emp_id_txt;
        private System.Windows.Forms.TextBox emp_name_txt;
        private System.Windows.Forms.ComboBox emp_department_combo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox emp_rate_txt;
        private System.Windows.Forms.Button PrintSelected_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button PrintAll_btn;
        private System.Drawing.Printing.PrintDocument PrintAllEmp;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument PrintSelectedData;
        private System.Windows.Forms.Panel adminprofile_panel;
        private System.Windows.Forms.PictureBox admin_profilepic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_About_Logout;
        private System.Windows.Forms.ToolStripMenuItem aBOUTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
    }
}