namespace StudentManagement.GUI.InformationGUI
{
    partial class LoginByFace
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
            this.btnLoginByFace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoginByFace
            // 
            this.btnLoginByFace.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLoginByFace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginByFace.Location = new System.Drawing.Point(106, 85);
            this.btnLoginByFace.Name = "btnLoginByFace";
            this.btnLoginByFace.Size = new System.Drawing.Size(450, 82);
            this.btnLoginByFace.TabIndex = 0;
            this.btnLoginByFace.Text = "Đăng Nhập Bằng Khuôn Mặt";
            this.btnLoginByFace.UseVisualStyleBackColor = false;
            this.btnLoginByFace.Click += new System.EventHandler(this.btnLoginByFace_Click);
            // 
            // LoginByFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(644, 284);
            this.Controls.Add(this.btnLoginByFace);
            this.Name = "LoginByFace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginByFace";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoginByFace;
    }
}