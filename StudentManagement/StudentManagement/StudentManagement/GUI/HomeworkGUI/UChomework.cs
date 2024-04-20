using StudentManagement.DAO;
using StudentManagement.Entity;
using StudentManagement.GUI.DocumentGUI;
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
        public string course_id { get; set; }
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
                SqlCommand cmd = new SqlCommand("select bt.TenBaiTap, bt.NgayMo,bt.HanNop,bt.YeuCau,bt.TenFile,bt.QuyenTruyCap from BaiTap bt where bt.MaKH ='" + course_id + "'");
                showListDocument(cmd);
            }
        }

        private void showListDocument(SqlCommand cmd)
        {
            panelDocument.Controls.Clear();

            int panelY = 0;

            List<HOMEWORK> list = homeworkDAO.getListHomework(cmd);
            foreach (var h in list)
            {
                Panel panelHWork = new Panel();
                panelHWork.BorderStyle = BorderStyle.FixedSingle;
                panelHWork.Location = new Point(10, panelY);
                panelHWork.Size = new Size(650, 150);
                panelHWork.Margin = new Padding(10);
                panelHWork.BackColor = Color.White;



                Label labelName = new Label();
                labelName.Text = h.name;
                labelName.Location = new Point(20, 10);
                labelName.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                labelName.AutoSize = true;

                Label labelDes = new Label();
                labelDes.Text = h.description;
                labelDes.Location = new Point(20, 50);
                labelDes.AutoSize = true;

                LinkLabel lblFileName = new LinkLabel();
                lblFileName.Text = h.filename;
                lblFileName.Location = new Point(20, 80);
                lblFileName.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                lblFileName.AutoSize = true;
                lblFileName.Tag = h.id;
                filename = h.filename;

                hw_id = h.id;

                lblFileName.Click += (clicklabel, eventArgs) =>
                {
                    string sql = "select File from BaiTap where MaBT = '" + hw_id + "' and MaKH ='" + course_id + "'";
                    LinkLabel lblfile = clicklabel as LinkLabel;
                    homeworkDAO.downloadFile(filename, sql);

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
                    UpdateDocumentFrm updateFrm = new UpdateDocumentFrm();
                    updateFrm.course_id = course_id;
                    updateFrm.doc_id = h.id;
                   
                    updateFrm.nameDoc = h.name;
                    updateFrm.desDoc = h.description;
                    updateFrm.nameFile = h.filename;
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

                if (role == 1)
                {
                    btnDelete.Visible = false;
                    btnUpdate.Visible = false;
                }

                panelDocument.Controls.Add(btnUpdate);
                panelDocument.Controls.Add(btnDelete);
                panelDocument.Controls.Add(labelName);
                panelDocument.Controls.Add(labelDes);
                panelDocument.Controls.Add(lblFileName);


                





                panelY += panelDocument.Height + 10;

                panelDocument.Controls.Add(panelHWork);


            }

        }
    }
}
