namespace StudentManagement.GUI
{
    partial class CourseStudentListFrm
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
            this.dataGvStdListCourse = new System.Windows.Forms.DataGridView();
            this.btnDeleteStd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvStdListCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGvStdListCourse
            // 
            this.dataGvStdListCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGvStdListCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGvStdListCourse.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGvStdListCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGvStdListCourse.Location = new System.Drawing.Point(40, 149);
            this.dataGvStdListCourse.Name = "dataGvStdListCourse";
            this.dataGvStdListCourse.RowHeadersWidth = 62;
            this.dataGvStdListCourse.RowTemplate.Height = 28;
            this.dataGvStdListCourse.Size = new System.Drawing.Size(995, 377);
            this.dataGvStdListCourse.TabIndex = 0;
            this.dataGvStdListCourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGvStdListCourse.Click += new System.EventHandler(this.dataGvStdListCourse_Click);
            // 
            // btnDeleteStd
            // 
            this.btnDeleteStd.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStd.Location = new System.Drawing.Point(467, 557);
            this.btnDeleteStd.Name = "btnDeleteStd";
            this.btnDeleteStd.Size = new System.Drawing.Size(126, 60);
            this.btnDeleteStd.TabIndex = 1;
            this.btnDeleteStd.Text = "Xoá";
            this.btnDeleteStd.UseVisualStyleBackColor = false;
            this.btnDeleteStd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh Sách Sinh Viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Môn học:";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(153, 109);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(42, 25);
            this.lblCourseName.TabIndex = 4;
            this.lblCourseName.Text = ".....";
            // 
            // CourseStudentListFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1067, 660);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteStd);
            this.Controls.Add(this.dataGvStdListCourse);
            this.Name = "CourseStudentListFrm";
            this.Text = "CourseStudentListFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CourseStudentListFrm_FormClosing);
            this.Load += new System.EventHandler(this.CourseStudentListFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGvStdListCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGvStdListCourse;
        private System.Windows.Forms.Button btnDeleteStd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCourseName;
    }
}