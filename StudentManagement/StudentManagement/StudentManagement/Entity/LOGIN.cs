using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Entity
{
    public class LOGIN
    {
        public static string ID { get; set; }

        // Thuộc tính Pass (public chỉ đọc)
        public static string Pass { get; private set; }

        // Thuộc tính Email
        public static string Email { get; set; }

        // Thuộc tính Image
        public static MemoryStream ImageLogin { get; set; }
        public static DateTime DateCreate {  get; set; }
        
       
    }
}
