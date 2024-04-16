using StudentManagement.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.DAO
{

    public class CourseDAO
    {
        XJDBC db = new XJDBC();
        Data data = new Data();
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



        public bool isRegisterCourse(string cid, string sid)
        {

            if (checkRegisterCourse(cid, sid))
                return true;
            else return false;
        }
        private bool checkRegisterCourse(string cid, string sid)
        {

            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Diem WHERE MaKH = @cid AND MaSV = @sid", db.getConnection);
            cmd.Parameters.AddWithValue("@cid", cid);
            cmd.Parameters.AddWithValue("@sid", sid);
            int count = (int)cmd.ExecuteScalar();
            return count > 0;

        }
        public Dictionary<string, object> selectCourse(string tableName, List<string> columns, string condition)
        {
            return data.SelectData(tableName, columns, condition);
        }
        public void fillData(string sql, DataGridView dt, Dictionary<string, object> parameters)
        {

            data.fillData(sql, dt, parameters);
        }
        public bool updateCourse(string tableName, Dictionary<string, object> parameters,string condition) {
            return data.UpdateData(tableName, parameters, condition);
        }
        public bool updateFileCourse(string courseId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update KhoaHoc set FileGiaoTrinh = null, TenFile=null where MaKH='" + courseId + "'", db.getConnection);
                db.openConnection();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally { db.closeConnection(); }

        }
     
    }


}
