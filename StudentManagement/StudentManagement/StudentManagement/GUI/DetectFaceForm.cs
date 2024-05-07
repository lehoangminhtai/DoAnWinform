using Emgu.CV;
using StudentManagement.DAO;
using StudentManagement.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        XJDBC db = new XJDBC();
        public string id {  get; set; }
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

        private void DetectFaceForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (lblName.Text.Trim() != "")
            {
                ACCOUNT.id = lblName.Text.Trim();
                ACCOUNT.role = getRole();
                if(ACCOUNT.role!=-1 && getStatus())
                    this.DialogResult = DialogResult.OK;
               
            }
              
        }
        private bool getStatus()
        {
            try
            {

                int status = -1;
                SqlCommand cmd = new SqlCommand($"select TrangThai from TaiKhoan where MaNguoiDung = '{ACCOUNT.id}'", db.getConnection);
                db.openConnection();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        status = reader.GetInt32(0);
                    }
                }
                if (status == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch
            {
                return false;
            }
        }
        private int getRole()
        {
            try
            {

                int role = -1;
                SqlCommand cmd = new SqlCommand($"select Quyen from TaiKhoan where MaNguoiDung = '{ACCOUNT.id}'", db.getConnection);
                db.openConnection();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        role = reader.GetInt32(0);
                    }
                }
                return role;
            }
            catch
            {
                return -1;
            }

        }
    }
}
