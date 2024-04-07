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
        //private Capture capture = new Capture();
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
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DetectFaceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            faceRec.StopCamera();
        }
    }
}
