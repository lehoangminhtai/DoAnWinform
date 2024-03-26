using StudentManagement.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.DAO
{
    public class LoginDAO
    {
        XJDBC db = new XJDBC();
        public bool isAuthFace(string id)
        {
            try
            {
                db.openConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM AuthFace WHERE idUser = @id",db.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                var result = cmd.ExecuteReader();
                if (result.HasRows)
                {
                   while (result.Read())
                    {
                        string idUser = (string)result.GetValue(result.GetOrdinal("idUser"));
                        bool isAuth = result.GetBoolean(result.GetOrdinal("isAuth"));
                        int role = (int)result.GetValue(result.GetOrdinal("MaQuyen"));
                        if (isAuth )
                        {
                            return true;
                        }
                        else
                        {
                            if(role == 0)
                            {
                                MessageBox.Show("Tài khoản đang chờ hệ thống xác thực\nVui lòng quay lại đăng nhập sau!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }
                            if(role == 1)//là học sinh
                            {
                                MessageBox.Show("Vui lòng kiểm tra email để xác thực OTP!!!", "Xác thực", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                string receiveMail = idUser + "@student.hcmute.edu.vn";
                                OTP.Email = receiveMail;
                                OTP.role = 3;//Nhận thông báo xác thực khuôn mặt;
                                OTP.SendEmail(receiveMail);

                                frmOTP otp = new frmOTP();
                                if(otp.ShowDialog()==DialogResult.OK)
                                    return true;
                                
                            }
                            if (role == 2)
                            {
                                MessageBox.Show("Vui lòng kiểm tra email để xác thực OTP!!!", "Xác thực", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                string receiveMail = idUser + "@hcmute.edu.vn";
                                OTP.Email = receiveMail;
                                OTP.role = 3;//Nhận thông báo xác thực khuôn mặt;
                                OTP.SendEmail(receiveMail);
                                frmOTP otp = new frmOTP();
                                if (otp.ShowDialog() == DialogResult.OK)
                                {
                                    return true;
                                }
                                
                            }

                        }
                    }
                }
                return false;
                
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                db.closeConnection();
            }
           
        }
    }
}
