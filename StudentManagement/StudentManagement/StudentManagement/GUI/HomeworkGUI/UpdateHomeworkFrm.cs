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
    public partial class UpdateHomeworkFrm : Form
    {
        public string course_id { get; set; }
        public int hw_id { get; set; }
        public string nameHW { get; set; }
        public string desHW { get; set; }

        private string file { get; set; }
        public string nameFile { get; set; }
        public DateTime dealine { get; set; }

        private string homeworkTableName = "BaiTap";
        HomeworkDAO homeworkDAO = new HomeworkDAO();
        Data data = new Data();
        public UpdateHomeworkFrm()
        {
            InitializeComponent();
        }

        private void UpdateHomeworkFrm_Load(object sender, EventArgs e)
        {
            txtNameHW.Text = nameHW;
            txtDescription.Text = desHW;
            linklblFileName.Text = nameFile;
            dateTimeDeadline.Value = dealine;
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            (string filePath, string filename) = homeworkDAO.openFile();
            file = filePath;
            nameFile = filename;
            linklblFileName.Text = nameFile;
        }

        private void btnUpdateHomework_Click(object sender, EventArgs e)
        {
            updateHomework();
        }
        private void updateHomework()
        {
            try
            {
                string hwName = txtNameHW.Text.Trim();
                string description = txtDescription.Text;
                DateTime deadline = dateTimeDeadline.Value;
                
                string condition = " MaBT = '" + hw_id + "' and MaKH = '" + course_id + "'";
                byte[] buffer;
                if (data.ValidateNotNull(hwName))
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
                                
                                { "TenBaiTap", hwName },
                                {"YeuCau",description },
                                {"FileBT",buffer },
                                {"TenFile",nameFile},
                                {"HanNop",deadline }


                            };
                            if (homeworkDAO.update(homeworkTableName, values,condition))
                            {
                                MessageBox.Show("Chỉnh sửa bài tập thành công!!!");
                                DialogResult = DialogResult.OK;

                            }
                        }
                    else if (linklblFileName.Text == "" && file == null)
                    {
                        Dictionary<string, object> values = new Dictionary<string, object>
                            {

                                { "TenBaiTap", hwName },
                                { "YeuCau",description },
                                {"HanNop",deadline }
                            };
                        if (homeworkDAO.update(homeworkTableName, values, condition)&& homeworkDAO.updateFileToNull(homeworkTableName,"FileBT","TenFile",condition))
                        {
                            MessageBox.Show("Chỉnh sửa bài tập thành công!!!");
                            DialogResult = DialogResult.OK;

                        }
                    }
                    else
                        {
                            Dictionary<string, object> values = new Dictionary<string, object>
                            {
                                
                                { "TenBaiTap", hwName },
                                { "YeuCau",description },
                                {"HanNop",deadline }

                            };
                            if (homeworkDAO.update(homeworkTableName, values, condition))
                            {
                                MessageBox.Show("Chỉnh sửa bài tập thành công!!!");
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

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            linklblFileName.Text = "";
            file = null;
        }
    }
}
