using StudentManagement.DAO;
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

namespace StudentManagement.GUI.NotificationGUI
{
    public partial class UcNotificationTeacher : UserControl
    {
        public string id_user { get; set; }
        public int role { get; set; }
        XJDBC db = new XJDBC();
        Data data = new Data();
        public string id_course { get; set; }
        private int id_Noti = 0;
        private string nameCourse {  get; set; }
        DateTime dateNoti = new DateTime();
        NotificationDAO notificationDAO = new NotificationDAO();
        public UcNotificationTeacher()
        {
            InitializeComponent();
        }

        private void dateTimeDeadline_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UcNotificationTeacher_Load(object sender, EventArgs e)
        {
           fillData();
           if(role==1)
                btnAddNoti.Visible = false;
        }
        private void fillData()
        {
            btnDeleteNoti.Visible = false;
            btnUpdateNoti.Visible = false;
            fillListBoxCourse();
            fillListBoxNoti();
        }

        private void fillListBoxCourse()
        {
            try
            {
                (string year, string semester) = data.GetYearAndSemester();
                string sql = "";
                if (role == 1)
                {
                    sql = "Select d.MaKH, kh.TenKH from Diem d join KhoaHoc kh on d.MaKH = kh.MaKH join GiangVien gv on kh.MaGV = gv.MaGV where d.MaSV='" + id_user + "' and kh.NamHoc like '%" + year + "%' and kh.HocKy ='" + semester + "'";

                }
                if (role == 2)
                {
                    sql = "Select kh.MaKH, kh.TenKH from KhoaHoc kh join GiangVien gv on kh.MaGV=gv.MaGV where kh.MaGV= '" + id_user + "' and kh.NamHoc like '%" + year + "%' and kh.HocKy ='" + semester + "'";

                }
                db.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, db.getConnection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                listBoxCourse.DisplayMember = "TenKH"; // DisplayMember is the column name for display
                listBoxCourse.ValueMember = "MaKH";     // ValueMember is the column name for value
                listBoxCourse.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đường dẫn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { db.closeConnection(); }
        }

        private void fillListBoxNoti()
        {
            try
            {

                string sql = $"select tb.MaTB, tb.TieuDe from ThongBao tb where tb.MaMH='{id_course}' ORDER BY tb.MaTB DESC";

                db.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, db.getConnection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                listBoxNoti.DisplayMember = "TieuDe"; // DisplayMember is the column name for display
                listBoxNoti.ValueMember = "MaTB";     // ValueMember is the column name for value
                listBoxNoti.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đường dẫn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { db.closeConnection(); }
        }

        private void listBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "";
            txtContent.Text = "";
            lblTimeRemain.Text = "";
            id_Noti = 0;
            id_course = listBoxCourse.SelectedValue.ToString();
            fillListBoxNoti();
            if (id_Noti == 0)
            {
                btnDeleteNoti.Visible = false;

                btnUpdateNoti.Visible = false;
            }
            nameCourse = listBoxCourse.Text.Trim();
           
        }

        private void listBoxNoti_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_Noti = Convert.ToInt32(listBoxNoti.SelectedValue.ToString());
            showDetailNotification();
            if (role == 2 && id_Noti != 0)
            {
                btnUpdateNoti.Visible = true;
                btnDeleteNoti.Visible = true;
            }
        }
        private void showDetailNotification()
        {
            try
            {
                SqlCommand cmd = new SqlCommand($"select tb.TieuDe, tb.NoiDung, tb.NgayDienRa from ThongBao tb where tb.MaTB='{id_Noti}'", db.getConnection);
                db.openConnection();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        string title = reader["TieuDe"].ToString();
                        string content = reader["NoiDung"].ToString();
                        DateTime date = reader.GetDateTime(2);
                        dateNoti = date;

                        lblTitle.Text = title;
                        txtContent.Text = content;
                        lblTimeRemain.Text = date.ToString(" dd/MM/yyyy hh:mm");
                    }
                }
                

            }
            catch { }
            finally { db.closeConnection(); }
        }

        private void btnAddNoti_Click(object sender, EventArgs e)
        {
            AddNotificationFrm frm = new AddNotificationFrm();
            frm.isUpdate = false;
            frm.id_course = id_course;
            frm.courseName = nameCourse;
            if(frm.ShowDialog() == DialogResult.OK)
            {
                fillListBoxNoti();
            }
        }

        private void btnUpdateNoti_Click(object sender, EventArgs e)
        {
            AddNotificationFrm frm = new AddNotificationFrm();
            frm.isUpdate = true;
            frm.id_course = id_course;
            frm.courseName = nameCourse;
            frm.title=lblTitle.Text;
            frm.description=txtContent.Text.Trim();
            frm.dateTime = dateNoti;
            frm.id_Noti = id_Noti;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                showDetailNotification();
            }
        }

        private void btnDeleteNoti_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Xoá thông báo ?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                string tableName = "ThongBao";
                Dictionary<string, object> dic = new Dictionary<string, object> {
                    {"MaTB",id_Noti}
                };
                if(notificationDAO.deleteNoti(tableName,dic))
                {
                    MessageBox.Show("Đã xoá thông báo!!!");
                    lblTitle.Text = "";
                    txtContent.Text = "";
                    lblTimeRemain.Text = "";
                    fillListBoxNoti();
                    btnDeleteNoti.Visible=false;
                    btnUpdateNoti.Visible=false;
                }
            }
        }

    }
}
