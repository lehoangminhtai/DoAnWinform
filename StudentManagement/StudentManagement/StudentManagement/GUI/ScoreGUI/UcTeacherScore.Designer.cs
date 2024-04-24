namespace StudentManagement.GUI.ScoreGUI
{
    partial class UcTeacherScore
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
            this.dataGVlistCourse = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVlistCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVlistCourse
            // 
            this.dataGVlistCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVlistCourse.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGVlistCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVlistCourse.Location = new System.Drawing.Point(92, 223);
            this.dataGVlistCourse.Name = "dataGVlistCourse";
            this.dataGVlistCourse.RowHeadersVisible = false;
            this.dataGVlistCourse.RowHeadersWidth = 62;
            this.dataGVlistCourse.RowTemplate.Height = 28;
            this.dataGVlistCourse.Size = new System.Drawing.Size(1254, 509);
            this.dataGVlistCourse.TabIndex = 0;
            this.dataGVlistCourse.DoubleClick += new System.EventHandler(this.dataGVlistCourse_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách Môn Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1059, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Năm học:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(1193, 171);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(92, 29);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "<Year>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Học Kỳ:";
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.Location = new System.Drawing.Point(211, 171);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(145, 29);
            this.lblSemester.TabIndex = 2;
            this.lblSemester.Text = "<Semester>";
            // 
            // UcTeacherScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGVlistCourse);
            this.Name = "UcTeacherScore";
            this.Size = new System.Drawing.Size(1461, 936);
            this.Load += new System.EventHandler(this.UcTeacherScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVlistCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVlistCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSemester;
    }
}
