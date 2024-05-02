using StudentManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.GUI.ScoreGUI
{
    public partial class EnterStudentScore : Form
    {

        public string id_student { get; set; }
        public string id_course { get; set; }
        public string nameStd { get; set; }
        private bool isupdate { get; set; }
        public string scoreMid { get; set; }
        public string scoreLast {  get; set; }
        XJDBC db = new XJDBC();

        public EnterStudentScore()
        {
            InitializeComponent();
        }

        private void EnterStudentScore_Load(object sender, EventArgs e)
        {
            lblNoti.Visible = false;
            lblGradeFinal.Text = "";
            fillCourseInfor();
            fillGVGrade();

        }

        private void fillCourseInfor()
        {
            if(scoreMid!=null&&scoreMid!="")
                txtGradeMid.Text =scoreMid.ToString();
            if (scoreLast != null && scoreLast != "")
                txtGradeLast.Text =scoreLast.ToString();

            lblIdStd.Text = "";
            lblNameStd.Text = "";
            lblIdStd.Text = id_student;
            lblNameStd.Text = nameStd;

            lblCourseName.Text = "";
            lblCourseSemester.Text = "";
            try
            {
                SqlCommand cmd = new SqlCommand($"select kh.TenKH, kh.HocKy from KhoaHoc kh where kh.MaKH ='{id_course}'", db.getConnection);
                db.openConnection();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblCourseName.Text = reader[0].ToString();
                    lblCourseSemester.Text = reader[1].ToString();
                }
                db.closeConnection();
                reader.Close();
            }
            catch
            {

            }

        }
        private void countAbsent()
        {
            try
            {
                db.openConnection();

                // Truy vấn để lấy số lượng bài tập trong khóa học
                string queryCountExercises = $"SELECT COUNT(*) FROM DiemDanh WHERE MaMH = '{id_course}'";
                SqlCommand commandCountExercises = new SqlCommand(queryCountExercises, db.getConnection);
                int countAtt = (int)commandCountExercises.ExecuteScalar();

                // Truy vấn để lấy số lượng bài tập mà sinh viên đã hoàn thành
                string queryCompletedExercises = $"SELECT COUNT(*) FROM ChiTietDiemDanh WHERE MaMH = '{id_course}' AND MaSV = '{id_student}'";
                SqlCommand commandCompletedExercises = new SqlCommand(queryCompletedExercises, db.getConnection);
                int present = (int)commandCompletedExercises.ExecuteScalar();

                // Đóng kết nối với cơ sở dữ liệu
                db.closeConnection();

                // Tính điểm trung bình
                int absent = countAtt - present;
                lblAbsent.Text = absent.ToString() + " buổi";

            }
            catch (Exception ex)
            {

            }
        }
        private void fillGVGrade()
        {
            FillDataGridView();
            FillDataGridViewAttend();
            countAbsent();
            //getAVGGradeExercise();
        }
        private void FillDataGridView()
        {
            try
            {


                // Truy vấn SQL để lấy danh sách tất cả các mã bài tập
                string queryGetExercises = $"SELECT DISTINCT bt.MaBT, bt.TenBaiTap  FROM BaiTap bt  where bt.MaKH = '{id_course}'";
                db.openConnection();

                SqlCommand commandGetExercises = new SqlCommand(queryGetExercises, db.getConnection);
                SqlDataAdapter adapterExercises = new SqlDataAdapter(commandGetExercises);
                DataTable dataTableExercises = new DataTable();

                adapterExercises.Fill(dataTableExercises);


                string queryGetData = "SELECT ";
                foreach (DataRow exerciseRow in dataTableExercises.Rows)
                {
                    string exerciseCode = exerciseRow["MaBT"].ToString();
                    string exerciseName = exerciseRow["TenBaiTap"].ToString();
                    queryGetData += $"(SELECT ct.Diem FROM ChiTietNopBai ct WHERE ct.MaSV = '{id_student}' AND ct.MaBT = '{exerciseCode}') AS ' {exerciseName}', ";
                }
                queryGetData = queryGetData.TrimEnd(',', ' ');

                queryGetData += " FROM (SELECT DISTINCT MaSV FROM ChiTietNopBai) hs";


                SqlCommand commandGetData = new SqlCommand(queryGetData, db.getConnection);
                SqlDataAdapter adapterData = new SqlDataAdapter(commandGetData);
                DataTable dataTableData = new DataTable();

                adapterData.Fill(dataTableData);

                // Thiết lập DataGridView
                dataGVScore.DataSource = dataTableData;
                db.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Looix!!");
            }

        }
        private void getAVGGradeExercise()
        {
            try
            {
                double count = 0;
                double doExercise = 0;
                db.openConnection();

                string query = $"select count(*) from BaiTap bt where bt.MaKH ='{id_course}'";


                SqlCommand command = new SqlCommand(query, db.getConnection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    count = (int)reader[0];
                }
                reader.Close();


                string query1 = $"select count(*) from ChiTietNopBai ct where ct.MaKH ='{id_course}' and ct.MaSV ='{id_student}' ";


                SqlCommand command1 = new SqlCommand(query1, db.getConnection);
                SqlDataReader reader1 = command1.ExecuteReader();
                if (reader1.Read())
                {
                    doExercise = (int)reader1[0];
                }
                reader.Close();

                db.closeConnection();

                double avgGrade = Math.Round((doExercise / count), 2);

                // lblAvgExercise.Text = avgGrade.ToString();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                Console.WriteLine($"Error: {ex.Message}");
            }

        }
        private void FillDataGridViewAttend()
        {
            try
            {


                // Truy vấn SQL để lấy danh sách tất cả các mã bài tập
                string queryGetExercises = $"SELECT DISTINCT dd.MaDD, dd.NgayGioDiemDanh as time  FROM  DiemDanh dd  where  dd.MaMH = '{id_course}' ";
                db.openConnection();

                SqlCommand commandGetExercises = new SqlCommand(queryGetExercises, db.getConnection);
                SqlDataAdapter adapterExercises = new SqlDataAdapter(commandGetExercises);
                DataTable dataTableExercises = new DataTable();

                adapterExercises.Fill(dataTableExercises);


                string queryGetData = "SELECT ";
                foreach (DataRow exerciseRow in dataTableExercises.Rows)
                {
                    string attID = exerciseRow["MaDD"].ToString();
                    string timeString = exerciseRow["time"].ToString();
                    DateTime attTime;
                    if (DateTime.TryParse(timeString, out attTime))
                    {
                        timeString = attTime.ToString("dd/MM/yyyy");

                    }
                    //DateTime attTime = DateTime.ParseExact(exerciseRow["time"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    queryGetData += $"(SELECT COALESCE(N'Có mặt', 'Vắng') FROM ChiTietDiemDanh ct WHERE ct.MaSV = '{id_student}' AND ct.MaDD = '{attID}') AS 'Ngày {timeString}', ";
                }
                queryGetData = queryGetData.TrimEnd(',', ' ');

                queryGetData += " FROM (SELECT DISTINCT MaSV FROM ChiTietDiemDanh) hs";


                SqlCommand commandGetData = new SqlCommand(queryGetData, db.getConnection);
                SqlDataAdapter adapterData = new SqlDataAdapter(commandGetData);
                DataTable dataTableData = new DataTable();

                adapterData.Fill(dataTableData);

                // Thiết lập DataGridView
                dataGvAttendance.DataSource = dataTableData;
                db.closeConnection();

            }
            catch
            {

            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtGradeMid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Không cho phép nhập ký tự này vào TextBox
            }

            // Kiểm tra xem dấu chấm thập phân đã được nhập hay chưa
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true; // Không cho phép nhập thêm dấu chấm thập phân nếu đã tồn tại một dấu chấm
            }
        }

        private void txtGradeMid_TextChanged(object sender, EventArgs e)
        {
            lblNoti.Visible = false;
            double gradeMid = 0;
            double gradeLast = 0;

            if (txtGradeMid.Text.Trim() != "")
                gradeMid = Convert.ToDouble(txtGradeMid.Text.Trim());

            if (txtGradeLast.Text.Trim() != "")
                gradeLast = Convert.ToDouble(txtGradeLast.Text.Trim());

            if ((gradeMid >= 0 && gradeMid <= 10) && (gradeLast >= 0 && gradeLast <= 10))
            {
                double gradeFinal = Math.Round((gradeMid + gradeLast) / 2, 2);
                lblGradeFinal.Text = gradeFinal.ToString();
            }
            else
            {
                lblNoti.Visible = true;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ScoreDAO scoreDAO = new ScoreDAO();
            string tablename = "Diem";
            string condition = $" MaKH= '{id_course}' and MaSV = '{id_student}'";

            double gradeMid = 0;
            double gradeLast = 0;
            double gradeFinal = 0;

           
            
            if (txtGradeMid.Text.Trim() != ""&& txtGradeLast.Text.Trim() != "") {
                if((gradeMid >= 0 && gradeMid <= 10) && (gradeLast >= 0 && gradeLast <= 10))
                {
                    gradeMid = Convert.ToDouble(txtGradeMid.Text.Trim());
                    gradeLast = Convert.ToDouble(txtGradeLast.Text.Trim());
                    gradeFinal = Math.Round((gradeMid + gradeLast) / 2, 2);
                    string status = "";


                    if (gradeFinal >= 8.5)
                        status = "Giỏi";
                    else if (gradeFinal >= 7)
                        status = "Khá";
                    else if (gradeFinal >= 5.5)
                        status = "Trung Bình";
                    else status = "Yếu";
                        Dictionary<string, object> dic = new Dictionary<string, object> {
                {"DiemQT",gradeMid},{"DiemCuoiKy",gradeLast},{"DiemTongKet",gradeFinal},{"TrangThai",status}
            };

                   
                    if (scoreDAO.updateScore(tablename, dic, condition))
                    {
                        MessageBox.Show("Đã nhập điểm cho sinh viên");
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập điểm trong khoảng 0-10", "Nhập điểm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập điểm đầy đủ", "Nhập điểm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                

            

        }
      
    }
}
