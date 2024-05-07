using DocumentFormat.OpenXml.Office2010.Excel;
using OfficeOpenXml;
using StudentManagement.DAO;
using StudentManagement.Entity;
using StudentManagement.GUI.ReportGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        XJDBC db= new XJDBC();
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printListStd();
        }
        private void printListStd()
        {
            Report report = new Report();
            
            report.reportpath = "D:\\Winform\\Winform\\PROJECT\\DoAnWinform\\StudentManagement\\StudentManagement\\StudentManagement\\GUI\\ReportGUI\\reportScoreStdList.rdlc";
            report.dataset = "DataSetResult";
            XJDBC db = new XJDBC();
            SqlCommand cmd = new SqlCommand($"select d.MaSV,d.DiemQT, d.DiemCuoiKy, d.DiemTongKet, hs.Ho, hs.Ten, kh.TenKH, d.TrangThai  from Diem d join HocSinh hs on d.MaSV = hs.MaSV join KhoaHoc kh on d.MaKH = kh.MaKH where d.MaKH ='{courseId}'", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            db.openConnection();
            System.Data.DataTable dt = new System.Data.DataTable();
            adapter.Fill(dt);
            report.dataTable = dt;

            db.closeConnection();
            report.ShowDialog();
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            importExcel();
        }
        private void importExcel()
        {
            try
            {


                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                dataGvStdListCourse.DataSource = null;
                dataGvStdListCourse.Rows.Clear();
                dataGvStdListCourse.Columns.Clear();

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                openFileDialog.Title = "Select an Excel File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    using (ExcelPackage package = new ExcelPackage(new System.IO.FileInfo(filePath)))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                        DataTable dt = new DataTable();

                        dt.Columns.Add("Mã Sinh Viên");
                        dt.Columns.Add("Họ");

                        dt.Columns.Add("Tên");
                        dt.Columns.Add("Điểm Quá Trình");
                        dt.Columns.Add("Điểm Cuối Kỳ");
                        dt.Columns.Add("Điểm Tổng Kết");
                        dt.Columns.Add("Xếp Loại");


                        for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                        {
                            DataRow newRow = dt.Rows.Add();
                            //newRow["ID"] = worksheet.Cells[row, 1].Value.ToString();

                            SCORE score = new SCORE();

                            string id = worksheet.Cells[row, 1].Value.ToString();

                            if (!Regex.IsMatch(id, @"^\d+$"))
                            {
                                MessageBox.Show("Lỗi mã sinh viên!!!, Dòng " + row, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                continue;
                            }
                            else
                            {
                                int.TryParse(worksheet.Cells[row, 1].Value.ToString(), out int studentId);

                                newRow["Mã Sinh Viên"] = id;
                                score.id_student = id;
                            }

                            string fname = worksheet.Cells[row, 2].Value?.ToString();

                            if (!Regex.IsMatch(fname, @"^[\p{L}\s]+$"))
                            {
                                MessageBox.Show("Lỗi họ tên, Dòng " + row, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                continue;
                            }
                            else
                            {
                                newRow["Họ"] = fname;
                            }


                            string lname = worksheet.Cells[row, 3].Value?.ToString();

                            if (!Regex.IsMatch(lname, @"^[\p{L}\s]+$"))
                            {
                                MessageBox.Show("Lỗi họ tên, Dòng " + row, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                newRow["Tên"] = lname;
                            }


                            string gradeMid = worksheet.Cells[row, 4].Value?.ToString();

                            if (isNumBer(gradeMid))
                            {
                                newRow["Điểm Quá Trình"] = gradeMid;
                                score.gradeMid= convertToDouble(gradeMid);
                            }
                            else
                            {
                                MessageBox.Show("Lỗi điểm, Dòng " + row, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            string gradeLast = worksheet.Cells[row, 5].Value?.ToString();
                            
                            if (isNumBer(gradeLast))
                            {
                                newRow["Điểm Cuối Kỳ"] = gradeLast;
                                score.gradeLast = convertToDouble(gradeLast);
                            }
                            else
                            {
                                MessageBox.Show("Lỗi điểm, Dòng " + row, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            string gradeFinal = worksheet.Cells[row, 6].Value?.ToString();
                            

                            if (isNumBer(gradeFinal))
                            {
                                newRow["Điểm Tổng Kết"] = gradeFinal;
                                score.gradeFinal = convertToDouble(gradeFinal);
                            }
                            else
                            {
                                MessageBox.Show("Lỗi điểm, Dòng " + row, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            string rank = worksheet.Cells[row, 7].Value?.ToString();
                            if(rank!=null)
                            {
                                newRow["Xếp Loại"] = rank;
                                score.rank = rank;
                            }
                            if (rank == null && gradeFinal!=null)
                            {
                                string status = "";
                                double gradeFinal_D=Convert.ToDouble(gradeFinal);

                                if (gradeFinal_D >= 8.5)
                                    rank = "Giỏi";
                                else if (gradeFinal_D >= 7)
                                    rank = "Khá";
                                else if (gradeFinal_D >= 5.5)
                                    status = "Trung Bình";
                                else rank = "Yếu";
                                newRow["Xếp Loại"] = rank;
                                score.rank = rank; 
                            }

                            if (checkExist(score.id_student))
                            {
                                string tableName = "Diem";
                                Dictionary<string, object>dic = new Dictionary<string, object> {
                                    {"DiemQT",score.gradeMid }, {"DiemCuoiKy",score.gradeLast},{"DiemTongKet",score.gradeFinal },{"TrangThai",score.rank}
                                };
                                string condition = $" MaKH ='{courseId}' and MaSV ='{score.id_student}'";

                                scoreDAO.updateScore(tableName, dic, condition);
                           
                            }


                        }

                        dataGvStdListCourse.DataSource = dt;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi nhập file, vui lòng nhập đủ điểm", "Nhập file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool isNumBer(string grade)
        {
            return Regex.IsMatch(grade, @"^\d+(\.\d+)?$");
        }
        private double  convertToDouble(string grade)
        {
            return Convert.ToDouble(grade);
        }
        private bool checkExist(string idStd)
        {
            try
            {
                string sql = $"SELECT COUNT(*) FROM Diem WHERE MaSV = '{idStd}' and MaKH='{courseId}'";
                SqlCommand cmd = new SqlCommand(sql,db.getConnection );
                db.openConnection();
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                   return true;
                }
                else
                {
                   return false;
                }
            }
            catch
            {
                return false;
            }
            finally { db.closeConnection(); }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGvStdListCourse.DataSource = null;
            dataGvStdListCourse.Rows.Clear();
            dataGvStdListCourse.Columns.Clear();
            fillData();
        }
    }
}
