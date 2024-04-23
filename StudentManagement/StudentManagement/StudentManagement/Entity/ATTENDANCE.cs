using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Entity
{
    public class ATTENDANCE
    {
        public int idAttend { get; set; }
        
        public DateTime dateAttend { get; set; }
        public string status {  get; set; }
    }
}
