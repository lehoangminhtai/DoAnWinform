using StudentManagement.DAO;
using StudentManagement.Entity;
using StudentManagement.GUI.Document;
using StudentManagement.GUI.DocumentGUI;
using StudentManagement.GUI.SubmitHwGUI;
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

namespace StudentManagement.GUI.HomeworkGUI
{
    public partial class UChomework : UserControl
    {
        XJDBC db= new XJDBC();
        public string course_id { get; set; }
        public string id_std { get; set; }
        public int hw_id { get; set; }
        public int role { get; set; }
        public string filename { get; set; }

        HomeworkDAO homeworkDAO =new HomeworkDAO();
        public UChomework()
        {
            InitializeComponent();
        }

        private void UChomework_Load(object sender, EventArgs e)
        {
            id_std = ACCOUNT.id;
            if (role == 1)
            {
                btnAddHomeW.Visible = false;
            }
            fillData();
        }
        private void fillData()
        {
            if (course_id != null)
            {
                SqlCommand cmd = new SqlCommand("select bt.MaBT, bt.TenBaiTap, bt.NgayMo,bt.HanNop,bt.YeuCau,bt.TenFile from BaiTap bt where bt.MaKH ='" + course_id + "'");
                showListDocument(cmd);
            }
        }

        private void showListDocument(SqlCommand cmd)
        {
            panelHomeWork.Controls.Clear();

            int panelY = 0;

            List<HOMEWORK> list = homeworkDAO.getListHomework(cmd);
            foreach (var h in list)
            {
                Panel panelHWork = new Panel();
                panelHWork.BorderStyle = BorderStyle.FixedSingle;
                panelHWork.Location = new Point(10, panelY);
                panelHWork.Size = new Size(650, 170);
                panelHWork.Margin = new Padding(10);
                panelHWork.BackColor = Color.White;



                Label labelName = new Label();
                labelName.Text = h.name;
                labelName.Location = new Point(20, 10);
                labelName.Font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
                labelName.AutoSize = true;

                Label labelOpenDate = new Label();
                labelOpenDate.Text = "Mở bài: " + h.openDate.ToString("dddd, dd MMMM yyyy, hh:mm tt");
                labelOpenDate.Location = new Point(20, 40);
                labelOpenDate.AutoSize = true;

                Label labelDeadline = new Label();
                labelDeadline.Text ="Đóng bài: "+ h.closeDate.ToString("dddd, dd MMMM yyyy, hh:mm tt");
                labelDeadline.Location = new Point(20, 60);
                labelDeadline.AutoSize = true;

                Label labelDes = new Label();
                labelDes.Text ="Yêu cầu: "+ h.description;
                labelDes.Location = new Point(20, 90);
                labelDes.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
                labelDes.AutoSize = true;

                LinkLabel lblFileName = new LinkLabel();
                lblFileName.Text = h.filename;
                lblFileName.Location = new Point(20, 130);
                lblFileName.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);
                lblFileName.AutoSize = true;
                lblFileName.Tag = h.id;
                filename = h.filename;

                hw_id = h.id;

                lblFileName.Click += (clicklabel, eventArgs) =>
                {
                    LinkLabel lblfile = clicklabel as LinkLabel;
                    string sql = "select FileBT from BaiTap where MaBT = '" + h.id + "' and MaKH ='" + course_id + "'";
                   
                    homeworkDAO.downloadFile(h.filename, sql);

                };

                Button btnUpdate = new Button();
                btnUpdate.BackgroundImage = Image.FromFile("Image/contract.png");
                btnUpdate.BackgroundImageLayout = ImageLayout.Zoom;
                btnUpdate.Location = new Point(580, 10);
                btnUpdate.Size = new Size(55, 35);
                btnUpdate.Tag = h.id;


                btnUpdate.Click += (clickButton, eventArgs) =>
                {
                    Button buttonUpdate = clickButton as Button;
                    UpdateHomeworkFrm updateFrm = new UpdateHomeworkFrm();
                    updateFrm.course_id = course_id;
                    updateFrm.hw_id = h.id;
                   
                    updateFrm.nameHW = h.name;
                    updateFrm.desHW = h.description;
                    updateFrm.nameFile = h.filename;
                    updateFrm.dealine = h.closeDate;
                    if (updateFrm.ShowDialog() == DialogResult.OK)
                    {
                        fillData();
                    }

                };

                Button btnDelete = new Button();
                btnDelete.BackgroundImage = Image.FromFile("Image/delete.png");
                btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
                btnDelete.Location = new Point(580, 55);
                btnDelete.Size = new Size(55, 40);
                btnDelete.Tag = h.id;

                btnDelete.Click += (clickButton, eventArgs) =>
                {
                    Button buttonDelete = clickButton as Button;
                    Dictionary<string, object> dic = new Dictionary<string, object>
                    {
                        {"MaBT",h.id}, {"MaKH",course_id}
                    };
                    DialogResult res = MessageBox.Show("Bạn có chắc muốn xoá bài tập này?", "Xoá Bài Tập", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.Yes)
                    {
                        if (homeworkDAO.delete("BaiTap", dic))
                        {
                            fillData();
                        }
                    }
                   
                };
                Button btnSubmit = new Button();
                btnSubmit.Text= "Nộp bài";
                btnSubmit.AutoSize = true;
                btnSubmit.Font= new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                btnSubmit.BackColor = Color.IndianRed;
                btnSubmit.Location = new Point(500, 10);
                btnSubmit.Size = new Size(55, 35);
                btnSubmit.Tag = h.id;

               /* if (h.closeDate <= DateTime.Now)
                {
                    btnSubmit.Visible = false;
                }*/
                btnSubmit.Click += (clickButton, eventArgs) =>
                {
                    Button buttonSubmit = clickButton as Button;
                    SubmitHomeworkFrm submitfrm = new SubmitHomeworkFrm();
                    submitfrm.idHW = h.id;
                    submitfrm.id_Course = course_id;
                    submitfrm.id_Student = ACCOUNT.id;
                    submitfrm.nameHW = h.name;

                    submitfrm.openDate = h.openDate;
                    submitfrm.deadline = h.closeDate;

                    if (submitfrm.ShowDialog() == DialogResult.OK)
                    {
                        fillData();
                    }
                };

                if (checkExitsSubmit(h.id))
                {
                    btnSubmit.Text = "Đã Nộp";
                    btnSubmit.BackColor = Color.PaleTurquoise;

                }

                Button btnResult = new Button();
                btnResult.Text = "Kết Quả";
                btnResult.AutoSize = true;
                btnResult.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                btnResult.BackColor = Color.PaleTurquoise;
                btnResult.Location = new Point(500, 50);
                btnResult.Size = new Size(55, 35);
                btnResult.Tag = h.id;

                btnResult.Click += (clickButton, eventArgs) =>
                {
                    Button buttonResult = clickButton as Button;
                    ListSubmitHwFrm frm = new ListSubmitHwFrm();
                    frm.id_course = course_id;
                    frm.id_hw =h.id;
                    frm.name_hw =h.name;
                    frm.Show();
                };

                if (role == 1)
                {
                    btnDelete.Visible = false;
                    btnUpdate.Visible = false;
                    btnResult.Visible = false;
                }
                if(role==2)
                {
                    btnSubmit.Visible = false;
                }

                panelHWork.Controls.Add(btnUpdate);
                panelHWork.Controls.Add(btnSubmit);
                panelHWork.Controls.Add(btnDelete);
                panelHWork.Controls.Add(btnResult);
                panelHWork.Controls.Add(labelName);
                panelHWork.Controls.Add(labelOpenDate);
                panelHWork.Controls.Add(labelDeadline);
                panelHWork.Controls.Add(labelDes);
                panelHWork.Controls.Add(lblFileName);

                panelY += panelHWork.Height + 10;

                panelHomeWork.Controls.Add(panelHWork);


            }

        }

        private void btnAddHomeW_Click(object sender, EventArgs e)
        {
           AddHomeworkFrm addHomeworkFrm = new AddHomeworkFrm();
            addHomeworkFrm.course_id = course_id;
            if (addHomeworkFrm.ShowDialog() == DialogResult.OK)
            {
                fillData();
            }
        }
        private bool checkExitsSubmit(int id_hw)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM ChiTietNopBai WHERE MaKH = '{course_id}' AND MaSV = '{id_std}' and MaBT='{id_hw}'", db.getConnection);

            int count = (int)cmd.ExecuteScalar();
            db.closeConnection();
            return count > 0;
        }
    }
}
