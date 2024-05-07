namespace StudentManagement.GUI.LoginFaceGUI
{
    partial class RegisterFaceFrm
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
            this.label5 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblmsg = new System.Windows.Forms.Label();
            this.btnSaveFace = new System.Windows.Forms.Button();
            this.btnCamera = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTakePic = new System.Windows.Forms.Button();
            this.pictureBoxCaptured = new System.Windows.Forms.PictureBox();
            this.pictureBoxCamara = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptured)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamara)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(129, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(693, 53);
            this.label5.TabIndex = 12;
            this.label5.Text = "Đăng Ký Nhận Diện Khuôn Mặt";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(722, 442);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 25);
            this.lblName.TabIndex = 10;
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.Location = new System.Drawing.Point(357, 645);
            this.lblmsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 25);
            this.lblmsg.TabIndex = 9;
            // 
            // btnSaveFace
            // 
            this.btnSaveFace.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSaveFace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFace.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveFace.Location = new System.Drawing.Point(670, 530);
            this.btnSaveFace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveFace.Name = "btnSaveFace";
            this.btnSaveFace.Size = new System.Drawing.Size(178, 72);
            this.btnSaveFace.TabIndex = 6;
            this.btnSaveFace.Text = "Lưu Ảnh";
            this.btnSaveFace.UseVisualStyleBackColor = false;
            this.btnSaveFace.Click += new System.EventHandler(this.btnSaveFace_Click);
            // 
            // btnCamera
            // 
            this.btnCamera.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCamera.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnCamera.Location = new System.Drawing.Point(138, 530);
            this.btnCamera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(184, 72);
            this.btnCamera.TabIndex = 4;
            this.btnCamera.Text = "Mở Camera";
            this.btnCamera.UseVisualStyleBackColor = false;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(510, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ảnh Chụp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(33, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Camera";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblmsg);
            this.groupBox1.Controls.Add(this.btnTakePic);
            this.groupBox1.Controls.Add(this.btnSaveFace);
            this.groupBox1.Controls.Add(this.btnCamera);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBoxCaptured);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBoxCamara);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1002, 670);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // btnTakePic
            // 
            this.btnTakePic.BackColor = System.Drawing.Color.GreenYellow;
            this.btnTakePic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakePic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTakePic.Location = new System.Drawing.Point(399, 531);
            this.btnTakePic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTakePic.Name = "btnTakePic";
            this.btnTakePic.Size = new System.Drawing.Size(178, 72);
            this.btnTakePic.TabIndex = 6;
            this.btnTakePic.Text = "Chụp Ảnh";
            this.btnTakePic.UseVisualStyleBackColor = false;
            this.btnTakePic.Click += new System.EventHandler(this.btnTakePic_Click);
            // 
            // pictureBoxCaptured
            // 
            this.pictureBoxCaptured.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCaptured.Location = new System.Drawing.Point(513, 146);
            this.pictureBoxCaptured.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxCaptured.Name = "pictureBoxCaptured";
            this.pictureBoxCaptured.Size = new System.Drawing.Size(390, 277);
            this.pictureBoxCaptured.TabIndex = 2;
            this.pictureBoxCaptured.TabStop = false;
            // 
            // pictureBoxCamara
            // 
            this.pictureBoxCamara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCamara.Location = new System.Drawing.Point(33, 146);
            this.pictureBoxCamara.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxCamara.Name = "pictureBoxCamara";
            this.pictureBoxCamara.Size = new System.Drawing.Size(390, 277);
            this.pictureBoxCamara.TabIndex = 0;
            this.pictureBoxCamara.TabStop = false;
            this.pictureBoxCamara.BackgroundImageChanged += new System.EventHandler(this.pictureBoxCamara_BackgroundImageChanged);
            this.pictureBoxCamara.Click += new System.EventHandler(this.pictureBoxCamara_Click);
            // 
            // RegisterFaceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 670);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegisterFaceFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterFaceFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterFaceFrm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterFaceFrm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptured)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Button btnSaveFace;
        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxCaptured;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxCamara;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTakePic;
    }
}