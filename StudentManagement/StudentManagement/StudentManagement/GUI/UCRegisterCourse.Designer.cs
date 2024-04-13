namespace StudentManagement.GUI
{
    partial class UCRegisterCourse
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCourse1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCourseList = new System.Windows.Forms.Button();
            this.btnCourseRegister = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.radIdCourse = new System.Windows.Forms.RadioButton();
            this.radNameCourse = new System.Windows.Forms.RadioButton();
            this.txtCourseSearch = new System.Windows.Forms.TextBox();
            this.btnSearchCourse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.groupBoxSearch);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panelCourse1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 793);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelResCourse_Paint);
            // 
            // panelCourse1
            // 
            this.panelCourse1.AutoScroll = true;
            this.panelCourse1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCourse1.Location = new System.Drawing.Point(0, 179);
            this.panelCourse1.Name = "panelCourse1";
            this.panelCourse1.Size = new System.Drawing.Size(1127, 644);
            this.panelCourse1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnCourseRegister);
            this.panel3.Controls.Add(this.btnCourseList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1127, 79);
            this.panel3.TabIndex = 1;
            // 
            // btnCourseList
            // 
            this.btnCourseList.Location = new System.Drawing.Point(34, 12);
            this.btnCourseList.Name = "btnCourseList";
            this.btnCourseList.Size = new System.Drawing.Size(234, 56);
            this.btnCourseList.TabIndex = 0;
            this.btnCourseList.Text = "DS Khoá Học";
            this.btnCourseList.UseVisualStyleBackColor = true;
            this.btnCourseList.Click += new System.EventHandler(this.btnCourseList_Click);
            // 
            // btnCourseRegister
            // 
            this.btnCourseRegister.Location = new System.Drawing.Point(342, 12);
            this.btnCourseRegister.Name = "btnCourseRegister";
            this.btnCourseRegister.Size = new System.Drawing.Size(234, 56);
            this.btnCourseRegister.TabIndex = 0;
            this.btnCourseRegister.Text = "KH Đã Đăng Ký";
            this.btnCourseRegister.UseVisualStyleBackColor = true;
            this.btnCourseRegister.Click += new System.EventHandler(this.btnCourseRegister_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.btnSearchCourse);
            this.groupBoxSearch.Controls.Add(this.txtCourseSearch);
            this.groupBoxSearch.Controls.Add(this.radNameCourse);
            this.groupBoxSearch.Controls.Add(this.radIdCourse);
            this.groupBoxSearch.Location = new System.Drawing.Point(3, 85);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(1121, 94);
            this.groupBoxSearch.TabIndex = 2;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Tìm kiếm học phần";
            // 
            // radIdCourse
            // 
            this.radIdCourse.AutoSize = true;
            this.radIdCourse.Location = new System.Drawing.Point(32, 41);
            this.radIdCourse.Name = "radIdCourse";
            this.radIdCourse.Size = new System.Drawing.Size(96, 24);
            this.radIdCourse.TabIndex = 0;
            this.radIdCourse.TabStop = true;
            this.radIdCourse.Text = "Theo mã";
            this.radIdCourse.UseVisualStyleBackColor = true;
            // 
            // radNameCourse
            // 
            this.radNameCourse.AutoSize = true;
            this.radNameCourse.Location = new System.Drawing.Point(170, 41);
            this.radNameCourse.Name = "radNameCourse";
            this.radNameCourse.Size = new System.Drawing.Size(97, 24);
            this.radNameCourse.TabIndex = 0;
            this.radNameCourse.TabStop = true;
            this.radNameCourse.Text = "Theo tên";
            this.radNameCourse.UseVisualStyleBackColor = true;
            // 
            // txtCourseSearch
            // 
            this.txtCourseSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseSearch.Location = new System.Drawing.Point(273, 25);
            this.txtCourseSearch.Multiline = true;
            this.txtCourseSearch.Name = "txtCourseSearch";
            this.txtCourseSearch.Size = new System.Drawing.Size(404, 52);
            this.txtCourseSearch.TabIndex = 1;
            // 
            // btnSearchCourse
            // 
            this.btnSearchCourse.Location = new System.Drawing.Point(701, 27);
            this.btnSearchCourse.Name = "btnSearchCourse";
            this.btnSearchCourse.Size = new System.Drawing.Size(159, 50);
            this.btnSearchCourse.TabIndex = 2;
            this.btnSearchCourse.Text = "Tìm kiếm";
            this.btnSearchCourse.UseVisualStyleBackColor = true;
            this.btnSearchCourse.Click += new System.EventHandler(this.btnSearchCourse_Click);
            // 
            // UCRegisterCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel1);
            this.Name = "UCRegisterCourse";
            this.Size = new System.Drawing.Size(1153, 793);
            this.Load += new System.EventHandler(this.UCRegisterCourse_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCourseRegister;
        private System.Windows.Forms.Button btnCourseList;
        private System.Windows.Forms.Panel panelCourse1;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.RadioButton radNameCourse;
        private System.Windows.Forms.RadioButton radIdCourse;
        private System.Windows.Forms.Button btnSearchCourse;
        private System.Windows.Forms.TextBox txtCourseSearch;
    }
}
