using StudentManagement.DAO;
using StudentManagement.Entity;
using StudentManagement.GUI.Document;
using StudentManagement.GUI.DocumentGUI;
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
                SqlCommand cmd = new SqlCommand("select tl.MaTL, tl.TenTL, tl.MoTa,tl.TenFile, tl.LinkYoutube from TaiLieu tl where tl.MaKH='" + course_id+"'");
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
                panelCourse.Size = new Size(650, 150);
                panelCourse.Margin = new Padding(10);
                panelCourse.BackColor = Color.White;



                Label labelName = new Label();
                labelName.Text = d.name;
                labelName.Location = new Point(20, 10);
                labelName.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                labelName.AutoSize = true;

                Label labelDes = new Label();
                labelDes.Text = d.description;
                labelDes.Location = new Point(20, 50);
                labelDes.AutoSize = true;

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

                Button btnUpdate = new Button();
                btnUpdate.BackgroundImage = Image.FromFile("Image/contract.png");
                btnUpdate.BackgroundImageLayout = ImageLayout.Zoom;
                btnUpdate.Location = new Point(580, 10);
                btnUpdate.Size = new Size(55, 35);
                btnUpdate.Tag=d.id;


                btnUpdate.Click += (clickButton, eventArgs) =>
                {
                    Button buttonUpdate = clickButton as Button;
                    UpdateDocumentFrm updateFrm = new UpdateDocumentFrm();
                    updateFrm.course_id  = course_id;
                    updateFrm.doc_id = d.id;
                    if (d.linkyoutube != null && d.linkyoutube != "")
                        updateFrm.linkVideoYouube = "https://www.youtube.com/watch?v=" + d.linkyoutube;
                    updateFrm.nameDoc = d.name;
                    updateFrm.desDoc = d.description;
                    updateFrm.nameFile = d.filename;
                    if (updateFrm.ShowDialog()==DialogResult.OK)
                    {
                        fillData();
                    }

                };

                Button btnDelete = new Button();
                btnDelete.BackgroundImage = Image.FromFile("Image/delete.png");
                btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
                btnDelete.Location = new Point(580, 55);
                btnDelete.Size = new Size(55, 40);
                btnDelete.Tag = d.id;

                btnDelete.Click += (clickButton, eventArgs) =>
                {
                    Button buttonDelete = clickButton as Button;
                    Dictionary<string, object> dic = new Dictionary<string, object>
                    {
                        {"MaTL",d.id}, {"MaKH",course_id}
                    };
                    DialogResult res = MessageBox.Show("Bạn có chắc muốn xoá tài liệu này?", "Xoá Tài Liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.Yes)
                    {
                        if (documentDAO.delete("TaiLieu", dic))
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

                panelCourse.Controls.Add(btnUpdate);
                panelCourse.Controls.Add(btnDelete);
                panelCourse.Controls.Add(labelName);
                panelCourse.Controls.Add(labelDes);
                panelCourse.Controls.Add(lblFileName);


                if (d.linkyoutube != null && d.linkyoutube!="")
                {
                    WebBrowser webBrowser = new WebBrowser();
                    webBrowser.Location = new Point(20, 103);
                    webBrowser.Size = new Size(350, 200);

                    var embed = "<html><head>" +
                "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                "</head><body>" +
                "<iframe width=\"300\" src=\"{0}\"" +
                "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                "</body></html>";
                    string url = "https://www.youtube.com/embed/" + d.linkyoutube;
                    webBrowser.DocumentText = string.Format(embed, url);

                    panelCourse.Controls.Add(webBrowser);
                    panelCourse.Height += 130;
                }
                

                
                

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

        private void panelDocument_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
