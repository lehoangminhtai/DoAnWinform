using StudentManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentManagement.GUI.ForumGUI
{
    public partial class UcForum : UserControl
    {
        public string id_User {  get; set; }
        public int role {  get; set; }
        Data data = new Data();
        XJDBC db =new XJDBC();
        ForumDAO forumDAO = new ForumDAO();
        
        public UcForum()
        {
            InitializeComponent();
        }

        private void UcForum_Load(object sender, EventArgs e)
        {
           fillData();
        }
        private void fillData()
        {
            cmbUser.SelectedIndex = 0;
            fillCmbCourse();
            
        }
        private void fillCmbCourse()
        {
            try
            {
                (string year, string semester) = data.GetYearAndSemester();
                string sql = "";
                if (role == 1)
                {
                     sql = "Select d.MaKH, kh.TenKH from Diem d join KhoaHoc kh on d.MaKH = kh.MaKH join GiangVien gv on kh.MaGV = gv.MaGV where d.MaSV='" + id_User + "' and kh.NamHoc like '%" + year + "%' and kh.HocKy ='" + semester + "'";
                    
                }
                if (role == 2)
                {
                   sql = "Select kh.MaKH, kh.TenKH from KhoaHoc kh join GiangVien gv on kh.MaGV=gv.MaGV where kh.MaGV= '" + id_User + "' and kh.NamHoc like '%" + year + "%' and kh.HocKy ='" + semester + "'";
                   
                }
                db.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, db.getConnection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                cmbCourse.DisplayMember = "TenKH"; // DisplayMember is the column name for display
                cmbCourse.ValueMember = "MaKH";     // ValueMember is the column name for value
                cmbCourse.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đường dẫn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { db.closeConnection(); }
        }

        private void btnUpQuest_Click(object sender, EventArgs e)
        {
            if (insert())
            {
                MessageBox.Show("Đã đăng bài!!!");
                txtQuestion.Text = "";
            }
        }
        private bool insert()
        {
            try
            {
                string tablename = "DienDan";
                string idCourse = cmbCourse.SelectedValue.ToString();
                DateTime currentDate = DateTime.Now;
                string content = txtQuestion.Text.Trim();
                if(content != "")
                {
                    Dictionary<string, object> data = new Dictionary<string, object>
                    {
                        {"NoiDung",content}, {"MaKH",idCourse}, {"MaNguoiTao",id_User}, {"NgayTao",currentDate }
                    };
                    return forumDAO.insertForum(tablename, data);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập câu hỏi muốn đăng!!", "Đăng bài", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
