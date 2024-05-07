using StudentManagement.GUI.LoginFaceGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.GUI.InformationGUI
{
    public partial class LoginByFace : Form
    {
        public string id_user {  get; set; }
        public LoginByFace()
        {
            InitializeComponent();
        }

        private void btnLoginByFace_Click(object sender, EventArgs e)
        {
            RegisterFaceFrm frm = new RegisterFaceFrm();
            frm.id_user = id_user;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
