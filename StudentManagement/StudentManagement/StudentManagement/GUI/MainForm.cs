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
        public int role {  get; set; }
        public string sid = "21110635";
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

            UcInformation ucInformation = new UcInformation();
            ucInformation.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucInformation);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isTimeRegisterCourse == true)
            {
                panelMain.Controls.Clear();
                SqlCommand cmd = new SqlCommand("Select MaKH, TenKH, CONCAT(v.Ho, ' ', v.Ten) as GiangVien  from KhoaHoc k join GiangVien v on k.MaGV = v.MaGV");
                int panelY = 10;
                string cid = null;
                List<COURSE> list = courseDAO.getListCourse(cmd);
                foreach (var c in list)
                {
                    Panel panelCourse = new Panel();
                    panelCourse.BorderStyle = BorderStyle.FixedSingle;
                    panelCourse.Location = new Point(10, panelY);
                    panelCourse.Size = new Size(450, 130);
                    panelCourse.Margin = new Padding(10);



                    Label labelId = new Label();
                    labelId.Text = c.id;
                    labelId.Location = new Point(20, 10);
                    labelId.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);

                    Label labelName = new Label();
                    labelName.Text = c.name;
                    labelName.Location = new Point(20, 50);
                    labelName.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                    labelName.ForeColor = Color.DarkCyan;
                    labelName.AutoSize = true;

                    Label labelTeacher = new Label();
                    labelTeacher.Text = c.teacherName;
                    labelTeacher.Location = new Point(20, 90);

                    Button buttonRegister = new Button();
                    buttonRegister.Text = "Đăng ký";
                    buttonRegister.Location = new Point(320, 30);
                    buttonRegister.Tag = c.id;
                    cid = c.id;
                    buttonRegister.Click += (clickedButton, eventArgs) =>
                    {

                        Button button = clickedButton as Button;
                        cid = button.Tag as string;
                        MessageBox.Show(cid);
                    };
                    if (isRegisterCourse(cid, sid))
                    {

                        buttonRegister.Enabled = false;
                    }
                    if (isRegisterCourse(cid, sid))
                    {
                        Button btnDelete = new Button();
                        btnDelete.Text = "Xoá học phần";
                        btnDelete.Location = new Point(320, 70);
                        btnDelete.Tag = c.id;
                        btnDelete.BackColor = Color.Red;
                        btnDelete.AutoSize = true;
                        panelCourse.Controls.Add(btnDelete);


                        btnDelete.Click += (clickedButton, eventArgs) =>
                        {

                            Button button = clickedButton as Button;
                            cid = button.Tag as string;
                            MessageBox.Show(cid);
                        };
                    }

                    panelCourse.Controls.Add(labelId);
                    panelCourse.Controls.Add(labelName);
                    panelCourse.Controls.Add(labelTeacher);
                    panelCourse.Controls.Add(buttonRegister);

                    panelY += panelCourse.Height + 10;
                    // Thêm panelCourse vào panelMain
                    panelMain.Controls.Add(panelCourse);
                }

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
        private bool isRegisterCourse(string cid,string sid)
        {
           
            if(checkRegisterCourse(cid,sid))
                return true;
            else return false;
        }
        private bool checkRegisterCourse(string cid,string sid)
        {
            
                db.openConnection();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Diem WHERE MaKH = @cid AND MaSV = @sid", db.getConnection);
                cmd.Parameters.AddWithValue("@cid", cid);
                cmd.Parameters.AddWithValue("@sid", sid);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
           
        }

        private void btnADMIN_Click(object sender, EventArgs e)
        {
            ADMINForm form = new ADMINForm();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
