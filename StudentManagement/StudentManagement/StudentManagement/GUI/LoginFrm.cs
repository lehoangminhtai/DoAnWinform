using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassLogin.ForeColor = Color.Black;
            
        }

        private void txtPassLogin_TextChanged(object sender, EventArgs e)
        {

            txtPassLogin.ForeColor = Color.Black;
            txtPassLogin.Font = new Font(txtPassLogin.Font.FontFamily, 8f);
        }

        private void txtPassLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPassLogin.ForeColor = Color.Black;
        }

        private void txtIdLogin_TextChanged(object sender, EventArgs e)
        {

            txtIdLogin.ForeColor = Color.Black;
            txtIdLogin.Font = new Font(txtIdLogin.Font.FontFamily, 8f);
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterFrm registerFrm = new RegisterFrm();
            //registerFrm.ShowDialog();
            if(registerFrm.ShowDialog() == DialogResult.OK)
            {
                frmOTP otp = new frmOTP();
                if(otp.ShowDialog() == DialogResult.OK)
                {
                    otp.Close();
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
