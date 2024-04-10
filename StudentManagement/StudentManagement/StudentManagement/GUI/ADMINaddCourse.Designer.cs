namespace StudentManagement.GUI
{
    partial class ADMINaddCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMINaddCourse));
            this.dataGvGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIdTeacher = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdCourse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumCreadit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCourseFile = new System.Windows.Forms.TextBox();
            this.btnUploadCourseFile = new System.Windows.Forms.Button();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtYearF = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtYearL = new System.Windows.Forms.TextBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGvGV
            // 
            this.dataGvGV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGvGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGvGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGvGV.Location = new System.Drawing.Point(494, 186);
            this.dataGvGV.Name = "dataGvGV";
            this.dataGvGV.RowHeadersWidth = 62;
            this.dataGvGV.RowTemplate.Height = 28;
            this.dataGvGV.Size = new System.Drawing.Size(730, 532);
            this.dataGvGV.TabIndex = 0;
            this.dataGvGV.Click += new System.EventHandler(this.dataGvGV_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(750, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH GIẢNG VIÊN";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã GV:";
            // 
            // lblIdTeacher
            // 
            this.lblIdTeacher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIdTeacher.AutoSize = true;
            this.lblIdTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTeacher.Location = new System.Drawing.Point(194, 190);
            this.lblIdTeacher.Name = "lblIdTeacher";
            this.lblIdTeacher.Size = new System.Drawing.Size(49, 29);
            this.lblIdTeacher.TabIndex = 2;
            this.lblIdTeacher.Text = "......";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã Môn Học:";
            // 
            // txtIdCourse
            // 
            this.txtIdCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIdCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCourse.Location = new System.Drawing.Point(193, 241);
            this.txtIdCourse.Multiline = true;
            this.txtIdCourse.Name = "txtIdCourse";
            this.txtIdCourse.Size = new System.Drawing.Size(248, 50);
            this.txtIdCourse.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Môn Học:";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseName.Location = new System.Drawing.Point(192, 310);
            this.txtCourseName.Multiline = true;
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(248, 50);
            this.txtCourseName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số TC:";
            // 
            // txtNumCreadit
            // 
            this.txtNumCreadit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumCreadit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCreadit.Location = new System.Drawing.Point(192, 377);
            this.txtNumCreadit.Multiline = true;
            this.txtNumCreadit.Name = "txtNumCreadit";
            this.txtNumCreadit.Size = new System.Drawing.Size(248, 50);
            this.txtNumCreadit.TabIndex = 3;
            this.txtNumCreadit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumCreadit_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 521);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Giáo Trình:";
            // 
            // txtCourseFile
            // 
            this.txtCourseFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCourseFile.Enabled = false;
            this.txtCourseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseFile.Location = new System.Drawing.Point(192, 521);
            this.txtCourseFile.Name = "txtCourseFile";
            this.txtCourseFile.Size = new System.Drawing.Size(249, 26);
            this.txtCourseFile.TabIndex = 3;
            // 
            // btnUploadCourseFile
            // 
            this.btnUploadCourseFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUploadCourseFile.Location = new System.Drawing.Point(193, 562);
            this.btnUploadCourseFile.Name = "btnUploadCourseFile";
            this.btnUploadCourseFile.Size = new System.Drawing.Size(96, 43);
            this.btnUploadCourseFile.TabIndex = 4;
            this.btnUploadCourseFile.Text = "Tải lên";
            this.btnUploadCourseFile.UseVisualStyleBackColor = true;
            this.btnUploadCourseFile.Click += new System.EventHandler(this.btnUploadCourseFile_Click);
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
            this.comboBoxSemester.Location = new System.Drawing.Point(191, 624);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(248, 34);
            this.comboBoxSemester.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 624);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Học Kỳ:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 681);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "Năm Học:";
            // 
            // txtYearF
            // 
            this.txtYearF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtYearF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearF.Location = new System.Drawing.Point(192, 672);
            this.txtYearF.Multiline = true;
            this.txtYearF.Name = "txtYearF";
            this.txtYearF.Size = new System.Drawing.Size(86, 46);
            this.txtYearF.TabIndex = 3;
            this.txtYearF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYearF_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(306, 681);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 29);
            this.label9.TabIndex = 2;
            this.label9.Text = "-";
            // 
            // txtYearL
            // 
            this.txtYearL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtYearL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearL.Location = new System.Drawing.Point(354, 672);
            this.txtYearL.Multiline = true;
            this.txtYearL.Name = "txtYearL";
            this.txtYearL.Size = new System.Drawing.Size(86, 46);
            this.txtYearL.TabIndex = 3;
            this.txtYearL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYearF_KeyPress);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddCourse.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCourse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCourse.BackgroundImage")));
            this.btnAddCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddCourse.Location = new System.Drawing.Point(575, 726);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(125, 75);
            this.btnAddCourse.TabIndex = 6;
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(83, 454);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 29);
            this.label10.TabIndex = 2;
            this.label10.Text = "Mô tả:";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(192, 443);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(248, 50);
            this.txtDescription.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1324, 51);
            this.panel1.TabIndex = 33;
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
            // ADMINaddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1324, 804);
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
            this.Controls.Add(this.lblIdTeacher);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGvGV);
            this.Name = "ADMINaddCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMINaddCourse";
            this.Load += new System.EventHandler(this.ADMINaddCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGvGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGvGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIdTeacher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumCreadit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCourseFile;
        private System.Windows.Forms.Button btnUploadCourseFile;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtYearF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtYearL;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDescription;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label11;
    }
}