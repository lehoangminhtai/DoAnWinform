namespace StudentManagement.GUI.SubmitHwGUI
{
    partial class ListSubmitHwFrm
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
            this.dataGVlistHW = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbFilterStatus = new System.Windows.Forms.ComboBox();
            this.txtIDSTD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameSTD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linklblFileName = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.btnGrade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVlistHW)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVlistHW
            // 
            this.dataGVlistHW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVlistHW.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGVlistHW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVlistHW.Location = new System.Drawing.Point(33, 192);
            this.dataGVlistHW.Name = "dataGVlistHW";
            this.dataGVlistHW.RowHeadersVisible = false;
            this.dataGVlistHW.RowHeadersWidth = 62;
            this.dataGVlistHW.RowTemplate.Height = 28;
            this.dataGVlistHW.Size = new System.Drawing.Size(879, 386);
            this.dataGVlistHW.TabIndex = 0;
            this.dataGVlistHW.Click += new System.EventHandler(this.dataGVlistHW_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kết quả bài tập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 612);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lượng:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(154, 612);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(62, 29);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "num";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(33, 115);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(387, 52);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSearch.Location = new System.Drawing.Point(450, 115);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 51);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbFilterStatus
            // 
            this.cmbFilterStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterStatus.FormattingEnabled = true;
            this.cmbFilterStatus.Items.AddRange(new object[] {
            "Đã Chấm",
            "Chưa Chấm"});
            this.cmbFilterStatus.Location = new System.Drawing.Point(725, 130);
            this.cmbFilterStatus.Name = "cmbFilterStatus";
            this.cmbFilterStatus.Size = new System.Drawing.Size(187, 37);
            this.cmbFilterStatus.TabIndex = 5;
            this.cmbFilterStatus.SelectedIndexChanged += new System.EventHandler(this.cmbFilterStatus_SelectedIndexChanged);
            // 
            // txtIDSTD
            // 
            this.txtIDSTD.Enabled = false;
            this.txtIDSTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDSTD.Location = new System.Drawing.Point(927, 239);
            this.txtIDSTD.Multiline = true;
            this.txtIDSTD.Name = "txtIDSTD";
            this.txtIDSTD.Size = new System.Drawing.Size(352, 41);
            this.txtIDSTD.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(927, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Điểm";
            // 
            // txtNameSTD
            // 
            this.txtNameSTD.Enabled = false;
            this.txtNameSTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSTD.Location = new System.Drawing.Point(927, 352);
            this.txtNameSTD.Multiline = true;
            this.txtNameSTD.Name = "txtNameSTD";
            this.txtNameSTD.Size = new System.Drawing.Size(352, 41);
            this.txtNameSTD.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(927, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Họ Tên";
            // 
            // linklblFileName
            // 
            this.linklblFileName.AutoSize = true;
            this.linklblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblFileName.Location = new System.Drawing.Point(928, 419);
            this.linklblFileName.Name = "linklblFileName";
            this.linklblFileName.Size = new System.Drawing.Size(123, 29);
            this.linklblFileName.TabIndex = 8;
            this.linklblFileName.TabStop = true;
            this.linklblFileName.Text = "linkLabel1";
            this.linklblFileName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblFileName_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(927, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã SV";
            // 
            // txtGrade
            // 
            this.txtGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrade.Location = new System.Drawing.Point(1099, 472);
            this.txtGrade.Multiline = true;
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(180, 54);
            this.txtGrade.TabIndex = 6;
            this.txtGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGrade_KeyPress);
            // 
            // btnGrade
            // 
            this.btnGrade.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrade.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGrade.Location = new System.Drawing.Point(1034, 558);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(173, 57);
            this.btnGrade.TabIndex = 9;
            this.btnGrade.Text = "Chấm Điểm";
            this.btnGrade.UseVisualStyleBackColor = false;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // ListSubmitHwFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1306, 667);
            this.Controls.Add(this.btnGrade);
            this.Controls.Add(this.linklblFileName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtNameSTD);
            this.Controls.Add(this.txtIDSTD);
            this.Controls.Add(this.cmbFilterStatus);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGVlistHW);
            this.Name = "ListSubmitHwFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListSubmitHwFrm";
            this.Load += new System.EventHandler(this.ListSubmitHwFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVlistHW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVlistHW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbFilterStatus;
        private System.Windows.Forms.TextBox txtIDSTD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameSTD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linklblFileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Button btnGrade;
    }
}