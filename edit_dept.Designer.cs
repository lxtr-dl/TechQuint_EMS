namespace TechQuint_EMS
{
    partial class edit_dept
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveEditDept_btn = new System.Windows.Forms.Button();
            this.EditedDeptname_txt = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(522, 56);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Edit Department";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cancel_btn);
            this.panel2.Location = new System.Drawing.Point(70, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 43);
            this.panel2.TabIndex = 11;
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
            this.cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SaveEditDept_btn);
            this.panel1.Location = new System.Drawing.Point(313, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 43);
            this.panel1.TabIndex = 10;
            // 
            // SaveEditDept_btn
            // 
            this.SaveEditDept_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
            this.SaveEditDept_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveEditDept_btn.ForeColor = System.Drawing.Color.White;
            this.SaveEditDept_btn.Location = new System.Drawing.Point(-14, -6);
            this.SaveEditDept_btn.Name = "SaveEditDept_btn";
            this.SaveEditDept_btn.Size = new System.Drawing.Size(159, 56);
            this.SaveEditDept_btn.TabIndex = 3;
            this.SaveEditDept_btn.Text = "SAVE";
            this.SaveEditDept_btn.UseVisualStyleBackColor = false;
            this.SaveEditDept_btn.Click += new System.EventHandler(this.SaveEditDept_btn_Click);
            // 
            // EditedDeptname_txt
            // 
            this.EditedDeptname_txt.BackColor = System.Drawing.Color.White;
            this.EditedDeptname_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditedDeptname_txt.Location = new System.Drawing.Point(33, 83);
            this.EditedDeptname_txt.Name = "EditedDeptname_txt";
            this.EditedDeptname_txt.Size = new System.Drawing.Size(448, 41);
            this.EditedDeptname_txt.TabIndex = 9;
            // 
            // edit_dept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(522, 217);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EditedDeptname_txt);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "edit_dept";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveEditDept_btn;
        private System.Windows.Forms.TextBox EditedDeptname_txt;
    }
}