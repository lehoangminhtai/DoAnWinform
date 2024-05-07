using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagement.DAO;

namespace StudentManagement.GUI.LoginFaceGUI
{
    public partial class RegisterFaceFrm : Form
    {
        FaceRec faceRec = new FaceRec();
        public string id_user {  get; set; }
        public RegisterFaceFrm()
        {
            InitializeComponent();
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            faceRec.openCamera(pictureBoxCamara, pictureBoxCaptured);
        }

        private void btnSaveFace_Click(object sender, EventArgs e)
        {
            
            faceRec.Save_IMAGE(id_user);
            faceRec.CloseCamera();
            this.DialogResult = DialogResult.OK;

        }

        private void btnTakePic_Click(object sender, EventArgs e)
        {
            pictureBoxCaptured.Image = pictureBoxCamara.Image;
            
        }

        private void RegisterFaceFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            faceRec.CloseCamera();
        }

        private void RegisterFaceFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            faceRec.CloseCamera();
        }

        private void pictureBoxCamara_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxCamara_BackgroundImageChanged(object sender, EventArgs e)
        {
           
        }
    }
}
