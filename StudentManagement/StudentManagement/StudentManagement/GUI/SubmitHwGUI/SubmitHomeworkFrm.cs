using StudentManagement.DAO;
using StudentManagement.Entity;
using StudentManagement.GUI.SubmitHwGUI;
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

namespace StudentManagement.GUI.HomeworkGUI
{
    public partial class SubmitHomeworkFrm : Form
    {
        public string id_Student { get; set; }
        public int idHW {  get; set; }
        public string id_Course {  get; set; }
        public string nameHW { get; set; }
       
        public DateTime openDate{ get; set; }
        public DateTime deadline {  get; set; }
        SubmitHomeworkDAO hwDetailDao = new SubmitHomeworkDAO();
        public bool isSubmit = false;
        public DateTime submitDate { get; set; }
        public SubmitHomeworkFrm()
        {
            InitializeComponent();
        }

        private void SubmitHomeworkFrm_Load(object sender, EventArgs e)
        {
           
            fillData();
        }
        public string remainTime(bool isSubmit)
        {
            DateTime currentTime = DateTime.Now;
            TimeSpan timeRemaining = deadline - currentTime;
            string result;
            if (isSubmit)
            {
                timeRemaining =  deadline- submitDate;
                result = $"Bạn đã nộp trước: {timeRemaining.Days} ngày {timeRemaining.Hours} giờ {timeRemaining.Minutes} phút";
                lblTimeRemain.BackColor=Color.LimeGreen;
            }
            else
             if (timeRemaining.TotalSeconds < 0 && isSubmit == false)
            {
                // Quá thời hạn deadline
                timeRemaining = timeRemaining.Duration(); // Lấy giá trị tuyệt đối của timeRemaining để tính thời gian đã quá deadline
                result = $"Bạn đã muộn: {timeRemaining.Days} ngày {timeRemaining.Hours} giờ {timeRemaining.Minutes} phút";
                lblTimeRemain.BackColor = Color.IndianRed;
            }
            else
            {
                // Chưa quá thời hạn deadline
                result = $" {timeRemaining.Days} ngày {timeRemaining.Hours} giờ {timeRemaining.Minutes} phút";
                lblTimeRemain.BackColor = Color.White;
            }
            return result ;
        }
        public void fillData()
        {
            if (deadline < DateTime.Now)
            {
                btnSubmit.Visible = false;
            }
            btnDeleteSubmit.Visible = false;
            lblSubmitStatus.Text = "Chưa Nộp";
            lblSubmitStatus.ForeColor = Color.IndianRed;

            lblTimeRemain.Text = remainTime(isSubmit);
            lblHomeworkName.Text = nameHW;
            lbllinkFileName.Text = "";
            lblSubmitTime.Text = "";
            lblDeadline.Text = deadline.ToString("dddd, dd MMMM yyyy, hh:mm tt");
            lblOpenDlDate.Text = openDate.ToString("dddd, dd MMMM yyyy, hh:mm tt");
            if (hwDetailDao.checkExistSubmit(idHW, id_Course, id_Student))
            {
                
                isSubmit = true;
                showInfor();
                lblTimeRemain.Text = remainTime(isSubmit);
                lblSubmitStatus.Text = "Đã Nộp";
                lblSubmitStatus.ForeColor = Color.LimeGreen;
                
                
            }
        }
        public void showInfor()
        {
            SqlCommand cmd = new SqlCommand("select ct.NgayNop, ct.TrangThai,ct.Diem, ct.TenFile from ChiTietNopBai ct where ct.MaBT ='"+ idHW+"' and ct.MaSV = '"+id_Student+"' and ct.MaKH = '"+id_Course+"'");
            SubmitHWDetail entity = hwDetailDao.getSubmitInfor(cmd);
            if (entity != null)
            {
                lbllinkFileName.Text = entity.filename;
                lblSubmitTime.Text = entity.submitDate.ToString("dddd, dd MMMM yyyy, hh:mm tt");
                submitDate = entity.submitDate;
                if(entity.Grade!=-1)
                {
                    lblGrade.Text = "Đã cho điểm   -  Điểm: " + entity.Grade;
                    btnSubmit.Visible = false;
                    btnDeleteSubmit.Visible= false;
                }
                else
                {
                    btnDeleteSubmit.Visible = true;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            AddSubmitHwFrm frm = new AddSubmitHwFrm();
            frm.idHW = idHW;
            frm.id_Course = id_Course;
            frm.id_Student = id_Student;
            frm.isSubmit = isSubmit;
            if(frm.ShowDialog()==DialogResult.OK)
            {
                fillData();
            }    
        }

        private void lbllinkFileName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string sql = "select FileNop from ChiTietNopBai where MaBT = '" + idHW + "' and MaKH ='" + id_Course + "' and MaSV ='"+id_Student+"'" ;

            hwDetailDao.downloadFile(lbllinkFileName.Text, sql);
        }

        private void btnDeleteSubmit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc muốn xoá bài nộp", "Xoá bài tập", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(res == DialogResult.Yes)
            {
                Dictionary<string, object> dic = new Dictionary<string, object>
                {
                    {"MaBT",idHW}, {"MaKH",id_Course}, {"MaSV", id_Student}
                };
                if (hwDetailDao.delete("ChiTietNopBai", dic))
                {
                    isSubmit = false;
                    fillData();
                }
            }
        }
    }
}
