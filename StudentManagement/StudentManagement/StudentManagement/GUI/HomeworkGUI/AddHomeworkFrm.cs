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

namespace StudentManagement.GUI.HomeworkGUI
{
    public partial class AddHomeworkFrm : Form
    {
        public string course_id {  get; set; }
        private string file { get; set; }
        private string nameFile { get; set; }
        private string homeworkTableName = "BaiTap";
        HomeworkDAO homeworkDAO = new HomeworkDAO();
        Data data = new Data();
        public AddHomeworkFrm()
        {
            InitializeComponent();
        }

        private void AddHomeworkFrm_Load(object sender, EventArgs e)
        {

        }
        private void addHomework()
        {
            try
            {
                string docName = txtNameDoc.Text.Trim();
                string description = txtDescription.Text;
                DateTime deadline = dateTimeDeadline.Value;
                DateTime currentTime = DateTime.Now;
                byte[] buffer;
                if (data.ValidateNotNull(docName))
                {
                    if(deadline >= currentTime)
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
                                { "TenBaiTap", docName },
                                {"YeuCau",description },
                                {"FileBT",buffer },
                                {"TenFile",nameFile},
                                {"NgayMo",currentTime },
                                {"HanNop",deadline }


                            };
                            if (homeworkDAO.insert(homeworkTableName, values))
                            {
                                MessageBox.Show("Đã giao bài tập!!!");
                                DialogResult = DialogResult.OK;

                            }
                        }

                        else
                        {
                            Dictionary<string, object> values = new Dictionary<string, object>
                            {
                                { "MaKH",  course_id},
                                { "TenBaiTap", docName },
                                { "YeuCau",description },
                                 {"NgayMo",currentTime },
                                {"HanNop",deadline }

                            };
                            if (homeworkDAO.insert(homeworkTableName, values))
                            {
                                MessageBox.Show("Đã giao bài tập!!!");
                                DialogResult = DialogResult.OK;

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng giao hạn nộp hợp lệ!!", "Hạn Nộp", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            (string filePath, string filename) = homeworkDAO.openFile();
            file = filePath;
            nameFile = filename;
            linklblFileName.Text = nameFile;
        }

        private void btnAddHomework_Click(object sender, EventArgs e)
        {
            addHomework();
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            file = null;
            nameFile =null;
            linklblFileName.Text = "Tải file lên";
        }
    }
}
