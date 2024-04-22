using StudentManagement.DAO;
using StudentManagement.Entity;
using StudentManagement.GUI;
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

namespace StudentManagement
{
    public partial class MainForm : Form
    {
        public  int role {  get; set; }
        public string sid {  get; set; }
        
        XJDBC db = new XJDBC();
        CourseDAO courseDAO = new CourseDAO();

        public bool isTimeRegisterCourse = true;
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
            try
            {
                UcInformation ucInformation = new UcInformation();
                ucInformation.Dock = DockStyle.Fill;

                ucInformation.role = role;
                ucInformation.id = sid;

                panelMain.Controls.Clear();
                panelMain.Controls.Add(ucInformation);
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isTimeRegisterCourse == true)
            {
                panelMain.Controls.Clear();
                UCRegisterCourse ucResCourse = new UCRegisterCourse();
                ucResCourse.sid = sid;
                ucResCourse.role = role;
                    // Thêm panelCourse vào panelMain
                 panelMain.Controls.Add(ucResCourse);
                

            }
            else
            {
                panelMain.Controls.Clear();
                Label lblNotice = new Label();
                lblNotice.Text = "Chưa đến thời hạn đăng ký học phần\nVui lòng quay lại sau";
                lblNotice.Font= new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
                lblNotice.AutoSize = true;
               
                panelMain.Controls.Add(lblNotice);
            }

        }
       
        private void btnADMIN_Click(object sender, EventArgs e)
        {
            ADMINForm form = new ADMINForm();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
           UCCourseList ucCourseList = new UCCourseList();
            ucCourseList.sid = sid;
            ucCourseList.role = role;
            // Thêm panelCourse vào panelMain
            panelMain.Controls.Add(ucCourseList);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            sid = ACCOUNT.id;
            role = ACCOUNT.role;
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
