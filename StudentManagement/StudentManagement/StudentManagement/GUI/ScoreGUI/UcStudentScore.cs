using StudentManagement.DAO;
using StudentManagement.Entity;
using StudentManagement.GUI.ReportGUI;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentManagement.GUI.ScoreGUI
{
    public partial class UcStudentScore : UserControl
    {
        XJDBC db = new XJDBC();
        ScoreDAO scoreDAO = new ScoreDAO();
        public string id_student { get; set; }
        public UcStudentScore()
        {
            InitializeComponent();
        }

        private void UcStudentScore_Load(object sender, EventArgs e)
        {
            fillData();
        }

        private void fillData()
        {
            lblIdStd.Text = id_student.ToString();
            
            fillCmbYear();
            fillDataGV();
        }
        private void fillCmbYear()
        {


            cmbSemester.SelectedIndex = 0;
            try
            {
                string sql = $"select CONCAT(hs.Ho,' ',hs.Ten) ,YEAR(hs.NgayTaoTK) as Nam from HocSinh hs where hs.MaSV='{id_student}'";
                SqlCommand cmd = new SqlCommand(sql, db.getConnection);
                db.openConnection();
                using (SqlDataReader reader = cmd.ExecuteReader()){

            
                int year = 0;
                if (reader.Read())
                {
                    string name = reader[0].ToString();
                    lblFullname.Text = name;
                    year = Convert.ToInt32(reader[1].ToString());
                }

                int currentYear = DateTime.Now.Year;
                while (year <= currentYear)
                {
                    string yearStr = year.ToString() + "-" + (year + 1).ToString();
                    cmbYear.Items.Add(yearStr);
                    year++;
                }
                cmbYear.SelectedIndex = 0;
            }
            db.closeConnection();


        }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đường dẫn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

}

        private void fillDataGV()
        {
            
                string sql = $@"d.MaSV='{id_student}'";
                fillDataGvChange(sql);
         
        }

        private void cmbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (cmbSemester.SelectedIndex == 0 && cmbYear.SelectedIndex == 0)
                {
                    string sql = $@"d.MaSV='{id_student}'";
                    fillDataGvChange(sql);
                }
                if (cmbSemester.SelectedIndex != 0 && cmbYear.SelectedIndex == 0)
                {
                    string sql = $@"d.MaSV='{id_student}' and  k.HocKy ='{cmbSemester.Text}'";
                    fillDataGvChange(sql);
                }
                if (cmbSemester.SelectedIndex == 0 && cmbYear.SelectedIndex != 0)
                {
                    string sql = $@" d.MaSV='{id_student}' and  k.NamHoc like '%{cmbYear.Text}%'";
                    fillDataGvChange(sql);
                }
                if (cmbSemester.SelectedIndex != 0 && cmbYear.SelectedIndex != 0)
                {
                    string sql = $@"d.MaSV='{id_student}' and  k.HocKy ='{cmbSemester.Text}' and k.NamHoc like '%{cmbYear.Text}%'";
                    fillDataGvChange(sql);
                }

        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (cmbSemester.SelectedIndex == 0 && cmbYear.SelectedIndex == 0)
                {
                    string sql = $@"d.MaSV='{id_student}'";
                    fillDataGvChange(sql);
                }
                if (cmbSemester.SelectedIndex != 0 && cmbYear.SelectedIndex == 0)
                {
                    string sql = $@"d.MaSV='{id_student}' and  k.HocKy ='{cmbSemester.Text}'";
                    fillDataGvChange(sql);
                }
                if (cmbSemester.SelectedIndex == 0 && cmbYear.SelectedIndex != 0)
                {
                    string sql = $@"d.MaSV='{id_student}' and  k.NamHoc like '%{cmbYear.Text}%'";
                    fillDataGvChange(sql);
                }
                if (cmbSemester.SelectedIndex != 0 && cmbYear.SelectedIndex != 0)
                {
                    string sql = $@"d.MaSV='{id_student}' and  k.HocKy ='{cmbSemester.Text}' and k.NamHoc like '%{cmbYear.Text}%'";
                    fillDataGvChange(sql);
                }

     
        }
        private void fillDataGvChange(string condition)
        {
            string sql = $@"select d.MaKH as ""Mã Khoá Học"", k.TenKH as ""Tên Khoá Học"",k.HocKy as ""Học Kỳ"",k.NamHoc as ""Năm Học"", d.DiemQT as ""Điểm Quá Trình"", d.DiemCuoiKy as ""Điểm Cuối Kỳ"", d.DiemTongKet as ""Điểm Tổng Kết"", d.TrangThai as ""Xếp Loại""  from Diem d join KhoaHoc k on d.MaKH = k.MaKH where "+condition;
            lblAvgScore.Text = scoreDAO.fillDataGvChange(sql,dataGvScore).ToString();
               
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printResult();
        }
        private void printResult()
        {
            Report report = new Report();

            report.reportpath = "D:\\Winform\\Winform\\PROJECT\\DoAnWinform\\StudentManagement\\StudentManagement\\StudentManagement\\GUI\\ReportGUI\\ReportStudentResult.rdlc";
            report.dataset = "DataSetResult";
            XJDBC db = new XJDBC();
            SqlCommand cmd = new SqlCommand($"select * from Diem d join HocSinh hs on d.MaSV = hs.MaSV join KhoaHoc kh on d.MaKH = kh.MaKH where d.MaSV = '{id_student}'", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            db.openConnection();
            System.Data.DataTable dt = new System.Data.DataTable();
            adapter.Fill(dt);
            report.dataTable = dt;

            db.closeConnection();
            report.ShowDialog();
        }
    }
}
