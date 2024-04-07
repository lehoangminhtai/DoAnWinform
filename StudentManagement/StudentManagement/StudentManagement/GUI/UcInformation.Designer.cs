namespace StudentManagement.GUI
{
    partial class UcInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcInformation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblsoDTNT = new System.Windows.Forms.Label();
            this.lblHoTenNT = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSoDTSv = new System.Windows.Forms.Label();
            this.lblDiaChiSV = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.lblNgayNhapHoc = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblHoTenSV = new System.Windows.Forms.Label();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnChangPass = new System.Windows.Forms.Button();
            this.picBoxAnhSV = new System.Windows.Forms.PictureBox();
            this.btnSetting = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAnhSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnSetting);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(49, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 50);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(75, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông tin cá nhân";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã sinh viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và tên: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số CCCD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 26);
            this.label6.TabIndex = 2;
            this.label6.Text = "Giới tính:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(71, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 26);
            this.label7.TabIndex = 2;
            this.label7.Text = "Email: ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblSoDTSv);
            this.groupBox1.Controls.Add(this.lblDiaChiSV);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox1.Location = new System.Drawing.Point(548, 367);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 251);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liên lạc";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GrayText;
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lblsoDTNT);
            this.groupBox3.Controls.Add(this.lblHoTenNT);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox3.Location = new System.Drawing.Point(16, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(491, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Người thân";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(6, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 26);
            this.label10.TabIndex = 2;
            this.label10.Text = "Họ và tên: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Location = new System.Drawing.Point(6, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 26);
            this.label11.TabIndex = 2;
            this.label11.Text = "Số ĐT: ";
            // 
            // lblsoDTNT
            // 
            this.lblsoDTNT.AutoSize = true;
            this.lblsoDTNT.Font = new System.Drawing.Font("Sitka Subheading", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsoDTNT.ForeColor = System.Drawing.SystemColors.Info;
            this.lblsoDTNT.Location = new System.Drawing.Point(116, 71);
            this.lblsoDTNT.Name = "lblsoDTNT";
            this.lblsoDTNT.Size = new System.Drawing.Size(61, 26);
            this.lblsoDTNT.TabIndex = 2;
            this.lblsoDTNT.Text = "Số ĐT";
            // 
            // lblHoTenNT
            // 
            this.lblHoTenNT.AutoSize = true;
            this.lblHoTenNT.Font = new System.Drawing.Font("Sitka Subheading", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTenNT.ForeColor = System.Drawing.SystemColors.Info;
            this.lblHoTenNT.Location = new System.Drawing.Point(116, 34);
            this.lblHoTenNT.Name = "lblHoTenNT";
            this.lblHoTenNT.Size = new System.Drawing.Size(71, 26);
            this.lblHoTenNT.TabIndex = 2;
            this.lblHoTenNT.Text = "Họ Tên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Brown;
            this.label9.Location = new System.Drawing.Point(16, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 26);
            this.label9.TabIndex = 2;
            this.label9.Text = "Số ĐT: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Brown;
            this.label8.Location = new System.Drawing.Point(16, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "Địa chỉ:";
            // 
            // lblSoDTSv
            // 
            this.lblSoDTSv.AutoSize = true;
            this.lblSoDTSv.Font = new System.Drawing.Font("Sitka Subheading", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDTSv.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblSoDTSv.Location = new System.Drawing.Point(114, 79);
            this.lblSoDTSv.Name = "lblSoDTSv";
            this.lblSoDTSv.Size = new System.Drawing.Size(61, 26);
            this.lblSoDTSv.TabIndex = 2;
            this.lblSoDTSv.Text = "Số ĐT";
            // 
            // lblDiaChiSV
            // 
            this.lblDiaChiSV.AutoSize = true;
            this.lblDiaChiSV.Font = new System.Drawing.Font("Sitka Subheading", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChiSV.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblDiaChiSV.Location = new System.Drawing.Point(114, 32);
            this.lblDiaChiSV.Name = "lblDiaChiSV";
            this.lblDiaChiSV.Size = new System.Drawing.Size(70, 26);
            this.lblDiaChiSV.TabIndex = 2;
            this.lblDiaChiSV.Text = "Địa chỉ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblTinhTrang);
            this.groupBox2.Controls.Add(this.lblNgayNhapHoc);
            this.groupBox2.Controls.Add(this.lblKhoa);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(76, 367);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 145);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đào Tạo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 26);
            this.label13.TabIndex = 2;
            this.label13.Text = "Tình trạng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 26);
            this.label12.TabIndex = 2;
            this.label12.Text = "Ngày nhập học: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Khoa:";
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTrang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTinhTrang.Location = new System.Drawing.Point(159, 106);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(102, 26);
            this.lblTinhTrang.TabIndex = 2;
            this.lblTinhTrang.Text = "Tình trạng";
            // 
            // lblNgayNhapHoc
            // 
            this.lblNgayNhapHoc.AutoSize = true;
            this.lblNgayNhapHoc.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhapHoc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNgayNhapHoc.Location = new System.Drawing.Point(159, 68);
            this.lblNgayNhapHoc.Name = "lblNgayNhapHoc";
            this.lblNgayNhapHoc.Size = new System.Drawing.Size(137, 26);
            this.lblNgayNhapHoc.TabIndex = 2;
            this.lblNgayNhapHoc.Text = "Ngày nhập học";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKhoa.Location = new System.Drawing.Point(159, 30);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(55, 26);
            this.lblKhoa.TabIndex = 2;
            this.lblKhoa.Text = "Khoa";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSV.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMaSV.Location = new System.Drawing.Point(230, 101);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(121, 26);
            this.lblMaSV.TabIndex = 2;
            this.lblMaSV.Text = "Mã sinh viên";
            // 
            // lblHoTenSV
            // 
            this.lblHoTenSV.AutoSize = true;
            this.lblHoTenSV.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTenSV.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHoTenSV.Location = new System.Drawing.Point(230, 153);
            this.lblHoTenSV.Name = "lblHoTenSV";
            this.lblHoTenSV.Size = new System.Drawing.Size(71, 26);
            this.lblHoTenSV.TabIndex = 2;
            this.lblHoTenSV.Text = "Họ Tên";
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCCD.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCCCD.Location = new System.Drawing.Point(230, 205);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(58, 26);
            this.lblCCCD.TabIndex = 2;
            this.lblCCCD.Text = "CCCD";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblGioiTinh.Location = new System.Drawing.Point(230, 257);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(89, 26);
            this.lblGioiTinh.TabIndex = 2;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEmail.Location = new System.Drawing.Point(230, 309);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(61, 26);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.label17_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Wheat;
            this.button1.Font = new System.Drawing.Font("Sitka Subheading", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Brown;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(282, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cập nhật thông tin";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChangPass
            // 
            this.btnChangPass.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnChangPass.Font = new System.Drawing.Font("Sitka Subheading", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangPass.ForeColor = System.Drawing.Color.Brown;
            this.btnChangPass.Image = ((System.Drawing.Image)(resources.GetObject("btnChangPass.Image")));
            this.btnChangPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangPass.Location = new System.Drawing.Point(76, 552);
            this.btnChangPass.Name = "btnChangPass";
            this.btnChangPass.Size = new System.Drawing.Size(158, 50);
            this.btnChangPass.TabIndex = 4;
            this.btnChangPass.Text = "Đổi mật khẩu";
            this.btnChangPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangPass.UseVisualStyleBackColor = false;
            // 
            // picBoxAnhSV
            // 
            this.picBoxAnhSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxAnhSV.Location = new System.Drawing.Point(744, 101);
            this.picBoxAnhSV.Name = "picBoxAnhSV";
            this.picBoxAnhSV.Size = new System.Drawing.Size(150, 182);
            this.picBoxAnhSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAnhSV.TabIndex = 3;
            this.picBoxAnhSV.TabStop = false;
            // 
            // btnSetting
            // 
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.Location = new System.Drawing.Point(972, 0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(51, 50);
            this.btnSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSetting.TabIndex = 3;
            this.btnSetting.TabStop = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // UcInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnChangPass);
            this.Controls.Add(this.picBoxAnhSV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblCCCD);
            this.Controls.Add(this.lblHoTenSV);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "UcInformation";
            this.Size = new System.Drawing.Size(1111, 669);
            this.Load += new System.EventHandler(this.UcInformation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAnhSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBoxAnhSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnChangPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.Label lblNgayNhapHoc;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblHoTenSV;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblsoDTNT;
        private System.Windows.Forms.Label lblHoTenNT;
        private System.Windows.Forms.Label lblSoDTSv;
        private System.Windows.Forms.Label lblDiaChiSV;
        private System.Windows.Forms.PictureBox btnSetting;
    }
}
