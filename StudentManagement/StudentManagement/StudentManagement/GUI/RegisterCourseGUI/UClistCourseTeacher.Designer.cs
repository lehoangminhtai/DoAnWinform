namespace StudentManagement.GUI
{
    partial class UClistCourseTeacher
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
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCountCourse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVlistCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVlistCourse
            // 
            this.dataGVlistCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVlistCourse.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGVlistCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVlistCourse.Location = new System.Drawing.Point(75, 39);
            this.dataGVlistCourse.Name = "dataGVlistCourse";
            this.dataGVlistCourse.RowHeadersVisible = false;
            this.dataGVlistCourse.RowHeadersWidth = 62;
            this.dataGVlistCourse.RowTemplate.Height = 28;
            this.dataGVlistCourse.Size = new System.Drawing.Size(1032, 415);
            this.dataGVlistCourse.TabIndex = 0;
            this.dataGVlistCourse.Click += new System.EventHandler(this.dataGVlistCourse_Click);
            this.dataGVlistCourse.DoubleClick += new System.EventHandler(this.dataGVlistCourse_DoubleClick);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.Location = new System.Drawing.Point(220, 577);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(191, 81);
            this.btnAddCourse.TabIndex = 1;
            this.btnAddCourse.Text = "Thêm";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(513, 577);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(191, 81);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Sửa\r\n";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(816, 577);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(191, 81);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xoá ";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblCountCourse
            // 
            this.lblCountCourse.AutoSize = true;
            this.lblCountCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountCourse.Location = new System.Drawing.Point(233, 480);
            this.lblCountCourse.Name = "lblCountCourse";
            this.lblCountCourse.Size = new System.Drawing.Size(25, 26);
            this.lblCountCourse.TabIndex = 2;
            this.lblCountCourse.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tổng số môn:";
            // 
            // UClistCourseTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lblCountCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.dataGVlistCourse);
            this.Name = "UClistCourseTeacher";
            this.Size = new System.Drawing.Size(1153, 693);
            this.Load += new System.EventHandler(this.UClistCourseTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVlistCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVlistCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblCountCourse;
        private System.Windows.Forms.Label label1;
    }
}
