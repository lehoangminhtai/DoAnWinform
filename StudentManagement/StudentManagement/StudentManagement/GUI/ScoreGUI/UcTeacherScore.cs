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
    public partial class UcTeacherScore : UserControl
    {
        public string id_teacher { get; set; }
        Data data = new Data();
        XJDBC db = new XJDBC();
        public string cid { get; set; }
        public string name { get; set; }
        public string numcre { get; set; }
        public string des { get; set; }
        public UcTeacherScore()
        {
            InitializeComponent();
        }

        private void UcTeacherScore_Load(object sender, EventArgs e)
        {
            fillData();
            getInfor();
        }

        private void fillData()
        {
            (string year, string semester) = data.GetYearAndSemester();
            string sql = "SELECT KH.MaKH as \"Mã Khoá Học\", KH.TenKH as \"Tên Khoá Học\",KH.SoTC as \"Số Tín Chỉ\",KH.MoTa as \"Mô Tả\",KH.HocKy as \"Học Kỳ\",Kh.NamHoc as \"Năm Học\", COUNT(DISTINCT DS.MaSV) AS \"Số Lượng SV\"" +
                   " FROM KhoaHoc KH "
                   + "  LEFT JOIN Diem DS ON KH.MaKH = DS.MaKH"
                    + " WHERE KH.MaGV = @tid  and kh.NamHoc like '%" + year + "%' and kh.HocKy ='" + semester + "' GROUP BY KH.MaKH, KH.TenKH, KH.SoTC,KH.MoTa,KH.HocKy,Kh.NamHoc";


            Dictionary<string, object> values = new Dictionary<string, object>
            {

                { "@tid",  id_teacher }

            };
            data.fillData(sql, dataGVlistCourse, values);
           
        }

        private void getInfor()
        {
            (string year, string semester) = data.GetYearAndSemester();
            lblSemester.Text = semester;
            if(semester =="HK2" || semester == "HK3")
            {
                int yearInt = Convert.ToInt32(year);
                lblYear.Text = (yearInt - 1)+"-" +year;
            }
            else
            {
                int yearInt = Convert.ToInt32(year);
                lblYear.Text = year+"-"+ (yearInt +1);
            }
        }
        private void dataGVlistCourse_DoubleClick(object sender, EventArgs e)
        {

            string cid = dataGVlistCourse.CurrentRow.Cells[0].Value.ToString();
            string cName = dataGVlistCourse.CurrentRow.Cells[1].Value.ToString();
            if(cid !=null && cid != "")
            {
                StudentScore frmStdScore = new StudentScore();

                frmStdScore.courseId = cid;
                frmStdScore.courseName = cName;
                frmStdScore.Show();
            }
            
            
        }
    }
}
