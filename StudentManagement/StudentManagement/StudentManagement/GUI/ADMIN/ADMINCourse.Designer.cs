namespace StudentManagement.GUI
{
    partial class ADMINCourse
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
            this.panelCourse = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelCourse
            // 
            this.panelCourse.AutoScroll = true;
            this.panelCourse.AutoSize = true;
            this.panelCourse.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCourse.Location = new System.Drawing.Point(0, 0);
            this.panelCourse.Name = "panelCourse";
            this.panelCourse.Size = new System.Drawing.Size(1089, 613);
            this.panelCourse.TabIndex = 0;
            // 
            // ADMINCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1089, 613);
            this.Controls.Add(this.panelCourse);
            this.Name = "ADMINCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMINCourse";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ADMINCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCourse;
    }
}