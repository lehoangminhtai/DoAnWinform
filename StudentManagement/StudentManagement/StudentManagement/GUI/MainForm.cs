using StudentManagement.GUI;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UcNotification ucNotification = new UcNotification();
            ucNotification.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucNotification);

        }

        private void btnInfor_Click(object sender, EventArgs e)
        {
           
            UcInformation ucInformation = new UcInformation();
            ucInformation.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucInformation);
        }
    }
}
