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

namespace StudentManagement.GUI.ScoreGUI
{
    public partial class StudentScore : Form
    {
        public string courseId { get; set; }
        public string courseName { get; set; }
        public string sid { get; set; }
        CourseDAO courseDAO = new CourseDAO();
        ScoreDAO scoreDAO = new ScoreDAO();
        public StudentScore()
        {
            InitializeComponent();
        }

        private void StudentScore_Load(object sender, EventArgs e)
        {
            fillData();
            lblCourseName.Text = courseName;
        }
        private void fillData()
        {
            string sql = "select hs.MaSV as \"Mã Sinh Viên\",CONCAT(hs.Ho,' ',hs.Ten) as \"Họ Tên\", hs.NgaySinh as \"Ngày Sinh\",hs.Email, d.DiemQT as \"Điểm Quá Trình\", d.DiemCuoiKy as \"Điểm Cuối Kỳ\", d.DiemTongKet as \"Điểm Tổng\", d.TrangThai as \"Xếp Loại\" from Diem d join HocSinh hs on d.MaSV = hs.MaSV where d.MaKH=@cid";
            Dictionary<string, object> values = new Dictionary<string, object>
            {

                { "@cid",  courseId}

            };
            courseDAO.fillData(sql, dataGvStdListCourse, values);

        }

        private void StudentScore_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGvStdListCourse_DoubleClick(object sender, EventArgs e)
        {
            sid = dataGvStdListCourse.CurrentRow.Cells[0].Value.ToString();
            string fullName = dataGvStdListCourse.CurrentRow.Cells[1].Value.ToString();
            string scoreMid = dataGvStdListCourse.CurrentRow.Cells[4].Value.ToString();
            string scoreLast = dataGvStdListCourse.CurrentRow.Cells[5].Value.ToString();
            if (sid != null && sid!="")
            {
                EnterStudentScore frm = new EnterStudentScore();
                frm.id_student = sid;
                frm.id_course = courseId;
                frm.nameStd = fullName;
                frm.scoreMid = scoreMid;
                frm.scoreLast = scoreLast;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    fillData();
                }
            }


        }
    }
}
