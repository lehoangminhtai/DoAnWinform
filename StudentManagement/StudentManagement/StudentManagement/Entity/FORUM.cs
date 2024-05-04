using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Entity
{
    public class FORUM
    {
        public int ID { get; set; }
        public string content { get; set; }
        public string id_course { get; set; }
        public string id_user { get; set;}
        public DateTime createDate { get; set;}
    }
}
