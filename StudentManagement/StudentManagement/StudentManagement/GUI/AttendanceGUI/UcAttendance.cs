using StudentManagement.DAO;
using StudentManagement.Entity;
using StudentManagement.GUI.HomeworkGUI;
using StudentManagement.GUI.SubmitHwGUI;
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

namespace StudentManagement.GUI.AttendanceGUI
{
    public partial class UcAttendance : UserControl
    {
        AttendanceDAO attendanceDAO = new AttendanceDAO();
        XJDBC db = new XJDBC();
        public string id_course { get; set; }
        public int id_attend { get; set; }
        public string id_std { get; set; }
        public int role { get; set; }
        public UcAttendance()
        {
            InitializeComponent();
        }

        private void UcAttendance_Load(object sender, EventArgs e)
        {
            if (role == 1)
                btnAddAttend.Visible = false;
            id_std = ACCOUNT.id;
            fillData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAttend_Click(object sender, EventArgs e)
        {
            AddAttendaceFrm addAttendaceFrm = new AddAttendaceFrm();
            addAttendaceFrm.id_course = id_course;
            if (addAttendaceFrm.ShowDialog() == DialogResult.OK)
            {
                fillData();
            }
        }
        private void fillData()
        {
            if (id_course != null)
            {
                SqlCommand cmd = new SqlCommand($"select d.MaDD,d.NgayGioDiemDanh from DiemDanh d where d.MaMH='{id_course}'");
                showListAttend(cmd);
            }
        }
        private void showListAttend(SqlCommand cmd)
        {
            panelAttend.Controls.Clear();

            int panelY = 0;

            List<ATTENDANCE> list = attendanceDAO.getListAttend(cmd);

            foreach (var d in list)
            {
                Panel panelAtt = new Panel();
                panelAtt.BorderStyle = BorderStyle.FixedSingle;
                panelAtt.Location = new Point(10, panelY);
                panelAtt.Size = new Size(650, 100);
                panelAtt.Margin = new Padding(10);
                panelAtt.BackColor = Color.White;

                Label labeDate = new Label();
                labeDate.Text = d.dateAttend.ToString("dddd, dd MMMM yyyy, hh:mm tt");
                labeDate.Location = new Point(20, 10);
                labeDate.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
                labeDate.AutoSize = true;

                Button btnUpdate = new Button();
                btnUpdate.BackgroundImage = Image.FromFile("Image/contract.png");
                btnUpdate.BackgroundImageLayout = ImageLayout.Zoom;
                btnUpdate.Location = new Point(580, 10);
                btnUpdate.Size = new Size(45, 30);
                btnUpdate.Tag = d.idAttend;


                btnUpdate.Click += (clickButton, eventArgs) =>
                {
                    Button btnUpdate2 = clickButton as Button;
                    UpdateAttendaceFrm frm = new UpdateAttendaceFrm();
                    frm.id_att = d.idAttend;
                    frm.id_course = id_course;
                    frm.date = d.dateAttend;
                    if (frm.ShowDialog() == DialogResult.OK)
                        fillData();

                };

                Button btnDelete = new Button();
                btnDelete.BackgroundImage = Image.FromFile("Image/delete.png");
                btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
                btnDelete.Location = new Point(580, 55);
                btnDelete.Size = new Size(45, 30);
                btnDelete.Tag = d.idAttend;

                btnDelete.Click += (clickButton, eventArgs) =>
                {
                    Dictionary<string, object> dic = new Dictionary<string, object>
                    {
                        {"MaDD",d.idAttend}, {"MaMH",id_course}
                    };
                    DialogResult res = MessageBox.Show("Bạn có chắc muốn xoá lần điểm danh này?", "Xoá Điểm Danh", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.Yes)
                    {
                        if (attendanceDAO.delete("DiemDanh", dic))
                        {
                            fillData();
                        }
                    }
                };

                Button btnSubmit = new Button();
                btnSubmit.Text = "Điểm danh";
                btnSubmit.AutoSize = true;
                btnSubmit.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                btnSubmit.BackColor = Color.PaleTurquoise;
                btnSubmit.Location = new Point(400, 10);
                btnSubmit.Size = new Size(55, 35);
                btnSubmit.Tag = d.idAttend;



                btnSubmit.Click += (clickButton, eventArgs) =>
                {
                    string tablename = "ChiTietDiemDanh";
                    Dictionary<string, object> dic = new Dictionary<string, object>
                    {
                        {"MaDD",d.idAttend}, {"MaMH",id_course},{"MaSV",id_std}
                    };
                    if (attendanceDAO.insert(tablename, dic))
                    {
                        MessageBox.Show("Điểm danh thành công!!!");
                        fillData();
                    }
                };

                if (checkExitsAttend(d.idAttend))
                {
                    btnSubmit.Enabled = false;
                    btnSubmit.Text = "Đã điểm danh";
                }

                if (d.dateAttend < DateTime.Now && checkExitsAttend(d.idAttend)==false)
                {
                    btnSubmit.Enabled = false;
                    btnSubmit.Text = "Vắng";
                    btnSubmit.BackColor = Color.IndianRed;
                }
                    

                Button btnResult = new Button();
                btnResult.Text = "Kết Quả";
                btnResult.AutoSize = true;
                btnResult.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                btnResult.BackColor = Color.PaleTurquoise;
                btnResult.Location = new Point(500, 10);
                btnResult.Size = new Size(55, 35);
                btnResult.Tag = d.idAttend;

                btnResult.Click += (clickButton, eventArgs) =>
                {
                    AttendanceResult frm = new AttendanceResult();
                    frm.id_attend = d.idAttend;
                    frm.id_course = id_course;
                    frm.date = d.dateAttend;
                    frm.Show();
                };

                if (role == 1)
                {
                    
                    btnDelete.Visible = false;
                    btnUpdate.Visible = false;
                    btnResult.Visible = false;
                    panelAtt.Width -= 100;
                }
                if (role == 2)
                {
                    btnSubmit.Visible = false;
                }

                panelAtt.Controls.Add(btnUpdate);
                panelAtt.Controls.Add(btnSubmit);
                panelAtt.Controls.Add(btnDelete);
                panelAtt.Controls.Add(btnResult);
                panelAtt.Controls.Add(labeDate);

                panelY += panelAtt.Height + 10;

                panelAttend.Controls.Add(panelAtt);

            }
        }

        private bool checkExitsAttend(int iddd)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM ChiTietDiemDanh WHERE MaMH = '{id_course}' AND MaSV = '{id_std}' and MaDD='{iddd}'", db.getConnection);
           
            int count = (int)cmd.ExecuteScalar();
            db.closeConnection();
            return count > 0;
        }
    }
}
