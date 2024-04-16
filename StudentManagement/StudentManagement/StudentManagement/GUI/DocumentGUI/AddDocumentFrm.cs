using StudentManagement.DAO;
using StudentManagement.Entity;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.GUI.Document
{
    public partial class AddDocumentFrm : Form
    {
        public string course_id {  get; set; }
        private string file { get; set; }
        private string nameFile { get; set; }
        private string documentTableName = "TaiLieu";
        DocumentDAO documentDAO = new DocumentDAO();
        Data data= new Data();
        public AddDocumentFrm()
        {
            InitializeComponent();
        }

        private void AddDocumentFrm_Load(object sender, EventArgs e)
        {
           
        }

        public void addCourse()
        {
            try
            {
                string docName = txtNameDoc.Text.Trim();
                string description = txtDescription.Text;

                byte[] buffer;





                if (data.ValidateNotNull(docName))
                {


                    if (nameFile != null && file != null)
                    {
                        using (Stream stream = File.OpenRead(file))
                        {
                            buffer = new byte[stream.Length];
                            stream.Read(buffer, 0, buffer.Length);
                        }

                        Dictionary<string, object> values = new Dictionary<string, object>
                            {
                                { "MaKH",  course_id},
                                { "TenTL", docName },
                                {"MoTa",description },
                                {"FileTaiLieu",buffer },
                                {"TenFile",nameFile }

                            };
                        if (documentDAO.insert(documentTableName, values))
                        {
                            MessageBox.Show("Thêm Khoá Học thành công");
                            
                        }
                    }

                    else
                    {
                        Dictionary<string, object> values = new Dictionary<string, object>
                            {
                                { "MaKH",  course_id},
                                { "TenTL", docName },
                                { "MoTa",description }
                            };
                        if (documentDAO.insert(documentTableName, values))
                        {
                            MessageBox.Show("Thêm Khoá Học thành công");
                            
                        }
                    }




                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                }
            }
            catch { MessageBox.Show("Vui lòng nhập thông tin hợp lệ!!!"); }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            (string filePath, string filename) = documentDAO.openFile();
            file = filePath;
            nameFile = filename;
            linklblFileName.Text = nameFile;
        }

        private void btnAddDoc_Click(object sender, EventArgs e)
        {
            addCourse();
            DialogResult = DialogResult.OK;
        }
    }
}
