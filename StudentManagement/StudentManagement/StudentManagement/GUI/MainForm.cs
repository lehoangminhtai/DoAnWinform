using StudentManagement.DAO;
using StudentManagement.Entity;
using StudentManagement.GUI;
using StudentManagement.GUI.ForumGUI;
using StudentManagement.GUI.NotificationGUI;
using StudentManagement.GUI.ScoreGUI;
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
            if (role != 3)
            {
                btnADMIN.Visible = false;
            }
            getInfor();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void getInfor()
        {
            lblChucVu.Text = "Học Sinh";
            string sql = $"select CONCAT(hs.Ho,' ',hs.Ten) as hoten from HocSinh hs where hs.MaSV='{sid}'";
            if (role == 2)
            {
                lblChucVu.Text = "Giảng Viên";
                sql = $"select CONCAT(gv.Ho,' ',gv.Ten) as hoten from GiangVien gv where gv.MaGV='{sid}'";
            }
            try
            {
                db.openConnection();
                SqlCommand cmd = new SqlCommand(sql, db.getConnection);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) 
                    {

                        lblHoTen.Text = reader.GetString(0);
                    }

                }
                //db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { db.closeConnection(); }
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
           UcScore ucScore = new UcScore();
            ucScore.sid = sid;
            ucScore.role = role;
            // Thêm panelCourse vào panelMain
            panelMain.Controls.Add(ucScore);
        }

        private void btnForum_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            UcForum ucforum = new UcForum();
            ucforum.id_User = sid;
            ucforum.role = role;
            // Thêm panelCourse vào panelMain
            panelMain.Controls.Add(ucforum);
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            UcNotification ucNoti = new UcNotification();
            ucNoti.id_user = sid;
            ucNoti.role = role;
            // Thêm panelCourse vào panelMain
            panelMain.Controls.Add(ucNoti);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
