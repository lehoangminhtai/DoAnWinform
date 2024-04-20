namespace StudentManagement.GUI.HomeworkGUI
{
    partial class UChomework
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
            this.panelDocument = new System.Windows.Forms.Panel();
            this.btnAddHomeW = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelDocument
            // 
            this.panelDocument.AutoSize = true;
            this.panelDocument.Location = new System.Drawing.Point(1, 94);
            this.panelDocument.Name = "panelDocument";
            this.panelDocument.Size = new System.Drawing.Size(1026, 599);
            this.panelDocument.TabIndex = 2;
            // 
            // btnAddHomeW
            // 
            this.btnAddHomeW.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddHomeW.BackgroundImage = global::StudentManagement.Properties.Resources.addHomework;
            this.btnAddHomeW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddHomeW.Location = new System.Drawing.Point(26, 11);
            this.btnAddHomeW.Name = "btnAddHomeW";
            this.btnAddHomeW.Size = new System.Drawing.Size(107, 77);
            this.btnAddHomeW.TabIndex = 3;
            this.btnAddHomeW.UseVisualStyleBackColor = false;
            // 
            // UChomework
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnAddHomeW);
            this.Controls.Add(this.panelDocument);
            this.Name = "UChomework";
            this.Size = new System.Drawing.Size(1030, 704);
            this.Load += new System.EventHandler(this.UChomework_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddHomeW;
        private System.Windows.Forms.Panel panelDocument;
    }
}
