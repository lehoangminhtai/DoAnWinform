﻿namespace StudentManagement.GUI.AttendanceGUI
{
    partial class UcAttendance
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddAttend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 653);
            this.panel1.TabIndex = 0;
            // 
            // btnAddAttend
            // 
            this.btnAddAttend.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAddAttend.Location = new System.Drawing.Point(17, 13);
            this.btnAddAttend.Name = "btnAddAttend";
            this.btnAddAttend.Size = new System.Drawing.Size(119, 48);
            this.btnAddAttend.TabIndex = 1;
            this.btnAddAttend.Text = "Điểm danh";
            this.btnAddAttend.UseVisualStyleBackColor = false;
            // 
            // UcAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnAddAttend);
            this.Controls.Add(this.panel1);
            this.Name = "UcAttendance";
            this.Size = new System.Drawing.Size(1040, 723);
            this.Load += new System.EventHandler(this.UcAttendance_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddAttend;
    }
}
