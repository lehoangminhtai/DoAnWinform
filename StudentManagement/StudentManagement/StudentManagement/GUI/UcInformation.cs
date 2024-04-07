using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.GUI
{
    public partial class UcInformation : UserControl
    {
        public UcInformation()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
        

       
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x00020000;
                var cp = base.CreateParams;
               
                cp.Style |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UcInformation_Load(object sender, EventArgs e)
        {
            
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateInfor updateFrm = new UpdateInfor();
            updateFrm.ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {

        }
    }
}
