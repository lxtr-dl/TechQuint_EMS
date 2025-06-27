namespace TechQuint_EMS
{
    partial class DeptMiniButtons
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
            this.MiniDeptName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MiniDeptName
            // 
            this.MiniDeptName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiniDeptName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiniDeptName.ForeColor = System.Drawing.Color.White;
            this.MiniDeptName.Location = new System.Drawing.Point(0, 0);
            this.MiniDeptName.Name = "MiniDeptName";
            this.MiniDeptName.Size = new System.Drawing.Size(164, 35);
            this.MiniDeptName.TabIndex = 0;
            this.MiniDeptName.Text = "DeptName";
            this.MiniDeptName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeptMiniButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
            this.Controls.Add(this.MiniDeptName);
            this.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Name = "DeptMiniButtons";
            this.Size = new System.Drawing.Size(164, 35);
            this.Load += new System.EventHandler(this.DeptMiniButtons_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MiniDeptName;
    }
}
