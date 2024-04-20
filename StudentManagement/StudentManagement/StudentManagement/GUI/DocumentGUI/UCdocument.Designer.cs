namespace StudentManagement.GUI
{
    partial class UCdocument
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
            this.btnAddDoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelDocument
            // 
            this.panelDocument.AutoSize = true;
            this.panelDocument.Location = new System.Drawing.Point(0, 96);
            this.panelDocument.Name = "panelDocument";
            this.panelDocument.Size = new System.Drawing.Size(1026, 599);
            this.panelDocument.TabIndex = 0;
            this.panelDocument.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDocument_Paint);
            // 
            // btnAddDoc
            // 
            this.btnAddDoc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddDoc.BackgroundImage = global::StudentManagement.Properties.Resources.add;
            this.btnAddDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddDoc.Location = new System.Drawing.Point(25, 13);
            this.btnAddDoc.Name = "btnAddDoc";
            this.btnAddDoc.Size = new System.Drawing.Size(107, 77);
            this.btnAddDoc.TabIndex = 1;
            this.btnAddDoc.UseVisualStyleBackColor = false;
            this.btnAddDoc.Click += new System.EventHandler(this.btnAddDoc_Click);
            // 
            // UCdocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnAddDoc);
            this.Controls.Add(this.panelDocument);
            this.Name = "UCdocument";
            this.Size = new System.Drawing.Size(1029, 704);
            this.Load += new System.EventHandler(this.UCdocument_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDocument;
        private System.Windows.Forms.Button btnAddDoc;
    }
}
