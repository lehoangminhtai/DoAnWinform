using StudentManagement.DAO;
using StudentManagement.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace StudentManagement
{
    public partial class RegisterFrm : Form
    {
        StudentDAO studentDAO = new StudentDAO();
        public RegisterFrm()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterFrm_Load(object sender, EventArgs e)
        {
            radMale.Checked = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if(CheckNotNull(txtId)&& CheckNotNull(txtFname) && CheckNotNull(txtLname) && CheckNotNull(txtPhone) && CheckNotNull(txtCCCD)) {
                    STUDENT.ID = txtId.Text.ToString().Trim();
                    
                    if (!Regex.IsMatch(txtFname.Text.Trim(), @"^[\p{L}\s]+$"))
                    {
                        
                        MessageBox.Show("Please enter a valid First Name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        STUDENT.Fname = txtFname.Text.ToString().Trim();
                    }

                    string lname = txtLname.Text.Trim();
                    if (!Regex.IsMatch(lname, @"^[\p{L}\s]+$"))
                    {
                        MessageBox.Show("Please enter a valid First Name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        STUDENT.Lname = txtLname.Text.ToString().Trim();
                    }
                    string phone = txtPhone.Text.Trim();
                    if (!Regex.IsMatch(phone, @"^\d{10}$"))
                    {
                        MessageBox.Show("Please enter a valid 10-digit phone number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        STUDENT.Phone = txtPhone.Text.ToString().Trim();
                    }
                    LOGIN.ID = txtId.Text.ToString().Trim();
                    
                    
                    STUDENT.Faculity = cmbFaculity.Text.ToString().Trim();
                    STUDENT.CCCD = txtCCCD.Text.ToString().Trim();
                    
                    STUDENT.BOD = DateTimeBOD.Value;
                    STUDENT.GioiTinh = "Male";
                    if (radFemale.Checked)
                    {
                        STUDENT.GioiTinh = "Female";
                    }
                   
                    STUDENT.DateCreate = DateTime.Now;
                   
                    STUDENT.Email = STUDENT.ID.ToString().Trim() + "@student.hcmute.edu.vn";
                    string receiveMail = "21102003tai@gmail.com";
                    OTP.Email = receiveMail;
                    OTP.SendEmail(receiveMail);
                    frmOTP otp = new frmOTP(); 
                    otp.ShowDialog();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    if (CheckNotNull(txtId)==false)
                    {
                        lblMaSV.Visible = true;
                    }
                    if (CheckNotNull(txtCCCD) == false)
                    {
                        labelCCCD.Visible = true;
                    }
                    if (CheckNotNull(txtFname) == false)
                    {
                        labelHo.Visible = true;
                    }
                    if (CheckNotNull(txtLname) == false)
                    {
                        labelTen.Visible = true;
                    }
                    if (cmbFaculity.SelectedItem==null)
                    {
                        labelKhoa.Visible = true;
                    }
                    if (CheckNotNull(txtPhone) == false)
                    {
                        lblSDT.Visible = true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private bool CheckNotNull(TextBox txt)
        {
            if (txt.Text.Trim() != "") { return true; }
            return false;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            lblMaSV.Visible = false;
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length == 8)
            {
                
               cmbFaculity.Focus();
            }
            
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Loại bỏ ký tự không phải số
            }
            if (textBox.Text.Length >= 8)
            {

                e.Handled = true; // Ngăn chặn nhập thêm ký tự nếu ô TextBox đã có 1 ký tự
            }
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // Kiểm tra nếu người dùng nhấn phím Delete và ô TextBox đang không trống
            if ( e.KeyCode != Keys.Delete && !string.IsNullOrEmpty(textBox.Text)&& textBox.Text.Length >= 8)
            {
                textBox.Text = ""; // Xóa ký tự trong ô TextBox
                e.Handled = true; // Ngăn không cho sự kiện được xử lý tiếp theo
            }
        }

        private void txtFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back &&!char.IsDigit(e.KeyChar) )
            {
                // Ngăn người dùng nhập ký tự số và ký tự đặc biệt vào TextBox
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Space || char.IsDigit(e.KeyChar))
                e.Handled = false;
        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {
            if(txtFname.Text !=" ") labelHo.Visible = false;
           
            TextBox textBox = (TextBox)sender;
            textBox.Text = RemoveNonAlphabeticCharacters(textBox.Text);
        }
        private string RemoveNonAlphabeticCharacters(string input)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in input)
            {
                // Kiểm tra nếu ký tự là ký tự chữ
                if (char.IsLetter(c)||c==' '||char.IsDigit(c))
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Loại bỏ ký tự không phải số
            }
            if (textBox.Text.Length >= 12)
            {

                e.Handled = true; // Ngăn chặn nhập thêm ký tự nếu ô TextBox đã có 1 ký tự
            }
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length == 12)
            {

                txtPhone.Focus();
            }
        }

        private void txtCCCD_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // Kiểm tra nếu người dùng nhấn phím Delete và ô TextBox đang không trống
            if (e.KeyCode != Keys.Delete && !string.IsNullOrEmpty(textBox.Text) && textBox.Text.Length >= 12)
            {
                textBox.Text = ""; // Xóa ký tự trong ô TextBox
                e.Handled = true; // Ngăn không cho sự kiện được xử lý tiếp theo
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Loại bỏ ký tự không phải số
            }
            if (textBox.Text.Length >= 10)
            {

                e.Handled = true; 
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length == 10)
            {

                btnOpenCam.Focus();
            }
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // Kiểm tra nếu người dùng nhấn phím Delete và ô TextBox đang không trống
            if (e.KeyCode != Keys.Delete && !string.IsNullOrEmpty(textBox.Text) && textBox.Text.Length >= 10)
            {
                textBox.Text = ""; // Xóa ký tự trong ô TextBox
                e.Handled = true; // Ngăn không cho sự kiện được xử lý tiếp theo
            }
        }

        private void cmbFaculity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbFaculity.SelectedIndex != null){
                labelKhoa.Visible = false;
            }
        }

        private void txtLname_TextChanged(object sender, EventArgs e)
        {
            labelTen.Visible = false;
            TextBox textBox = (TextBox)sender;
            textBox.Text = RemoveNonAlphabeticCharacters(textBox.Text);
        }
    }
}
