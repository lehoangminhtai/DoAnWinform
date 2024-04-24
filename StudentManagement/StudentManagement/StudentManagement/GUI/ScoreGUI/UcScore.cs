using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.GUI.ScoreGUI
{
    public partial class UcScore : UserControl
    {
        public int role {  get; set; }
        public string sid { get; set; }
        public UcScore()
        {
            InitializeComponent();
        }

        private void UcScore_Load(object sender, EventArgs e)
        {
            if(role==2)
            {
                UcTeacherScore ucScore = new UcTeacherScore();
                ucScore.id_teacher = sid;
                
                panelContainer.Controls.Clear();
                panelContainer.Controls.Add(ucScore);
            }
                
        }
    }
}
