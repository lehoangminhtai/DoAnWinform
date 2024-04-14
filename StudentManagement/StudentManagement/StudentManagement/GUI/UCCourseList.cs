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

namespace StudentManagement.GUI
{
    public partial class UCCourseList : UserControl
    {
        public string sid { get; set; }
        public int role {  get; set; }
        public string cid {  get; set; }
        ScoreDAO scoreDAO = new ScoreDAO();
        CourseDAO courseDAO = new CourseDAO();
        Data data = new Data();
        public UCCourseList()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UCCourseList_Load(object sender, EventArgs e)
        {
            fillData();
        }
        private void fillData()
        {
            (string year, string semester) = data.GetYearAndSemester();
            if (role == 1)
            {
                SqlCommand cmd = new SqlCommand("Select d.MaKH, kh.TenKH, kh.HocKy,kh.NamHoc, CONCAT(gv.Ho, ' ', gv.Ten) as GiangVien,kh.SoTC, kh.MoTa,kh.TenFile  from Diem d join KhoaHoc kh on d.MaKH = kh.MaKH join GiangVien gv on kh.MaGV = gv.MaGV where d.MaSV='" + sid + "' and kh.NamHoc like '%" + year + "%' and kh.HocKy ='"+ semester + "'");
                showListCourse(cmd);
            }
        }
        private void showListCourse(SqlCommand cmd)
        {

            //panelCourseList.Controls.Clear();

            int panelY = 50;
            
            List<COURSE> list = scoreDAO.getListCourse(cmd);
            foreach (var c in list)
            {
                Panel panelCourse = new Panel();
                panelCourse.BorderStyle = BorderStyle.FixedSingle;
                panelCourse.Location = new Point(10, panelY);
                panelCourse.Size = new Size(750, 130);
                panelCourse.Margin = new Padding(10);
                panelCourse.BackColor = Color.Turquoise;

                LinkLabel labelName = new LinkLabel();
                labelName.Text = c.name;
                labelName.Location = new Point(20, 10);
                labelName.Font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
                labelName.ForeColor = Color.DarkCyan;
                labelName.AutoSize = true;
                labelName.Tag = c.id;

                Label labelSemester = new Label();
                labelSemester.Text ="Học kỳ:"+ c.semester;
                labelSemester.Location = new Point(20, 35);
                labelSemester.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);
               


                Label labelYear = new Label();
                labelYear.Text = "Năm học: " + c.year;
                labelYear.Location = new Point(20, 65);
                labelYear.AutoSize = true;

                Label labelTeacher = new Label();
                labelTeacher.Text = "Giảng viên: " + c.teacherName;
                labelTeacher.Location = new Point(20, 90);
                labelTeacher.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Italic);
                labelTeacher.AutoSize = true;


                cid = c.id;
                labelName.Click += (clicklabel, eventArgs) =>
                {
                    LinkLabel lblName = clicklabel as LinkLabel;
                    cid = lblName.Tag as string;
                   UCCourse ucCourse = new UCCourse();
                    ucCourse.role = role;
                    UCCourse.id = cid;
                    UCCourse.name = c.name;
                    UCCourse.teacherName = c.teacherName;
                    UCCourse.semester = c.semester;
                    UCCourse.year = c.year;
                    UCCourse.des = c.description;
                    UCCourse.numCrea = c.numCrea;
                    UCCourse.filename = c.nameFile;

                    panelCourseList.Controls.Clear();
                    panelCourseList.Controls.Add(ucCourse);
                };
                
                panelCourse.Controls.Add(labelName);
                panelCourse.Controls.Add(labelSemester);
                panelCourse.Controls.Add(labelYear);
                panelCourse.Controls.Add(labelTeacher);
                

                panelY += panelCourse.Height + 10;

                panelCourseList.Controls.Add(panelCourse);


            }
            
        }
        private void selectCourse()
        {
            string tableName;
            List<string> columns;
            string condition;
            Dictionary<string, object> results = new Dictionary<string, object>();
            if (role == 1)
            {
                tableName = "KhoaHoc";
                columns = new List<string> { "MaKH","TenKH","SoTC","MoTa","TenFile","NamHoc","HocKy","",

                    "CCCD","NgaySinh","SDT","GioiTinh","DiaChi","Khoa","NguoiThanHT" ,"NguoiThanSDT","Email","NgayTaoTK","TinhTrangTK","HinhAnh"};
                condition = "MaSV = '" + cid + "'";
                results = courseDAO.selectCourse(tableName, columns, condition);
            }
        }
    }
}
