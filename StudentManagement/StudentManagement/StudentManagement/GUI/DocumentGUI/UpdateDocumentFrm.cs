using StudentManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.GUI.DocumentGUI
{
    public partial class UpdateDocumentFrm : Form
    {
        public string course_id { get; set; }
        public int doc_id { get; set; }
        public string nameDoc { get; set; }
        public string desDoc { get; set; }
        
        private string file { get; set; }
        public string nameFile { get; set; }
        public string linkVideoYouube { get; set; }
        private string documentTableName = "TaiLieu";
        DocumentDAO documentDAO = new DocumentDAO();
        Data data = new Data();
        public UpdateDocumentFrm()
        {
            InitializeComponent();
        }

        private void UpdateDocumentFrm_Load(object sender, EventArgs e)
        {
            txtNameDoc.Text = nameDoc;
            txtDescription.Text = desDoc;
            txtUrl.Text = linkVideoYouube;
            linklblFileName.Text = nameFile;
        }

        private void btnUpdateDoc_Click(object sender, EventArgs e)
        {
            
            updateDoc();
        }
        private void updateDoc()
        {
           try
            {
                string docName = txtNameDoc.Text.Trim();
                string description = txtDescription.Text;
                string idvideo = documentDAO.getIdYoutubeVideo(txtUrl.Text.Trim());
                //string url = "https://www.youtube.com/embed/" + idvideo;
                byte[] buffer;

                string condition = " MaTL='" + doc_id + "' and MaKH = '" + course_id+"'";
                if (data.ValidateNotNull(docName))
                {
                    if (file != null)
                    {
                        using (Stream stream = File.OpenRead(file))
                        {
                            buffer = new byte[stream.Length];
                            stream.Read(buffer, 0, buffer.Length);
                        }

                        Dictionary<string, object> values = new Dictionary<string, object>
                            {
                               
                                { "TenTL", docName },
                                {"MoTa",description },
                                {"FileTaiLieu",buffer },
                                {"TenFile",nameFile },
                                {"LinkYoutube",idvideo }

                            };
                        if (documentDAO.update(documentTableName, values,condition))
                        {
                            MessageBox.Show("Cập nhật Khoá Học thành công");
                            DialogResult = DialogResult.OK;

                        }
                    }

                    else
                    {
                        Dictionary<string, object> values = new Dictionary<string, object>
                            {
                                
                                { "TenTL", docName },
                                { "MoTa",description },
                                {"LinkYoutube",idvideo }
                            };
                        if (documentDAO.update(documentTableName, values, condition))
                        {
                            MessageBox.Show("Cập nhật Khoá Học thành công");
                            DialogResult = DialogResult.OK;

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

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            (string filePath, string filename) = documentDAO.openFile();
            file = filePath;
            nameFile = filename;
            linklblFileName.Text = nameFile;
        }
    }
}
