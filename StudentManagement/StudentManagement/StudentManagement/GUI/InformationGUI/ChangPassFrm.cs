using StudentManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.GUI.InformationGUI
{
    public partial class ChangPassFrm : Form
    {
        public ChangPassFrm()
        {
            InitializeComponent();
        }
        Data data = new Data();
        XJDBC db = new XJDBC();
        public string id_user {  get; set; }
        private void btnShowCrrPss_Click(object sender, EventArgs e)
        {
            if (txtCurrentPass.PasswordChar == '*')
            {
                // Hiển thị mật khẩu
                txtCurrentPass.PasswordChar = '\0';
            }
            else
            {
                // Ẩn mật khẩu
                txtCurrentPass.PasswordChar = '*';
            }
        }

        private void txtCurrentPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtComfrmPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShowNwPss_Click(object sender, EventArgs e)
        {
            if (txtNewPass.PasswordChar == '*')
            {
                // Hiển thị mật khẩu
                txtNewPass.PasswordChar = '\0';
            }
            else
            {
                // Ẩn mật khẩu
                txtNewPass.PasswordChar = '*';
            }
        }

        private void btnShowCfrPss_Click(object sender, EventArgs e)
        {
            if (txtComfrmPass.PasswordChar == '*')
            {
                // Hiển thị mật khẩu
                txtComfrmPass.PasswordChar = '\0';
            }
            else
            {
                // Ẩn mật khẩu
                txtComfrmPass.PasswordChar = '*';
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdatePass_Click(object sender, EventArgs e)
        {
            update();
        }
        private void update()
        {
            string currentPass = txtCurrentPass.Text.Trim();
            string newPass = txtNewPass.Text.Trim();
            string confirmPass = txtComfrmPass.Text.Trim();
            if (currentPass == "" || newPass == "" || confirmPass == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!","Mật Khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string hashCrnPass = data.HashPassword(currentPass);
                if(checkPass(hashCrnPass))
                {
                    if (isValidPass(newPass))
                    {
                        if (confirmPass == newPass)
                        {
                            string hashNwPass = data.HashPassword(newPass);
                            string tableName = "TaiKhoan";
                            string condition = $" MaNguoiDung = '{id_user}'";
                            Dictionary<string, object> dic = new Dictionary<string, object>
                            {
                                {"MatKhau",hashNwPass}
                            };
                            if (data.UpdateData(tableName, dic, condition))
                            {
                                this.DialogResult = DialogResult.OK;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu xác nhận không trùng mật khẩu mới!!!", "Mật Khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập mật khẩu có độ dài từ 8 -12 ký tự\nmột ký tự thường\nmột ký tự hoa\n một chữ số\nmột ký tự đặc biệt!!!", "Mật Khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    
                    MessageBox.Show("Vui lòng nhập đúng mật khẩu hiện tại !!!", "Mật Khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

            
           
        }
        private bool isValidPass(string password)
        {
            Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,20}$");

            return regex.IsMatch(password);
        }
        private bool checkPass(string pass)
        {
            try
            {
                SqlCommand cmd = new SqlCommand($"Select MatKhau from TaiKhoan where MaNguoiDung ='{id_user}'", db.getConnection);
                db.openConnection();
                SqlDataReader reader = cmd.ExecuteReader();
                string oldPass = "";
                if (reader.Read())
                {
                   oldPass = reader.GetString(0); // Lấy mật khẩu đã băm từ cơ sở dữ liệu
                }
                
                if (oldPass.Trim() == pass.Trim()) { 
                    return true;
                }
                else
                {
                    return false;
                }
                  
                
                
            }
            catch
            {
                MessageBox.Show("Lỗi sql");
                return false;
            }
            finally { db.closeConnection();  }
           

        }

    }
}
