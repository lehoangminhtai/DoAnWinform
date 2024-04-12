using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Entity
{
    public class COURSE
    {
        public string id { get; set; }
        public string name { get; set; }

        public string teacherName {  get; set; }
        public COURSE() { }
        public COURSE(string id, string name, string teacherName)
        {
            this.id = id;
            this.name = name;
            this.teacherName = teacherName;
        }
    }
}
