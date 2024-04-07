namespace StudentManagement.GUI
{
    partial class ADMINForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGVSVGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.quanLyHocTapDataSet2 = new StudentManagement.QuanLyHocTapDataSet2();
            this.hocSinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hocSinhTableAdapter = new StudentManagement.QuanLyHocTapDataSet2TableAdapters.HocSinhTableAdapter();
            this.maSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhAnhDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiThanHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiThanSDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTaoTKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangTKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVSVGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHocTapDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(120, 35);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1178, 664);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.dataGVSVGV);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1170, 621);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sinh Viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGVSVGV
            // 
            this.dataGVSVGV.AutoGenerateColumns = false;
            this.dataGVSVGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGVSVGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVSVGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSVDataGridViewTextBoxColumn,
            this.hoDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.cCCDDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.hinhAnhDataGridViewImageColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.khoaDataGridViewTextBoxColumn,
            this.nguoiThanHTDataGridViewTextBoxColumn,
            this.nguoiThanSDTDataGridViewTextBoxColumn,
            this.ngayTaoTKDataGridViewTextBoxColumn,
            this.tinhTrangTKDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGVSVGV.DataSource = this.hocSinhBindingSource;
            this.dataGVSVGV.Location = new System.Drawing.Point(52, 114);
            this.dataGVSVGV.Name = "dataGVSVGV";
            this.dataGVSVGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGVSVGV.RowHeadersWidth = 62;
            this.dataGVSVGV.RowTemplate.Height = 28;
            this.dataGVSVGV.Size = new System.Drawing.Size(1080, 406);
            this.dataGVSVGV.TabIndex = 2;
            this.dataGVSVGV.Click += new System.EventHandler(this.dataGVSVGV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 108);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH SINH VIÊN \r\n\r\n\r\n";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1170, 621);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Khoá Học";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1170, 621);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Điểm";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1170, 621);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Tài khoản";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 39);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1170, 621);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Xác thực";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 39);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1170, 621);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Diễn đàn";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 108);
            this.label2.TabIndex = 3;
            this.label2.Text = "DANH SÁCH GIẢNG VIÊN \r\n\r\n\r\n";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dataGridView1.Location = new System.Drawing.Point(55, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1079, 406);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "SDTNguoiThan";
            this.dataGridViewTextBoxColumn11.HeaderText = "SDTNguoiThan";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 218;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "HoTenNguoiThan";
            this.dataGridViewTextBoxColumn10.HeaderText = "HoTenNguoiThan";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 243;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1170, 621);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Giảng Viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // quanLyHocTapDataSet2
            // 
            this.quanLyHocTapDataSet2.DataSetName = "QuanLyHocTapDataSet2";
            this.quanLyHocTapDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hocSinhBindingSource
            // 
            this.hocSinhBindingSource.DataMember = "HocSinh";
            this.hocSinhBindingSource.DataSource = this.quanLyHocTapDataSet2;
            // 
            // hocSinhTableAdapter
            // 
            this.hocSinhTableAdapter.ClearBeforeFill = true;
            // 
            // maSVDataGridViewTextBoxColumn
            // 
            this.maSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV";
            this.maSVDataGridViewTextBoxColumn.HeaderText = "MaSV";
            this.maSVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maSVDataGridViewTextBoxColumn.Name = "maSVDataGridViewTextBoxColumn";
            this.maSVDataGridViewTextBoxColumn.Width = 113;
            // 
            // hoDataGridViewTextBoxColumn
            // 
            this.hoDataGridViewTextBoxColumn.DataPropertyName = "Ho";
            this.hoDataGridViewTextBoxColumn.HeaderText = "Ho";
            this.hoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hoDataGridViewTextBoxColumn.Name = "hoDataGridViewTextBoxColumn";
            this.hoDataGridViewTextBoxColumn.Width = 80;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Ten";
            this.tenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            this.tenDataGridViewTextBoxColumn.Width = 92;
            // 
            // cCCDDataGridViewTextBoxColumn
            // 
            this.cCCDDataGridViewTextBoxColumn.DataPropertyName = "CCCD";
            this.cCCDDataGridViewTextBoxColumn.HeaderText = "CCCD";
            this.cCCDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cCCDDataGridViewTextBoxColumn.Name = "cCCDDataGridViewTextBoxColumn";
            this.cCCDDataGridViewTextBoxColumn.Width = 117;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.Width = 153;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.Width = 98;
            // 
            // hinhAnhDataGridViewImageColumn
            // 
            this.hinhAnhDataGridViewImageColumn.DataPropertyName = "HinhAnh";
            this.hinhAnhDataGridViewImageColumn.HeaderText = "HinhAnh";
            this.hinhAnhDataGridViewImageColumn.MinimumWidth = 8;
            this.hinhAnhDataGridViewImageColumn.Name = "hinhAnhDataGridViewImageColumn";
            this.hinhAnhDataGridViewImageColumn.Width = 109;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.Width = 141;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.Width = 121;
            // 
            // khoaDataGridViewTextBoxColumn
            // 
            this.khoaDataGridViewTextBoxColumn.DataPropertyName = "Khoa";
            this.khoaDataGridViewTextBoxColumn.HeaderText = "Khoa";
            this.khoaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.khoaDataGridViewTextBoxColumn.Name = "khoaDataGridViewTextBoxColumn";
            this.khoaDataGridViewTextBoxColumn.Width = 105;
            // 
            // nguoiThanHTDataGridViewTextBoxColumn
            // 
            this.nguoiThanHTDataGridViewTextBoxColumn.DataPropertyName = "NguoiThanHT";
            this.nguoiThanHTDataGridViewTextBoxColumn.HeaderText = "NguoiThanHT";
            this.nguoiThanHTDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nguoiThanHTDataGridViewTextBoxColumn.Name = "nguoiThanHTDataGridViewTextBoxColumn";
            this.nguoiThanHTDataGridViewTextBoxColumn.Width = 202;
            // 
            // nguoiThanSDTDataGridViewTextBoxColumn
            // 
            this.nguoiThanSDTDataGridViewTextBoxColumn.DataPropertyName = "NguoiThanSDT";
            this.nguoiThanSDTDataGridViewTextBoxColumn.HeaderText = "NguoiThanSDT";
            this.nguoiThanSDTDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nguoiThanSDTDataGridViewTextBoxColumn.Name = "nguoiThanSDTDataGridViewTextBoxColumn";
            this.nguoiThanSDTDataGridViewTextBoxColumn.Width = 218;
            // 
            // ngayTaoTKDataGridViewTextBoxColumn
            // 
            this.ngayTaoTKDataGridViewTextBoxColumn.DataPropertyName = "NgayTaoTK";
            this.ngayTaoTKDataGridViewTextBoxColumn.HeaderText = "NgayTaoTK";
            this.ngayTaoTKDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ngayTaoTKDataGridViewTextBoxColumn.Name = "ngayTaoTKDataGridViewTextBoxColumn";
            this.ngayTaoTKDataGridViewTextBoxColumn.Width = 180;
            // 
            // tinhTrangTKDataGridViewTextBoxColumn
            // 
            this.tinhTrangTKDataGridViewTextBoxColumn.DataPropertyName = "TinhTrangTK";
            this.tinhTrangTKDataGridViewTextBoxColumn.HeaderText = "TinhTrangTK";
            this.tinhTrangTKDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tinhTrangTKDataGridViewTextBoxColumn.Name = "tinhTrangTKDataGridViewTextBoxColumn";
            this.tinhTrangTKDataGridViewTextBoxColumn.Width = 193;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 110;
            // 
            // ADMINForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1178, 664);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(1200, 706);
            this.Name = "ADMINForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Trang quản lý";
            this.Load += new System.EventHandler(this.ADMINForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVSVGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHocTapDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGVSVGV;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Label label2;
        private QuanLyHocTapDataSet2 quanLyHocTapDataSet2;
        private System.Windows.Forms.BindingSource hocSinhBindingSource;
        private QuanLyHocTapDataSet2TableAdapters.HocSinhTableAdapter hocSinhTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn hinhAnhDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiThanHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiThanSDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTaoTKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangTKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}