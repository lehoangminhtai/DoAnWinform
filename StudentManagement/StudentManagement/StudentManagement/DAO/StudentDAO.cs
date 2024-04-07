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
using System.IO;

namespace StudentManagement.DAO
{
    public class StudentDAO
    {
        XJDBC db = new XJDBC();
        public bool Insert()
        {
            try
            {
                
                
                db.openConnection();

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

                //command.Parameters.Add("pic",SqlDbType.Image).Value = STUDENT.Image.ToArray();
                try
                {
                    if ((command.ExecuteNonQuery() == 1))
                    {
                        if(STUDENT.Image !=null)
                        {
                            SqlCommand cmd = new SqlCommand("update HocSinh set HinhAnh = @image where MaSV =@MaSV",db.getConnection);
                            cmd.Parameters.Add("@image", SqlDbType.Image).Value = STUDENT.Image.ToArray();
                            cmd.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = STUDENT.ID;
                            cmd.ExecuteNonQuery();

                        }
                       
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

        public bool updateStudent(string id, string fname, string lname, string CCCD, DateTime date, string phone, MemoryStream picture, string gender,string address, string fac, string nameParents, string phoneParents,string email)
        {
            SqlCommand command = new SqlCommand("UPDATE HocSinh SET Ho= @fn, Ten=@ln,CCCD =@cccd, NgaySinh=@bdt, SDT=@phn,HinhAnh=@pic , GioiTinh=@gdr,  DiaChi=@adrs, Khoa= @fac, NguoiThanHT = @fullNamePar, NguoiThanSDT = @phonePar, Email =@email where MaSV=@id", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@cccd", SqlDbType.VarChar).Value = CCCD;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = date;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            if(picture != null )
                command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            else
                command.Parameters.Add("@pic", SqlDbType.Image).Value = DBNull.Value;

            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
          
            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@fac", SqlDbType.NVarChar).Value = fac;
            command.Parameters.Add("@fullNamePar", SqlDbType.NVarChar).Value = nameParents;
            command.Parameters.Add("@phonePar", SqlDbType.VarChar).Value = phoneParents;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;

            db.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public bool CheckUserExist()
        {

            try
            {
                XJDBC db = new XJDBC();
                db.openConnection();
                SqlCommand cmd = new SqlCommand("select * from HocSinh where MaSV = @id", db.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = STUDENT.ID;
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
        public bool CheckUserExist(String id)
        {

            try
            {
                XJDBC db = new XJDBC();
                db.openConnection();
                SqlCommand cmd = new SqlCommand("select * from HocSinh where MaSV = @id", db.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
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
