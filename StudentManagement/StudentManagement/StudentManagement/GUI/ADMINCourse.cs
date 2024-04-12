using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.GUI
{
    public partial class ADMINCourse : Form
    {
        public string id {  get; set; }
        public string name { get; set; }
        public int numCre {  get; set; }
        public string des {  get; set; }
       
        public ADMINCourse()
        {
            InitializeComponent();
        }

        private void ADMINCourse_Load(object sender, EventArgs e)
        {
            UCCourse course = new UCCourse();
            course.Dock = DockStyle.Fill;
            panelCourse.Controls.Clear();
            panelCourse.Controls.Add(course);
        }
    }
}
