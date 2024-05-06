namespace StudentManagement.GUI.NotificationGUI
{
    partial class UcNotificationTeacher
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelListNoti = new System.Windows.Forms.Panel();
            this.btnDeleteNoti = new System.Windows.Forms.Button();
            this.btnUpdateNoti = new System.Windows.Forms.Button();
            this.lblTimeRemain = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.listBoxCourse = new System.Windows.Forms.ListBox();
            this.listBoxNoti = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddNoti = new System.Windows.Forms.Button();
            this.panelListNoti.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(67, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khoá Học";
            // 
            // panelListNoti
            // 
            this.panelListNoti.AutoScroll = true;
            this.panelListNoti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelListNoti.Controls.Add(this.btnDeleteNoti);
            this.panelListNoti.Controls.Add(this.btnUpdateNoti);
            this.panelListNoti.Controls.Add(this.lblTimeRemain);
            this.panelListNoti.Controls.Add(this.label8);
            this.panelListNoti.Controls.Add(this.txtContent);
            this.panelListNoti.Controls.Add(this.label4);
            this.panelListNoti.Controls.Add(this.lblTitle);
            this.panelListNoti.Location = new System.Drawing.Point(777, 90);
            this.panelListNoti.Name = "panelListNoti";
            this.panelListNoti.Size = new System.Drawing.Size(637, 503);
            this.panelListNoti.TabIndex = 2;
            // 
            // btnDeleteNoti
            // 
            this.btnDeleteNoti.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteNoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNoti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteNoti.Location = new System.Drawing.Point(372, 424);
            this.btnDeleteNoti.Name = "btnDeleteNoti";
            this.btnDeleteNoti.Size = new System.Drawing.Size(141, 60);
            this.btnDeleteNoti.TabIndex = 10;
            this.btnDeleteNoti.Text = "Xoá";
            this.btnDeleteNoti.UseVisualStyleBackColor = false;
            this.btnDeleteNoti.Click += new System.EventHandler(this.btnDeleteNoti_Click);
            // 
            // btnUpdateNoti
            // 
            this.btnUpdateNoti.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUpdateNoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateNoti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateNoti.Location = new System.Drawing.Point(175, 424);
            this.btnUpdateNoti.Name = "btnUpdateNoti";
            this.btnUpdateNoti.Size = new System.Drawing.Size(141, 60);
            this.btnUpdateNoti.TabIndex = 10;
            this.btnUpdateNoti.Text = "Cập nhật";
            this.btnUpdateNoti.UseVisualStyleBackColor = false;
            this.btnUpdateNoti.Click += new System.EventHandler(this.btnUpdateNoti_Click);
            // 
            // lblTimeRemain
            // 
            this.lblTimeRemain.AutoSize = true;
            this.lblTimeRemain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeRemain.Location = new System.Drawing.Point(204, 338);
            this.lblTimeRemain.Name = "lblTimeRemain";
            this.lblTimeRemain.Size = new System.Drawing.Size(68, 22);
            this.lblTimeRemain.TabIndex = 9;
            this.lblTimeRemain.Text = "label10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Thời gian diễn ra:";
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(102, 62);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(514, 242);
            this.txtContent.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nội Dung";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTitle.Location = new System.Drawing.Point(21, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(586, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tiêu Đề";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxCourse
            // 
            this.listBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCourse.FormattingEnabled = true;
            this.listBoxCourse.ItemHeight = 29;
            this.listBoxCourse.Location = new System.Drawing.Point(26, 90);
            this.listBoxCourse.Name = "listBoxCourse";
            this.listBoxCourse.Size = new System.Drawing.Size(333, 497);
            this.listBoxCourse.TabIndex = 0;
            this.listBoxCourse.SelectedIndexChanged += new System.EventHandler(this.listBoxCourse_SelectedIndexChanged);
            // 
            // listBoxNoti
            // 
            this.listBoxNoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNoti.FormattingEnabled = true;
            this.listBoxNoti.ItemHeight = 29;
            this.listBoxNoti.Location = new System.Drawing.Point(377, 90);
            this.listBoxNoti.Name = "listBoxNoti";
            this.listBoxNoti.Size = new System.Drawing.Size(369, 497);
            this.listBoxNoti.TabIndex = 0;
            this.listBoxNoti.SelectedIndexChanged += new System.EventHandler(this.listBoxNoti_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(477, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thông Báo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label3.Location = new System.Drawing.Point(1032, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chi Tiết";
            // 
            // btnAddNoti
            // 
            this.btnAddNoti.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddNoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNoti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNoti.Location = new System.Drawing.Point(483, 606);
            this.btnAddNoti.Name = "btnAddNoti";
            this.btnAddNoti.Size = new System.Drawing.Size(141, 60);
            this.btnAddNoti.TabIndex = 10;
            this.btnAddNoti.Text = "Thông báo";
            this.btnAddNoti.UseVisualStyleBackColor = false;
            this.btnAddNoti.Click += new System.EventHandler(this.btnAddNoti_Click);
            // 
            // UcNotificationTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.listBoxNoti);
            this.Controls.Add(this.btnAddNoti);
            this.Controls.Add(this.listBoxCourse);
            this.Controls.Add(this.panelListNoti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UcNotificationTeacher";
            this.Size = new System.Drawing.Size(1461, 684);
            this.Load += new System.EventHandler(this.UcNotificationTeacher_Load);
            this.panelListNoti.ResumeLayout(false);
            this.panelListNoti.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelListNoti;
        private System.Windows.Forms.ListBox listBoxCourse;
        private System.Windows.Forms.ListBox listBoxNoti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTimeRemain;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdateNoti;
        private System.Windows.Forms.Button btnDeleteNoti;
        private System.Windows.Forms.Button btnAddNoti;
    }
}
