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
            this.hocSinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyHocTapDataSet = new StudentManagement.QuanLyHocTapDataSet();
            this.giangVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giangVien = new StudentManagement.GiangVien();
            this.hocSinhTableAdapter = new StudentManagement.QuanLyHocTapDataSetTableAdapters.HocSinhTableAdapter();
            this.giangVienTableAdapter = new StudentManagement.GiangVienTableAdapters.GiangVienTableAdapter();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnLockAccount = new System.Windows.Forms.Button();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.btbUnlockAccount = new System.Windows.Forms.Button();
            this.dataGvAccount = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGvCourse = new System.Windows.Forms.DataGridView();
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
            this.label2 = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dataGvWait = new System.Windows.Forms.DataGridView();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnTakeAcc = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHocTapDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVien)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvAccount)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvCourse)).BeginInit();
            this.tabPageGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvGV)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVSVGV)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvWait)).BeginInit();
            this.SuspendLayout();
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
            // hocSinhTableAdapter
            // 
            this.hocSinhTableAdapter.ClearBeforeFill = true;
            // 
            // giangVienTableAdapter
            // 
            this.giangVienTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.lblName);
            this.tabPage6.Controls.Add(this.btnDelete);
            this.tabPage6.Controls.Add(this.btnTakeAcc);
            this.tabPage6.Controls.Add(this.cmbUser);
            this.tabPage6.Controls.Add(this.dataGvWait);
            this.tabPage6.Controls.Add(this.label5);
            this.tabPage6.Location = new System.Drawing.Point(4, 39);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1830, 899);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Xác thực";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(859, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 51);
            this.label5.TabIndex = 6;
            this.label5.Text = "CẤP TÀI KHOẢN";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnLockAccount);
            this.tabPage5.Controls.Add(this.btnResetPass);
            this.tabPage5.Controls.Add(this.btbUnlockAccount);
            this.tabPage5.Controls.Add(this.dataGvAccount);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Location = new System.Drawing.Point(4, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1830, 899);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Tài khoản";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnLockAccount
            // 
            this.btnLockAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLockAccount.BackColor = System.Drawing.Color.IndianRed;
            this.btnLockAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLockAccount.Location = new System.Drawing.Point(1251, 841);
            this.btnLockAccount.Name = "btnLockAccount";
            this.btnLockAccount.Size = new System.Drawing.Size(290, 50);
            this.btnLockAccount.TabIndex = 7;
            this.btnLockAccount.Text = "Khoá Tài Khoản";
            this.btnLockAccount.UseVisualStyleBackColor = false;
            this.btnLockAccount.Click += new System.EventHandler(this.btnLockAccount_Click);
            // 
            // btnResetPass
            // 
            this.btnResetPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnResetPass.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnResetPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResetPass.Location = new System.Drawing.Point(407, 841);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(312, 50);
            this.btnResetPass.TabIndex = 8;
            this.btnResetPass.Text = "Đặt Lại Mật Khẩu";
            this.btnResetPass.UseVisualStyleBackColor = false;
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // btbUnlockAccount
            // 
            this.btbUnlockAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btbUnlockAccount.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btbUnlockAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btbUnlockAccount.Location = new System.Drawing.Point(793, 841);
            this.btbUnlockAccount.Name = "btbUnlockAccount";
            this.btbUnlockAccount.Size = new System.Drawing.Size(312, 50);
            this.btbUnlockAccount.TabIndex = 8;
            this.btbUnlockAccount.Text = "Mở Khoá Tài Khoản";
            this.btbUnlockAccount.UseVisualStyleBackColor = false;
            this.btbUnlockAccount.Click += new System.EventHandler(this.btbUnlockAccount_Click);
            // 
            // dataGvAccount
            // 
            this.dataGvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGvAccount.Location = new System.Drawing.Point(8, 83);
            this.dataGvAccount.Name = "dataGvAccount";
            this.dataGvAccount.RowHeadersWidth = 62;
            this.dataGvAccount.RowTemplate.Height = 28;
            this.dataGvAccount.Size = new System.Drawing.Size(1814, 735);
            this.dataGvAccount.TabIndex = 6;
            this.dataGvAccount.Click += new System.EventHandler(this.dataGvAccount_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(859, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 51);
            this.label4.TabIndex = 5;
            this.label4.Text = "TÀI KHOẢN";
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
            this.tabPage3.Size = new System.Drawing.Size(1830, 899);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Khoá Học";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteCourse.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteCourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteCourse.Location = new System.Drawing.Point(1026, 820);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(205, 50);
            this.btnDeleteCourse.TabIndex = 5;
            this.btnDeleteCourse.Text = "Xoá Khoá Học";
            this.btnDeleteCourse.UseVisualStyleBackColor = false;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddCourse.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAddCourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCourse.Location = new System.Drawing.Point(554, 822);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(205, 50);
            this.btnAddCourse.TabIndex = 5;
            this.btnAddCourse.Text = "Thêm Khoá Học";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(729, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 51);
            this.label3.TabIndex = 4;
            this.label3.Text = "DANH SÁCH KHOÁ HỌC";
            // 
            // dataGvCourse
            // 
            this.dataGvCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGvCourse.Location = new System.Drawing.Point(8, 83);
            this.dataGvCourse.Name = "dataGvCourse";
            this.dataGvCourse.RowHeadersWidth = 62;
            this.dataGvCourse.RowTemplate.Height = 28;
            this.dataGvCourse.Size = new System.Drawing.Size(1814, 735);
            this.dataGvCourse.TabIndex = 0;
            this.dataGvCourse.Click += new System.EventHandler(this.dataGvCourse_Click);
            this.dataGvCourse.DoubleClick += new System.EventHandler(this.dataGvCourse_DoubleClick);
            // 
            // tabPageGV
            // 
            this.tabPageGV.Controls.Add(this.dataGvGV);
            this.tabPageGV.Controls.Add(this.label2);
            this.tabPageGV.Location = new System.Drawing.Point(4, 39);
            this.tabPageGV.Name = "tabPageGV";
            this.tabPageGV.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGV.Size = new System.Drawing.Size(1830, 899);
            this.tabPageGV.TabIndex = 1;
            this.tabPageGV.Text = "Giảng Viên";
            this.tabPageGV.UseVisualStyleBackColor = true;
            this.tabPageGV.Click += new System.EventHandler(this.tabPageGV_Click);
            // 
            // dataGvGV
            // 
            this.dataGvGV.AutoGenerateColumns = false;
            this.dataGvGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dataGvGV.Location = new System.Drawing.Point(8, 83);
            this.dataGvGV.Name = "dataGvGV";
            this.dataGvGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGvGV.RowHeadersWidth = 62;
            this.dataGvGV.RowTemplate.Height = 28;
            this.dataGvGV.Size = new System.Drawing.Size(1814, 735);
            this.dataGvGV.TabIndex = 4;
            this.dataGvGV.DoubleClick += new System.EventHandler(this.dataGvGV_DoubleClick);
            // 
            // maGVDataGridViewTextBoxColumn
            // 
            this.maGVDataGridViewTextBoxColumn.DataPropertyName = "MaGV";
            this.maGVDataGridViewTextBoxColumn.HeaderText = "Mã Giảng Viên";
            this.maGVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maGVDataGridViewTextBoxColumn.Name = "maGVDataGridViewTextBoxColumn";
            // 
            // hoDataGridViewTextBoxColumn1
            // 
            this.hoDataGridViewTextBoxColumn1.DataPropertyName = "Ho";
            this.hoDataGridViewTextBoxColumn1.HeaderText = "Họ";
            this.hoDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.hoDataGridViewTextBoxColumn1.Name = "hoDataGridViewTextBoxColumn1";
            // 
            // tenDataGridViewTextBoxColumn1
            // 
            this.tenDataGridViewTextBoxColumn1.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn1.HeaderText = "Tên";
            this.tenDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.tenDataGridViewTextBoxColumn1.Name = "tenDataGridViewTextBoxColumn1";
            // 
            // cCCDDataGridViewTextBoxColumn1
            // 
            this.cCCDDataGridViewTextBoxColumn1.DataPropertyName = "CCCD";
            this.cCCDDataGridViewTextBoxColumn1.HeaderText = "Số CCCD";
            this.cCCDDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.cCCDDataGridViewTextBoxColumn1.Name = "cCCDDataGridViewTextBoxColumn1";
            // 
            // ngaySinhDataGridViewTextBoxColumn1
            // 
            this.ngaySinhDataGridViewTextBoxColumn1.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn1.HeaderText = "Ngày Sinh";
            this.ngaySinhDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.ngaySinhDataGridViewTextBoxColumn1.Name = "ngaySinhDataGridViewTextBoxColumn1";
            // 
            // sDTDataGridViewTextBoxColumn1
            // 
            this.sDTDataGridViewTextBoxColumn1.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn1.HeaderText = "Số Điện Thoại";
            this.sDTDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.sDTDataGridViewTextBoxColumn1.Name = "sDTDataGridViewTextBoxColumn1";
            // 
            // hinhAnhDataGridViewImageColumn1
            // 
            this.hinhAnhDataGridViewImageColumn1.DataPropertyName = "HinhAnh";
            this.hinhAnhDataGridViewImageColumn1.HeaderText = "Hình Ảnh";
            this.hinhAnhDataGridViewImageColumn1.MinimumWidth = 8;
            this.hinhAnhDataGridViewImageColumn1.Name = "hinhAnhDataGridViewImageColumn1";
            // 
            // gioiTinhDataGridViewTextBoxColumn1
            // 
            this.gioiTinhDataGridViewTextBoxColumn1.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn1.HeaderText = "Giới Tính";
            this.gioiTinhDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.gioiTinhDataGridViewTextBoxColumn1.Name = "gioiTinhDataGridViewTextBoxColumn1";
            // 
            // diaChiDataGridViewTextBoxColumn1
            // 
            this.diaChiDataGridViewTextBoxColumn1.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn1.HeaderText = "Địa Chỉ";
            this.diaChiDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.diaChiDataGridViewTextBoxColumn1.Name = "diaChiDataGridViewTextBoxColumn1";
            // 
            // ngayTaoTKDataGridViewTextBoxColumn1
            // 
            this.ngayTaoTKDataGridViewTextBoxColumn1.DataPropertyName = "NgayTaoTK";
            this.ngayTaoTKDataGridViewTextBoxColumn1.HeaderText = "Ngày Tạo Tài Khoản";
            this.ngayTaoTKDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.ngayTaoTKDataGridViewTextBoxColumn1.Name = "ngayTaoTKDataGridViewTextBoxColumn1";
            // 
            // tinhTrangTKDataGridViewTextBoxColumn1
            // 
            this.tinhTrangTKDataGridViewTextBoxColumn1.DataPropertyName = "TinhTrangTK";
            this.tinhTrangTKDataGridViewTextBoxColumn1.HeaderText = "Tình Trạng Tài Khoản";
            this.tinhTrangTKDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.tinhTrangTKDataGridViewTextBoxColumn1.Name = "tinhTrangTKDataGridViewTextBoxColumn1";
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(729, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 63);
            this.label2.TabIndex = 3;
            this.label2.Text = "DANH SÁCH GIẢNG VIÊN \r\n\r\n\r\n";
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.dataGVSVGV);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1830, 899);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sinh Viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGVSVGV
            // 
            this.dataGVSVGV.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.dataGVSVGV.Location = new System.Drawing.Point(8, 83);
            this.dataGVSVGV.Name = "dataGVSVGV";
            this.dataGVSVGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGVSVGV.RowHeadersWidth = 62;
            this.dataGVSVGV.RowTemplate.Height = 28;
            this.dataGVSVGV.Size = new System.Drawing.Size(1814, 735);
            this.dataGVSVGV.TabIndex = 2;
            this.dataGVSVGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVSVGV_CellContentClick);
            this.dataGVSVGV.Click += new System.EventHandler(this.dataGVSVGV_Click);
            this.dataGVSVGV.DoubleClick += new System.EventHandler(this.dataGVSVGV_DoubleClick);
            // 
            // maSVDataGridViewTextBoxColumn
            // 
            this.maSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV";
            this.maSVDataGridViewTextBoxColumn.HeaderText = "Mã Sinh Viên";
            this.maSVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maSVDataGridViewTextBoxColumn.Name = "maSVDataGridViewTextBoxColumn";
            this.maSVDataGridViewTextBoxColumn.Width = 174;
            // 
            // hoDataGridViewTextBoxColumn
            // 
            this.hoDataGridViewTextBoxColumn.DataPropertyName = "Ho";
            this.hoDataGridViewTextBoxColumn.HeaderText = "Họ";
            this.hoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hoDataGridViewTextBoxColumn.Name = "hoDataGridViewTextBoxColumn";
            this.hoDataGridViewTextBoxColumn.Width = 80;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.tenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            this.tenDataGridViewTextBoxColumn.Width = 92;
            // 
            // cCCDDataGridViewTextBoxColumn
            // 
            this.cCCDDataGridViewTextBoxColumn.DataPropertyName = "CCCD";
            this.cCCDDataGridViewTextBoxColumn.HeaderText = "Số CCCD";
            this.cCCDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cCCDDataGridViewTextBoxColumn.Name = "cCCDDataGridViewTextBoxColumn";
            this.cCCDDataGridViewTextBoxColumn.Width = 141;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày Sinh";
            this.ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.Width = 146;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "Số Điện Thoại";
            this.sDTDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.Width = 186;
            // 
            // hinhAnhDataGridViewImageColumn
            // 
            this.hinhAnhDataGridViewImageColumn.DataPropertyName = "HinhAnh";
            this.hinhAnhDataGridViewImageColumn.HeaderText = "Hình Ảnh";
            this.hinhAnhDataGridViewImageColumn.MinimumWidth = 8;
            this.hinhAnhDataGridViewImageColumn.Name = "hinhAnhDataGridViewImageColumn";
            this.hinhAnhDataGridViewImageColumn.Width = 104;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "Giới Tính";
            this.gioiTinhDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.Width = 135;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.Width = 85;
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
            this.nguoiThanHTDataGridViewTextBoxColumn.HeaderText = "Họ Tên Người Thân";
            this.nguoiThanHTDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nguoiThanHTDataGridViewTextBoxColumn.Name = "nguoiThanHTDataGridViewTextBoxColumn";
            this.nguoiThanHTDataGridViewTextBoxColumn.Width = 189;
            // 
            // nguoiThanSDTDataGridViewTextBoxColumn
            // 
            this.nguoiThanSDTDataGridViewTextBoxColumn.DataPropertyName = "NguoiThanSDT";
            this.nguoiThanSDTDataGridViewTextBoxColumn.HeaderText = "Số ĐT Người Thân";
            this.nguoiThanSDTDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nguoiThanSDTDataGridViewTextBoxColumn.Name = "nguoiThanSDTDataGridViewTextBoxColumn";
            this.nguoiThanSDTDataGridViewTextBoxColumn.Width = 179;
            // 
            // ngayTaoTKDataGridViewTextBoxColumn
            // 
            this.ngayTaoTKDataGridViewTextBoxColumn.DataPropertyName = "NgayTaoTK";
            this.ngayTaoTKDataGridViewTextBoxColumn.HeaderText = "Ngày Tạo Tài Khoản";
            this.ngayTaoTKDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ngayTaoTKDataGridViewTextBoxColumn.Name = "ngayTaoTKDataGridViewTextBoxColumn";
            this.ngayTaoTKDataGridViewTextBoxColumn.Width = 184;
            // 
            // tinhTrangTKDataGridViewTextBoxColumn
            // 
            this.tinhTrangTKDataGridViewTextBoxColumn.DataPropertyName = "TinhTrangTK";
            this.tinhTrangTKDataGridViewTextBoxColumn.HeaderText = "Tình Trạng Tài Khoản";
            this.tinhTrangTKDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tinhTrangTKDataGridViewTextBoxColumn.Name = "tinhTrangTKDataGridViewTextBoxColumn";
            this.tinhTrangTKDataGridViewTextBoxColumn.Width = 196;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 110;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(729, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH SINH VIÊN \r\n\r\n\r\n";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageGV);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(120, 35);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1838, 942);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // dataGvWait
            // 
            this.dataGvWait.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGvWait.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGvWait.Location = new System.Drawing.Point(10, 156);
            this.dataGvWait.Name = "dataGvWait";
            this.dataGvWait.RowHeadersWidth = 62;
            this.dataGvWait.RowTemplate.Height = 28;
            this.dataGvWait.Size = new System.Drawing.Size(1814, 637);
            this.dataGvWait.TabIndex = 7;
            this.dataGvWait.Click += new System.EventHandler(this.dataGvWait_Click);
            // 
            // cmbUser
            // 
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Items.AddRange(new object[] {
            "Học Sinh",
            "Giảng Viên"});
            this.cmbUser.Location = new System.Drawing.Point(833, 83);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(322, 37);
            this.cmbUser.TabIndex = 8;
            this.cmbUser.SelectedIndexChanged += new System.EventHandler(this.cmbUser_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(1083, 824);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(290, 50);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xoá Tài Khoản";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnTakeAcc
            // 
            this.btnTakeAcc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTakeAcc.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnTakeAcc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTakeAcc.Location = new System.Drawing.Point(625, 824);
            this.btnTakeAcc.Name = "btnTakeAcc";
            this.btnTakeAcc.Size = new System.Drawing.Size(312, 50);
            this.btnTakeAcc.TabIndex = 10;
            this.btnTakeAcc.Text = "Cấp Tài Khoản";
            this.btnTakeAcc.UseVisualStyleBackColor = false;
            this.btnTakeAcc.Click += new System.EventHandler(this.btnTakeAcc_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 806);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 29);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "<>";
            // 
            // ADMINForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1838, 942);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(1200, 706);
            this.Name = "ADMINForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Trang quản lý";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ADMINForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHocTapDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVien)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGvAccount)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGvCourse)).EndInit();
            this.tabPageGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGvGV)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVSVGV)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGvWait)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private QuanLyHocTapDataSet quanLyHocTapDataSet;
        private System.Windows.Forms.BindingSource hocSinhBindingSource;
        private QuanLyHocTapDataSetTableAdapters.HocSinhTableAdapter hocSinhTableAdapter;
        private GiangVien giangVien;
        private System.Windows.Forms.BindingSource giangVienBindingSource;
        private GiangVienTableAdapters.GiangVienTableAdapter giangVienTableAdapter;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGvCourse;
        private System.Windows.Forms.TabPage tabPageGV;
        private System.Windows.Forms.DataGridView dataGvGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGVSVGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnLockAccount;
        private System.Windows.Forms.Button btbUnlockAccount;
        private System.Windows.Forms.DataGridView dataGvAccount;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnResetPass;
        private System.Windows.Forms.DataGridView dataGvWait;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnTakeAcc;
        private System.Windows.Forms.Label lblName;
    }
}