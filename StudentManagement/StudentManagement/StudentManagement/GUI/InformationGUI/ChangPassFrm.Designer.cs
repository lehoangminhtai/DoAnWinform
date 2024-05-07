namespace StudentManagement.GUI.InformationGUI
{
    partial class ChangPassFrm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCurrentPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtComfrmPass = new System.Windows.Forms.TextBox();
            this.btnShowCrrPss = new System.Windows.Forms.Button();
            this.btnShowNwPss = new System.Windows.Forms.Button();
            this.btnShowCfrPss = new System.Windows.Forms.Button();
            this.btnUpdatePass = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(273, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu hiện tại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhập lại mật khẩu mới";
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.Location = new System.Drawing.Point(280, 97);
            this.txtCurrentPass.Multiline = true;
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.PasswordChar = '*';
            this.txtCurrentPass.Size = new System.Drawing.Size(356, 45);
            this.txtCurrentPass.TabIndex = 2;
            this.txtCurrentPass.TextChanged += new System.EventHandler(this.txtCurrentPass_TextChanged);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(280, 166);
            this.txtNewPass.Multiline = true;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(356, 45);
            this.txtNewPass.TabIndex = 2;
            this.txtNewPass.TextChanged += new System.EventHandler(this.txtNewPass_TextChanged);
            // 
            // txtComfrmPass
            // 
            this.txtComfrmPass.Location = new System.Drawing.Point(280, 234);
            this.txtComfrmPass.Multiline = true;
            this.txtComfrmPass.Name = "txtComfrmPass";
            this.txtComfrmPass.PasswordChar = '*';
            this.txtComfrmPass.Size = new System.Drawing.Size(356, 45);
            this.txtComfrmPass.TabIndex = 2;
            this.txtComfrmPass.TextChanged += new System.EventHandler(this.txtComfrmPass_TextChanged);
            // 
            // btnShowCrrPss
            // 
            this.btnShowCrrPss.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowCrrPss.BackgroundImage = global::StudentManagement.Properties.Resources.hide;
            this.btnShowCrrPss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowCrrPss.Location = new System.Drawing.Point(665, 97);
            this.btnShowCrrPss.Name = "btnShowCrrPss";
            this.btnShowCrrPss.Size = new System.Drawing.Size(49, 44);
            this.btnShowCrrPss.TabIndex = 3;
            this.btnShowCrrPss.UseVisualStyleBackColor = false;
            this.btnShowCrrPss.Click += new System.EventHandler(this.btnShowCrrPss_Click);
            // 
            // btnShowNwPss
            // 
            this.btnShowNwPss.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowNwPss.BackgroundImage = global::StudentManagement.Properties.Resources.hide;
            this.btnShowNwPss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowNwPss.Location = new System.Drawing.Point(665, 166);
            this.btnShowNwPss.Name = "btnShowNwPss";
            this.btnShowNwPss.Size = new System.Drawing.Size(49, 44);
            this.btnShowNwPss.TabIndex = 3;
            this.btnShowNwPss.UseVisualStyleBackColor = false;
            this.btnShowNwPss.Click += new System.EventHandler(this.btnShowNwPss_Click);
            // 
            // btnShowCfrPss
            // 
            this.btnShowCfrPss.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowCfrPss.BackgroundImage = global::StudentManagement.Properties.Resources.hide;
            this.btnShowCfrPss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowCfrPss.Location = new System.Drawing.Point(665, 234);
            this.btnShowCfrPss.Name = "btnShowCfrPss";
            this.btnShowCfrPss.Size = new System.Drawing.Size(49, 44);
            this.btnShowCfrPss.TabIndex = 3;
            this.btnShowCfrPss.UseVisualStyleBackColor = false;
            this.btnShowCfrPss.Click += new System.EventHandler(this.btnShowCfrPss_Click);
            // 
            // btnUpdatePass
            // 
            this.btnUpdatePass.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdatePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdatePass.Location = new System.Drawing.Point(280, 353);
            this.btnUpdatePass.Name = "btnUpdatePass";
            this.btnUpdatePass.Size = new System.Drawing.Size(128, 66);
            this.btnUpdatePass.TabIndex = 4;
            this.btnUpdatePass.Text = "Xác Nhận";
            this.btnUpdatePass.UseVisualStyleBackColor = false;
            this.btnUpdatePass.Click += new System.EventHandler(this.btnUpdatePass_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(496, 353);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 66);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ChangPassFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(769, 447);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdatePass);
            this.Controls.Add(this.btnShowCfrPss);
            this.Controls.Add(this.btnShowNwPss);
            this.Controls.Add(this.btnShowCrrPss);
            this.Controls.Add(this.txtComfrmPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtCurrentPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangPassFrm";
            this.Text = "ChangPassFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurrentPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtComfrmPass;
        private System.Windows.Forms.Button btnShowCrrPss;
        private System.Windows.Forms.Button btnShowNwPss;
        private System.Windows.Forms.Button btnShowCfrPss;
        private System.Windows.Forms.Button btnUpdatePass;
        private System.Windows.Forms.Button btnCancel;
    }
}