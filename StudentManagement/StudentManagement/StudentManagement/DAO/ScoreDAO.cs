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
    public class ScoreDAO
    {
        XJDBC db = new XJDBC();
        Data data = new Data();

        public double fillDataGvChange(string sql,DataGridView dt)
        {
            double scoreAvg = 0;
            try
            {
                fillDaGV(sql, dt);
                string sqlAvg = $@"SELECT ROUND(AVG(dd.[Điểm Tổng Kết]), 1) FROM ( {sql} ) dd";
                SqlCommand cmd = new SqlCommand(sqlAvg, db.getConnection);
                db.openConnection();
                scoreAvg = (double)cmd.ExecuteScalar();
            }
            catch {
                
            }
            finally { db.closeConnection();
                
            }
            return scoreAvg;
        }
        public void fillDaGV(string sql, DataGridView dt)
        {
            data.fillData(sql, dt);
        }
        public bool inserScore(string tableName, Dictionary<string, object> values)
        {
            return data.InsertData(tableName, values);
        }
        public bool deleteScore(string tableName, Dictionary<string, object> values)
        {
            return data.Delete(tableName, values); 
        }
        public bool updateScore(string tableName, Dictionary<string, object> values, string condition)
        {
            return data.UpdateData(tableName, values, condition);
        }
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
                            id= reader.GetString(0),
                            name = reader.GetString(1),
                            semester = reader.GetString(2),
                            year = reader.GetString(3),
                            teacherName = reader.GetString(4),
                            numCrea = reader.GetInt32(5).ToString(),
                            description= reader.GetString(6),
                            nameFile = reader.IsDBNull(7) ? "" : reader.GetString(7)
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
