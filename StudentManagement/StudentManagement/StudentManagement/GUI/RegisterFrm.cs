
using Emgu.CV;
using StudentManagement.DAO;
using StudentManagement.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace StudentManagement
{
    public partial class RegisterFrm : Form
    {
        FaceRec faceRec = new FaceRec();
        
        StudentDAO studentDAO = new StudentDAO();
        TeacherDao teacherDao = new TeacherDao();  
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

            pictureBox1.Image = Image.FromFile("../../Image/bg_login.jpg");
            radMale.Checked = true;
            radMaleGV.Checked = true;
            tabPage1.Text = "Sinh Viên";
            tabPage2.Text = "Giảng viên";

            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try { 
            
                if(CheckNotNull(txtId)&& CheckNotNull(txtFname) && CheckNotNull(txtLname) && CheckNotNull(txtPhone) && CheckNotNull(txtCCCD) && cmbFaculity.SelectedItem!=null) {
                    if(txtId.Text.Trim().Length == 8) { 
                        STUDENT.ID = txtId.Text.ToString().Trim();
                    
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập đúng mã SV!!!", "Lỗi Mã SV",MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    }
                    
                    if (!Regex.IsMatch(txtFname.Text.Trim(), @"^[\p{L}\s]+$"))
                    {
                        
                        MessageBox.Show("vVui lòng nhập họ hợp lệ", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        STUDENT.Fname = txtFname.Text.ToString().Trim();
                    }

                    string lname = txtLname.Text.Trim();
                    if (!Regex.IsMatch(lname, @"^[\p{L}\s]+$"))
                    {
                        MessageBox.Show("Vui lòng nhập tên hợp lệ!!!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string cccd = txtCCCD.Text.Trim();
                    if (!Regex.IsMatch(cccd, @"^\d{12}$"))
                    {
                        MessageBox.Show("Vui lòng nhập đúng số CCCD", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        STUDENT.CCCD = txtCCCD.Text.ToString().Trim();
                    }
                   
                    
                    STUDENT.BOD = DateTimeBOD.Value;
                    STUDENT.GioiTinh = "Male";
                    if (radFemale.Checked)
                    {
                        STUDENT.GioiTinh = "Female";
                    }
                   
                    STUDENT.DateCreate = DateTime.Now;
                    int born_year = DateTimeBOD.Value.Year;
                    int this_year = DateTime.Now.Year;
                    //  sv tu 10-100,  co the thay doi
                    if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
                    {
                        MessageBox.Show("Sinh viên phải từ 10 tuổi đến 100 tuổi!!!", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                       

                        OTP.role = 1;
                        STUDENT.Email = STUDENT.ID.ToString().Trim() + "@student.hcmute.edu.vn";
                        string receiveMail = "21102003tai@gmail.com";
                        if (studentDAO.CheckUserExist())
                        {
                            
                                MemoryStream pic = new MemoryStream();
                                picCaptured.Image.Save(pic, picCaptured.Image.RawFormat);
                                STUDENT.Image = pic;
                                OTP.Email = receiveMail;
                            
                                OTP.SendEmail(receiveMail);
                                //frmOTP otp = new frmOTP();

                                this.DialogResult = DialogResult.OK;
                            
                          
                            //otp.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Mã SV: " + STUDENT.ID + " đã đăng ký hoặc đang chờ xác nhận từ ADMIN!!!", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                           
                        }
                       
                    }
                   
                    
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
            labelCCCD.Visible = false;  
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
            lblSDT.Visible = false;
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length == 10)
            {

                btnCap.Focus();
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

        private void btnDKGV_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckNotNull(txtIdGV) && CheckNotNull(txtHoGV) && CheckNotNull(txtTenGV) && CheckNotNull(txtSDTGV) && CheckNotNull(txtCCCDGV) )
                {
                    
                    TEACHER.ID = txtIdGV.Text.ToString().Trim();

                    if (!Regex.IsMatch(txtHoGV.Text.Trim(), @"^[\p{L}\s]+$"))
                    {

                        MessageBox.Show("Vui lòng nhập họ hợp lệ", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        TEACHER.Fname = txtHoGV.Text.ToString().Trim();
                    }

                    string lname = txtTenGV.Text.Trim();
                    if (!Regex.IsMatch(lname, @"^[\p{L}\s]+$"))
                    {
                        MessageBox.Show("Vui lòng nhập tên hợp lệ!!!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        TEACHER.Lname = txtTenGV.Text.ToString().Trim();
                    }
                    string phone = txtSDTGV.Text.Trim();
                    if (!Regex.IsMatch(phone, @"^\d{10}$"))
                    {
                        MessageBox.Show("Vui lòng nhập đúng số ĐT (VN)", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        TEACHER.Phone = txtSDTGV.Text.ToString().Trim();
                    }



                    string cccd = txtCCCDGV.Text.Trim();
                    if (!Regex.IsMatch(cccd, @"^\d{12}$"))
                    {
                        MessageBox.Show("Vui lòng nhập đúng số CCCD", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        TEACHER.CCCD = txtCCCDGV.Text.ToString().Trim();
                    }


                    TEACHER.BOD = dateTimeBODGV.Value;
                    TEACHER.GioiTinh = "Male";
                    if (radFemaleGV.Checked)
                    {
                        TEACHER.GioiTinh = "Female";
                    }
                   
                    int born_year = dateTimeBODGV.Value.Year;
                    int this_year = DateTime.Now.Year;

                    

                    if (((this_year - born_year) < 22) || ((this_year - born_year) > 100))
                    {
                        MessageBox.Show("Độ tuổi không hợp lệ!!!", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        
                           

                            TEACHER.DateCreate = DateTime.Now;

                            TEACHER.Email = TEACHER.ID.ToString().Trim() + "@hcmute.edu.vn";
                            string receiveMail = "21102003tai@gmail.com";
                            if (teacherDao.CheckUserExist())
                            {

                                MemoryStream pic = new MemoryStream();
                                picCapturedGV.Image.Save(pic, picCapturedGV.Image.RawFormat);
                                TEACHER.Image = pic;

                                OTP.Email = receiveMail;
                                OTP.role = 2; //là giáo viên

                                OTP.SendEmail(receiveMail);
                                //frmOTP otp = new frmOTP();
                                this.DialogResult = DialogResult.OK;
                                //otp.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Mã GV: " + TEACHER.ID + " đã đăng ký hoặc đang chờ xác nhận từ ADMIN!!!", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                       

                    }
                    
                   
                }
                else
                {
                    if (CheckNotNull(txtIdGV) == false)
                    {
                        lblMaGV.Visible = true;
                    }
                    if (CheckNotNull(txtCCCDGV) == false)
                    {
                        lblCCCDGV.Visible = true;
                    }
                    if (CheckNotNull(txtHoGV) == false)
                    {
                        lblHoGV.Visible = true;
                    }
                    if (CheckNotNull(txtTenGV) == false)
                    {
                        lblTenGV.Visible = true;
                    }
                   
                    if (CheckNotNull(txtSDTGV) == false)
                    {
                        lblSDTGV.Visible = true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtIdGV_TextChanged(object sender, EventArgs e)
        {
            lblMaGV.Visible=false;
        }

        private void txtHoGV_TextChanged(object sender, EventArgs e)
        {
            lblHoGV.Visible=false;
            TextBox textBox = (TextBox)sender;
            textBox.Text = RemoveNonAlphabeticCharacters(textBox.Text);
        }

        private void txtTenGV_TextChanged(object sender, EventArgs e)
        {
            lblTenGV.Visible=false;
            TextBox textBox = (TextBox)sender;
            textBox.Text = RemoveNonAlphabeticCharacters(textBox.Text);
        }

        private void txtCCCDGV_TextChanged(object sender, EventArgs e)
        {
            lblCCCDGV.Visible = false;
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length == 12)
            {

                txtSDTGV.Focus();
            }
        }

        private void txtSDTGV_TextChanged(object sender, EventArgs e)
        {
            lblSDTGV.Visible = false;
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length == 10)
            {

                btnCapturedGV.Focus();
            }
        }

        

        private void btnCap_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                picCaptured.Image = Image.FromFile(opf.FileName);
            }
            //picCaptured.Image = picCam.Image;

            //STUDENT.Image = picCaptured.Image;
            /*StudentDAO stdDao= new StudentDAO();
            string id = txtId.Text.Trim();
            if (id !="" && id.Length==8)
            {
                if (stdDao.CheckUserExist(id))
                {
                    faceRec.Save_IMAGE(txtId.Text.Trim());
                    picCaptured.Image = picCam.Image;
                    MessageBox.Show("Xác thực khuôn mặt thành công!!!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tài khoản đã đăng ký hoặc đang xác thực. \nVui lòng đăng ký nhận dạng khuông mặt trong hồ sơ cá nhân!!!","Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng mã sinh viên để xác thực!!!","Thông tin",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }*/
            

           
            
        }

        private void btnCapturedGV_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                picCapturedGV.Image = Image.FromFile(opf.FileName);
            }
            /*TeacherDao teacherDao = new TeacherDao();
            string id = txtIdGV.Text.Trim();
            if (id != "")
            {
                if (teacherDao.CheckUserExist(id))
                {
                    faceRec.Save_IMAGE(id);
                    picCapturedGV.Image = picCamGV.Image;
                    MessageBox.Show("Xác thực khuôn mặt thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tài khoản đã đăng ký hoặc đang xác thực. \nVui lòng đăng ký nhận dạng khuông mặt trong hồ sơ cá nhân!!!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng mã giảng viên để xác thực!!!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }

       
    }
}
