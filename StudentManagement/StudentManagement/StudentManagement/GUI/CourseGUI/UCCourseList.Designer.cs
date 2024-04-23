namespace StudentManagement.GUI
{
    partial class UCCourseList
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
            this.panelCourseList = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCourseList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCourseList
            // 
            this.panelCourseList.AutoSize = true;
            this.panelCourseList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelCourseList.Controls.Add(this.label1);
            this.panelCourseList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCourseList.Location = new System.Drawing.Point(0, 0);
            this.panelCourseList.Name = "panelCourseList";
            this.panelCourseList.Size = new System.Drawing.Size(1641, 1072);
            this.panelCourseList.TabIndex = 0;
            this.panelCourseList.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH MÔN HỌC";
            // 
            // UCCourseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panelCourseList);
            this.Name = "UCCourseList";
            this.Size = new System.Drawing.Size(1641, 1072);
            this.Load += new System.EventHandler(this.UCCourseList_Load);
            this.panelCourseList.ResumeLayout(false);
            this.panelCourseList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCourseList;
        private System.Windows.Forms.Label label1;
    }
}
