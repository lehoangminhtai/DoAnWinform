using StudentManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class frmOTP : Form
    {
        StudentDAO studentDAO = new StudentDAO();
        TeacherDao teacherDao = new TeacherDao();
        public frmOTP()
        {
            InitializeComponent();
        }


        private OTP otp =new OTP();
        //Khởi tạo thời gian đêm ngược time otp
        private int count = 60;
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length == 1)
            {
                SendKeys.Send("{TAB}");
            }
           

            // Chỉ giữ lại một ký tự nếu nội dung vượt quá một chữ số
            if (textBox.Text.Length > 1)
            {
                string strInput = textBox.Text;
                if (otp.IsNumeric(strInput))
                {
                    textBox1.TextChanged -= textBox6_TextChanged;
                    textBox2.TextChanged -= textBox6_TextChanged;
                    textBox3.TextChanged -= textBox6_TextChanged;
                    textBox4.TextChanged -= textBox6_TextChanged;
                    textBox5.TextChanged -= textBox6_TextChanged;
                    textBox6.TextChanged -= textBox6_TextChanged;

                    int num = int.Parse(strInput);
                    OTP.numOTP_Client = num;
                    int[] digits = OTP.separateNumber(num);
                    textBox.Text.Trim();
                    textBox6.Text = digits[0].ToString();
                    textBox5.Text = digits[1].ToString();
                    textBox4.Text = digits[2].ToString();
                    textBox3.Text = digits[3].ToString();
                    textBox2.Text = digits[4].ToString();
                    textBox1.Text = digits[5].ToString();

                    textBox1.TextChanged += textBox6_TextChanged;
                    textBox2.TextChanged += textBox6_TextChanged;
                    textBox3.TextChanged += textBox6_TextChanged;
                    textBox4.TextChanged += textBox6_TextChanged;
                    textBox5.TextChanged += textBox6_TextChanged;
                    textBox6.TextChanged += textBox6_TextChanged;

                    
                    
                }
                else
                {
                    textBox.Text = "";
                }
            }
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                btnSendOTP.Focus();
            }

        }

        private void lnkLblOTP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             try
            {
                count = 120;
                this.frmOTP_Load(sender, e);
                OTP.SendEmail(OTP.Email);
               

            }
            catch
            {
                MessageBox.Show("Register fail!!");
            }
        }

        private void frmOTP_Load(object sender, EventArgs e)
        {
            timer1.Start();
           
           
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
                count--;
                lblTimeRemain.Text = count.ToString()+"s";
                
            if(count == 0)
            {
                timer1.Stop();
                lnkLblOTP.Enabled = true;
            }
            if (count > 0)
            {
                lnkLblOTP.Enabled = false;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
           

            TextBox textBox = (TextBox)sender;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Loại bỏ ký tự không phải số
            }
            if (textBox.Text.Length >= 1)
            {
                
                e.Handled = true; // Ngăn chặn nhập thêm ký tự nếu ô TextBox đã có 1 ký tự
            }

        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // Kiểm tra nếu người dùng nhấn phím Delete và ô TextBox đang không trống
            if (e.KeyCode != Keys.Delete && !string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = ""; // Xóa ký tự trong ô TextBox
                e.Handled = true; // Ngăn không cho sự kiện được xử lý tiếp theo
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSendOTP_Click(object sender, EventArgs e)
        {
            
            if(count > 0)
            {
                if(OTP.numOTP ==OTP.numOTP_Client)
                {
                    if (OTP.role == 1)
                    {
                        if (studentDAO.Insert())
                        {
                            MessageBox.Show("Đăng ký thành công, vui lòng chờ thông báo xác nhận admin qua email!!!", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    if (OTP.role == 2)
                    {
                        if (teacherDao.Insert())
                        {
                            MessageBox.Show("Đăng ký thành công, vui lòng chờ thông báo xác nhận admin qua email!!!", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult= DialogResult.OK;
                        }
                    }
                   
                }
                else
                {
                    int num = OTP.numOTP_Client;
                    MessageBox.Show(OTP.numOTP.ToString()+" "+num.ToString());
                    MessageBox.Show("Sai OTP!!!\nVui lòng nhập đúng mã OTP.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mã OTP đã hết hạn\n Vui lòng chọn gửi lại mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
