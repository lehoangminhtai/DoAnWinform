using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Entity
{
    public class STUDENT
    {
        public static string ID { get; set; }
        public static string Fname { get; set; }
        public static string Lname { get; set; }
        public static string CCCD { get; set; }
        public static DateTime  BOD { get; set; }
        public static string Phone { get; set; }
        public static byte[] Image { get; set; }
        public static string GioiTinh { get; set; }
        public static string Adddress { get; set; }
        public static string Faculity { get; set; }
        public static string NameOfRela { get; set; }
        public static string PhoneOfRela { get; set; }
        public static DateTime DateCreate { get; set; }
        public static int Status { get; set; }
        public static int CodePermis { get; set; }
        public static string Email { get; set; }
        
        public bool AddStudent()
        {
            string sql = "INSERT INTO Student(MaSV, Ho, Ten, CCCD, NgaySinh, SDT, HinhAnh, GioiTinh, DiaChi, Khoa, SDTNguoiThan, NgayTaoTK, TinhTrangTK, MaQuyen, Email) " +
                "VALUES(@MaSV, @Ho, @Ten, @CCCD, @NgaySinh, @SDT, @HinhAnh, @GioiTinh, @DiaChi, @Khoa, @HoTenNguoiThan, @SDTNguoiThan, @NgayTaoTK, @TinhTrangTK, @MaQuyen, @Email)";
            return true;
        }
    }
}
