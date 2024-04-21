namespace StudentManagement.GUI.SubmitHwGUI
{
    partial class AddSubmitHwFrm
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
            this.linklblFileName = new System.Windows.Forms.LinkLabel();
            this.btnSaveSubmit = new System.Windows.Forms.Button();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nộp Bài";
            // 
            // linklblFileName
            // 
            this.linklblFileName.AutoSize = true;
            this.linklblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblFileName.Location = new System.Drawing.Point(29, 244);
            this.linklblFileName.Name = "linklblFileName";
            this.linklblFileName.Size = new System.Drawing.Size(124, 29);
            this.linklblFileName.TabIndex = 2;
            this.linklblFileName.TabStop = true;
            this.linklblFileName.Text = "(Chọn file)";
            // 
            // btnSaveSubmit
            // 
            this.btnSaveSubmit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSaveSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveSubmit.Location = new System.Drawing.Point(89, 377);
            this.btnSaveSubmit.Name = "btnSaveSubmit";
            this.btnSaveSubmit.Size = new System.Drawing.Size(192, 65);
            this.btnSaveSubmit.TabIndex = 3;
            this.btnSaveSubmit.Text = "Lưu";
            this.btnSaveSubmit.UseVisualStyleBackColor = false;
            this.btnSaveSubmit.Click += new System.EventHandler(this.btnSaveSubmit_Click);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChooseFile.BackgroundImage = global::StudentManagement.Properties.Resources.file__1_;
            this.btnChooseFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChooseFile.Location = new System.Drawing.Point(240, 101);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(137, 88);
            this.btnChooseFile.TabIndex = 4;
            this.btnChooseFile.UseVisualStyleBackColor = false;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(392, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 65);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddSubmitHwFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(698, 514);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSaveSubmit);
            this.Controls.Add(this.linklblFileName);
            this.Controls.Add(this.label1);
            this.Name = "AddSubmitHwFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSubmitHwFrm";
            this.Load += new System.EventHandler(this.AddSubmitHwFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linklblFileName;
        private System.Windows.Forms.Button btnSaveSubmit;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Button button1;
    }
}