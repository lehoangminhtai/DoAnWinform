namespace StudentManagement.GUI
{
    partial class UClistCourseRegister
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
            this.dataGVlistcourse = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.lblSumCre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVlistcourse)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVlistcourse
            // 
            this.dataGVlistcourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVlistcourse.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGVlistcourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVlistcourse.Location = new System.Drawing.Point(62, 55);
            this.dataGVlistcourse.Name = "dataGVlistcourse";
            this.dataGVlistcourse.RowHeadersVisible = false;
            this.dataGVlistcourse.RowHeadersWidth = 62;
            this.dataGVlistcourse.RowTemplate.Height = 28;
            this.dataGVlistcourse.Size = new System.Drawing.Size(1036, 351);
            this.dataGVlistcourse.TabIndex = 0;
            this.dataGVlistcourse.Click += new System.EventHandler(this.dataGVlistcourse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng số tín chỉ:";
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteCourse.Location = new System.Drawing.Point(523, 489);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(189, 58);
            this.btnDeleteCourse.TabIndex = 2;
            this.btnDeleteCourse.Text = "Xoá học phần";
            this.btnDeleteCourse.UseVisualStyleBackColor = false;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // lblSumCre
            // 
            this.lblSumCre.AutoSize = true;
            this.lblSumCre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumCre.Location = new System.Drawing.Point(239, 428);
            this.lblSumCre.Name = "lblSumCre";
            this.lblSumCre.Size = new System.Drawing.Size(25, 26);
            this.lblSumCre.TabIndex = 1;
            this.lblSumCre.Text = "0";
            // 
            // UClistCourseRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnDeleteCourse);
            this.Controls.Add(this.lblSumCre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGVlistcourse);
            this.Name = "UClistCourseRegister";
            this.Size = new System.Drawing.Size(1153, 693);
            this.Load += new System.EventHandler(this.UClistCourseRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVlistcourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVlistcourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.Label lblSumCre;
    }
}
