using StudentManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.GUI
{
    public partial class ADMINForm : Form
    {
        XJDBC db = new XJDBC();
        Data data = new Data();
        public string idCourse {  get; set; }
        public ADMINForm()
        {
            InitializeComponent();
        }

        private void ADMINForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'giangVien._GiangVien' table. You can move, or remove it, as needed.
            this.giangVienTableAdapter.Fill(this.giangVien._GiangVien);

            this.hocSinhTableAdapter.Fill(this.quanLyHocTapDataSet.HocSinh);



            fillDataGV("select * from HocSinh", dataGVSVGV);
            fillDataGV("select * from GiangVien", dataGvGV);
            fillDataCourse();
                }
        public void fillDataCourse()
        {
            data.fillData("select k.MaKH, k.TenKH, k.SoTC, k.MoTa, k.HocKy, k.NamHoc, k.TenFile as GiaoTrinh,CONCAT(v.Ho, ' ', v.Ten) as GiangVien from KhoaHoc k join GiangVien v on k.MaGV = v.MaGV", dataGvCourse);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void fillDataGV(String command, DataGridView dtgv)
        {
            db.openConnection();
            try
            {

            
            
                SqlCommand cmd = new SqlCommand(command, db.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                picCol = (DataGridViewImageColumn)dtgv.Columns[6];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dtgv.DataSource = dt;
               
                /*txtCourseID.Text = "";
                txtCourseName.Text = "";
                numPeriod.Value = 0;
                txtDescription.Text = "";*/
          }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void dataGVSVGV_Click(object sender, EventArgs e)
        {
            
           
        }

        private void dataGVSVGV_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ADMINUpdateSTD updateStdFrm = new ADMINUpdateSTD();
                updateStdFrm.role = 1;
                if (dataGVSVGV.CurrentRow.Cells[0].Value.ToString() != null)
                    updateStdFrm.lblMa.Text = dataGVSVGV.CurrentRow.Cells[0].Value.ToString();
                updateStdFrm.txtHo.Text = dataGVSVGV.CurrentRow.Cells[1].Value.ToString();
                updateStdFrm.txtTen.Text = dataGVSVGV.CurrentRow.Cells[2].Value.ToString();
                updateStdFrm.txtCCCD.Text = dataGVSVGV.CurrentRow.Cells[3].Value.ToString();
                updateStdFrm.dateOfB.Value = (DateTime)dataGVSVGV.CurrentRow.Cells[4].Value;
                updateStdFrm.txtSoDT.Text = dataGVSVGV.CurrentRow.Cells[5].Value.ToString();

                object value = dataGVSVGV.CurrentRow.Cells[6].Value;
                if (value != DBNull.Value)
                {
                    byte[] pic = (byte[])value;
                    MemoryStream picture = new MemoryStream(pic);
                    updateStdFrm.picBoxAnh.Image = Image.FromStream(picture);
                }
                else
                {
                    updateStdFrm.picBoxAnh.Image = null;
                }

                if (dataGVSVGV.CurrentRow.Cells[7].Value.ToString().Trim() == "Male")
                {
                    updateStdFrm.radNam.Checked = true;
                }
                else
                {
                    updateStdFrm.radNu.Checked = true;
                }

                updateStdFrm.txtDiaChi.Text = dataGVSVGV.CurrentRow.Cells[8].Value.ToString();
                updateStdFrm.cmbKhoa.Text = dataGVSVGV.CurrentRow.Cells[9].Value.ToString();
                if (dataGVSVGV.CurrentRow.Cells[10].Value == null || dataGVSVGV.CurrentRow.Cells[11].Value == null)
                {
                    updateStdFrm.txtHoTenNT.Text = "";
                    updateStdFrm.txtSoDTNT.Text = "";
                }
                else
                {
                    updateStdFrm.txtHoTenNT.Text = dataGVSVGV.CurrentRow.Cells[10].Value.ToString();
                    updateStdFrm.txtSoDTNT.Text = dataGVSVGV.CurrentRow.Cells[11].Value.ToString();
                }

                updateStdFrm.txtEmail.Text = dataGVSVGV.CurrentRow.Cells[14].Value.ToString();


                if (updateStdFrm.ShowDialog() == DialogResult.OK)
                {
                   
                    updateStdFrm.Close();
                    ADMINForm_Load(sender, e);
                }

            }
            catch
            {
                MessageBox.Show("Lỗi lấy giá trị!!!");
            }
        }

        private void tabPageGV_Click(object sender, EventArgs e)
        {
            //fillDataGV("select * from GiangVien",dataGvGV);
        }

        private void dataGvGV_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ADMINUpdateSTD updateStdFrm = new ADMINUpdateSTD();
                updateStdFrm.role = 2;
                if (dataGvGV.CurrentRow.Cells[0].Value.ToString() != null)
                    updateStdFrm.lblMa.Text = dataGvGV.CurrentRow.Cells[0].Value.ToString();
                updateStdFrm.txtHo.Text = dataGvGV.CurrentRow.Cells[1].Value.ToString();
                updateStdFrm.txtTen.Text = dataGvGV.CurrentRow.Cells[2].Value.ToString();
                updateStdFrm.txtCCCD.Text = dataGvGV.CurrentRow.Cells[3].Value.ToString();
                updateStdFrm.dateOfB.Value = (DateTime)dataGvGV.CurrentRow.Cells[4].Value;
                updateStdFrm.txtSoDT.Text = dataGvGV.CurrentRow.Cells[5].Value.ToString();

                object value = dataGvGV.CurrentRow.Cells[6].Value;
                if (value != DBNull.Value)
                {
                    byte[] pic = (byte[])value;
                    MemoryStream picture = new MemoryStream(pic);
                    updateStdFrm.picBoxAnh.Image = Image.FromStream(picture);
                }
                else
                {
                    updateStdFrm.picBoxAnh.Image = null;
                }

                if (dataGvGV.CurrentRow.Cells[7].Value.ToString().Trim() == "Male")
                {
                    updateStdFrm.radNam.Checked = true;
                }
                else
                {
                    updateStdFrm.radNu.Checked = true;
                }

                updateStdFrm.txtDiaChi.Text = dataGvGV.CurrentRow.Cells[8].Value.ToString();
                
                updateStdFrm.txtEmail.Text = dataGvGV.CurrentRow.Cells[11].Value.ToString();

                updateStdFrm.groupBoxNT.Visible = false;

                if (updateStdFrm.ShowDialog() == DialogResult.OK)
                {

                    updateStdFrm.Close();
                    ADMINForm_Load(sender, e);
                }

            }
            catch
            {
                MessageBox.Show("Lỗi lấy giá trị!!!");
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            ADMINaddCourse addC = new ADMINaddCourse();
            if (addC.ShowDialog() == DialogResult.OK)
            {
                fillDataCourse();
            }
        
            
        }

        private void dataGvCourse_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                UCCourse.id = dataGvCourse.CurrentRow.Cells[0].Value.ToString();
                UCCourse.name = dataGvCourse.CurrentRow.Cells[1].Value.ToString();
                UCCourse.numCrea = dataGvCourse.CurrentRow.Cells[2].Value.ToString();
                UCCourse.des = dataGvCourse.CurrentRow.Cells[3].Value.ToString();
               
                UCCourse.semester = dataGvCourse.CurrentRow.Cells[4].Value.ToString();
                UCCourse.year = dataGvCourse.CurrentRow.Cells[5].Value.ToString();
                UCCourse.filename = dataGvCourse.CurrentRow.Cells[6].Value.ToString();
                UCCourse.teacherName = dataGvCourse.CurrentRow.Cells[7].Value.ToString();

                ADMINCourse coursefrm = new ADMINCourse();
                coursefrm.Show();
            }
            catch
            {
                MessageBox.Show("Lỗi lấy giá trị!!!");
            }
        }

        private void dataGvCourse_Click(object sender, EventArgs e)
        {
            idCourse = dataGvCourse.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            
            if (idCourse != "") {
                DialogResult result=MessageBox.Show("Người dùng và dữ liệu thuộc về khoá học sẽ bị xoá!!!\nBạn có chắc xoá khoá học?", "Xoá khoá học", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    
                    Dictionary<string, object> values = new Dictionary<string, object>
                {
                { "MaKH",  idCourse}
                };
                    if (data.Delete("KhoaHoc", values))
                    {
                        MessageBox.Show("Xoá khoá học thành công!!!");
                        fillDataCourse();
                    }

                }
            }
        }

        private void dataGVSVGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
