using StudentManagement.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UcNotification ucNotification = new UcNotification();
            ucNotification.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucNotification);

        }

        private void btnInfor_Click(object sender, EventArgs e)
        {

            UcInformation ucInformation = new UcInformation();
            ucInformation.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucInformation);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            int numberOfCourses = 10; // Số lượng khóa học
            int panelHeight = 100;
            int panelSpacing = 10;
            int initialY = 10;
            for (int i = 1; i <= numberOfCourses; i=i+1)
            {
                // Tạo mật khẩu ngẫu nhiên cho mỗi khóa học


                // Tạo một panel mới chứa thông tin về khóa học và mật khẩu
                Panel coursePanel = new Panel();
                coursePanel.BorderStyle = BorderStyle.FixedSingle;
                coursePanel.Width = 200;
                coursePanel.Height = 40;
                coursePanel.Location = new System.Drawing.Point(10, initialY + (panelHeight + panelSpacing) * (i - 1));

                Label lblCourse = new Label();
                lblCourse.Text = "Khóa học " + i.ToString();
                lblCourse.Location = new System.Drawing.Point(10, 10);

                Label lblPassword = new Label();
                lblPassword.Text = "Mật khẩu";
                lblPassword.Location = new System.Drawing.Point(10, 30);

                coursePanel.Controls.Add(lblCourse);
                coursePanel.Controls.Add(lblPassword);

                // Thêm panel vào container
                panelMain.Controls.Add(coursePanel);
            }
        }

        private void btnADMIN_Click(object sender, EventArgs e)
        {
            ADMINForm form = new ADMINForm();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
