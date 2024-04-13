﻿using StudentManagement.DAO;
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
    public partial class UCRegisterCourse : UserControl
    {
        XJDBC db = new XJDBC();
        CourseDAO courseDAO = new CourseDAO();
        ScoreDAO scoreDAO = new ScoreDAO();
        public string sid = "21110635";
        public string scoreTableName = "Diem";
        public UCRegisterCourse()
        {
            InitializeComponent();
        }



        private void UCRegisterCourse_Load(object sender, EventArgs e)
        {

        }
        private void showListCourse(SqlCommand cmd)
        {
            panelCourse1.Controls.Clear();

            int panelY = 30;
            string cid = null;
            List<COURSE> list = courseDAO.getListCourse(cmd);
            foreach (var c in list)
            {
                Panel panelCourse = new Panel();
                panelCourse.BorderStyle = BorderStyle.FixedSingle;
                panelCourse.Location = new Point(10, panelY);
                panelCourse.Size = new Size(450, 130);
                panelCourse.Margin = new Padding(10);



                Label labelId = new Label();
                labelId.Text = c.id;
                labelId.Location = new Point(20, 10);
                labelId.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);

                Label labelName = new Label();
                labelName.Text = c.name;
                labelName.Location = new Point(20, 50);
                labelName.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                labelName.ForeColor = Color.DarkCyan;
                labelName.AutoSize = true;

                Label labelTeacher = new Label();
                labelTeacher.Text = "Giảng viên: " + c.teacherName;
                labelTeacher.Location = new Point(20, 90);

                Button buttonRegister = new Button();
                buttonRegister.Text = "Đăng ký";
                buttonRegister.Location = new Point(320, 30);
                buttonRegister.Tag = c.id;

                Button btnDelete = new Button();
                btnDelete.Text = "Xoá học phần";
                btnDelete.Location = new Point(320, 70);
                btnDelete.Tag = c.id;
                btnDelete.BackColor = Color.Red;
                btnDelete.AutoSize = true;
                panelCourse.Controls.Add(btnDelete);
                btnDelete.Visible = false;


                cid = c.id;
                buttonRegister.Click += (clickedButton, eventArgs) =>
                {

                    Button button = clickedButton as Button;
                    cid = button.Tag as string;

                    Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "MaKH",  cid},
                        { "MaSV",  sid}

                    };
                    if (scoreDAO.inserScore(scoreTableName, values))
                    {
                        MessageBox.Show("Đăng ký học phần  thành công!!!");
                        button.Enabled = false;
                        //btnDelete.Visible = true;



                    }

                };

                if (courseDAO.isRegisterCourse(cid, sid))
                {
                    buttonRegister.Enabled = false;

                    btnDelete.Visible = true;


                    btnDelete.Click += (clickedButton, eventArgs) =>
                    {

                        Button button = clickedButton as Button;
                        cid = button.Tag as string;
                        Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "MaKH",  cid},
                        { "MaSV",  sid}

                    };
                        if (scoreDAO.deleteScore(scoreTableName, values))
                        {
                            MessageBox.Show("Xoá học phần thành công!!!");
                            button.Visible = false;
                            buttonRegister.Enabled = true;
                        }
                    };
                }

                panelCourse.Controls.Add(labelId);
                panelCourse.Controls.Add(labelName);
                panelCourse.Controls.Add(labelTeacher);
                panelCourse.Controls.Add(buttonRegister);

                panelY += panelCourse.Height + 10;

                panelCourse1.Controls.Add(panelCourse);


            }

        }
        private void btnCourseList_Click(object sender, EventArgs e)
        {
            groupBoxSearch.Visible = true;
            txtCourseSearch.Text = "";
            SqlCommand cmd = new SqlCommand("Select MaKH, TenKH, CONCAT(v.Ho, ' ', v.Ten) as GiangVien  from KhoaHoc k join GiangVien v on k.MaGV = v.MaGV");
            showListCourse(cmd);

        }

        private void panelResCourse_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void btnCourseRegister_Click(object sender, EventArgs e)
        {
            groupBoxSearch.Visible=false;
            panelCourse1.Controls.Clear();
            UClistCourseRegister uclistC = new UClistCourseRegister();
            uclistC.student_id = sid;
            panelCourse1.Controls.Add(uclistC);
        }

        private void btnSearchCourse_Click(object sender, EventArgs e)
        {
            if (txtCourseSearch.Text.Trim() != "")
            {
                if(radIdCourse.Checked)
                {
                    SqlCommand cmd = new SqlCommand("Select MaKH, TenKH, CONCAT(v.Ho, ' ', v.Ten) as GiangVien  from KhoaHoc k join GiangVien v on k.MaGV = v.MaGV where k.MaKH like '%"+txtCourseSearch.Text.Trim()+"%'");
                    showListCourse(cmd);
                }
                if (radNameCourse.Checked)
                {
                    SqlCommand cmd = new SqlCommand("Select MaKH, TenKH, CONCAT(v.Ho, ' ', v.Ten) as GiangVien  from KhoaHoc k join GiangVien v on k.MaGV = v.MaGV where k.TenKH like N'%" + txtCourseSearch.Text.Trim() + "%'");
                    showListCourse(cmd);
                }
            }
           
        }
    }
}