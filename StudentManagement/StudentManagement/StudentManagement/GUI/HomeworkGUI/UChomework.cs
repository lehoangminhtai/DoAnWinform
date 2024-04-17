using StudentManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.GUI.HomeworkGUI
{
    public partial class UChomework : UserControl
    {
        public string course_id { get; set; }
        public int doc_id { get; set; }
        public int role { get; set; }
        public string filename { get; set; }

        HomeworkDAO HomeworkDAO =new HomeworkDAO();
        public UChomework()
        {
            InitializeComponent();
        }

        private void UChomework_Load(object sender, EventArgs e)
        {

        }
    }
}
