using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Entity
{
    public class HOMEWORK
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime openDate { get; set; }
        public DateTime closeDate { get; set; }
        public string description { get; set; }
        public string filename { get; set; }

        public int role_view { get; set; }
    }
}
