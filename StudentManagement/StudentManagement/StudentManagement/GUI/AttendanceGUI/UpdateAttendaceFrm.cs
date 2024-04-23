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
    public partial class UpdateAttendaceFrm : Form
    {
        public string id_course {  get; set; }
        public int id_att {  get; set; }
        public DateTime date { get; set; }
        AttendanceDAO attendanceDAO = new AttendanceDAO();
        public UpdateAttendaceFrm()
        {
            InitializeComponent();
        }

        private void UpdateAttendaceFrm_Load(object sender, EventArgs e)
        {
            dateTimeAttend.Value = date;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTime dateAtt = dateTimeAttend.Value;
            DateTime currentTime = DateTime.Now;
            string tableName = "DiemDanh";
            Dictionary<string, object> values = new Dictionary<string, object>
            {
                {"NgayGioDiemDanh", dateAtt }

            };
            string condition = $" MaDD ='{id_att}' and MaMH ='{id_course}'";
            if (dateAtt >= currentTime)
            {
                if (attendanceDAO.update(tableName, values,condition))
                {
                    MessageBox.Show("Đã cập nhật điểm danh!!!");
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng giao thời hạn hợp lệ!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
