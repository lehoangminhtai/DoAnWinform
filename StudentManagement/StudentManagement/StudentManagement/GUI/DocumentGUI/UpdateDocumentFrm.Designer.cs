namespace StudentManagement.GUI.DocumentGUI
{
    partial class UpdateDocumentFrm
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
            this.btnUpdateDoc = new System.Windows.Forms.Button();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.linklblFileName = new System.Windows.Forms.LinkLabel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNameDoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateDoc
            // 
            this.btnUpdateDoc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateDoc.BackgroundImage = global::StudentManagement.Properties.Resources.edit;
            this.btnUpdateDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateDoc.Location = new System.Drawing.Point(523, 640);
            this.btnUpdateDoc.Name = "btnUpdateDoc";
            this.btnUpdateDoc.Size = new System.Drawing.Size(133, 107);
            this.btnUpdateDoc.TabIndex = 16;
            this.btnUpdateDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateDoc.UseVisualStyleBackColor = false;
            this.btnUpdateDoc.Click += new System.EventHandler(this.btnUpdateDoc_Click);
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUploadFile.BackgroundImage = global::StudentManagement.Properties.Resources.folder;
            this.btnUploadFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUploadFile.Location = new System.Drawing.Point(343, 509);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(52, 42);
            this.btnUploadFile.TabIndex = 17;
            this.btnUploadFile.UseVisualStyleBackColor = false;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // linklblFileName
            // 
            this.linklblFileName.AutoSize = true;
            this.linklblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblFileName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linklblFileName.Location = new System.Drawing.Point(338, 463);
            this.linklblFileName.Name = "linklblFileName";
            this.linklblFileName.Size = new System.Drawing.Size(110, 29);
            this.linklblFileName.TabIndex = 15;
            this.linklblFileName.TabStop = true;
            this.linklblFileName.Text = "fileName";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(338, 264);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(571, 166);
            this.txtDescription.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(244, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(221, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mô tả";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(338, 568);
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(564, 54);
            this.txtUrl.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(75, 584);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Link video Youtube";
            // 
            // txtNameDoc
            // 
            this.txtNameDoc.Location = new System.Drawing.Point(338, 157);
            this.txtNameDoc.Multiline = true;
            this.txtNameDoc.Name = "txtNameDoc";
            this.txtNameDoc.Size = new System.Drawing.Size(564, 54);
            this.txtNameDoc.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(200, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Chủ đề";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentManagement.Properties.Resources.documents__1_;
            this.pictureBox1.Location = new System.Drawing.Point(57, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(415, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "CẬP NHẬT";
            // 
            // UpdateDocumentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(967, 772);
            this.Controls.Add(this.btnUpdateDoc);
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
            this.Name = "UpdateDocumentFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateDocumentFrm";
            this.Load += new System.EventHandler(this.UpdateDocumentFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateDoc;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.LinkLabel linklblFileName;
        public System.Windows.Forms.TextBox txtDescription;
        public System.Windows.Forms.TextBox txtUrl;
        public System.Windows.Forms.TextBox txtNameDoc;
    }
}