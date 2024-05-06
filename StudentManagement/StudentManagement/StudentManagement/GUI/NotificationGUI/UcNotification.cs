using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.GUI.NotificationGUI
{
    public partial class UcNotification : UserControl
    {
        public string id_user {  get; set; }
        public int role {  get; set; }

        public UcNotification()
        {
            InitializeComponent();
        }

        private void UcNotification_Load(object sender, EventArgs e)
        {

        }
    }
}
