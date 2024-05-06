using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.GUI.ForumGUI
{
    public partial class ShowImageCmt : Form
    {
        public MemoryStream pic {  get; set; }
        public ShowImageCmt()
        {
            InitializeComponent();
        }

        private void ShowImageCmt_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromStream(pic);  
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    pictureBox1.Image.Save(saveDialog.FileName);
                    MessageBox.Show("Đã lưu ảnh!!!");
                }
            }
            else
            {
                MessageBox.Show("Không có hình ảnh để lưu.");
            }
        }
    }
}
