namespace StudentManagement.GUI.ScoreGUI
{
    partial class EnterStudentScore
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIdStd = new System.Windows.Forms.Label();
            this.lblNameStd = new System.Windows.Forms.Label();
            this.dataGVScore = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCourseSemester = new System.Windows.Forms.Label();
            this.dataGvAttendance = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAbsent = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGradeMid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGradeLast = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblGradeFinal = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblNoti = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvAttendance)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(373, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bảng Điểm Chi Tiết";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Sinh Viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(100, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ Tên:";
            // 
            // lblIdStd
            // 
            this.lblIdStd.AutoSize = true;
            this.lblIdStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdStd.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblIdStd.Location = new System.Drawing.Point(244, 130);
            this.lblIdStd.Name = "lblIdStd";
            this.lblIdStd.Size = new System.Drawing.Size(182, 29);
            this.lblIdStd.TabIndex = 1;
            this.lblIdStd.Text = "<Mã Sinh Viên>";
            // 
            // lblNameStd
            // 
            this.lblNameStd.AutoSize = true;
            this.lblNameStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameStd.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNameStd.Location = new System.Drawing.Point(244, 183);
            this.lblNameStd.Name = "lblNameStd";
            this.lblNameStd.Size = new System.Drawing.Size(121, 29);
            this.lblNameStd.TabIndex = 1;
            this.lblNameStd.Text = "<Họ Tên>";
            // 
            // dataGVScore
            // 
            this.dataGVScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVScore.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGVScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGVScore.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGVScore.Location = new System.Drawing.Point(46, 302);
            this.dataGVScore.Name = "dataGVScore";
            this.dataGVScore.RowHeadersVisible = false;
            this.dataGVScore.RowHeadersWidth = 62;
            this.dataGVScore.RowTemplate.Height = 28;
            this.dataGVScore.Size = new System.Drawing.Size(1014, 112);
            this.dataGVScore.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm bài tập tuần";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(752, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Môn học:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(767, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Học Kỳ:";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCourseName.Location = new System.Drawing.Point(878, 134);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(182, 29);
            this.lblCourseName.TabIndex = 1;
            this.lblCourseName.Text = "<Tên môn học>";
            // 
            // lblCourseSemester
            // 
            this.lblCourseSemester.AutoSize = true;
            this.lblCourseSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseSemester.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCourseSemester.Location = new System.Drawing.Point(878, 195);
            this.lblCourseSemester.Name = "lblCourseSemester";
            this.lblCourseSemester.Size = new System.Drawing.Size(74, 29);
            this.lblCourseSemester.TabIndex = 1;
            this.lblCourseSemester.Text = "<HK>";
            // 
            // dataGvAttendance
            // 
            this.dataGvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGvAttendance.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGvAttendance.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGvAttendance.Location = new System.Drawing.Point(46, 512);
            this.dataGvAttendance.Name = "dataGvAttendance";
            this.dataGvAttendance.RowHeadersVisible = false;
            this.dataGvAttendance.RowHeadersWidth = 62;
            this.dataGvAttendance.RowTemplate.Height = 28;
            this.dataGvAttendance.Size = new System.Drawing.Size(1014, 112);
            this.dataGvAttendance.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 467);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Điểm danh";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNoti);
            this.groupBox1.Controls.Add(this.txtGradeLast);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtGradeMid);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 702);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1014, 204);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập điểm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 655);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Vắng:";
            // 
            // lblAbsent
            // 
            this.lblAbsent.AutoSize = true;
            this.lblAbsent.Location = new System.Drawing.Point(120, 654);
            this.lblAbsent.Name = "lblAbsent";
            this.lblAbsent.Size = new System.Drawing.Size(27, 20);
            this.lblAbsent.TabIndex = 6;
            this.lblAbsent.Text = "<>";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(43, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Điểm Quá Trình";
            // 
            // txtGradeMid
            // 
            this.txtGradeMid.Location = new System.Drawing.Point(271, 49);
            this.txtGradeMid.Multiline = true;
            this.txtGradeMid.Name = "txtGradeMid";
            this.txtGradeMid.Size = new System.Drawing.Size(353, 51);
            this.txtGradeMid.TabIndex = 1;
            this.txtGradeMid.TextChanged += new System.EventHandler(this.txtGradeMid_TextChanged);
            this.txtGradeMid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGradeMid_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.IndianRed;
            this.label10.Location = new System.Drawing.Point(69, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "Điểm Cuối Kỳ";
            // 
            // txtGradeLast
            // 
            this.txtGradeLast.Location = new System.Drawing.Point(271, 127);
            this.txtGradeLast.Multiline = true;
            this.txtGradeLast.Name = "txtGradeLast";
            this.txtGradeLast.Size = new System.Drawing.Size(353, 51);
            this.txtGradeLast.TabIndex = 1;
            this.txtGradeLast.TextChanged += new System.EventHandler(this.txtGradeMid_TextChanged);
            this.txtGradeLast.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGradeMid_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkOrange;
            this.label11.Location = new System.Drawing.Point(47, 937);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 29);
            this.label11.TabIndex = 0;
            this.label11.Text = "Điểm Tổng Kết";
            // 
            // lblGradeFinal
            // 
            this.lblGradeFinal.AutoSize = true;
            this.lblGradeFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeFinal.ForeColor = System.Drawing.Color.Black;
            this.lblGradeFinal.Location = new System.Drawing.Point(262, 937);
            this.lblGradeFinal.Name = "lblGradeFinal";
            this.lblGradeFinal.Size = new System.Drawing.Size(175, 29);
            this.lblGradeFinal.TabIndex = 0;
            this.lblGradeFinal.Text = "Điểm Tổng Kết";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.Location = new System.Drawing.Point(757, 922);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 65);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblNoti
            // 
            this.lblNoti.AutoSize = true;
            this.lblNoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoti.ForeColor = System.Drawing.Color.Firebrick;
            this.lblNoti.Location = new System.Drawing.Point(653, 101);
            this.lblNoti.Name = "lblNoti";
            this.lblNoti.Size = new System.Drawing.Size(197, 20);
            this.lblNoti.TabIndex = 2;
            this.lblNoti.Text = "*Vui lòng nhập điểm hợp lệ";
            // 
            // EnterStudentScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1104, 1050);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblGradeFinal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblAbsent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGvAttendance);
            this.Controls.Add(this.dataGVScore);
            this.Controls.Add(this.lblCourseSemester);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblNameStd);
            this.Controls.Add(this.lblIdStd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EnterStudentScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnterStudentScore";
            this.Load += new System.EventHandler(this.EnterStudentScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvAttendance)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIdStd;
        private System.Windows.Forms.Label lblNameStd;
        private System.Windows.Forms.DataGridView dataGVScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCourseSemester;
        private System.Windows.Forms.DataGridView dataGvAttendance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAbsent;
        private System.Windows.Forms.TextBox txtGradeMid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGradeLast;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblGradeFinal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblNoti;
    }
}