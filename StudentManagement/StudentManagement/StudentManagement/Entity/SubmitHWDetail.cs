using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Entity
{
    public class SubmitHWDetail
    {
        public string filename { get; set; }
        public string statusSubmit { get; set; }
        public double Grade { get; set; }
        public DateTime submitDate { get; set; }
    }
}
