using StudentManagement.Entity;
using StudentManagement.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            //Application.Run(new FormYoutubeeeeee());
            /*Form1 loginFrm = new Form1();
            if (loginFrm.ShowDialog() == DialogResult.OK)
            {    
                Application.Run(new MainForm());
            } */
        }
        }
    }
