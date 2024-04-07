using StudentManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.GUI
{
    public partial class ADMINUpdateSTD : Form
    {
        public ADMINUpdateSTD()
        {
            InitializeComponent();
        }

        private void ADMINUpdateSTD_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                picBoxAnh.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            StudentDAO stdDAO = new StudentDAO();
            string id = lblMa.Text;
            string fname = txtHo.Text;
            string lname = txtTen.Text;
            string cccd = txtCCCD.Text;
            DateTime date = dateOfB.Value;
            string phone = txtSoDT.Text;
            MemoryStream pic = new MemoryStream();
            if (picBoxAnh.Image != null)
            {
                
                picBoxAnh.Image.Save(pic, picBoxAnh.Image.RawFormat);
            }
            else
            {
                pic = null;
            }
            string gender = "Male";
            if(radNu.Checked)
            {
                gender = "Female";
            }
            string addr = txtDiaChi.Text;
            string fac = cmbKhoa.Text;

            string nameParents = txtHoTenNT.Text;
            string phoneParents = txtSoDTNT.Text;
            string email = txtEmail.Text;

            try
            {
                if (stdDAO.updateStudent(id,fname,lname,cccd,date,phone,pic,gender,addr,fac,nameParents,phoneParents,email))
                {
                    MessageBox.Show("Update Student Successfully!!!","Update",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }


        }
    }
}
