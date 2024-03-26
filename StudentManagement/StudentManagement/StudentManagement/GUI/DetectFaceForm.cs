using Emgu.CV;
using StudentManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.GUI
{
    public partial class DetectFaceForm : Form
    {
        FaceRec faceRec = new FaceRec();
        private Capture capture = new Capture();
        public DetectFaceForm()
        {
            InitializeComponent();
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            faceRec.openCamera(pictureBoxCamara, pictureBoxCaptured);
        }

        private void btnDetectFace_Click(object sender, EventArgs e)
        {
            lblName.Text.Trim();
            faceRec.isTrained = true;
            faceRec.getPersonName(lblName);
            Thread thread = new Thread(() =>
            {
                DateTime startTime = DateTime.Now;
                TimeSpan duration = TimeSpan.FromSeconds(30);

                while (DateTime.Now - startTime < duration)
                {
                    if (lblName.ToString()!="")
                    {
                        LoginDAO loginDao = new LoginDAO();
                        if (loginDao.isAuthFace(lblName.ToString().Trim()))
                        {
                            MessageBox.Show(lblName.ToString());
                            MainForm main = new MainForm();
                            main.ShowDialog();
                        }
                        return;
                    }

                    // Đợi một khoảng thời gian ngắn trước khi kiểm tra lại
                    Thread.Sleep(1000); // Đợi 1 giây trước khi kiểm tra lại
                }

                // Nếu không có khuôn mặt được nhận ra sau 30 giây, thông báo "Unknown"
                this.Invoke(new MethodInvoker(delegate
                {
                    lblName.Text = "Unknown";
                    MessageBox.Show("Khuôn mặt không được nhận ra sau 30 giây.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
            });

            thread.Start();
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
