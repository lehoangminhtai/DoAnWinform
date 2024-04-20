using StudentManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.GUI
{
    public partial class UpdateInfor : Form
    {
        public string id {  get; set; }
        public int role { get; set; }
        StudentDAO stdDao = new StudentDAO();
        public UpdateInfor()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void UpdateInfor_Load(object sender, EventArgs e)
        {
            if (role == 2)
            {
                groupBoxNT.Visible = false;
                lblFac.Visible = false;
                txtKhoa.Visible = false;
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                try { picBoxAnhSV.Image = Image.FromFile(opf.FileName); }
                catch { }
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();
                string addr = txtDiaChiSV.Text.Trim();
                string phone = txtSoDTsv.Text.Trim();
                string nameParents = txtHoTenNT.Text.Trim();
                string phoneParent = txtSoDTNT.Text.Trim();
                string id =lblMa.Text.Trim();
            MemoryStream pic = new MemoryStream();
            if (picBoxAnhSV.Image != null)
            {
                // Tạo một bản sao của hình ảnh từ picBoxAnhSV.Image
                using (MemoryStream tempStream = new MemoryStream())
                {
                    picBoxAnhSV.Image.Save(tempStream, picBoxAnhSV.Image.RawFormat);
                    tempStream.Position = 0;

                    // Copy dữ liệu từ bản sao vào MemoryStream
                    tempStream.CopyTo(pic);
                }
            }




            if (stdDao.validatData(email, addr, phone) && stdDao.isValidEmail(email)&& stdDao.isValidPhoneNumber(phone))
                {
                    if (role == 1 )
                    {
                        if (phoneParent!=""&& stdDao.isValidPhoneNumber(phoneParent) && nameParents!="" && stdDao.isValidName(nameParents))
                        {
                            string tableName = "HocSinh";
                            string condition = "MaSV = '" + id + "'";
                            Dictionary<string, object> dic = new Dictionary<string, object>
                            {
                                {"Email",email}, {"SDT",phone}, {"DiaChi",addr}, {"NguoiThanHT",nameParents}, {"NguoiThanSDT",phoneParent},{"HinhAnh",pic.ToArray()}
                            };
                            if(stdDao.updateStudent(tableName, dic, condition))
                            {
                                MessageBox.Show("Cập nhật thông tin thành công");
                                DialogResult = DialogResult.OK;
                            }
                        }
                        else
                        { MessageBox.Show("Vui lòng nhập đủ và đúng thông tin người thân!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    if(role==2)
                    {
                        string tableName = "GiangVien";
                        string condition = "MaGV = '" + id + "'";
                        Dictionary<string, object> dic = new Dictionary<string, object>
                            {
                                {"Email",email}, {"SDT",phone}, {"DiaChi",addr},{"HinhAnh",pic.ToArray()}
                            };
                        if (stdDao.updateStudent(tableName, dic, condition))
                        {
                            MessageBox.Show("Cập nhật thông tin thành công");
                            DialogResult = DialogResult.OK;
                        }
                    }
                }
                else
                    MessageBox.Show("Vui lòng nhập thông tin hợp lệ!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch {
                MessageBox.Show("Vui lòng nhập dữ liệu hợp lệ!!!","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
