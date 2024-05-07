using OtpNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagement.DAO;
using StudentManagement.Entity;

namespace StudentManagement
{
    public class OTP
    {
        private static byte[] secretKey;
        private static Totp totp;
        Data data = new Data();
       
        public static int role {  get; set; }
       public static string Email {  get; set; }

       public static int numOTP { get; set; }
        public static int numOTP_Client {  get; set; }

        public static string GenerateOTP()
        {
            secretKey = KeyGeneration.GenerateRandomKey(20);
            totp = new Totp(secretKey, step: 30, totpSize: 6);
            string otp = totp.ComputeTotp();
            return otp;
        }
        
        public bool IsNumeric(string input)
        {
            int sum = 0;
            foreach (char c in input)
            {
                sum += 1;
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            if (sum == 6) {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int[] separateNumber(int number)
        {
            int[] digits = new int[6];

          
            for (int i = 5; i >= 0; i--)
            {
                digits[i] = number % 10; 
                number /= 10;
            }
            return digits;

        }
        public static void SendEmail(string toaddress)
        {
            
            try
            {
                // Thay đổi các thông tin sau theo email của bạn và thông tin SMTP server
                string smtpAddress = "smtp.gmail.com"; // Địa chỉ SMTP server của bạn
                int portNumber = 587; // Cổng của SMTP server (thường là 587 hoặc 25)
                bool enableSSL = true; // Có sử dụng SSL không
                string emailFrom = "21110635@student.hcmute.edu.vn"; // Email của bạn
                string password = "Tranlai_@2003"; // Mật khẩu email của bạn
                string emailTo = toaddress; // Email đích
                string subjectEmail = "[Management App] Confirm Account"; // Chủ đề của email
                string otp = GenerateOTP();
                string bodyEmail = "Mã OTP xác thực tài khoản "+otp; // Nội dung của email
                numOTP = int.Parse(otp);
                MailMessage mail = new MailMessage();

                mail.From = new MailAddress(emailFrom);
                mail.To.Add(emailTo);
                mail.Subject = subjectEmail;
                mail.Body = bodyEmail;
                mail.IsBodyHtml = true; // Nếu bạn muốn sử dụng HTML trong nội dung email

                SmtpClient smtp = new SmtpClient(smtpAddress, portNumber);

                smtp.Credentials = new NetworkCredential(emailFrom, password);
                smtp.EnableSsl = enableSSL;
                smtp.Send(mail);


                MessageBox.Show("Vui long kiểm tra email để lấy mã OTP.");
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Xảy ra lỗi trong quá trình đăng ký tài khoản !!!");
                MessageBox.Show(ex.Message);

            }
        }

        public  void SendPass(string toaddress)
        {

            try
            {
                // Thay đổi các thông tin sau theo email của bạn và thông tin SMTP server
                string smtpAddress = "smtp.gmail.com"; // Địa chỉ SMTP server của bạn
                int portNumber = 587; // Cổng của SMTP server (thường là 587 hoặc 25)
                bool enableSSL = true; // Có sử dụng SSL không
                string emailFrom = "21110635@student.hcmute.edu.vn"; // Email của bạn
                string password = "Tranlai_@2003"; // Mật khẩu email của bạn
                string emailTo = toaddress; // Email đích
                string subjectEmail = "[Management App] Reset Password"; // Chủ đề của email
                string newPass = GenerateRandomPass.GenerateRandomPassword(8);

              
                string bodyEmail = "Mật khẩu được đặt lại là " + newPass; // Nội dung của email
                
                MailMessage mail = new MailMessage();

                mail.From = new MailAddress(emailFrom);
                mail.To.Add(emailTo);
                mail.Subject = subjectEmail;
                mail.Body = bodyEmail;
                mail.IsBodyHtml = true; // Nếu bạn muốn sử dụng HTML trong nội dung email

                SmtpClient smtp = new SmtpClient(smtpAddress, portNumber);

                smtp.Credentials = new NetworkCredential(emailFrom, password);
                smtp.EnableSsl = enableSSL;
                smtp.Send(mail);

                if(updatePass(ACCOUNT.id, newPass))
                    MessageBox.Show("Vui long kiểm tra email để lấy mật khẩu mới");
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Xảy ra lỗi trong quá trình đăng ký tài khoản !!!");
                MessageBox.Show(ex.Message);

            }
        }
        private  bool updatePass(string id_user,string pass)
        {
            string hashNwPass = data.HashPassword(pass);
            string tableName = "TaiKhoan";
            string condition = $" MaNguoiDung = '{id_user}'";
            Dictionary<string, object> dic = new Dictionary<string, object>
                            {
                                {"MatKhau",hashNwPass}
                            };
            if(data.UpdateData(tableName, dic, condition))
            {
                return true;
            }
            else
                return false;
           
        }

        public void OpenAcc(string toaddress, string pass)
        {

            try
            {
                // Thay đổi các thông tin sau theo email của bạn và thông tin SMTP server
                string smtpAddress = "smtp.gmail.com"; // Địa chỉ SMTP server của bạn
                int portNumber = 587; // Cổng của SMTP server (thường là 587 hoặc 25)
                bool enableSSL = true; // Có sử dụng SSL không
                string emailFrom = "21110635@student.hcmute.edu.vn"; // Email của bạn
                string password = "Tranlai_@2003"; // Mật khẩu email của bạn
                string emailTo = toaddress; // Email đích
                string subjectEmail = "[Management App] Active Account:"; // Chủ đề của email
               


                string bodyEmail ="Mã đăng nhập của bạn là: "+ pass + "\nMật khẩu được đặt lại là: " + pass +"\nVui lòng đổi mật khẩu sau khi đăng nhập"; // Nội dung của email

                MailMessage mail = new MailMessage();

                mail.From = new MailAddress(emailFrom);
                mail.To.Add(emailTo);
                mail.Subject = subjectEmail;
                mail.Body = bodyEmail;
                mail.IsBodyHtml = true; // Nếu bạn muốn sử dụng HTML trong nội dung email

                SmtpClient smtp = new SmtpClient(smtpAddress, portNumber);

                smtp.Credentials = new NetworkCredential(emailFrom, password);
                smtp.EnableSsl = enableSSL;
                smtp.Send(mail);
                MessageBox.Show("Đã cấp tài khoản cho người dùng!!!");
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Xảy ra lỗi trong quá trình đăng ký tài khoản !!!");
                MessageBox.Show(ex.Message);

            }
        }
    }
}
