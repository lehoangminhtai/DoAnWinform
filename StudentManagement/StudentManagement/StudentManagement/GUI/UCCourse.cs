using StudentManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.GUI
{
    public partial class UCCourse : UserControl
    {
        Data data = new Data();
        XJDBC db = new XJDBC();
        public static string id, name, des, filename, year, semester, numCrea, teacherName;

        private void lblCourseFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string fileExtension = System.IO.Path.GetExtension(filename);

            string fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(filename);

            SaveFileDialog sfd = new SaveFileDialog();


            sfd.Filter = $" files({fileExtension})|*{fileExtension}";
            sfd.ValidateNames = true;
             if (sfd.ShowDialog() == DialogResult.OK)
             {
               
                 DownloadFile(sfd.FileName);
             }



           
        }

        public void DownloadFile(string namefile)
        {
            db.openConnection();
            bool em = false;
            SqlCommand cmd = new SqlCommand("select FileGiaoTrinh from KhoaHoc where MaKH = '"+id.Trim()+"'",db.getConnection); 
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
            if (reader.Read())
            {
                em = true;
                byte[] fileData = (byte[])reader.GetValue(0);
                using (FileStream fs = new FileStream(namefile, FileMode.Create, FileAccess.ReadWrite))
                {
                    
                    using (BinaryWriter bw = new BinaryWriter(fs))
                    {
                        bw.Write(fileData);
                        bw.Close();
                    }
                }
                MessageBox.Show("Download File Successfully");
            }
            if(em == false)
            {
                MessageBox.Show("Download File Failed!!!");
            }
            reader.Close();

        }

        
        public UCCourse()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblCourseName_Click(object sender, EventArgs e)
        {

        }

        private void UCCourse_Load(object sender, EventArgs e)
        {

            lblCourseId.Text = id;
            lblCourseName.Text = name;
            lblCourseTeacher.Text = teacherName;
            lblCourseFile.Text = filename;
            lblNumCreadit.Text = numCrea;
            lblSemester.Text=semester;
            lblYear.Text = year;
            txtCourseDescription.Text = des;


        } 
    }
}
