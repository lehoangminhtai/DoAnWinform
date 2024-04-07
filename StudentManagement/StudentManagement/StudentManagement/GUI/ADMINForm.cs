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
        public ADMINForm()
        {
            InitializeComponent();
        }

        private void ADMINForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyHocTapDataSet2.HocSinh' table. You can move, or remove it, as needed.
            this.hocSinhTableAdapter.Fill(this.quanLyHocTapDataSet2.HocSinh);
            // TODO: This line of code loads data into the 'quanLyHocTapDataSet1.HocSinh' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'quanLyHocTapDataSet.HocSinh' table. You can move, or remove it, as needed.
            // this.hocSinhTableAdapter.Fill(this.quanLyHocTapDataSet.HocSinh);


            fillDataGVCourse("SELECT TOP (1000) [MaSV],[Ho],[Ten]   ,[CCCD]    ,[NgaySinh]    ,[SDT]     ,[HinhAnh]     ,[GioiTinh]      ,[DiaChi] ,[Khoa],[NgayTaoTK]    ,[TinhTrangTK]  ,[Email]  FROM [QuanLyHocTap].[dbo].[HocSinh] ");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void fillDataGVCourse(String command)
        {
            db.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(command, db.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                picCol = (DataGridViewImageColumn)dataGVSVGV.Columns[6];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGVSVGV.DataSource = dt;
               
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
            try
            {
                ADMINUpdateSTD updateStdFrm = new ADMINUpdateSTD();
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


                if(updateStdFrm.ShowDialog() == DialogResult.OK)
                {
                    updateStdFrm.Close();
                }
               
            }
            catch
            {
                MessageBox.Show("Lỗi lấy giá trị!!!");
            }
           
        }

        
    }
}
