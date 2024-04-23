using StudentManagement.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.DAO
{
    public class AttendanceDAO
    {
        Data data = new Data();
        XJDBC db = new XJDBC();

        public List<ATTENDANCE> getListAttend(SqlCommand cmd)
        {
            List<ATTENDANCE> listAtt = new List<ATTENDANCE>();

            try
            {
                db.openConnection();
                cmd.Connection = db.getConnection;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ATTENDANCE att = new ATTENDANCE
                        {
                            idAttend = reader.GetInt32(0),
                            dateAttend = reader.GetDateTime(1)
                            
                            

                        };

                        listAtt.Add(att);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { db.closeConnection(); }

            return listAtt;
        }
        public void fillData(string sql, DataGridView dt)
        {
            data.fillData(sql, dt);
        }
        public int count(string sql)
        {
            return data.count(sql);
        }
        public void fillData(string sql, DataGridView dt, Dictionary<string, object> parameters)
        {
            data.fillData(sql, dt, parameters);    
        }
            public bool insert(string tablename,Dictionary<string,object> values)
        {
            return data.InsertData(tablename,values);
        }
        public bool update(string tablename, Dictionary<string,object> values,string condition) {
            return data.UpdateData(tablename,values,condition);
        }
        public bool delete(string tablename, Dictionary<string, object> values)
        {
            return data.Delete(tablename, values);
        }
       
    }
}
