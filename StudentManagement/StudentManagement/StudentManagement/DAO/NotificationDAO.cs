using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DAO
{
    public class NotificationDAO
    {
        Data data= new Data();
        XJDBC db = new XJDBC();

        public bool inserNoti(string tablename, Dictionary<string, object> dic)
        {
            return data.InsertData(tablename, dic);
        }

        public bool updateNoti(string tablename, Dictionary<string,object>dic, string condition)
        {
            return data.UpdateData(tablename, dic, condition);
        }
        public bool deleteNoti(string tableName, Dictionary<string, object> values)
        {
            return data.Delete(tableName, values);
        }
    }
}
