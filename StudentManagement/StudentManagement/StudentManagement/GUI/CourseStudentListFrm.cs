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

namespace StudentManagement.GUI
{
    public partial class CourseStudentListFrm : Form
    {
        public string courseId {  get; set; }
        public string courseName { get; set; }
        public string sid {  get; set; }
        CourseDAO courseDAO = new CourseDAO();
        ScoreDAO scoreDAO = new ScoreDAO();
        public CourseStudentListFrm()
        {
            InitializeComponent();
        }

        private void CourseStudentListFrm_Load(object sender, EventArgs e)
        {
            btnDeleteStd.Visible= false;
            lblCourseName.Text = courseName;
            fillData();
        }
        private void fillData()
        {
            string sql = "select hs.MaSV,CONCAT(hs.Ho,' ',hs.Ten) as HoTen, hs.NgaySinh,hs.Email from Diem d join HocSinh hs on d.MaSV = hs.MaSV where d.MaKH=@cid";
            Dictionary<string, object> values = new Dictionary<string, object>
            {

                { "@cid",  courseId}

            };
            courseDAO.fillData(sql, dataGvStdListCourse, values);
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sid != null && sid != "")
            {

                string courseTableName = "Diem";
                Dictionary<string, object> values = new Dictionary<string, object> {
                    {"MaSV",sid}, {"MaKH",courseId}     };

                if (scoreDAO.deleteScore(courseTableName, values))
                {
                    MessageBox.Show("Xoá sinh viên thành công!!!");
                    btnDeleteStd.Visible = false;
                    fillData();
                }

            }
        
        }

        private void dataGvStdListCourse_Click(object sender, EventArgs e)
        {
            sid = dataGvStdListCourse.CurrentRow.Cells[0].Value.ToString();
            btnDeleteStd.Visible = true;
        }

        private void CourseStudentListFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
