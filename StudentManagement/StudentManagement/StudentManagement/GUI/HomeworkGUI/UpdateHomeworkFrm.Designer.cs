namespace StudentManagement.GUI.HomeworkGUI
{
    partial class UpdateHomeworkFrm
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
            this.dateTimeDeadline = new System.Windows.Forms.DateTimePicker();
            this.linklblFileName = new System.Windows.Forms.LinkLabel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameHW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateHomework = new System.Windows.Forms.Button();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimeDeadline
            // 
            this.dateTimeDeadline.CustomFormat = "dddd dd MMMM   yyyy    hh:mm:ss tt";
            this.dateTimeDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDeadline.Location = new System.Drawing.Point(317, 520);
            this.dateTimeDeadline.Name = "dateTimeDeadline";
            this.dateTimeDeadline.ShowUpDown = true;
            this.dateTimeDeadline.Size = new System.Drawing.Size(584, 37);
            this.dateTimeDeadline.TabIndex = 30;
            // 
            // linklblFileName
            // 
            this.linklblFileName.AutoSize = true;
            this.linklblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblFileName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linklblFileName.Location = new System.Drawing.Point(317, 385);
            this.linklblFileName.Name = "linklblFileName";
            this.linklblFileName.Size = new System.Drawing.Size(110, 29);
            this.linklblFileName.TabIndex = 27;
            this.linklblFileName.TabStop = true;
            this.linklblFileName.Text = "fileName";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(317, 190);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(571, 144);
            this.txtDescription.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(163, 520);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 32);
            this.label5.TabIndex = 21;
            this.label5.Text = "Hạn nộp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(223, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 32);
            this.label4.TabIndex = 22;
            this.label4.Text = "File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(160, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 32);
            this.label3.TabIndex = 23;
            this.label3.Text = "Yêu Cầu";
            // 
            // txtNameHW
            // 
            this.txtNameHW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameHW.Location = new System.Drawing.Point(317, 110);
            this.txtNameHW.Multiline = true;
            this.txtNameHW.Name = "txtNameHW";
            this.txtNameHW.Size = new System.Drawing.Size(571, 54);
            this.txtNameHW.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(221, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(394, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "CHỈNH SỬA BÀI TẬP";
            // 
            // btnUpdateHomework
            // 
            this.btnUpdateHomework.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateHomework.BackgroundImage = global::StudentManagement.Properties.Resources.edit;
            this.btnUpdateHomework.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateHomework.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateHomework.Location = new System.Drawing.Point(482, 604);
            this.btnUpdateHomework.Name = "btnUpdateHomework";
            this.btnUpdateHomework.Size = new System.Drawing.Size(133, 107);
            this.btnUpdateHomework.TabIndex = 28;
            this.btnUpdateHomework.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateHomework.UseVisualStyleBackColor = false;
            this.btnUpdateHomework.Click += new System.EventHandler(this.btnUpdateHomework_Click);
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUploadFile.BackgroundImage = global::StudentManagement.Properties.Resources.folder;
            this.btnUploadFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUploadFile.Location = new System.Drawing.Point(317, 431);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(52, 42);
            this.btnUploadFile.TabIndex = 29;
            this.btnUploadFile.UseVisualStyleBackColor = false;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentManagement.Properties.Resources.documents__1_;
            this.pictureBox1.Location = new System.Drawing.Point(36, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteFile.Location = new System.Drawing.Point(401, 431);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(94, 41);
            this.btnDeleteFile.TabIndex = 31;
            this.btnDeleteFile.Text = "Xoá file";
            this.btnDeleteFile.UseVisualStyleBackColor = false;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // UpdateHomeworkFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(937, 796);
            this.Controls.Add(this.btnDeleteFile);
            this.Controls.Add(this.dateTimeDeadline);
            this.Controls.Add(this.btnUpdateHomework);
            this.Controls.Add(this.btnUploadFile);
            this.Controls.Add(this.linklblFileName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameHW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "UpdateHomeworkFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateHomeworkFrm";
            this.Load += new System.EventHandler(this.UpdateHomeworkFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeDeadline;
        private System.Windows.Forms.Button btnUpdateHomework;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.LinkLabel linklblFileName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameHW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteFile;
    }
}