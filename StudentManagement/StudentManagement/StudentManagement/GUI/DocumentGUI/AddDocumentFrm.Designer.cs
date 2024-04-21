namespace StudentManagement.GUI.Document
{
    partial class AddDocumentFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameDoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linklblFileName = new System.Windows.Forms.LinkLabel();
            this.btnAddDoc = new System.Windows.Forms.Button();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(370, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM TÀI LIỆU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(155, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chủ đề";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNameDoc
            // 
            this.txtNameDoc.Location = new System.Drawing.Point(293, 144);
            this.txtNameDoc.Multiline = true;
            this.txtNameDoc.Name = "txtNameDoc";
            this.txtNameDoc.Size = new System.Drawing.Size(564, 54);
            this.txtNameDoc.TabIndex = 3;
            this.txtNameDoc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(176, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mô tả";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(293, 251);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(571, 166);
            this.txtDescription.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(199, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "File";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // linklblFileName
            // 
            this.linklblFileName.AutoSize = true;
            this.linklblFileName.Enabled = false;
            this.linklblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblFileName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linklblFileName.Location = new System.Drawing.Point(293, 450);
            this.linklblFileName.Name = "linklblFileName";
            this.linklblFileName.Size = new System.Drawing.Size(125, 29);
            this.linklblFileName.TabIndex = 4;
            this.linklblFileName.TabStop = true;
            this.linklblFileName.Text = "Tải file lên";
            this.linklblFileName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnAddDoc
            // 
            this.btnAddDoc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddDoc.BackgroundImage = global::StudentManagement.Properties.Resources.add_file;
            this.btnAddDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDoc.Location = new System.Drawing.Point(478, 627);
            this.btnAddDoc.Name = "btnAddDoc";
            this.btnAddDoc.Size = new System.Drawing.Size(133, 107);
            this.btnAddDoc.TabIndex = 5;
            this.btnAddDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDoc.UseVisualStyleBackColor = false;
            this.btnAddDoc.Click += new System.EventHandler(this.btnAddDoc_Click);
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUploadFile.BackgroundImage = global::StudentManagement.Properties.Resources.folder;
            this.btnUploadFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUploadFile.Location = new System.Drawing.Point(298, 496);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(52, 42);
            this.btnUploadFile.TabIndex = 5;
            this.btnUploadFile.UseVisualStyleBackColor = false;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentManagement.Properties.Resources.documents__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(30, 571);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "Link video Youtube";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(293, 555);
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(564, 54);
            this.txtUrl.TabIndex = 3;
            this.txtUrl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteFile.Location = new System.Drawing.Point(377, 497);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(94, 41);
            this.btnDeleteFile.TabIndex = 19;
            this.btnDeleteFile.Text = "Xoá file";
            this.btnDeleteFile.UseVisualStyleBackColor = false;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // AddDocumentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(967, 772);
            this.Controls.Add(this.btnDeleteFile);
            this.Controls.Add(this.btnAddDoc);
            this.Controls.Add(this.btnUploadFile);
            this.Controls.Add(this.linklblFileName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNameDoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "AddDocumentFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDocumentFrm";
            this.Load += new System.EventHandler(this.AddDocumentFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linklblFileName;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.Button btnAddDoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnDeleteFile;
    }
}