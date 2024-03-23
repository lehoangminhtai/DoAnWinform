using StudentManagement.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;

namespace StudentManagement.DAO
{
    public class StudentDAO
    {
        XJDBC db = new XJDBC();
        public bool Insert()
        {
            try
            {
                
                SqlCommand cmd_Insert_Login = new SqlCommand(String.Format("Insert into DangNhap(MaDN) values ('{0}')",STUDENT.ID),db.getConnection);
                db.openConnection();
                if(CheckUserExist())
                    cmd_Insert_Login.ExecuteNonQuery();
                String sql = "INSERT INTO HocSinh(MaSV, Ho, Ten, CCCD, SDT,NgaySinh, GioiTinh, Khoa, NgayTaoTK, Email) " +
                "VALUES(@id,@fname, @lname,@cccd, @phone,@bod, @gender, @fac,@datecreate, '" + STUDENT.ID + "@student.hcmute.edu.vn')";
               // XJDBC.Update(sql, STUDENT.ID, STUDENT.Fname, STUDENT.Lname, STUDENT.CCCD, STUDENT.BOD, STUDENT.Phone, STUDENT.Image, STUDENT.GioiTinh, STUDENT.Faculity, STUDENT.DateCreate);
               SqlCommand command = new SqlCommand(sql,db.getConnection);
               
                command.Parameters.Add("@id", SqlDbType.VarChar).Value = STUDENT.ID;
                command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = STUDENT.Fname;
                command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = STUDENT.Lname;
                command.Parameters.Add("@cccd", SqlDbType.VarChar).Value = STUDENT.CCCD;
                
                command.Parameters.Add("@phone", SqlDbType.VarChar).Value = STUDENT.Phone;
                command.Parameters.Add("@bod", SqlDbType.Date).Value = STUDENT.BOD.ToShortDateString();
                command.Parameters.Add("@gender", SqlDbType.VarChar).Value = STUDENT.GioiTinh;
                command.Parameters.Add("@fac", SqlDbType.NVarChar).Value = STUDENT.Faculity;
                command.Parameters.Add("@datecreate", SqlDbType.Date).Value = STUDENT.DateCreate.ToShortDateString();
                try
                {
                    if ((command.ExecuteNonQuery() == 1))
                    {
                        
                        return true;
                    }
                    else
                    {
                       
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                
                return true;
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
            finally { db.closeConnection(); }
        }
        
        public bool CheckUserExist()
        {

            try
            {
                XJDBC db = new XJDBC();
                db.openConnection();
                SqlCommand cmd = new SqlCommand("select * from DangNhap where MaDN = @id", db.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = LOGIN.ID;
                var result = cmd.ExecuteReader();
                if (result.HasRows)
                {
                    db.closeConnection();
                    return false;
                }
                db.closeConnection();
                return true;
            }
            catch
            {
                return false;
            }

        }

    }
    
    
}
