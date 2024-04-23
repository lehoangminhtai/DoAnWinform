namespace StudentManagement.GUI.HomeworkGUI
{
    partial class SubmitHomeworkFrm
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
            this.lblHomeworkName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOpenDlDate = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSubmitStatus = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSubmitTime = new System.Windows.Forms.Label();
            this.lblTimeRemain = new System.Windows.Forms.Label();
            this.lbllinkFileName = new System.Windows.Forms.LinkLabel();
            this.lblGrade = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDeleteSubmit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(283, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nộp Bài Tập";
            // 
            // lblHomeworkName
            // 
            this.lblHomeworkName.AutoSize = true;
            this.lblHomeworkName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeworkName.Location = new System.Drawing.Point(41, 111);
            this.lblHomeworkName.Name = "lblHomeworkName";
            this.lblHomeworkName.Size = new System.Drawing.Size(119, 32);
            this.lblHomeworkName.TabIndex = 1;
            this.lblHomeworkName.Text = "Bài tập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày mở:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày đóng:";
            // 
            // lblOpenDlDate
            // 
            this.lblOpenDlDate.AutoSize = true;
            this.lblOpenDlDate.Location = new System.Drawing.Point(148, 167);
            this.lblOpenDlDate.Name = "lblOpenDlDate";
            this.lblOpenDlDate.Size = new System.Drawing.Size(51, 20);
            this.lblOpenDlDate.TabIndex = 3;
            this.lblOpenDlDate.Text = "label3";
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Location = new System.Drawing.Point(148, 202);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(51, 20);
            this.lblDeadline.TabIndex = 3;
            this.lblDeadline.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trạng thái bài nộp:";
            // 
            // lblSubmitStatus
            // 
            this.lblSubmitStatus.AutoSize = true;
            this.lblSubmitStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmitStatus.ForeColor = System.Drawing.Color.IndianRed;
            this.lblSubmitStatus.Location = new System.Drawing.Point(247, 39);
            this.lblSubmitStatus.Name = "lblSubmitStatus";
            this.lblSubmitStatus.Size = new System.Drawing.Size(106, 25);
            this.lblSubmitStatus.TabIndex = 5;
            this.lblSubmitStatus.Text = "Chưa nộp";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(299, 582);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(198, 74);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Nộp bài";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSubmitTime);
            this.groupBox1.Controls.Add(this.lblTimeRemain);
            this.groupBox1.Controls.Add(this.lbllinkFileName);
            this.groupBox1.Controls.Add(this.lblGrade);
            this.groupBox1.Controls.Add(this.lblSubmitStatus);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(47, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 279);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bài nộp";
            // 
            // lblSubmitTime
            // 
            this.lblSubmitTime.AutoSize = true;
            this.lblSubmitTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmitTime.Location = new System.Drawing.Point(252, 238);
            this.lblSubmitTime.Name = "lblSubmitTime";
            this.lblSubmitTime.Size = new System.Drawing.Size(68, 22);
            this.lblSubmitTime.TabIndex = 7;
            this.lblSubmitTime.Text = "label10";
            // 
            // lblTimeRemain
            // 
            this.lblTimeRemain.AutoSize = true;
            this.lblTimeRemain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeRemain.Location = new System.Drawing.Point(252, 186);
            this.lblTimeRemain.Name = "lblTimeRemain";
            this.lblTimeRemain.Size = new System.Drawing.Size(68, 22);
            this.lblTimeRemain.TabIndex = 7;
            this.lblTimeRemain.Text = "label10";
            // 
            // lbllinkFileName
            // 
            this.lbllinkFileName.AutoSize = true;
            this.lbllinkFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllinkFileName.Location = new System.Drawing.Point(247, 137);
            this.lbllinkFileName.Name = "lbllinkFileName";
            this.lbllinkFileName.Size = new System.Drawing.Size(100, 25);
            this.lbllinkFileName.TabIndex = 6;
            this.lbllinkFileName.TabStop = true;
            this.lbllinkFileName.Text = "linkLabel1";
            this.lbllinkFileName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllinkFileName_LinkClicked);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.ForeColor = System.Drawing.Color.IndianRed;
            this.lblGrade.Location = new System.Drawing.Point(247, 88);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(122, 25);
            this.lblGrade.TabIndex = 5;
            this.lblGrade.Text = "Chưa chấm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(107, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Bài nộp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Điểm số:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Lần cuối chỉnh sửa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Thời gian còn lại:";
            // 
            // btnDeleteSubmit
            // 
            this.btnDeleteSubmit.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteSubmit.Location = new System.Drawing.Point(588, 582);
            this.btnDeleteSubmit.Name = "btnDeleteSubmit";
            this.btnDeleteSubmit.Size = new System.Drawing.Size(198, 74);
            this.btnDeleteSubmit.TabIndex = 6;
            this.btnDeleteSubmit.Text = "Bỏ Bài Nộp";
            this.btnDeleteSubmit.UseVisualStyleBackColor = false;
            this.btnDeleteSubmit.Click += new System.EventHandler(this.btnDeleteSubmit_Click);
            // 
            // SubmitHomeworkFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(858, 668);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteSubmit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.lblOpenDlDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblHomeworkName);
            this.Controls.Add(this.label1);
            this.Name = "SubmitHomeworkFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubmitHomeworkFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubmitHomeworkFrm_FormClosing);
            this.Load += new System.EventHandler(this.SubmitHomeworkFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHomeworkName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOpenDlDate;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSubmitStatus;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteSubmit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lbllinkFileName;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSubmitTime;
        private System.Windows.Forms.Label lblTimeRemain;
    }
}