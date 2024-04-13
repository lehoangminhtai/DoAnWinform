using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DAO
{
    public class ScoreDAO
    {
        XJDBC db = new XJDBC();
        Data data = new Data();
        public bool inserScore(string tableName, Dictionary<string, object> values)
        {
            return data.InsertData(tableName, values);
        }
        public bool deleteScore(string tableName, Dictionary<string, object> values)
        {
            return data.Delete(tableName, values);
        }
    }
}
