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

namespace StudentManagement.GUI.AttendanceGUI
{
    public partial class AttendanceResult : Form
    {
        AttendanceDAO attendanceDAO = new AttendanceDAO();
        public DateTime date {get;set;}
        public string id_course { get;set;}
        public int id_attend { get;set;}
        string sql = $"select ct.MaSV as \"Mã SV\", hs.Ho as \"Họ\", hs.Ten as \"Tên\" from ChiTietDiemDanh ct join HocSinh hs on hs.MaSV = ct.MaSV where ";
        public AttendanceResult()
        {
            InitializeComponent();
        }

        private void AttendanceResult_Load(object sender, EventArgs e)
        {
            lblCount.Text = "";
            lblCountAttend.Text = "";
            lblCountAbsent.Text = "";
            lblDate.Text = date.ToString("dd/MM/yyyy");
            fillData();
        }
        private void fillData()
        {
            fillgrid();
            int countAttend = count($"select count(*) from  ChiTietDiemDanh ct where ct.MaMH='{id_course}' and ct.MaDD='{id_attend}'");
            int countsum = count($"select count(*) from  Diem d where d.MaKH='{id_course}'");
            int countAbsent = countsum - countAttend;

            lblCount.Text = "" + countsum;
            lblCountAttend.Text = "" + countAttend;
            lblCountAbsent.Text = "" + countAbsent;

        }
        private void fillgrid()
        {
            string condition = $"ct.MaDD = '{id_attend}' and ct.MaMH ='{id_course}'";
            attendanceDAO.fillData(sql+condition, dataGVResult);
        }
        private int count(string sqlcount)
        {
           
            return attendanceDAO.count(sqlcount);
        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }
    }
}
