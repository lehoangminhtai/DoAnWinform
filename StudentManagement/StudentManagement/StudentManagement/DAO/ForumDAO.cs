using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DAO
{
    public class ForumDAO
    {
        Data data = new Data();

        public bool insertForum(string tableName,Dictionary<string, object> dic)
        {
            return data.InsertData(tableName, dic);
        }
    }
}
