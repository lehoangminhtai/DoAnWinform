using StudentManagement.DAO;
using StudentManagement.GUI.InformationGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.GUI
{
    public partial class UcInformation : UserControl
    {
        public string id {  get; set; }
        public int role {  get; set; }
        public string gender { get; set; }
        Data data = new Data();
        public UcInformation()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
        

       
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x00020000;
                var cp = base.CreateParams;
               
                cp.Style |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UcInformation_Load(object sender, EventArgs e)
        {
            try { 
            fillData();
        }
            catch { }
        }
        public void fillData()
        {
            string tableName;
            List<string> columns;
            string condition;
            Dictionary<string, object> results = new Dictionary<string, object>();
            if (role==1)
            {
                tableName = "HocSinh";
                columns = new List<string> { "MaSV", "CONCAT(Ho,' ',Ten) as HoTen",
                    
                    "CCCD","NgaySinh","SDT","GioiTinh","DiaChi","Khoa","NguoiThanHT" ,"NguoiThanSDT","Email","NgayTaoTK","TinhTrangTK","HinhAnh"};
                condition = "MaSV = '" + id + "'";
                results = data.SelectData(tableName, columns, condition);
            }
            if(role==2)
            {
                tableName = "GiangVien";
                columns = new List<string> { "MaGV", "CONCAT(Ho,' ',Ten) as HoTen",

                    "CCCD","NgaySinh","SDT","GioiTinh","DiaChi","Email","NgayTaoTK","TinhTrangTK","HinhAnh"};
                condition = "MaGV = '" + id + "'";
                results = data.SelectData(tableName, columns, condition);

                groupBoxNT.Visible = false;
                lblFac.Visible = false;
                lblKhoa.Visible = false;
                lblJoin.Text = "Ngày bắt đầu giảng dạy: ";
                lblId.Text = "Mã Giảng Viên: ";
            }

            if (results != null && results.Count > 0)
            {
                // Lấy dòng dữ liệu đầu tiên từ kết quả truy vấn
                Dictionary<string, object> result = results;

                // Kiểm tra và gán giá trị cho các label
                if (result.ContainsKey("MaSV"))
                {
                    lblMaSV.Text = result["MaSV"].ToString();
                }
                if (result.ContainsKey("MaGV"))
                {
                    lblMaSV.Text = result["MaGV"].ToString();
                }
                if (result.ContainsKey("HoTen"))
                {
                    lblHoTenSV.Text = result["HoTen"].ToString();
                }
                if (result.ContainsKey("CCCD"))
                {
                    lblCCCD.Text = result["CCCD"].ToString();
                }
                if (result.ContainsKey("NgaySinh"))
                {
                    if (result["NgaySinh"] is DateTime)
                    {
                        DateTime ngaySinh = (DateTime)result["NgaySinh"];
                       
                        lblNgaySinh.Text = ngaySinh.ToString("d");
                    }
                    
                }
                if (result.ContainsKey("SDT"))
                {
                    lblSoDTSv.Text = result["SDT"].ToString();
                }
                if (result.ContainsKey("GioiTinh"))
                {
                    gender = result["GioiTinh"].ToString().Trim();
                    if (gender == "Male")
                        lblGioiTinh.Text = "Nam";
                    if (gender == "Female")
                        lblGioiTinh.Text = "Nữ";
                }
                if (result.ContainsKey("DiaChi"))
                {
                    
                    lblDiaChiSV.Text = result["DiaChi"].ToString();

                }
                if (result.ContainsKey("Khoa"))
                {
                    lblKhoa.Text = result["Khoa"].ToString();
                }
                
                if (result.ContainsKey("NguoiThanHT"))
                {
                    lblHoTenNT.Text = result["NguoiThanHT"].ToString();
                }
                if (result.ContainsKey("NguoiThanSDT"))
                {
                    lblsoDTNT.Text = result["NguoiThanSDT"].ToString();
                }
                if (result.ContainsKey("Email"))
                {
                    lblEmail.Text = result["Email"].ToString();
                }
                if (result.ContainsKey("NgayTaoTK"))
                {
                   

                    if (result["NgayTaoTK"] is DateTime)
                    {
                        DateTime ngayNH = (DateTime)result["NgayTaoTK"];

                        lblNgayNhapHoc.Text = ngayNH.ToString("d");
                    }
                }
                if (result.ContainsKey("TinhTrangTK"))
                {
                    int i = Convert.ToInt32(result["TinhTrangTK"].ToString());
                    if (i == 0)
                    {
                       
                        lblTinhTrang.Text = "Ngưng hoạt động";
                    }
                    else
                        lblTinhTrang.Text = "Còn hoạt động";

                }

                if (result.ContainsKey("HinhAnh"))
                {
                    try
                    {
                        object value = result["HinhAnh"];
                        if (value != DBNull.Value)
                        {
                            byte[] pic = (byte[])value;
                            MemoryStream picture = new MemoryStream(pic);
                            picBoxAnhSV.Image = Image.FromStream(picture);
                        }
                        else
                        {
                            picBoxAnhSV.Image= null;
                        }

                        
                    }
                    catch { }
                    

                }

            }
            else
            {
                MessageBox.Show("Không có dữ liệu hoặc có lỗi xảy ra khi lấy dữ liệu từ cơ sở dữ liệu!");
            }


        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateInfor updateFrm = new UpdateInfor();
            updateFrm.id = id;
            updateFrm.role = role;

            updateFrm.lblMa.Text = lblMaSV.Text;
            updateFrm.lblTen.Text = lblHoTenSV.Text;
            updateFrm.txtEmail.Text = lblEmail.Text;
            if (gender == "Male")
                updateFrm.radNam.Checked = true;
            if (gender == "Female")
                updateFrm.radNu.Checked = true;
            updateFrm.txtCCCD.Text = lblCCCD.Text;

            string ngaySinhStr = lblNgaySinh.Text;
            DateTime ngaySinh;

            if (DateTime.TryParseExact(ngaySinhStr, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaySinh))
            {
                updateFrm.dateOfB.Value = ngaySinh;
            }

            updateFrm.txtKhoa.Text = lblKhoa.Text;
            updateFrm.txtDiaChiSV.Text = lblDiaChiSV.Text;
            updateFrm.txtSoDTsv.Text = lblSoDTSv.Text;
             
            updateFrm.txtHoTenNT.Text = lblHoTenNT.Text;
            updateFrm.txtSoDTNT.Text = lblsoDTNT.Text;

            updateFrm.picBoxAnhSV.Image = picBoxAnhSV.Image;
            if(updateFrm.ShowDialog()==DialogResult.OK)
            {
                fillData();
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            LoginByFace frm = new LoginByFace();
            frm.id_user = id;
            frm.ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnChangPass_Click(object sender, EventArgs e)
        {
            ChangPassFrm frm = new ChangPassFrm();
            frm.id_user = id;
            if(frm.ShowDialog()== DialogResult.OK )
            {
                MessageBox.Show("Đổi mật khẩu thành công !!!");
            }
        }
    }
}
