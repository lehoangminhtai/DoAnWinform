namespace StudentManagement.GUI
{
    partial class UpdateInfor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateInfor));
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxNT = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoDTNT = new System.Windows.Forms.TextBox();
            this.txtHoTenNT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoDTsv = new System.Windows.Forms.TextBox();
            this.txtDiaChiSV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateOfB = new System.Windows.Forms.DateTimePicker();
            this.lblFac = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.picBoxAnhSV = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxNT.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAnhSV)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 26);
            this.label10.TabIndex = 12;
            this.label10.Text = "Họ và tên: ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.groupBoxNT);
            this.groupBox1.Controls.Add(this.txtSoDTsv);
            this.groupBox1.Controls.Add(this.txtDiaChiSV);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(31, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 281);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liên lạc";
            // 
            // groupBoxNT
            // 
            this.groupBoxNT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxNT.Controls.Add(this.label1);
            this.groupBoxNT.Controls.Add(this.txtSoDTNT);
            this.groupBoxNT.Controls.Add(this.txtHoTenNT);
            this.groupBoxNT.Controls.Add(this.label3);
            this.groupBoxNT.Location = new System.Drawing.Point(16, 139);
            this.groupBoxNT.Name = "groupBoxNT";
            this.groupBoxNT.Size = new System.Drawing.Size(528, 121);
            this.groupBoxNT.TabIndex = 3;
            this.groupBoxNT.TabStop = false;
            this.groupBoxNT.Text = "Người thân";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Họ và tên: ";
            // 
            // txtSoDTNT
            // 
            this.txtSoDTNT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoDTNT.Location = new System.Drawing.Point(117, 75);
            this.txtSoDTNT.Multiline = true;
            this.txtSoDTNT.Name = "txtSoDTNT";
            this.txtSoDTNT.Size = new System.Drawing.Size(385, 31);
            this.txtSoDTNT.TabIndex = 21;
            this.txtSoDTNT.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtHoTenNT
            // 
            this.txtHoTenNT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHoTenNT.Location = new System.Drawing.Point(117, 34);
            this.txtHoTenNT.Multiline = true;
            this.txtHoTenNT.Name = "txtHoTenNT";
            this.txtHoTenNT.Size = new System.Drawing.Size(385, 26);
            this.txtHoTenNT.TabIndex = 21;
            this.txtHoTenNT.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số ĐT: ";
            // 
            // txtSoDTsv
            // 
            this.txtSoDTsv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoDTsv.Location = new System.Drawing.Point(99, 79);
            this.txtSoDTsv.Multiline = true;
            this.txtSoDTsv.Name = "txtSoDTsv";
            this.txtSoDTsv.Size = new System.Drawing.Size(385, 40);
            this.txtSoDTsv.TabIndex = 21;
            this.txtSoDTsv.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtDiaChiSV
            // 
            this.txtDiaChiSV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiaChiSV.Location = new System.Drawing.Point(99, 25);
            this.txtDiaChiSV.Multiline = true;
            this.txtDiaChiSV.Name = "txtDiaChiSV";
            this.txtDiaChiSV.Size = new System.Drawing.Size(385, 40);
            this.txtDiaChiSV.TabIndex = 21;
            this.txtDiaChiSV.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 26);
            this.label9.TabIndex = 2;
            this.label9.Text = "Số ĐT: ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa chỉ:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 51);
            this.panel1.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Subheading", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(12, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(316, 35);
            this.label8.TabIndex = 21;
            this.label8.Text = "Cập nhập thông tin cá nhân";
            // 
            // lblMa
            // 
            this.lblMa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMa.Location = new System.Drawing.Point(169, 91);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(121, 26);
            this.lblMa.TabIndex = 8;
            this.lblMa.Text = "Mã sinh viên";
            this.lblMa.Click += new System.EventHandler(this.label11_Click);
            // 
            // lblTen
            // 
            this.lblTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTen.Location = new System.Drawing.Point(169, 146);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(125, 26);
            this.lblTen.TabIndex = 8;
            this.lblTen.Text = "Tên sinh viên";
            this.lblTen.Click += new System.EventHandler(this.label11_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email: ";
            this.label5.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Location = new System.Drawing.Point(168, 201);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(385, 40);
            this.txtEmail.TabIndex = 21;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.radNu);
            this.groupBox2.Controls.Add(this.radNam);
            this.groupBox2.Location = new System.Drawing.Point(168, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 54);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            // 
            // radNu
            // 
            this.radNu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radNu.AutoSize = true;
            this.radNu.Enabled = false;
            this.radNu.Location = new System.Drawing.Point(231, 16);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(54, 24);
            this.radNu.TabIndex = 0;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radNam.AutoSize = true;
            this.radNam.Enabled = false;
            this.radNam.Location = new System.Drawing.Point(35, 16);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(67, 24);
            this.radNam.TabIndex = 0;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCCCD.Enabled = false;
            this.txtCCCD.Location = new System.Drawing.Point(168, 255);
            this.txtCCCD.Multiline = true;
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.ReadOnly = true;
            this.txtCCCD.Size = new System.Drawing.Size(385, 40);
            this.txtCCCD.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 26);
            this.label7.TabIndex = 40;
            this.label7.Text = "CCCD:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(36, 323);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 26);
            this.label11.TabIndex = 37;
            this.label11.Text = "Giới tính:";
            // 
            // dateOfB
            // 
            this.dateOfB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateOfB.Enabled = false;
            this.dateOfB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfB.Location = new System.Drawing.Point(168, 375);
            this.dateOfB.Name = "dateOfB";
            this.dateOfB.Size = new System.Drawing.Size(385, 35);
            this.dateOfB.TabIndex = 44;
            // 
            // lblFac
            // 
            this.lblFac.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFac.AutoSize = true;
            this.lblFac.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFac.Location = new System.Drawing.Point(614, 454);
            this.lblFac.Name = "lblFac";
            this.lblFac.Size = new System.Drawing.Size(55, 26);
            this.lblFac.TabIndex = 38;
            this.lblFac.Text = "Khoa";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(36, 375);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 26);
            this.label12.TabIndex = 39;
            this.label12.Text = "Ngày sinh:";
            // 
            // txtKhoa
            // 
            this.txtKhoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtKhoa.Enabled = false;
            this.txtKhoa.Location = new System.Drawing.Point(685, 450);
            this.txtKhoa.Multiline = true;
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.ReadOnly = true;
            this.txtKhoa.Size = new System.Drawing.Size(256, 40);
            this.txtKhoa.TabIndex = 41;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(815, 638);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 50);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(628, 629);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(164, 59);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Xác nhận";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUploadImage.BackColor = System.Drawing.Color.White;
            this.btnUploadImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUploadImage.BackgroundImage")));
            this.btnUploadImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUploadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImage.Image = ((System.Drawing.Image)(resources.GetObject("btnUploadImage.Image")));
            this.btnUploadImage.Location = new System.Drawing.Point(725, 288);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(150, 67);
            this.btnUploadImage.TabIndex = 18;
            this.btnUploadImage.UseVisualStyleBackColor = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // picBoxAnhSV
            // 
            this.picBoxAnhSV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picBoxAnhSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxAnhSV.Location = new System.Drawing.Point(725, 91);
            this.picBoxAnhSV.Name = "picBoxAnhSV";
            this.picBoxAnhSV.Size = new System.Drawing.Size(150, 182);
            this.picBoxAnhSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxAnhSV.TabIndex = 16;
            this.picBoxAnhSV.TabStop = false;
            // 
            // UpdateInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(965, 718);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtKhoa);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateOfB);
            this.Controls.Add(this.lblFac);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picBoxAnhSV);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Name = "UpdateInfor";
            this.Text = "Cập nhật thông tin";
            this.Load += new System.EventHandler(this.UpdateInfor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxNT.ResumeLayout(false);
            this.groupBoxNT.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAnhSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.RadioButton radNu;
        public System.Windows.Forms.RadioButton radNam;
        public System.Windows.Forms.TextBox txtCCCD;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.DateTimePicker dateOfB;
        public System.Windows.Forms.Label lblFac;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtKhoa;
        public System.Windows.Forms.PictureBox picBoxAnhSV;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBoxNT;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnUploadImage;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lblMa;
        public System.Windows.Forms.TextBox txtSoDTNT;
        public System.Windows.Forms.TextBox txtHoTenNT;
        public System.Windows.Forms.TextBox txtSoDTsv;
        public System.Windows.Forms.TextBox txtDiaChiSV;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Label lblTen;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtEmail;
    }
}