using StudentManagement.DAO;
using StudentManagement.Entity;
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
using static System.Resources.ResXFileRef;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentManagement.GUI.ForumGUI
{
    public partial class UcForum : UserControl
    {
        public string id_User {  get; set; }
        public int role {  get; set; }
        public int fid { get; set; }
        public string idCourse {  get; set; }
        Data data = new Data();
        XJDBC db =new XJDBC();
        ForumDAO forumDAO = new ForumDAO();
        public string condition = "";
        public string sql = "select d.MaDD,d.NoiDung,d.MaKH,d.MaNguoiTao,d.NgayTao from DienDan d where ";
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
            idCourse = cmbCourse.SelectedValue.ToString();

            
            fillListForum();
            
        }
        private void fillListForum( )
        {
            condition = $"d.MaKH ='{idCourse}'";
            SqlCommand cmd = new SqlCommand(sql+condition);

            showListForum(cmd);
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
                fillListForum();
            }
        }
        private bool insert()
        {
            try
            {
                string tablename = "DienDan";
                idCourse = cmbCourse.SelectedValue.ToString();
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
        private void showListForum(SqlCommand cmd)
        {
            int panelY = 10;
            panelContainer.Controls.Clear();
            List<FORUM> list = forumDAO.getListForum(cmd);
            foreach (var f in list)
            {
                Panel panelForum = new Panel();
                panelForum.BorderStyle = BorderStyle.FixedSingle;
                panelForum.Location = new Point(10, panelY);
                panelForum.Size = new Size(950, 100);
                panelForum.Margin = new Padding(10);
                panelForum.BackColor = Color.Transparent;

                LinkLabel labelName = new LinkLabel();
                labelName.Text = f.content;
                labelName.Location = new Point(20, 10);
                labelName.Font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
                labelName.ForeColor = Color.DarkCyan;
                labelName.AutoSize = true;
                labelName.Tag = f.ID;

                Label labelUserCreate = new Label();
                labelUserCreate.Text = "Người tạo:" + f.id_user;
                labelUserCreate.Location = new Point(20, 43);
                labelUserCreate.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);
                labelUserCreate.AutoSize = true;


                Label labelTime = new Label();
                labelTime.Text = "Ngày tạo: " + f.createDate.ToString("dd/MM/yyyy hh:mm");
                labelTime.Location = new Point(20, 68);
                labelTime.AutoSize = true;




                fid = f.ID;
                labelName.Click += (clicklabel, eventArgs) =>
                {
                    LinkLabel lblName = clicklabel as LinkLabel;
                    MessageBox.Show(f.ID+"");

                    
                };

               panelForum.Controls.Add(labelName);
                panelForum.Controls.Add(labelUserCreate);
                panelForum.Controls.Add(labelTime);

                panelY += panelForum.Height + 10;

                panelContainer.Controls.Add(panelForum);


            }
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            idCourse = cmbCourse.SelectedValue.ToString();
            fillListForum();
        }
    }
}
