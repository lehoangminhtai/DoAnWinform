using StudentManagement.DAO;
using StudentManagement.Entity;
using StudentManagement.GUI.Document;
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
    public partial class UCdocument : UserControl
    {
        public string course_id {  get; set; }
        public int doc_id {  get; set; }
        public int role {  get; set; }
        public string filename { get; set; }
        DocumentDAO documentDAO=new DocumentDAO();
        public UCdocument()
        {
            InitializeComponent();
        }

        private void UCdocument_Load(object sender, EventArgs e)
        {
            if (role == 1)
            {
                btnAddDoc.Visible = false;
            }
            fillData();
        }
        private void fillData()
        {
            if (course_id != null)
            {
                SqlCommand cmd = new SqlCommand("select tl.MaTL, tl.TenTL, tl.MoTa,tl.TenFile from TaiLieu tl where tl.MaKH='" + course_id+"'");
                showListDocument(cmd);
            }
        }
        private void showListDocument(SqlCommand cmd)
        {
            panelDocument.Controls.Clear();

            int panelY = 0;
            
            List<DOCUMENT> list = documentDAO.getListDocument(cmd);
            foreach (var d in list)
            {
                Panel panelCourse = new Panel();
                panelCourse.BorderStyle = BorderStyle.FixedSingle;
                panelCourse.Location = new Point(10, panelY);
                panelCourse.Size = new Size(650, 130);
                panelCourse.Margin = new Padding(10);



                Label labelName = new Label();
                labelName.Text = d.name;
                labelName.Location = new Point(20, 10);
                labelName.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                labelName.AutoSize = true;

                Label labelDes = new Label();
                labelDes.Text = d.description;
                labelDes.Location = new Point(20, 50);
                labelName.AutoSize = true;

                LinkLabel lblFileName = new LinkLabel();
                lblFileName.Text = d.filename;
                lblFileName.Location = new Point(20, 80);
                lblFileName.Font = new Font("Microsoft Sans Serif",9,FontStyle.Bold);
                lblFileName.AutoSize = true;
                lblFileName.Tag = d.id;
                filename = d.filename;

                doc_id = d.id;

                lblFileName.Click += (clicklabel, eventArgs) =>
                {
                    string sql = "select FileTaiLieu from TaiLieu where MaTl = '" + doc_id + "' and MaKH ='" + course_id + "'";
                    LinkLabel lblfile = clicklabel as LinkLabel;
                    documentDAO.downloadFile(filename, sql);
                    
                };

                panelCourse.Controls.Add(labelName);
                panelCourse.Controls.Add(labelDes);
                panelCourse.Controls.Add(lblFileName);


                panelY += panelCourse.Height + 10;

                panelDocument.Controls.Add(panelCourse);


            }

        }

        private void btnAddDoc_Click(object sender, EventArgs e)
        {
            AddDocumentFrm addDocumentFrm = new AddDocumentFrm();
            addDocumentFrm.course_id = course_id;
            if(addDocumentFrm.ShowDialog()==DialogResult.OK)
            {
                fillData();
            }
        }
    }
}
