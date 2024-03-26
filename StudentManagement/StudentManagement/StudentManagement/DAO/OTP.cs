using OtpNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public class OTP
    {
        private static byte[] secretKey;
        private static Totp totp;
       
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
        public static void SendEmail(string toAddress)
        {
            
            try
            {
                // Thay đổi các thông tin sau theo email của bạn và thông tin SMTP server
                string smtpAddress = "smtp.gmail.com"; // Địa chỉ SMTP server của bạn
                int portNumber = 587; // Cổng của SMTP server (thường là 587 hoặc 25)
                bool enableSSL = true; // Có sử dụng SSL không
                string emailFrom = "21110635@student.hcmute.edu.vn"; // Email của bạn
                string password = "Nguyentam_@1984"; // Mật khẩu email của bạn
                string emailTo = toAddress; // Email đích
                string subjectEmail = "[Management App] Confirm Account"; // Chủ đề của email
                string bodyEmail = "Mã OTP xác thực tài khoản "+GenerateOTP(); // Nội dung của email
                numOTP = int.Parse(bodyEmail);
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


                MessageBox.Show("Vui long kiểm tra email sinh viên để lấy mã OTP.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xảy ra lỗi trong quá trình đăng ký tài khoản !!!");

            }
        }

    }
}
