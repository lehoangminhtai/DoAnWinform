using StudentManagement.DAO;
using StudentManagement.Entity;
using StudentManagement.GUI;
using StudentManagement.GUI.LoginRegisterGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Form1 : Form
    {
        XJDBC db =new XJDBC();
        Data data = new Data();
        string receiveMail = "21102003tai@gmail.com";
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassLogin.ForeColor = Color.Black;
            
        }

        private void txtPassLogin_TextChanged(object sender, EventArgs e)
        {

            txtPassLogin.ForeColor = Color.Black;
            txtPassLogin.Font = new Font(txtPassLogin.Font.FontFamily, 8f);
        }

        private void txtPassLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPassLogin.ForeColor = Color.Black;
        }

        private void txtIdLogin_TextChanged(object sender, EventArgs e)
        {

            txtIdLogin.ForeColor = Color.Black;
            txtIdLogin.Font = new Font(txtIdLogin.Font.FontFamily, 8f);
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterFrm registerFrm = new RegisterFrm();
            //registerFrm.ShowDialog();
            if(registerFrm.ShowDialog() == DialogResult.OK)
            {
                frmOTP otp = new frmOTP();
                otp.isForgotPass = false;
                if(otp.ShowDialog() == DialogResult.OK)
                {
                    otp.Close();
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            string id_user = txtIdLogin.Text.Trim();
            string pass = txtPassLogin.Text.Trim();

            if (id_user == "" || pass == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!!","Đăng Nhập",MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            else
            {
                if (checkAccount(id_user, pass))
                {
                    ACCOUNT.id = id_user;
                    ACCOUNT.role= getRole();
                    if (ACCOUNT.role != -1 && getStatus())
                        this.DialogResult = DialogResult.OK;
                    else
                    {
                        MessageBox.Show("Tài Khoản của bạn đã bị khoá!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng !!!", "Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }
        private bool checkAccount(string id, string pass)
        {
            try
            {
                string hashPass = data.HashPassword(pass);
                using (SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM TaiKhoan WHERE MaNguoiDung = @id AND MatKhau = @hashPass", db.getConnection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@hashPass", hashPass);
                    db.openConnection();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                db.closeConnection();
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

        private void btnLoginByFace_Click(object sender, EventArgs e)
        {
            DetectFaceForm detectFace = new DetectFaceForm();
            if(detectFace.ShowDialog()==DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void txtPassLogin_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void lnkForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassFrm frm= new ForgotPassFrm();
            
            if (frm.ShowDialog()== DialogResult.OK)
            {
                frmOTP otp = new frmOTP();
                otp.isForgotPass = true;
                if (otp.ShowDialog() == DialogResult.OK)
                {
                    OTP otpp = new OTP();
                    otpp.SendPass(receiveMail);
                    otp.Close();
                }
            }
            
        }
    }
}
