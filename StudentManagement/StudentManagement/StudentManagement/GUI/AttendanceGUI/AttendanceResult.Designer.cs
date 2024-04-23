namespace StudentManagement.GUI.AttendanceGUI
{
    partial class AttendanceResult
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
            this.dataGVResult = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCountAttend = new System.Windows.Forms.Label();
            this.lblCountAbsent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVResult
            // 
            this.dataGVResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVResult.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGVResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVResult.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGVResult.Location = new System.Drawing.Point(37, 144);
            this.dataGVResult.Name = "dataGVResult";
            this.dataGVResult.RowHeadersVisible = false;
            this.dataGVResult.RowHeadersWidth = 62;
            this.dataGVResult.RowTemplate.Height = 28;
            this.dataGVResult.Size = new System.Drawing.Size(781, 346);
            this.dataGVResult.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(317, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Điểm Danh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(108, 104);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(80, 26);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "<date>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Lượng SV:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(187, 512);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(91, 26);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "<count>";
            this.lblCount.Click += new System.EventHandler(this.lblCount_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(638, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Vắng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(346, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Đi học:";
            // 
            // lblCountAttend
            // 
            this.lblCountAttend.AutoSize = true;
            this.lblCountAttend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountAttend.Location = new System.Drawing.Point(434, 512);
            this.lblCountAttend.Name = "lblCountAttend";
            this.lblCountAttend.Size = new System.Drawing.Size(91, 26);
            this.lblCountAttend.TabIndex = 2;
            this.lblCountAttend.Text = "<count>";
            this.lblCountAttend.Click += new System.EventHandler(this.lblCount_Click);
            // 
            // lblCountAbsent
            // 
            this.lblCountAbsent.AutoSize = true;
            this.lblCountAbsent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountAbsent.Location = new System.Drawing.Point(727, 512);
            this.lblCountAbsent.Name = "lblCountAbsent";
            this.lblCountAbsent.Size = new System.Drawing.Size(91, 26);
            this.lblCountAbsent.TabIndex = 2;
            this.lblCountAbsent.Text = "<count>";
            this.lblCountAbsent.Click += new System.EventHandler(this.lblCount_Click);
            // 
            // AttendanceResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(852, 666);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCountAbsent);
            this.Controls.Add(this.lblCountAttend);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGVResult);
            this.Name = "AttendanceResult";
            this.Text = "AttendanceResult";
            this.Load += new System.EventHandler(this.AttendanceResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCountAttend;
        private System.Windows.Forms.Label lblCountAbsent;
    }
}