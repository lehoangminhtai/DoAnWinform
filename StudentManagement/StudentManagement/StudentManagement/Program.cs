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
            //Application.Run(new MainForm());
            /*DetectFaceForm detectFaceForm = new DetectFaceForm();
            if (detectFaceForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }*/


            /*Form1 loginFrm = new Form1();
            if (loginFrm.ShowDialog() == DialogResult.OK)
            {    
                Application.Run(new MainForm());
            } */
            Form1 loginFrm = new Form1();
            while (true)
            {
                if (loginFrm.ShowDialog() == DialogResult.OK)
                {
                    MainForm mainForm = new MainForm();
                    if (mainForm.ShowDialog() == DialogResult.Cancel)
                    {
                        mainForm.Dispose(); // Giải phóng tài nguyên
                        continue; // Tiếp tục vòng lặp để hiển thị form đăng nhập
                    }
                    else
                    {
                        break; // Thoát vòng lặp nếu không đăng xuất
                    }
                }
                else
                {
                    break; // Thoát vòng lặp nếu không đăng nhập
                }
            }

        }
    }
    }
