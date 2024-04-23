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
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.btnSearchCourse = new System.Windows.Forms.Button();
            this.txtCourseSearch = new System.Windows.Forms.TextBox();
            this.radNameCourse = new System.Windows.Forms.RadioButton();
            this.radIdCourse = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCourseRegister = new System.Windows.Forms.Button();
            this.btnCourseList = new System.Windows.Forms.Button();
            this.panelCourse1 = new System.Windows.Forms.Panel();
            this.panelCourse2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.panelCourse2);
            this.panel1.Controls.Add(this.groupBoxSearch);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panelCourse1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 818);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelResCourse_Paint);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.AutoSize = true;
            this.groupBoxSearch.Controls.Add(this.btnSearchCourse);
            this.groupBoxSearch.Controls.Add(this.txtCourseSearch);
            this.groupBoxSearch.Controls.Add(this.radNameCourse);
            this.groupBoxSearch.Controls.Add(this.radIdCourse);
            this.groupBoxSearch.Location = new System.Drawing.Point(3, 85);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(1121, 102);
            this.groupBoxSearch.TabIndex = 2;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Tìm kiếm học phần";
            this.groupBoxSearch.Enter += new System.EventHandler(this.groupBoxSearch_Enter);
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
            // txtCourseSearch
            // 
            this.txtCourseSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseSearch.Location = new System.Drawing.Point(273, 25);
            this.txtCourseSearch.Multiline = true;
            this.txtCourseSearch.Name = "txtCourseSearch";
            this.txtCourseSearch.Size = new System.Drawing.Size(404, 52);
            this.txtCourseSearch.TabIndex = 1;
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
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnCourseRegister);
            this.panel3.Controls.Add(this.btnCourseList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1156, 73);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnCourseRegister
            // 
            this.btnCourseRegister.Location = new System.Drawing.Point(340, 12);
            this.btnCourseRegister.Name = "btnCourseRegister";
            this.btnCourseRegister.Size = new System.Drawing.Size(234, 56);
            this.btnCourseRegister.TabIndex = 0;
            this.btnCourseRegister.Text = "KH Đã Đăng Ký";
            this.btnCourseRegister.UseVisualStyleBackColor = true;
            this.btnCourseRegister.Click += new System.EventHandler(this.btnCourseRegister_Click);
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
            // panelCourse1
            // 
            this.panelCourse1.AutoScroll = true;
            this.panelCourse1.AutoSize = true;
            this.panelCourse1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCourse1.Location = new System.Drawing.Point(0, 818);
            this.panelCourse1.Name = "panelCourse1";
            this.panelCourse1.Size = new System.Drawing.Size(1156, 0);
            this.panelCourse1.TabIndex = 0;
            // 
            // panelCourse2
            // 
            this.panelCourse2.AutoSize = true;
            this.panelCourse2.Location = new System.Drawing.Point(3, 205);
            this.panelCourse2.Name = "panelCourse2";
            this.panelCourse2.Size = new System.Drawing.Size(1150, 610);
            this.panelCourse2.TabIndex = 3;
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
            this.Size = new System.Drawing.Size(1156, 818);
            this.Load += new System.EventHandler(this.UCRegisterCourse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelCourse2;
    }
}
