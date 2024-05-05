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
    public class ForumDAO
    {
        Data data = new Data();
        XJDBC db = new XJDBC();

        public bool insertForum(string tableName,Dictionary<string, object> dic)
        {
            return data.InsertData(tableName, dic);
        }


        public bool deleteForum(string tablename, Dictionary<string,object> dic)
        {
            return data.Delete(tablename, dic);
        }

        public List<FORUM> getListForum(SqlCommand cmd)
        {
            List<FORUM> listForum = new List<FORUM>();

            try
            {
                db.openConnection();
                cmd.Connection = db.getConnection;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        FORUM forum = new FORUM
                        {
                            ID = reader.GetInt32(0),
                            content = reader.GetString(1),
                            id_course = reader.GetString(2),
                            id_user = reader.GetString(3),
                            createDate = reader.GetDateTime(4),
                          
                        };

                        listForum.Add(forum);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { db.closeConnection(); }

            return listForum;
        }
    }
}
