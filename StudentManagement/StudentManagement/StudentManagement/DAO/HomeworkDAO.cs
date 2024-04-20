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
    public class HomeworkDAO
    {
        XJDBC db = new XJDBC();
        Data data = new Data();

        public List<HOMEWORK> getListHomework(SqlCommand cmd)
        {
            List<HOMEWORK> listHW = new List<HOMEWORK>();

            try
            {
                db.openConnection();
                cmd.Connection = db.getConnection;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        HOMEWORK hw = new HOMEWORK
                        {
                            id = reader.GetInt32(0),
                            name = reader.GetString(1),
                            openDate = reader.GetDateTime(2),
                            closeDate = reader.GetDateTime(3),
                            description = reader.GetString(4),
                            filename = reader.IsDBNull(5) ? "" : reader.GetString(5),
                            role_view = reader.GetInt32(6)

                        };

                        listHW.Add(hw);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { db.closeConnection(); }

            return listHW;
        }
        public bool insert(string tableName, Dictionary<string, object> values)
        {
            return data.InsertData(tableName, values);
        }
        public bool update(string tableName, Dictionary<string, object> values, string condition)
        {
            return data.UpdateData(tableName, values, condition);
        }
        public bool delete(string tableName, Dictionary<string, object> values)
        {
            return data.Delete(tableName, values);
        }
        public (string file, string filename) openFile()
        {
            return data.openFile();
        }
        public void downloadFile(string filename, string sql)
        {
            data.downloadFile(filename, sql);
        }
    }
}
