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
    public class DocumentDAO
    {
        XJDBC db = new XJDBC();
        Data data = new Data();
        public List<DOCUMENT> getListDocument(SqlCommand cmd)
        {
            List<DOCUMENT> listDoc = new List<DOCUMENT>();

            try
            {
                db.openConnection();
                cmd.Connection = db.getConnection;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DOCUMENT doc = new DOCUMENT
                        {
                            id = reader.GetInt32(0),
                            name = reader.GetString(1),
                            description = reader.GetString(2),
                            filename = reader.IsDBNull(3) ? "" : reader.GetString(3)
                            
                        };

                        listDoc.Add(doc);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { db.closeConnection(); }

            return listDoc;
        }
        public bool insert(string tableName, Dictionary<string, object> values)
        {
            return data.InsertData(tableName,values);
        }

        public (string file, string filename) openFile()
        {
            return data.openFile();
        }
        public void downloadFile(string filename,  string sql)
        {
            data.downloadFile(filename, sql);
        }

    }
}
