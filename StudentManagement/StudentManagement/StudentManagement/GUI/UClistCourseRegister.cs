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

namespace StudentManagement.GUI
{
    public partial class UClistCourseRegister : UserControl
    {
        public string student_id {  get; set; }
        Data data = new Data();
        XJDBC db = new XJDBC();
        ScoreDAO scoreDAO = new ScoreDAO();
        public string course_id {  get; set; }
        public string courseTableName = "Diem";
        public UClistCourseRegister()
        {
            InitializeComponent();
        }

        private void UClistCourseRegister_Load(object sender, EventArgs e)
        {
            btnDeleteCourse.Visible = false;
            fillData();
           
        }
         private void fillData()
        {
            string sql = "select kh.MaKH as MaKhoaHoc, kh.TenKH as TenKhoaHoc, kh.SoTC as SoTinChi, kh.HocKy, kh.NamHoc, CONCAT(gv.Ho,' ',gv.Ten) as GiangVien  from Diem d join KhoaHoc kh on d.MaKH = kh.MaKH join GiangVien gv on kh.MaGV =gv.MaGV where d.MaSV=@sid";
            Dictionary<string, object> values = new Dictionary<string, object>
            {
                
                { "@sid",  student_id}

            };
            data.fillData(sql,dataGVlistcourse,values);
            string sql_count = "select sum(kh.SoTC) as TongSoTC from Diem d join KhoaHoc kh on d.MaKH=kh.MaKH where d.MaSV='" + student_id + "' group by d.MaSV ";

            lblSumCre.Text = tongSoTC(sql_count).ToString();

        }
        private int tongSoTC(string sql)
        {
            int sum = 0;
            SqlCommand cmd = new SqlCommand(sql,db.getConnection);
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

        private void dataGVlistcourse_Click(object sender, EventArgs e)
        {
            try
            {
                course_id = dataGVlistcourse.CurrentRow.Cells[0].Value.ToString();
                if (course_id != null && course_id != "")
                    btnDeleteCourse.Visible = true;
                else
                {
                    btnDeleteCourse.Visible = false;
                }
            }
            catch { }
            
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if(course_id != null && course_id!="")
            {
                Dictionary<string,object> values = new Dictionary<string, object> {
                    {"MaSV",student_id}, {"MaKH",course_id}
                };
                if (scoreDAO.deleteScore(courseTableName, values))
                {
                    MessageBox.Show("Xoá học phần thành công!!!");
                    btnDeleteCourse.Visible=false;
                    fillData();
                }
            }
           
        }
    }
}
