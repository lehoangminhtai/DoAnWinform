namespace StudentManagement.GUI
{
    partial class AddCourseFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCourseFrm));
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.btnUploadCourseFile = new System.Windows.Forms.Button();
            this.txtYearL = new System.Windows.Forms.TextBox();
            this.txtYearF = new System.Windows.Forms.TextBox();
            this.txtCourseFile = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtNumCreadit = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdCourse = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Subheading", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(12, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(362, 35);
            this.label11.TabIndex = 21;
            this.label11.Text = "Trang quản lý - Thêm Khoá Học";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 51);
            this.panel1.TabIndex = 54;
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Items.AddRange(new object[] {
            "HK1",
            "HK2",
            "HK3"});
            this.comboBoxSemester.Location = new System.Drawing.Point(309, 506);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(248, 34);
            this.comboBoxSemester.TabIndex = 52;
            // 
            // btnUploadCourseFile
            // 
            this.btnUploadCourseFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUploadCourseFile.Location = new System.Drawing.Point(311, 444);
            this.btnUploadCourseFile.Name = "btnUploadCourseFile";
            this.btnUploadCourseFile.Size = new System.Drawing.Size(96, 43);
            this.btnUploadCourseFile.TabIndex = 51;
            this.btnUploadCourseFile.Text = "Tải lên";
            this.btnUploadCourseFile.UseVisualStyleBackColor = true;
            this.btnUploadCourseFile.Click += new System.EventHandler(this.btnUploadCourseFile_Click);
            // 
            // txtYearL
            // 
            this.txtYearL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtYearL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearL.Location = new System.Drawing.Point(472, 554);
            this.txtYearL.Multiline = true;
            this.txtYearL.Name = "txtYearL";
            this.txtYearL.Size = new System.Drawing.Size(86, 46);
            this.txtYearL.TabIndex = 49;
            // 
            // txtYearF
            // 
            this.txtYearF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtYearF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearF.Location = new System.Drawing.Point(310, 554);
            this.txtYearF.Multiline = true;
            this.txtYearF.Name = "txtYearF";
            this.txtYearF.Size = new System.Drawing.Size(86, 46);
            this.txtYearF.TabIndex = 47;
            this.txtYearF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYearF_KeyPress);
            // 
            // txtCourseFile
            // 
            this.txtCourseFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCourseFile.Enabled = false;
            this.txtCourseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseFile.Location = new System.Drawing.Point(310, 403);
            this.txtCourseFile.Name = "txtCourseFile";
            this.txtCourseFile.Size = new System.Drawing.Size(249, 26);
            this.txtCourseFile.TabIndex = 46;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(310, 325);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(248, 50);
            this.txtDescription.TabIndex = 45;
            // 
            // txtNumCreadit
            // 
            this.txtNumCreadit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumCreadit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCreadit.Location = new System.Drawing.Point(310, 259);
            this.txtNumCreadit.Multiline = true;
            this.txtNumCreadit.Name = "txtNumCreadit";
            this.txtNumCreadit.Size = new System.Drawing.Size(248, 50);
            this.txtNumCreadit.TabIndex = 44;
            this.txtNumCreadit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumCreadit_KeyPress);
            // 
            // txtCourseName
            // 
            this.txtCourseName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseName.Location = new System.Drawing.Point(310, 192);
            this.txtCourseName.Multiline = true;
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(248, 50);
            this.txtCourseName.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(424, 563);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 29);
            this.label9.TabIndex = 34;
            this.label9.Text = "-";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(167, 563);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 29);
            this.label8.TabIndex = 41;
            this.label8.Text = "Năm Học:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(192, 506);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 29);
            this.label7.TabIndex = 40;
            this.label7.Text = "Học Kỳ:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(152, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 29);
            this.label6.TabIndex = 39;
            this.label6.Text = "Giáo Trình:";
            // 
            // txtIdCourse
            // 
            this.txtIdCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIdCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCourse.Location = new System.Drawing.Point(311, 123);
            this.txtIdCourse.Multiline = true;
            this.txtIdCourse.Name = "txtIdCourse";
            this.txtIdCourse.Size = new System.Drawing.Size(248, 50);
            this.txtIdCourse.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(201, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 29);
            this.label10.TabIndex = 38;
            this.label10.Text = "Mô tả:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(201, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 29);
            this.label5.TabIndex = 37;
            this.label5.Text = "Số TC:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 29);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tên Môn Học:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 29);
            this.label4.TabIndex = 42;
            this.label4.Text = "Mã Môn Học:";
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddCourse.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCourse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCourse.BackgroundImage")));
            this.btnAddCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddCourse.Location = new System.Drawing.Point(368, 631);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(125, 75);
            this.btnAddCourse.TabIndex = 53;
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // AddCourseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(892, 716);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.btnUploadCourseFile);
            this.Controls.Add(this.txtYearL);
            this.Controls.Add(this.txtYearF);
            this.Controls.Add(this.txtCourseFile);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtNumCreadit);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdCourse);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "AddCourseFrm";
            this.Text = "AddCourseFrm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.Button btnUploadCourseFile;
        private System.Windows.Forms.TextBox txtYearL;
        private System.Windows.Forms.TextBox txtYearF;
        private System.Windows.Forms.TextBox txtCourseFile;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtNumCreadit;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdCourse;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}