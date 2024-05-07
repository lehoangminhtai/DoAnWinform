using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Entity
{
    public class SCORE
    {
        public string id_student { get; set; }
        public double gradeMid {  get; set; }
        public double gradeLast {  get; set; }
        public double gradeFinal { get; set;}
        public string rank { get; set; }
    }
}
