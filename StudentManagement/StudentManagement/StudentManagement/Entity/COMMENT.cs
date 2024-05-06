using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Entity
{
    public class COMMENT
    {
        public int id_comment { get; set; }
       
        public string comment { get; set; }
        public DateTime date { get; set; }
        public string id_user {  get; set; }
        public  MemoryStream image { get; set; }
    }
}
