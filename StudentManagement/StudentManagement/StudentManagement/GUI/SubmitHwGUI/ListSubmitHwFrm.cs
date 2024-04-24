using StudentManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.GUI.SubmitHwGUI
{
    public partial class ListSubmitHwFrm : Form
    {
        public int id_hw {  get; set; }
        public string id_course { get; set; }
        public string name_hw {  get; set; }
        SubmitHomeworkDAO submitHomeworkDAO = new SubmitHomeworkDAO();
        public string tablename = "ChiTietNopBai";
        public string sql = "select ct.MaSV as \"Mã Sinh Viên\", CONCAT(hs.Ho,' ',hs.Ten) as \"Họ Tên\",ct.TenFile as \"Bài Nộp\",ct.Diem as \"Điểm\" from ChiTietNopBai ct join HocSinh hs on ct.MaSV = hs.MaSV where ";
        Data data = new Data();
        public string condition {  get; set; }
        public ListSubmitHwFrm()
        {
            InitializeComponent();
        }

        private void ListSubmitHwFrm_Load(object sender, EventArgs e)
        {
            linklblFileName.Text = "";
            lblCount.Text = "";
            fillData();
        }
        public void fillData()
        {
            condition = "ct.MaKH ='" + id_course + "' and ct.MaBT='" + id_hw + "'";
            fillGV(sql+condition);
            countSubmit(condition);
        }
        public void refresh()
        {
            fillGV(sql + condition);
            countSubmit(condition);
        }
        private void countSubmit(string condition)
        {
            string sqlCount = "select COUNT(*) from ChiTietNopBai ct join HocSinh hs on ct.MaSV = hs.MaSV where " + condition;
            lblCount.Text = submitHomeworkDAO.count(sqlCount).ToString();
        }
        private void fillGV(string sql)
        {
            submitHomeworkDAO.fillData(sql, dataGVlistHW);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search =txtSearch.Text.Trim();

            if (search != "")
            {
                condition = $"CONCAT(ct.MaSV,hs.Ho,hs.Ten) like '%{search}%'";
                string sql = "select ct.MaSV as \"Mã Sinh Viên\", CONCAT(hs.Ho,' ',hs.Ten) as \"Họ Tên\",ct.TenFile as \"Bài Nộp\",ct.Diem as \"Điểm\" from ChiTietNopBai ct join HocSinh hs on ct.MaSV = hs.MaSV where " + condition;
                Dictionary<string, object> values = new Dictionary<string, object>
                {
                    {"@search",$"%{search}%" }
                };
                fillGV(sql);

               
                countSubmit(condition);
            }
        }

        private void cmbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterStatus.SelectedIndex == 0)
            {
                
                 condition = $"ct.TrangThai = 'Graded' and ct.MaBT = '{id_hw}'";
               
                fillGV(sql+condition);


                countSubmit(condition);
            }
            if (cmbFilterStatus.SelectedIndex == 1)
            {

                 condition = "ct.TrangThai = 'Ungraded'";

                fillGV(sql + condition);


                countSubmit(condition);
            }
        }

        private void dataGVlistHW_Click(object sender, EventArgs e)
        {
            string sid = dataGVlistHW.CurrentRow.Cells[0].Value.ToString();
            string name = dataGVlistHW.CurrentRow.Cells[1].Value.ToString();
            string filename = dataGVlistHW.CurrentRow.Cells[2].Value.ToString();
            string grade = dataGVlistHW.CurrentRow.Cells[3].Value.ToString();

            txtIDSTD.Text = sid;
            txtNameSTD.Text = name;
            txtGrade.Text = grade;
            linklblFileName.Text = filename;
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            try
            {
                string sid = txtIDSTD.Text.Trim();
                double grade = Convert.ToDouble(txtGrade.Text.Trim());

                if (data.ValidateNotNull(sid, grade))
                {
                   string  condition1 = $" MaBT = '{id_hw}' and MaSV = '{sid}' and MaKH = '{id_course}'";
                    Dictionary<string,object> dic = new Dictionary<string, object> {
                        {"Diem",grade}, {"TrangThai","Graded"}
                    };
                    if (submitHomeworkDAO.update(tablename, dic, condition1))
                    {
                        MessageBox.Show("Đã chấm điểm cho SV: " + sid + "--" + txtNameSTD.Text);
                        refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn học sinh để nhập điểm!!!", "Nhập điểm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch {
                MessageBox.Show("Vui lòng chọn học sinh để nhập điểm!!!", "Nhập điểm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Loại bỏ ký tự không hợp lệ
            }
        }

        private void linklblFileName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string sql = "select FileNop from ChiTietNopBai where MaBT = '" + id_hw + "' and MaKH ='" + id_course + "' and MaSV ='" + txtIDSTD.Text.Trim() + "'";

            submitHomeworkDAO.downloadFile(linklblFileName.Text, sql);
        }
    }
}
