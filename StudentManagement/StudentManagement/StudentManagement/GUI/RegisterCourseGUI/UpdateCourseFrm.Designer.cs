namespace StudentManagement.GUI.RegisterCourseGUI
{
    partial class UpdateCourseFrm
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtNumCreadit = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(315, 212);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(248, 50);
            this.txtDescription.TabIndex = 55;
            // 
            // txtNumCreadit
            // 
            this.txtNumCreadit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumCreadit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCreadit.Location = new System.Drawing.Point(315, 146);
            this.txtNumCreadit.Multiline = true;
            this.txtNumCreadit.Name = "txtNumCreadit";
            this.txtNumCreadit.Size = new System.Drawing.Size(248, 50);
            this.txtNumCreadit.TabIndex = 54;
            this.txtNumCreadit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumCreadit_KeyPress);
            // 
            // txtCourseName
            // 
            this.txtCourseName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseName.Location = new System.Drawing.Point(315, 79);
            this.txtCourseName.Multiline = true;
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(248, 50);
            this.txtCourseName.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(206, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 29);
            this.label10.TabIndex = 53;
            this.label10.Text = "Mô tả:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(206, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 29);
            this.label5.TabIndex = 52;
            this.label5.Text = "Số TC:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 29);
            this.label3.TabIndex = 51;
            this.label3.Text = "Tên Môn Học:";
            // 
            // btnUpdateCourse
            // 
            this.btnUpdateCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdateCourse.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateCourse.BackgroundImage = global::StudentManagement.Properties.Resources.edit;
            this.btnUpdateCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateCourse.Location = new System.Drawing.Point(359, 315);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.Size = new System.Drawing.Size(125, 75);
            this.btnUpdateCourse.TabIndex = 57;
            this.btnUpdateCourse.UseVisualStyleBackColor = false;
            this.btnUpdateCourse.Click += new System.EventHandler(this.btnUpdateCourse_Click);
            // 
            // UpdateCourseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 471);
            this.Controls.Add(this.btnUpdateCourse);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtNumCreadit);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Name = "UpdateCourseFrm";
            this.Text = "UpdateCourseFrm";
            this.Load += new System.EventHandler(this.UpdateCourseFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtNumCreadit;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateCourse;
    }
}