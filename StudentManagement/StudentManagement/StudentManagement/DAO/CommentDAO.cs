using StudentManagement.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.DAO
{
    public class CommentDAO
    {
        Data data = new Data();
        XJDBC db = new XJDBC();

        public bool insertComment(string tableName, Dictionary<string, object> dic)
        {
            return data.InsertData(tableName, dic);
        }


        public bool deleteComment(string tablename, Dictionary<string, object> dic)
        {
            return data.Delete(tablename, dic);
        }

        public List<COMMENT> getListComment(SqlCommand cmd)
        {
            List<COMMENT> listCmt = new List<COMMENT>();

            try
            {
                db.openConnection();
                cmd.Connection = db.getConnection;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        COMMENT cmt = new COMMENT
                        {
                            id_comment = reader.GetInt32(0),                      
                            comment = reader.GetString(1),
                            date = reader.GetDateTime(2),
                            id_user = reader.GetString(3),
                            image = reader.IsDBNull(4) ? null : new MemoryStream((byte[])reader.GetValue(4))

                        };

                        listCmt.Add(cmt);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { db.closeConnection(); }

            return listCmt;
        }
    }
}
