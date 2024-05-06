using StudentManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.GUI.NotificationGUI
{
    public partial class AddNotificationFrm : Form
    {
        public string id_course { get; set; }
        public bool isUpdate { get; set; }
        public int id_Noti {  get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string courseName {  get; set; }
        public DateTime dateTime { get; set; }
        string tableNameNoti = "ThongBao";
        NotificationDAO notificationDAO = new NotificationDAO();
        public AddNotificationFrm()
        {
            InitializeComponent();
        }

        private void AddNotificationFrm_Load(object sender, EventArgs e)
        {
            txtCourseName.Text = courseName;
            if (isUpdate)
            {
                txtTitle.Text = title;
                txtContent.Text = description;
                dateTimeHappen.Value = dateTime;
            }

        }
        private void insertNoti()
        {
            Dictionary<string, object> valueNoti = new Dictionary<string, object>
                            {
                                { "MaMH",  id_course},
                                { "TieuDe", txtTitle.Text.Trim() },
                {"NoiDung",txtContent.Text.Trim()},
                                {"NgayDienRa",dateTimeHappen.Value }
            };
            if(notificationDAO.inserNoti(tableNameNoti, valueNoti))
            {
                MessageBox.Show("Đã thông báo");
                this.DialogResult = DialogResult.OK;
            }
        } 
        private void updateNoti() {
            string condition = $" MaTB = '{id_Noti}'";
            Dictionary<string, object> valueNoti = new Dictionary<string, object>
                            {
                                
                                { "TieuDe", txtTitle.Text.Trim() },
                {"NoiDung",txtContent.Text.Trim()},
                                {"NgayDienRa",dateTimeHappen.Value }
            };
            if(notificationDAO.updateNoti(tableNameNoti, valueNoti, condition))
            {
                MessageBox.Show("Đã cập nhật thông báo");
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnAddNoti_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text!="")
            {
                DateTime deadline = dateTimeHappen.Value;
                DateTime currentTime = DateTime.Now;
                if (deadline >= currentTime)
                {
                    if (!isUpdate)
                    {
                        insertNoti();
                    }
                    else
                    {
                        updateNoti();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập giờ diễn ra trong tương lai !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tiêu đề cho thông báo !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
