using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.GUI.ForumGUI
{
    public partial class ForumCommentFrm : Form
    {
        public int id_Forum {  get; set; }
        public string id_User {  get; set; }
        public int id_Comment { get; set; }
        public string nameCourse {  get; set; }
        public string question {  get; set; }

        public ForumCommentFrm()
        {
            InitializeComponent();
        }

        private void ForumCommentFrm_Load(object sender, EventArgs e)
        {
            txtQuestion.Text = question;
            lblCourseName.Text = nameCourse;
     
        }
    }
}
