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
    public partial class AddAttendaceFrm : Form
    {
        public string id_course {  get; set; }
        AttendanceDAO attendanceDAO = new AttendanceDAO();
        
        public AddAttendaceFrm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime dateAtt = dateTimeAttend.Value;
            DateTime currentTime = DateTime.Now;
            string tableName = "DiemDanh";
            Dictionary<string, object> values = new Dictionary<string, object>
            {
                {"MaMH",id_course }, {"NgayGioDiemDanh", dateAtt }

            };
            if (dateAtt >= currentTime)
            {
                if (attendanceDAO.insert(tableName, values))
                {
                    MessageBox.Show("Đã thêm điểm danh!!!");
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng giao thời hạn hợp lệ!!!","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}
