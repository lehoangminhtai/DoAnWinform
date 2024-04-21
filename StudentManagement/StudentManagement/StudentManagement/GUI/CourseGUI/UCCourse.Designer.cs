namespace StudentManagement.GUI
{
    partial class UCCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCourse));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtCourseDescription = new System.Windows.Forms.TextBox();
            this.lblCourseFile = new System.Windows.Forms.LinkLabel();
            this.lblCourseTeacher = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblNumCreadit = new System.Windows.Forms.Label();
            this.lblCourseId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBaiTap = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnExcercise = new System.Windows.Forms.Button();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelBaiTap.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label);
            this.panel1.Location = new System.Drawing.Point(64, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1461, 78);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label.Location = new System.Drawing.Point(110, 28);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(142, 32);
            this.label.TabIndex = 2;
            this.label.Text = "Khoá học";
            // 
            // lblCourseName
            // 
            this.lblCourseName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCourseName.Location = new System.Drawing.Point(64, 139);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(247, 40);
            this.lblCourseName.TabIndex = 3;
            this.lblCourseName.Text = "Tên khoá học";
            this.lblCourseName.Click += new System.EventHandler(this.lblCourseName_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(239, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Mã khoá học:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.btnDeleteFile);
            this.groupBox1.Controls.Add(this.btnUpload);
            this.groupBox1.Controls.Add(this.txtCourseDescription);
            this.groupBox1.Controls.Add(this.lblCourseFile);
            this.groupBox1.Controls.Add(this.lblCourseTeacher);
            this.groupBox1.Controls.Add(this.lblYear);
            this.groupBox1.Controls.Add(this.lblSemester);
            this.groupBox1.Controls.Add(this.lblNumCreadit);
            this.groupBox1.Controls.Add(this.lblCourseId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(64, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1466, 366);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFile.Location = new System.Drawing.Point(381, 115);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(106, 36);
            this.btnDeleteFile.TabIndex = 8;
            this.btnDeleteFile.Text = "Xoá";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(251, 115);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(106, 36);
            this.btnUpload.TabIndex = 8;
            this.btnUpload.Text = "Tải lên";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtCourseDescription
            // 
            this.txtCourseDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCourseDescription.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCourseDescription.Enabled = false;
            this.txtCourseDescription.Location = new System.Drawing.Point(366, 244);
            this.txtCourseDescription.Multiline = true;
            this.txtCourseDescription.Name = "txtCourseDescription";
            this.txtCourseDescription.ReadOnly = true;
            this.txtCourseDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCourseDescription.Size = new System.Drawing.Size(1023, 101);
            this.txtCourseDescription.TabIndex = 7;
            // 
            // lblCourseFile
            // 
            this.lblCourseFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCourseFile.AutoSize = true;
            this.lblCourseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseFile.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblCourseFile.Location = new System.Drawing.Point(361, 81);
            this.lblCourseFile.Name = "lblCourseFile";
            this.lblCourseFile.Size = new System.Drawing.Size(80, 20);
            this.lblCourseFile.TabIndex = 6;
            this.lblCourseFile.TabStop = true;
            this.lblCourseFile.Text = "linkLabel1";
            this.lblCourseFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCourseFile_LinkClicked);
            // 
            // lblCourseTeacher
            // 
            this.lblCourseTeacher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCourseTeacher.AutoSize = true;
            this.lblCourseTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseTeacher.Location = new System.Drawing.Point(1332, 33);
            this.lblCourseTeacher.Name = "lblCourseTeacher";
            this.lblCourseTeacher.Size = new System.Drawing.Size(57, 20);
            this.lblCourseTeacher.TabIndex = 5;
            this.lblCourseTeacher.Text = "label7";
            // 
            // lblYear
            // 
            this.lblYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(1332, 191);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(57, 20);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "label7";
            // 
            // lblSemester
            // 
            this.lblSemester.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.Location = new System.Drawing.Point(362, 205);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(57, 20);
            this.lblSemester.TabIndex = 5;
            this.lblSemester.Text = "label7";
            // 
            // lblNumCreadit
            // 
            this.lblNumCreadit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumCreadit.AutoSize = true;
            this.lblNumCreadit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCreadit.Location = new System.Drawing.Point(362, 166);
            this.lblNumCreadit.Name = "lblNumCreadit";
            this.lblNumCreadit.Size = new System.Drawing.Size(57, 20);
            this.lblNumCreadit.TabIndex = 5;
            this.lblNumCreadit.Text = "label7";
            // 
            // lblCourseId
            // 
            this.lblCourseId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCourseId.AutoSize = true;
            this.lblCourseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseId.Location = new System.Drawing.Point(362, 47);
            this.lblCourseId.Name = "lblCourseId";
            this.lblCourseId.Size = new System.Drawing.Size(57, 20);
            this.lblCourseId.TabIndex = 5;
            this.lblCourseId.Text = "label7";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số tín chỉ:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1236, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giảng viên:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1239, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Năm học:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(259, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Giáo trình:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Học kỳ:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mô tả:";
            // 
            // panelBaiTap
            // 
            this.panelBaiTap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBaiTap.AutoSize = true;
            this.panelBaiTap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBaiTap.Controls.Add(this.panelContainer);
            this.panelBaiTap.Controls.Add(this.btnExcercise);
            this.panelBaiTap.Controls.Add(this.btnMaterial);
            this.panelBaiTap.Location = new System.Drawing.Point(64, 573);
            this.panelBaiTap.Name = "panelBaiTap";
            this.panelBaiTap.Size = new System.Drawing.Size(1469, 489);
            this.panelBaiTap.TabIndex = 8;
            this.panelBaiTap.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBaiTap_Paint);
            // 
            // panelContainer
            // 
            this.panelContainer.AutoSize = true;
            this.panelContainer.Location = new System.Drawing.Point(0, 110);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1464, 374);
            this.panelContainer.TabIndex = 1;
            // 
            // btnExcercise
            // 
            this.btnExcercise.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcercise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcercise.Image = global::StudentManagement.Properties.Resources.homework;
            this.btnExcercise.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcercise.Location = new System.Drawing.Point(1107, 10);
            this.btnExcercise.Name = "btnExcercise";
            this.btnExcercise.Size = new System.Drawing.Size(328, 96);
            this.btnExcercise.TabIndex = 0;
            this.btnExcercise.Text = "Bài Tập";
            this.btnExcercise.UseVisualStyleBackColor = false;
            this.btnExcercise.Click += new System.EventHandler(this.btnExcercise_Click);
            // 
            // btnMaterial
            // 
            this.btnMaterial.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterial.Image = ((System.Drawing.Image)(resources.GetObject("btnMaterial.Image")));
            this.btnMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterial.Location = new System.Drawing.Point(24, 10);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(328, 96);
            this.btnMaterial.TabIndex = 0;
            this.btnMaterial.Text = "Tài liệu";
            this.btnMaterial.UseVisualStyleBackColor = false;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // UCCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panelBaiTap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.panel1);
            this.Name = "UCCourse";
            this.Size = new System.Drawing.Size(1641, 1072);
            this.Load += new System.EventHandler(this.UCCourse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelBaiTap.ResumeLayout(false);
            this.panelBaiTap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelBaiTap;
        public System.Windows.Forms.Label lblCourseName;
        public System.Windows.Forms.Label lblCourseId;
        public System.Windows.Forms.LinkLabel lblCourseFile;
        public System.Windows.Forms.Label lblCourseTeacher;
        public System.Windows.Forms.Label lblYear;
        public System.Windows.Forms.Label lblSemester;
        public System.Windows.Forms.Label lblNumCreadit;
        public System.Windows.Forms.TextBox txtCourseDescription;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnExcercise;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Panel panelContainer;
    }
}
