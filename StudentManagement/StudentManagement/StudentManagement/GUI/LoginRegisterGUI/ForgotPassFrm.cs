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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.GUI.LoginRegisterGUI
{
    public partial class ForgotPassFrm : Form
    {
        XJDBC db = new XJDBC();
        Data data = new Data();
        public ForgotPassFrm()
        {
            InitializeComponent();
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            resetPass();
        }
        private void resetPass()
        {
            string id_user = txtUserId.Text.Trim();
            if(id_user=="")
            {
                MessageBox.Show("Vui lòng nhập mã đăng nhập !!!", "Quên Mật Khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else {
                if (checkAccount(id_user))
                {
                    string receiveMail = "21102003tai@gmail.com";
                    int role = getRole();
                    ACCOUNT.id = id_user;
                    if (role == 1)
                    {
                        receiveMail = id_user + "@student.hcmute.edu.vn";
                    }
                    else
                    {
                        receiveMail = id_user + "@hcmute.edu.vn";
                    }
                    receiveMail = "21102003tai@gmail.com";
                    OTP.Email = receiveMail;
                    OTP.role = role; 

                    OTP.SendEmail(receiveMail);

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Mã đăng nhập không đúng hoặc chưa đăng ký tài khoản !!!", "Quên Mật Khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
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
        private bool checkAccount(string id)
        {
            try
            {
              
                using (SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM TaiKhoan WHERE MaNguoiDung = @id", db.getConnection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    
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
    }
}
