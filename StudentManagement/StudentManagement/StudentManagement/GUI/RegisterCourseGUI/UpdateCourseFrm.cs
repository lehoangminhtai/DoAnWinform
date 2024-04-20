using StudentManagement.DAO;
using StudentManagement.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.GUI.RegisterCourseGUI
{
    public partial class UpdateCourseFrm : Form
    {
        public string cid {  get; set; }
        public string name { get; set; }
        public string numcre { get; set; }
        public string des { get; set; }
        public UpdateCourseFrm()
        {
            InitializeComponent();
        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            try
            {
                string courseName = txtCourseName.Text.Trim();
                string numCre = txtNumCreadit.Text.Trim();
                int numCreadit = Convert.ToInt32(numCre);
                string description = txtDescription.Text;
                CourseDAO courseDAO = new CourseDAO();
                if (courseDAO.ValitdatNotNull( courseName, numCre))
                {
                    string condition = "MaKH = '" + cid + "'";
                    Dictionary<string,object> dic = new Dictionary<string, object> {
                        {"TenKh",courseName}, {"SoTC",numCreadit},{"MoTa",description}
                    };
                    if (courseDAO.updateCourse("KhoaHoc", dic, condition))
                    {
                        MessageBox.Show("Cập nhật khoá học thành công !!!");
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                }
            }
            catch { }
        }

        private void txtNumCreadit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void UpdateCourseFrm_Load(object sender, EventArgs e)
        {
            txtCourseName.Text = name;
            txtDescription.Text = des;
            txtNumCreadit.Text = numcre;
            
        }
    }
}
