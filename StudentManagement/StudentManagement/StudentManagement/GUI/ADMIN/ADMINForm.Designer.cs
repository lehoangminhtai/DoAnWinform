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
            this.hocSinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyHocTapDataSet = new StudentManagement.QuanLyHocTapDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageGV = new System.Windows.Forms.TabPage();
            this.dataGvGV = new System.Windows.Forms.DataGridView();
            this.maGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCCDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhAnhDataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.gioiTinhDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTaoTKDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangTKDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giangVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giangVien = new StudentManagement.GiangVien();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGvCourse = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.hocSinhTableAdapter = new StudentManagement.QuanLyHocTapDataSetTableAdapters.HocSinhTableAdapter();
            this.giangVienTableAdapter = new StudentManagement.GiangVienTableAdapters.GiangVienTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVSVGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHocTapDataSet)).BeginInit();
            this.tabPageGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVien)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageGV);
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
            this.tabControl1.Size = new System.Drawing.Size(1178, 754);
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
            this.tabPage1.Size = new System.Drawing.Size(1170, 711);
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
            this.dataGVSVGV.Location = new System.Drawing.Point(49, 114);
            this.dataGVSVGV.Name = "dataGVSVGV";
            this.dataGVSVGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGVSVGV.RowHeadersWidth = 62;
            this.dataGVSVGV.RowTemplate.Height = 28;
            this.dataGVSVGV.Size = new System.Drawing.Size(1080, 406);
            this.dataGVSVGV.TabIndex = 2;
            this.dataGVSVGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVSVGV_CellContentClick);
            this.dataGVSVGV.Click += new System.EventHandler(this.dataGVSVGV_Click);
            this.dataGVSVGV.DoubleClick += new System.EventHandler(this.dataGVSVGV_DoubleClick);
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
            // hocSinhBindingSource
            // 
            this.hocSinhBindingSource.DataMember = "HocSinh";
            this.hocSinhBindingSource.DataSource = this.quanLyHocTapDataSet;
            // 
            // quanLyHocTapDataSet
            // 
            this.quanLyHocTapDataSet.DataSetName = "QuanLyHocTapDataSet";
            this.quanLyHocTapDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 108);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH SINH VIÊN \r\n\r\n\r\n";
            // 
            // tabPageGV
            // 
            this.tabPageGV.Controls.Add(this.dataGvGV);
            this.tabPageGV.Controls.Add(this.label2);
            this.tabPageGV.Location = new System.Drawing.Point(4, 39);
            this.tabPageGV.Name = "tabPageGV";
            this.tabPageGV.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGV.Size = new System.Drawing.Size(1170, 711);
            this.tabPageGV.TabIndex = 1;
            this.tabPageGV.Text = "Giảng Viên";
            this.tabPageGV.UseVisualStyleBackColor = true;
            this.tabPageGV.Click += new System.EventHandler(this.tabPageGV_Click);
            // 
            // dataGvGV
            // 
            this.dataGvGV.AutoGenerateColumns = false;
            this.dataGvGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGvGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGvGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maGVDataGridViewTextBoxColumn,
            this.hoDataGridViewTextBoxColumn1,
            this.tenDataGridViewTextBoxColumn1,
            this.cCCDDataGridViewTextBoxColumn1,
            this.ngaySinhDataGridViewTextBoxColumn1,
            this.sDTDataGridViewTextBoxColumn1,
            this.hinhAnhDataGridViewImageColumn1,
            this.gioiTinhDataGridViewTextBoxColumn1,
            this.diaChiDataGridViewTextBoxColumn1,
            this.ngayTaoTKDataGridViewTextBoxColumn1,
            this.tinhTrangTKDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn1});
            this.dataGvGV.DataSource = this.giangVienBindingSource;
            this.dataGvGV.Location = new System.Drawing.Point(52, 114);
            this.dataGvGV.Name = "dataGvGV";
            this.dataGvGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGvGV.RowHeadersWidth = 62;
            this.dataGvGV.RowTemplate.Height = 28;
            this.dataGvGV.Size = new System.Drawing.Size(1079, 406);
            this.dataGvGV.TabIndex = 4;
            this.dataGvGV.DoubleClick += new System.EventHandler(this.dataGvGV_DoubleClick);
            // 
            // maGVDataGridViewTextBoxColumn
            // 
            this.maGVDataGridViewTextBoxColumn.DataPropertyName = "MaGV";
            this.maGVDataGridViewTextBoxColumn.HeaderText = "MaGV";
            this.maGVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maGVDataGridViewTextBoxColumn.Name = "maGVDataGridViewTextBoxColumn";
            this.maGVDataGridViewTextBoxColumn.Width = 115;
            // 
            // hoDataGridViewTextBoxColumn1
            // 
            this.hoDataGridViewTextBoxColumn1.DataPropertyName = "Ho";
            this.hoDataGridViewTextBoxColumn1.HeaderText = "Ho";
            this.hoDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.hoDataGridViewTextBoxColumn1.Name = "hoDataGridViewTextBoxColumn1";
            this.hoDataGridViewTextBoxColumn1.Width = 80;
            // 
            // tenDataGridViewTextBoxColumn1
            // 
            this.tenDataGridViewTextBoxColumn1.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn1.HeaderText = "Ten";
            this.tenDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.tenDataGridViewTextBoxColumn1.Name = "tenDataGridViewTextBoxColumn1";
            this.tenDataGridViewTextBoxColumn1.Width = 92;
            // 
            // cCCDDataGridViewTextBoxColumn1
            // 
            this.cCCDDataGridViewTextBoxColumn1.DataPropertyName = "CCCD";
            this.cCCDDataGridViewTextBoxColumn1.HeaderText = "CCCD";
            this.cCCDDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.cCCDDataGridViewTextBoxColumn1.Name = "cCCDDataGridViewTextBoxColumn1";
            this.cCCDDataGridViewTextBoxColumn1.Width = 117;
            // 
            // ngaySinhDataGridViewTextBoxColumn1
            // 
            this.ngaySinhDataGridViewTextBoxColumn1.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn1.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.ngaySinhDataGridViewTextBoxColumn1.Name = "ngaySinhDataGridViewTextBoxColumn1";
            this.ngaySinhDataGridViewTextBoxColumn1.Width = 153;
            // 
            // sDTDataGridViewTextBoxColumn1
            // 
            this.sDTDataGridViewTextBoxColumn1.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn1.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.sDTDataGridViewTextBoxColumn1.Name = "sDTDataGridViewTextBoxColumn1";
            this.sDTDataGridViewTextBoxColumn1.Width = 98;
            // 
            // hinhAnhDataGridViewImageColumn1
            // 
            this.hinhAnhDataGridViewImageColumn1.DataPropertyName = "HinhAnh";
            this.hinhAnhDataGridViewImageColumn1.HeaderText = "HinhAnh";
            this.hinhAnhDataGridViewImageColumn1.MinimumWidth = 8;
            this.hinhAnhDataGridViewImageColumn1.Name = "hinhAnhDataGridViewImageColumn1";
            this.hinhAnhDataGridViewImageColumn1.Width = 109;
            // 
            // gioiTinhDataGridViewTextBoxColumn1
            // 
            this.gioiTinhDataGridViewTextBoxColumn1.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn1.HeaderText = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.gioiTinhDataGridViewTextBoxColumn1.Name = "gioiTinhDataGridViewTextBoxColumn1";
            this.gioiTinhDataGridViewTextBoxColumn1.Width = 141;
            // 
            // diaChiDataGridViewTextBoxColumn1
            // 
            this.diaChiDataGridViewTextBoxColumn1.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn1.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.diaChiDataGridViewTextBoxColumn1.Name = "diaChiDataGridViewTextBoxColumn1";
            this.diaChiDataGridViewTextBoxColumn1.Width = 121;
            // 
            // ngayTaoTKDataGridViewTextBoxColumn1
            // 
            this.ngayTaoTKDataGridViewTextBoxColumn1.DataPropertyName = "NgayTaoTK";
            this.ngayTaoTKDataGridViewTextBoxColumn1.HeaderText = "NgayTaoTK";
            this.ngayTaoTKDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.ngayTaoTKDataGridViewTextBoxColumn1.Name = "ngayTaoTKDataGridViewTextBoxColumn1";
            this.ngayTaoTKDataGridViewTextBoxColumn1.Width = 180;
            // 
            // tinhTrangTKDataGridViewTextBoxColumn1
            // 
            this.tinhTrangTKDataGridViewTextBoxColumn1.DataPropertyName = "TinhTrangTK";
            this.tinhTrangTKDataGridViewTextBoxColumn1.HeaderText = "TinhTrangTK";
            this.tinhTrangTKDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.tinhTrangTKDataGridViewTextBoxColumn1.Name = "tinhTrangTKDataGridViewTextBoxColumn1";
            this.tinhTrangTKDataGridViewTextBoxColumn1.Width = 193;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            this.emailDataGridViewTextBoxColumn1.Width = 110;
            // 
            // giangVienBindingSource
            // 
            this.giangVienBindingSource.DataMember = "GiangVien";
            this.giangVienBindingSource.DataSource = this.giangVien;
            // 
            // giangVien
            // 
            this.giangVien.DataSetName = "GiangVien";
            this.giangVien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 108);
            this.label2.TabIndex = 3;
            this.label2.Text = "DANH SÁCH GIẢNG VIÊN \r\n\r\n\r\n";
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.btnDeleteCourse);
            this.tabPage3.Controls.Add(this.btnAddCourse);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.dataGvCourse);
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1170, 711);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Khoá Học";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteCourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteCourse.Location = new System.Drawing.Point(682, 591);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(205, 50);
            this.btnDeleteCourse.TabIndex = 5;
            this.btnDeleteCourse.Text = "Xoá Khoá Học";
            this.btnDeleteCourse.UseVisualStyleBackColor = false;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAddCourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCourse.Location = new System.Drawing.Point(269, 591);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(205, 50);
            this.btnAddCourse.TabIndex = 5;
            this.btnAddCourse.Text = "Thêm Khoá Học";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 108);
            this.label3.TabIndex = 4;
            this.label3.Text = "DANH SÁCH GIẢNG VIÊN \r\n\r\n\r\n";
            // 
            // dataGvCourse
            // 
            this.dataGvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGvCourse.Location = new System.Drawing.Point(82, 126);
            this.dataGvCourse.Name = "dataGvCourse";
            this.dataGvCourse.RowHeadersWidth = 62;
            this.dataGvCourse.RowTemplate.Height = 28;
            this.dataGvCourse.Size = new System.Drawing.Size(1003, 414);
            this.dataGvCourse.TabIndex = 0;
            this.dataGvCourse.Click += new System.EventHandler(this.dataGvCourse_Click);
            this.dataGvCourse.DoubleClick += new System.EventHandler(this.dataGvCourse_DoubleClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1170, 711);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Điểm";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1170, 711);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Tài khoản";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 39);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1170, 711);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Xác thực";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 39);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1170, 711);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Diễn đàn";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // hocSinhTableAdapter
            // 
            this.hocSinhTableAdapter.ClearBeforeFill = true;
            // 
            // giangVienTableAdapter
            // 
            this.giangVienTableAdapter.ClearBeforeFill = true;
            // 
            // ADMINForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1178, 754);
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
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHocTapDataSet)).EndInit();
            this.tabPageGV.ResumeLayout(false);
            this.tabPageGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVien)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvCourse)).EndInit();
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
        private System.Windows.Forms.TabPage tabPageGV;
        private System.Windows.Forms.DataGridView dataGvGV;
        private System.Windows.Forms.Label label2;
        private QuanLyHocTapDataSet quanLyHocTapDataSet;
        private System.Windows.Forms.BindingSource hocSinhBindingSource;
        private QuanLyHocTapDataSetTableAdapters.HocSinhTableAdapter hocSinhTableAdapter;
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
        private GiangVien giangVien;
        private System.Windows.Forms.BindingSource giangVienBindingSource;
        private GiangVienTableAdapters.GiangVienTableAdapter giangVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCCDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn hinhAnhDataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTaoTKDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangTKDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGvCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteCourse;
    }
}