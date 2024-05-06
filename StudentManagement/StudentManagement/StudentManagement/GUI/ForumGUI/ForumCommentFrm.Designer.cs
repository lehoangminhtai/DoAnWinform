namespace StudentManagement.GUI.ForumGUI
{
    partial class ForumCommentFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForumCommentFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.panelComment = new System.Windows.Forms.Panel();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnComment = new System.Windows.Forms.Button();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.lblImageName = new System.Windows.Forms.Label();
            this.lblNotice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(496, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diễn Đàn";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(58, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Môn học:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(58, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Câu hỏi:";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQuestion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.ForeColor = System.Drawing.Color.Orange;
            this.txtQuestion.Location = new System.Drawing.Point(207, 170);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuestion.Size = new System.Drawing.Size(873, 143);
            this.txtQuestion.TabIndex = 2;
            // 
            // lblCourseName
            // 
            this.lblCourseName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.BackColor = System.Drawing.Color.DarkCyan;
            this.lblCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCourseName.Location = new System.Drawing.Point(201, 116);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(46, 32);
            this.lblCourseName.TabIndex = 1;
            this.lblCourseName.Text = "<>";
            // 
            // panelComment
            // 
            this.panelComment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelComment.AutoScroll = true;
            this.panelComment.Location = new System.Drawing.Point(64, 340);
            this.panelComment.Name = "panelComment";
            this.panelComment.Size = new System.Drawing.Size(1016, 465);
            this.panelComment.TabIndex = 3;
            // 
            // txtComment
            // 
            this.txtComment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.Location = new System.Drawing.Point(64, 853);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(739, 75);
            this.txtComment.TabIndex = 4;
            this.txtComment.TextChanged += new System.EventHandler(this.txtComment_TextChanged);
            // 
            // btnComment
            // 
            this.btnComment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnComment.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComment.Location = new System.Drawing.Point(920, 853);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(160, 75);
            this.btnComment.TabIndex = 5;
            this.btnComment.Text = "Bình luận";
            this.btnComment.UseVisualStyleBackColor = false;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUploadImage.BackColor = System.Drawing.Color.White;
            this.btnUploadImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUploadImage.BackgroundImage")));
            this.btnUploadImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUploadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImage.Image = ((System.Drawing.Image)(resources.GetObject("btnUploadImage.Image")));
            this.btnUploadImage.Location = new System.Drawing.Point(809, 853);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(105, 75);
            this.btnUploadImage.TabIndex = 19;
            this.btnUploadImage.UseVisualStyleBackColor = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // lblImageName
            // 
            this.lblImageName.AutoSize = true;
            this.lblImageName.Location = new System.Drawing.Point(68, 821);
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(96, 20);
            this.lblImageName.TabIndex = 20;
            this.lblImageName.Text = "ImageName";
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.ForeColor = System.Drawing.Color.Red;
            this.lblNotice.Location = new System.Drawing.Point(68, 931);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(139, 20);
            this.lblNotice.TabIndex = 20;
            this.lblNotice.Text = "* Bạn nói gì đó đi!!!";
            // 
            // ForumCommentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1132, 962);
            this.Controls.Add(this.lblNotice);
            this.Controls.Add(this.lblImageName);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.btnComment);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.panelComment);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ForumCommentFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForumCommentFrm";
            this.Load += new System.EventHandler(this.ForumCommentFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Panel panelComment;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnComment;
        public System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.Label lblImageName;
        private System.Windows.Forms.Label lblNotice;
    }
}