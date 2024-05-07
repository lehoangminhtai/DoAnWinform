using DocumentFormat.OpenXml.Office2010.Excel;
using StudentManagement.DAO;
using StudentManagement.GUI.ScoreGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.GUI
{
    public partial class ADMINForm : Form
    {
        XJDBC db = new XJDBC();
        Data data = new Data();
        public string idCourse { get; set; }
        public string id_account { get; set; }

        public string id_auth { get; set; }
        public string name_auth { get; set; }
        public int role = 1;


        public ADMINForm()
        {
            InitializeComponent();
        }

        private void ADMINForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'giangVien._GiangVien' table. You can move, or remove it, as needed.
            this.giangVienTableAdapter.Fill(this.giangVien._GiangVien);

            this.hocSinhTableAdapter.Fill(this.quanLyHocTapDataSet.HocSinh);

            cmbUser.SelectedIndex = 0;

            fillDataGV("select * from HocSinh where TinhTrangTK = '1'", dataGVSVGV);
            fillDataGV("select * from GiangVien where TinhTrangTK = '1'", dataGvGV);
            fillDataCourse();
            fillDataAccount();
            //fillDataAuth();
            // fillDataGV("select hs.MaSV as \"Mã Sinh Viên\", hs.Ho as \"Họ\",hs.Ten as \"Tên\", hs.CCCD as \"Số CCCD\", hs.NgaySinh as \"Ngày Sinh\" , hs.SDT as \"Số Điện Thoại\", hs.HinhAnh as \"Hình Ảnh\", hs.GioiTinh as \"Giới Tính\", hs.DiaChi as \"Địa Chỉ\", hs.Email from HocSinh hs where hs.TinhTrangTK ='1'", dataGvWait);
        }
        public void fillDataCourse()
        {
            data.fillData("select k.MaKH as \"Mã Khoá Học\" , k.TenKH as \"Tên Khoá Học\", k.SoTC as \"Số Tín Chỉ\", k.MoTa as \"Mô Tả\", k.HocKy as \"Học Kỳ\", k.NamHoc as \"Năm Học\", k.TenFile as \"Giáo Trình\",CONCAT(v.Ho, ' ', v.Ten) as \"Giảng Viên\" from KhoaHoc k join GiangVien v on k.MaGV = v.MaGV", dataGvCourse);
        }
        public void fillDataAuthStd()
        {

            data.fillData("select hs.MaSV as \"Mã Sinh Viên\", hs.Ho as \"Họ\",hs.Ten as \"Tên\", hs.CCCD as \"Số CCCD\", hs.NgaySinh as \"Ngày Sinh\" , hs.SDT as \"Số Điện Thoại\", hs.HinhAnh as \"Hình Ảnh\", hs.GioiTinh as \"Giới Tính\", hs.DiaChi as \"Địa Chỉ\", hs.Email from HocSinh hs where hs.TinhTrangTK ='0'", dataGvWait);
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGvWait.Columns[6];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        public void fillDataAccount()
        {
            data.fillData(@"SELECT 
                        tk.MaNguoiDung AS ""Tên Đăng Nhập"", 
                        tk.MatKhau AS ""Mật Khẩu"", 
                        CASE 
                            WHEN tk.Quyen = 1 THEN N'Học Sinh'
                            WHEN tk.Quyen = 2 THEN N'Giáo Viên'
        
                        END AS ""Quyền"",
                        CASE 
                            WHEN tk.TrangThai = 1 THEN N'Hoạt Động'
                            WHEN tk.TrangThai = 0 THEN N'Khoá'
        
                        END AS ""Trạng Thái""
    
                    FROM 
                        TaiKhoan tk;
                    ", dataGvAccount);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void fillDataGV(String command, DataGridView dtgv)
        {
            db.openConnection();
            try
            {



                SqlCommand cmd = new SqlCommand(command, db.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                picCol = (DataGridViewImageColumn)dtgv.Columns[6];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dtgv.DataSource = dt;

                /*txtCourseID.Text = "";
                txtCourseName.Text = "";
                numPeriod.Value = 0;
                txtDescription.Text = "";*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void dataGVSVGV_Click(object sender, EventArgs e)
        {


        }

        private void dataGVSVGV_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ADMINUpdateSTD updateStdFrm = new ADMINUpdateSTD();
                updateStdFrm.role = 1;
                if (dataGVSVGV.CurrentRow.Cells[0].Value.ToString() != null)
                    updateStdFrm.lblMa.Text = dataGVSVGV.CurrentRow.Cells[0].Value.ToString();
                updateStdFrm.txtHo.Text = dataGVSVGV.CurrentRow.Cells[1].Value.ToString();
                updateStdFrm.txtTen.Text = dataGVSVGV.CurrentRow.Cells[2].Value.ToString();
                updateStdFrm.txtCCCD.Text = dataGVSVGV.CurrentRow.Cells[3].Value.ToString();
                updateStdFrm.dateOfB.Value = (DateTime)dataGVSVGV.CurrentRow.Cells[4].Value;
                updateStdFrm.txtSoDT.Text = dataGVSVGV.CurrentRow.Cells[5].Value.ToString();

                object value = dataGVSVGV.CurrentRow.Cells[6].Value;
                if (value != DBNull.Value)
                {
                    byte[] pic = (byte[])value;
                    MemoryStream picture = new MemoryStream(pic);
                    updateStdFrm.picBoxAnh.Image = Image.FromStream(picture);
                }
                else
                {
                    updateStdFrm.picBoxAnh.Image = null;
                }

                if (dataGVSVGV.CurrentRow.Cells[7].Value.ToString().Trim() == "Male")
                {
                    updateStdFrm.radNam.Checked = true;
                }
                else
                {
                    updateStdFrm.radNu.Checked = true;
                }

                updateStdFrm.txtDiaChi.Text = dataGVSVGV.CurrentRow.Cells[8].Value.ToString();
                updateStdFrm.cmbKhoa.Text = dataGVSVGV.CurrentRow.Cells[9].Value.ToString();
                if (dataGVSVGV.CurrentRow.Cells[10].Value == null || dataGVSVGV.CurrentRow.Cells[11].Value == null)
                {
                    updateStdFrm.txtHoTenNT.Text = "";
                    updateStdFrm.txtSoDTNT.Text = "";
                }
                else
                {
                    updateStdFrm.txtHoTenNT.Text = dataGVSVGV.CurrentRow.Cells[10].Value.ToString();
                    updateStdFrm.txtSoDTNT.Text = dataGVSVGV.CurrentRow.Cells[11].Value.ToString();
                }

                updateStdFrm.txtEmail.Text = dataGVSVGV.CurrentRow.Cells[14].Value.ToString();


                if (updateStdFrm.ShowDialog() == DialogResult.OK)
                {

                    updateStdFrm.Close();
                    ADMINForm_Load(sender, e);
                }

            }
            catch
            {
                MessageBox.Show("Lỗi lấy giá trị!!!");
            }
        }

        private void tabPageGV_Click(object sender, EventArgs e)
        {
            //fillDataGV("select * from GiangVien",dataGvGV);
        }

        private void dataGvGV_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ADMINUpdateSTD updateStdFrm = new ADMINUpdateSTD();
                updateStdFrm.role = 2;
                if (dataGvGV.CurrentRow.Cells[0].Value.ToString() != null)
                    updateStdFrm.lblMa.Text = dataGvGV.CurrentRow.Cells[0].Value.ToString();
                updateStdFrm.txtHo.Text = dataGvGV.CurrentRow.Cells[1].Value.ToString();
                updateStdFrm.txtTen.Text = dataGvGV.CurrentRow.Cells[2].Value.ToString();
                updateStdFrm.txtCCCD.Text = dataGvGV.CurrentRow.Cells[3].Value.ToString();
                updateStdFrm.dateOfB.Value = (DateTime)dataGvGV.CurrentRow.Cells[4].Value;
                updateStdFrm.txtSoDT.Text = dataGvGV.CurrentRow.Cells[5].Value.ToString();

                object value = dataGvGV.CurrentRow.Cells[6].Value;
                if (value != DBNull.Value)
                {
                    byte[] pic = (byte[])value;
                    MemoryStream picture = new MemoryStream(pic);
                    updateStdFrm.picBoxAnh.Image = Image.FromStream(picture);
                }
                else
                {
                    updateStdFrm.picBoxAnh.Image = null;
                }

                if (dataGvGV.CurrentRow.Cells[7].Value.ToString().Trim() == "Male")
                {
                    updateStdFrm.radNam.Checked = true;
                }
                else
                {
                    updateStdFrm.radNu.Checked = true;
                }

                updateStdFrm.txtDiaChi.Text = dataGvGV.CurrentRow.Cells[8].Value.ToString();

                updateStdFrm.txtEmail.Text = dataGvGV.CurrentRow.Cells[11].Value.ToString();

                updateStdFrm.groupBoxNT.Visible = false;

                if (updateStdFrm.ShowDialog() == DialogResult.OK)
                {

                    updateStdFrm.Close();
                    ADMINForm_Load(sender, e);
                }

            }
            catch
            {
                MessageBox.Show("Lỗi lấy giá trị!!!");
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            ADMINaddCourse addC = new ADMINaddCourse();
            if (addC.ShowDialog() == DialogResult.OK)
            {
                fillDataCourse();
            }


        }

        private void dataGvCourse_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (idCourse != "")
                {
                    /* UCCourse.id = dataGvCourse.CurrentRow.Cells[0].Value.ToString();
                     UCCourse.name = dataGvCourse.CurrentRow.Cells[1].Value.ToString();
                     UCCourse.numCrea = dataGvCourse.CurrentRow.Cells[2].Value.ToString();
                     UCCourse.des = dataGvCourse.CurrentRow.Cells[3].Value.ToString();

                     UCCourse.semester = dataGvCourse.CurrentRow.Cells[4].Value.ToString();
                     UCCourse.year = dataGvCourse.CurrentRow.Cells[5].Value.ToString();
                     UCCourse.filename = dataGvCourse.CurrentRow.Cells[6].Value.ToString();
                     UCCourse.teacherName = dataGvCourse.CurrentRow.Cells[7].Value.ToString();

                     ADMINCourse coursefrm = new ADMINCourse();
                     coursefrm.Show();*/

                    string cid = dataGvCourse.CurrentRow.Cells[0].Value.ToString();
                    string cName = dataGvCourse.CurrentRow.Cells[1].Value.ToString();
                    if (cid != null && cid != "")
                    {
                        StudentScore frmStdScore = new StudentScore();

                        frmStdScore.courseId = cid;
                        frmStdScore.courseName = cName;
                        frmStdScore.Show();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi lấy giá trị!!!");
            }
        }

        private void dataGvCourse_Click(object sender, EventArgs e)
        {
            try
            {


                if (dataGvCourse.CurrentRow.Cells[0].Value.ToString() != null)
                    idCourse = dataGvCourse.CurrentRow.Cells[0].Value.ToString();
                else
                    idCourse = null;
            }
            catch
            {

            }

        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {

            if (idCourse != "")
            {
                DialogResult result = MessageBox.Show("Người dùng và dữ liệu thuộc về khoá học sẽ bị xoá!!!\nBạn có chắc xoá khoá học?", "Xoá khoá học", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    Dictionary<string, object> values = new Dictionary<string, object>
                {
                { "MaKH",  idCourse}
                };
                    if (data.Delete("KhoaHoc", values))
                    {
                        MessageBox.Show("Xoá khoá học thành công!!!");
                        fillDataCourse();
                    }

                }
            }
        }

        private void dataGVSVGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLockAccount_Click(object sender, EventArgs e)
        {
            if (id_account != null && id_account != "")
            {
                DialogResult res = MessageBox.Show("Khoá Tài Khoản " + id_account, "Khoá Tài Khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    Dictionary<string, object> dic = new Dictionary<string, object>
                    {
                        {"TrangThai",0}
                    };
                    string condition = $" MaNguoiDung = '{id_account}'";
                    if (data.UpdateData("TaiKhoan", dic, condition))
                    {
                        MessageBox.Show("Đã Khoá Tài Khoản: " + id_account);
                        fillDataAccount();
                    }
                }
            }

        }

        private void dataGvAccount_Click(object sender, EventArgs e)
        {
            try
            {


                if (dataGvAccount.CurrentRow.Cells[0].Value.ToString() != null)
                    id_account = dataGvAccount.CurrentRow.Cells[0].Value.ToString();
                else
                    id_account = null;
            }
            catch
            {

            }
        }

        private void btbUnlockAccount_Click(object sender, EventArgs e)
        {
            if (id_account != null && id_account != "")
            {
                DialogResult res = MessageBox.Show("Mở Khoá Tài Khoản " + id_account, " Mở Khoá Tài Khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    Dictionary<string, object> dic = new Dictionary<string, object>
                    {
                        {"TrangThai",1}
                    };
                    string condition = $" MaNguoiDung = '{id_account}'";
                    if (data.UpdateData("TaiKhoan", dic, condition))
                    {
                        MessageBox.Show("Đã Mở Khoá Tài Khoản: " + id_account);
                        fillDataAccount();
                    }
                }
            }

        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            if (id_account != null && id_account != "")
            {
                DialogResult res = MessageBox.Show("Đặt Lại Mật Khẩu Cho Tài Khoản " + id_account, "Mật Khẩu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    string hashId_account = data.HashPassword(id_account);
                    Dictionary<string, object> dic = new Dictionary<string, object>
                    {
                        {"MatKhau",hashId_account}
                    };
                    string condition = $" MaNguoiDung = '{id_account}'";
                    if (data.UpdateData("TaiKhoan", dic, condition))
                    {
                        MessageBox.Show("Đã Đặt Lại Mật Khẩu Cho Tài Khoản: " + id_account + "Với mật khấu: " + id_account);
                        fillDataAccount();
                    }
                }
            }
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUser.SelectedIndex == 0)
            {
                role = 1;
                
                fillDataAuthStd();
            }
            else
            {
                role = 2;
                fillDataAuthTeacher();
            }
            id_auth = "";
            name_auth = "";
            lblName.Text = "";
        }
        public void fillDataAuthTeacher()
        {

            data.fillData("select hs.MaGV as \"Mã Giảng Viên\", hs.Ho as \"Họ\",hs.Ten as \"Tên\", hs.CCCD as \"Số CCCD\", hs.NgaySinh as \"Ngày Sinh\" , hs.SDT as \"Số Điện Thoại\", hs.HinhAnh as \"Hình Ảnh\", hs.GioiTinh as \"Giới Tính\", hs.DiaChi as \"Địa Chỉ\", hs.Email from GiangVien hs where hs.TinhTrangTK ='0'", dataGvWait);
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGvWait.Columns[6];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void btnTakeAcc_Click(object sender, EventArgs e)
        {
            takeacc();
        }

        private void takeacc()
        {
            string email = "";
           
            
            if(id_auth !="" && role != -1)
            {
                string tableName = "TaiKhoan";
                string hashPass = data.HashPassword(id_auth);

                Dictionary<string, object> dic = new Dictionary<string, object>
                {
                    {"MaNguoiDung",id_auth },{"MatKhau",hashPass},{"Quyen",role},{"TrangThai",1}
                };
                if (data.InsertData(tableName, dic))
                {
                    if (role == 1)
                    {
                        email = id_auth + "@student.hcmute.edu.vn";
                    }
                    else
                    {
                        email = id_auth + "@hcmute.edu.vn";
                    }
                    OTP otp =new OTP();
                    email = "21102003tai@gmail.com";
                    otp.OpenAcc(email,id_auth);

                    Dictionary<string, object> newdic = new Dictionary<string, object>();

                    if (role == 1)
                    {
                        tableName = "HocSinh";
                        newdic.Add("TinhTrangTK", 1);
                        string condition = $"MaSV = '{id_auth}'";
                        data.UpdateData(tableName, newdic, condition);
                        fillDataAuthStd();
                    }

                    else
                    {
                        tableName = "GiangVien";
                        newdic.Add("TinhTrangTK", 1);
                        string condition = $"MaGV = '{id_auth}'";
                        data.UpdateData(tableName, newdic, condition);
                        fillDataAuthTeacher();
                    }
                       
                }
            }
        }
        private void dataGvWait_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (dataGvWait.CurrentRow.Cells[0] != null)
                {
                    id_auth = dataGvWait.CurrentRow.Cells[0].Value.ToString();
                    name_auth = dataGvWait.CurrentRow.Cells[1].Value.ToString();
                    
                }
                else
                {
                    id_auth = "";
                    name_auth = "";

                }
                lblName.Text = name_auth;
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteAuth();
        }
        private void deleteAuth()
        {
            if (id_auth != "")
            {
                DialogResult res = MessageBox.Show("Gỡ Tài Khoản Này!!!", "Gỡ Tài Khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    string tableName = "";
                    Dictionary<string, object> dic = new Dictionary<string, object>(); 
                    if (role == 1)
                    {
                        dic.Add("MaSV", id_auth);
                        tableName = "HocSinh";
                    }

                    else
                    {
                        dic.Add("MaGV", id_auth);
                        tableName = "GiangVien";
                    }
                    if(data.Delete(tableName, dic))
                    {
                        MessageBox.Show("Đã gỡ tài khoản");
                        if (role == 1)
                            fillDataAuthStd();
                        else
                            fillDataAuthTeacher();
                    }
                        
                    
                }
            }
        }
    }
}
