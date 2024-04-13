﻿using StudentManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace StudentManagement.GUI
{
    public partial class ADMINaddCourse : Form
    {
        XJDBC db = new XJDBC();
        Data data = new Data();

        private string file {  get; set; }
        private string nameFile { get; set; }
        public ADMINaddCourse()
        {
            InitializeComponent();
        }

        private void ADMINaddCourse_Load(object sender, EventArgs e)
        {
            lblIdTeacher.Text = "";
            string sql = "select MaGV, Ho, Ten from GiangVien";

            data.fillData(sql, dataGvGV);
        }

        private void dataGvGV_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGvGV.CurrentRow.Cells["MaGV"].Value.ToString();
                lblIdTeacher.Text = id;
            }
            catch { }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            addCourse();
            DialogResult = DialogResult.OK;
            
        }
        public void addCourse()
        {

            string courseId = txtIdCourse.Text.Trim();
            string courseName = txtCourseName.Text.Trim();
            string numCre = txtNumCreadit.Text.Trim();

            string description = txtDescription.Text;
            string yearF = txtYearF.Text.Trim();
            string yearL = txtYearL.Text.Trim();
            string year = yearF + "-" + yearL;
            string semester = comboBoxSemester.Text.Trim();
            string idTearcher = lblIdTeacher.Text.Trim();
            byte[] buffer ;
           
                
          


            if (data.ValidateNotNull(idTearcher, courseId, courseName, numCre, year, semester, idTearcher))
            {
                if (checkYear(yearF, yearL))
                {
                    int numCreadit = Convert.ToInt32(numCre);

                    if (nameFile != null && file!=null)
                    {
                        using (Stream stream = File.OpenRead(file))
                        {
                            buffer = new byte[stream.Length];
                            stream.Read(buffer, 0, buffer.Length);
                        }

            Dictionary<string, object> values = new Dictionary<string, object>
            {
                { "MaKH",  courseId},
                { "TenKH", courseName },
                { "SoTC", numCreadit },
                {"MoTa",description },
                {"FileGiaoTrinh",buffer },
                {"TenFile",nameFile },
                {"NamHoc",year },
                {"HocKy",semester },
                {"MaGV",idTearcher }
            };
                        if (data.InsertData("KhoaHoc", values))
                        {
                            MessageBox.Show("Thêm Khoá Học thành công");
                        }
                    }

                    else
                    {
                        Dictionary<string, object> values = new Dictionary<string, object>
            {
                { "MaKH",  courseId},
                { "TenKH", courseName },
                { "SoTC", numCreadit },
                {"MoTa",description },
                
                {"NamHoc",year },
                {"HocKy",semester },
                {"MaGV",idTearcher }
            };
                        if (data.InsertData("KhoaHoc", values))
                        {
                            MessageBox.Show("Thêm Khoá Học thành công");
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập năm học hợp lệ!!!");
                }
                
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }



        }
        private bool checkYear(string FYear, string LYear)
        {
            DateTime currentDate = DateTime.Now;
            int year = currentDate.Year;
            int year1 = Convert.ToInt32(FYear);
            int year2 = Convert.ToInt32(LYear);
            if (year1 >= year2 || year2>year)
                return false;
            
            if(year1 == year)
            {
                if (year2 == year1 + 1)
                    return true;
            }
            if(year2 == year)
            {
                if(year1 == year-1)
                    return true;

            }
            return false;
        }
        private void txtNumCreadit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtYearF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || ((TextBox)sender).Text.Length >= 4)
            {
                e.Handled = true; // Suppress the key press
            }
            if ( e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false; // Cho phép phím xoá đi qua
            }
        }

        private void btnUploadCourseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            string filePath = dlg.FileName;

            string filename = Path.GetFileName(filePath);
            txtCourseFile.Text = filename;

            file = filePath;
            nameFile = filename;
        }
    }
}
