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

namespace StudentManagement.GUI.SubmitHwGUI
{
    public partial class AddSubmitHwFrm : Form
    {
        public string id_Student { get; set; }
        public int idHW { get; set; }
        public string id_Course { get; set; }
        SubmitHomeworkDAO hwDetailDao = new SubmitHomeworkDAO();
        private string file { get; set; }
        private string nameFile { get; set; }
        private string homeworkTableName = "ChiTietNopBai";
        public bool isSubmit {  get; set; }
        public AddSubmitHwFrm()
        {
            InitializeComponent();
        }

        private void AddSubmitHwFrm_Load(object sender, EventArgs e)
        {
            linklblFileName.Text = "";
            
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            (string filePath, string filename) = hwDetailDao.openFile();
            file = filePath;
            nameFile = filename;
            linklblFileName.Text = nameFile;
        }
        private void addHomeworkSubmit()
        {
            try
            {
                DateTime currentTime = DateTime.Now;
                byte[] buffer;

                if (nameFile != null && file != null)
                {
                    using (Stream stream = File.OpenRead(file))
                    {
                        buffer = new byte[stream.Length];
                        stream.Read(buffer, 0, buffer.Length);
                    }

                    Dictionary<string, object> values = new Dictionary<string, object>
                            {
                        {"MaBT",idHW },
                        {"MaSV",id_Student },
                        {"MaKH",id_Course },
                        {"FileNop",buffer },
                        {"TenFile",nameFile},
                        {"NgayNop",currentTime },
                        {"TrangThai","Ungraded" }


                            };
                    if (hwDetailDao.insert(homeworkTableName, values))
                    {
                        MessageBox.Show("Đã nộp bài!!!");
                        DialogResult = DialogResult.OK;

                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn file!!!", "Lỗi nộp bài", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch { MessageBox.Show("Thông tin không hợp lệ!!!"); }

        }

        private void updateHomeworkSubmit()
        {
            try
            {
                DateTime currentTime = DateTime.Now;
                byte[] buffer;

                if (nameFile != null && file != null)
                {
                    using (Stream stream = File.OpenRead(file))
                    {
                        buffer = new byte[stream.Length];
                        stream.Read(buffer, 0, buffer.Length);
                    }

                    Dictionary<string, object> values = new Dictionary<string, object>
                            {
                        
                        {"FileNop",buffer },
                        {"TenFile",nameFile},
                        {"NgayNop",currentTime },
                        {"TrangThai","Ungraded" }


                            };
                    string condition = $" MaBT ='{idHW}' and MASV ='{id_Student}' and MaKH = '{id_Course}'";

                    if (hwDetailDao.update(homeworkTableName, values,condition))
                    {
                        MessageBox.Show("Đã thay đổi bài nộp!!!");
                        DialogResult = DialogResult.OK;

                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn file!!!", "Lỗi nộp bài", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch { MessageBox.Show("Thông tin không hợp lệ!!!"); }

        }

        private void btnSaveSubmit_Click(object sender, EventArgs e)
        {
            if(isSubmit)
                updateHomeworkSubmit();
            else
                addHomeworkSubmit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
