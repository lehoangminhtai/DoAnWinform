using StudentManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            fillData();
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
                    
                    "CCCD","NgaySinh","SDT","GioiTinh","DiaChi","Khoa","NguoiThanHT" ,"NguoiThanSDT","Email"};
                condition = "MaSV = '" + id + "'";
                results = data.SelectData(tableName, columns, condition);
            }
            if(role==2)
            {
                tableName = "GiangVien";
                columns = new List<string> { "MaKH", "TenKH", "SoTC" };
                condition = "MaSV = '" + id + "'";
                results = data.SelectData(tableName, columns, condition);
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
            updateFrm.ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
