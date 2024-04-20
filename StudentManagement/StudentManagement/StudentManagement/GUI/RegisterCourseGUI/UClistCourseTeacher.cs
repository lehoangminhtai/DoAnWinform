using StudentManagement.DAO;
using StudentManagement.GUI.RegisterCourseGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.GUI
{
    public partial class UClistCourseTeacher : UserControl
    {
        public string id_teacher {  get; set; }
        Data data = new Data();
        XJDBC db = new XJDBC();
        public string cid {  get; set; }
        public string name { get; set; }
        public string numcre { get; set; }
        public string des { get; set; }
        public UClistCourseTeacher()
        {
            InitializeComponent();
        }

        private void UClistCourseTeacher_Load(object sender, EventArgs e)
        {
            fillData();
        }
        private void fillData()
        {
            (string year, string semester) = data.GetYearAndSemester();
            string sql = @"SELECT KH.MaKH as MaKhoaHoc, KH.TenKH as TenKhoaHoc,KH.SoTC,KH.MoTa,KH.HocKy,Kh.NamHoc, COUNT(DISTINCT DS.MaSV) AS SoLuongSV
                    FROM KhoaHoc KH
                    LEFT JOIN Diem DS ON KH.MaKH = DS.MaKH
                    WHERE KH.MaGV = @tid  and kh.NamHoc like '%" + year + "%' and kh.HocKy ='"+ semester + "' GROUP BY KH.MaKH, KH.TenKH, KH.SoTC,KH.MoTa,KH.HocKy,Kh.NamHoc";


           
            Dictionary<string, object> values = new Dictionary<string, object>
            {

                { "@tid",  id_teacher }

            };
            data.fillData(sql, dataGVlistCourse, values);
            string sql_count = "select COUNT(kh.MaKH) as TongSoMon from KhoaHoc kh  where kh.MaGV='"+id_teacher+ "'and kh.NamHoc like '%" + year + "%' and kh.HocKy ='"+ semester + "' group by kh.MaGV ";

            lblCountCourse.Text = countCourse(sql_count).ToString();
        }
        private int countCourse(string sql)
        {
            int sum = 0;
            SqlCommand cmd = new SqlCommand(sql, db.getConnection);
            db.openConnection();
            object result = cmd.ExecuteScalar();

            // Kiểm tra xem kết quả có tồn tại không
            if (result != null)
            {

                sum = Convert.ToInt32(result);
            }
            else
                sum = 0;
            db.closeConnection();
            return sum;

        }

        private void dataGVlistCourse_DoubleClick(object sender, EventArgs e)
        {
            string cid = dataGVlistCourse.CurrentRow.Cells[0].Value.ToString();
            string cName = dataGVlistCourse.CurrentRow.Cells[1].Value.ToString();

            CourseStudentListFrm lstStdFrm = new CourseStudentListFrm();
            lstStdFrm.courseId = cid;
            lstStdFrm.courseName = cName;
            if (lstStdFrm.ShowDialog() == DialogResult.OK)
            {
                fillData();
            }
            
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            AddCourseFrm frm = new AddCourseFrm();
            frm.teacherId = id_teacher;
            if(frm.ShowDialog() == DialogResult.OK)
            {
                fillData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if(cid !=null && cid != "")
            {
                string tablename = "KhoaHoc";
                Dictionary<string, object> dic = new Dictionary<string, object>
                {
                    {"MaKH", cid},
                };
                DialogResult res = MessageBox.Show("Bạn có chác xoá khoá học này","Xoá Khoá học",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    CourseDAO courseDAO = new CourseDAO();
                    if(courseDAO.deleteCourse(tablename, dic))
                    {
                        MessageBox.Show("Xoá Khoá học thành công!!!");
                        fillData();
                    }
                }

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try {
                
               
                if (cid != null && cid != "")
                {
                    UpdateCourseFrm frm = new UpdateCourseFrm();
                    frm.cid = cid;
                    frm.name = name;
                    frm.numcre = numcre;
                    frm.des = des;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        fillData();
                    }

                }
            }
            catch { }
            
        }

        private void dataGVlistCourse_Click(object sender, EventArgs e)
        {
            cid = dataGVlistCourse.CurrentRow.Cells["MaKhoaHoc"].Value.ToString();
             name = dataGVlistCourse.CurrentRow.Cells["TenKhoaHoc"].Value.ToString();
             numcre = dataGVlistCourse.CurrentRow.Cells["SoTC"].Value.ToString();
             des = dataGVlistCourse.CurrentRow.Cells["MoTa"].Value.ToString();
        }
    }
}
