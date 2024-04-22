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

namespace StudentManagement.GUI.AttendanceGUI
{
    public partial class UcAttendance : UserControl
    {
        public string id_course {  get; set; }
        public int id_attend {  get; set; }
        public string id_std { get; set; }
        public int role { get; set; }
        public UcAttendance()
        {
            InitializeComponent();
        }

        private void UcAttendance_Load(object sender, EventArgs e)
        {
            id_std = ACCOUNT.id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
