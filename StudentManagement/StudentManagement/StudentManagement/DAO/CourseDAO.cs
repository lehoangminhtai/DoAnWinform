using StudentManagement.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.DAO
{
   
    public class CourseDAO
    {
        XJDBC db = new XJDBC();
        public List<COURSE> getListCourse(SqlCommand cmd)
        {
            List<COURSE> listCourse = new List<COURSE>();

            try
            {
                db.openConnection();
                cmd.Connection = db.getConnection;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        COURSE course = new COURSE
                        {
                            id = reader.GetString(0),
                            name = reader.GetString(1),
                            teacherName = reader.GetString(2)
                        };

                        listCourse.Add(course);
                    }
                }
                  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { db.closeConnection(); }
            
            return listCourse;
        }
    }
}
