using StudentManagement.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StudentManagement.DAO
{
    public class TeacherDao
    {
        XJDBC db = new XJDBC();
        public bool Insert()
        {
            try
            {

  
                db.openConnection();
                
                    String sql = "INSERT INTO GiangVien(MaGV, Ho, Ten, CCCD, SDT,NgaySinh, GioiTinh, NgayTaoTK, Email, HinhAnh) " +
                "VALUES(@id,@fname, @lname,@cccd, @phone,@bod, @gender,@datecreate, '" + TEACHER.ID + "@hcmute.edu.vn',@pic)";

                    SqlCommand command = new SqlCommand(sql, db.getConnection);

                    command.Parameters.Add("@id", SqlDbType.VarChar).Value = TEACHER.ID;
                    command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = TEACHER.Fname;
                    command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = TEACHER.Lname;
                    command.Parameters.Add("@cccd", SqlDbType.VarChar).Value = TEACHER.CCCD;

                    command.Parameters.Add("@phone", SqlDbType.VarChar).Value = TEACHER.Phone;
                    command.Parameters.Add("@bod", SqlDbType.Date).Value = TEACHER.BOD.ToShortDateString();
                    command.Parameters.Add("@gender", SqlDbType.VarChar).Value = TEACHER.GioiTinh;

                    command.Parameters.Add("@datecreate", SqlDbType.Date).Value = TEACHER.DateCreate.ToShortDateString();

                    command.Parameters.Add("@pic",SqlDbType.Image).Value = TEACHER.Image.ToArray();
                    try
                    {
                        if ((command.ExecuteNonQuery() == 1))
                        {
                            if (TEACHER.Image != null)
                            {
                                SqlCommand cmd = new SqlCommand("update GiangVien set HinhAnh = @image where MaGV =@MaGV", db.getConnection);
                                cmd.Parameters.Add("@image", SqlDbType.Image).Value = TEACHER.Image.ToArray();
                                cmd.Parameters.Add("@MaGV", SqlDbType.VarChar).Value = TEACHER.ID;
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
            catch (Exception ex)
            {
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
                SqlCommand cmd = new SqlCommand("select * from GiangVien where MaGV = @id", db.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = TEACHER.ID;
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
        public bool CheckUserExist(string id)
        {

            try
            {
                XJDBC db = new XJDBC();
                db.openConnection();
                SqlCommand cmd = new SqlCommand("select * from GiangVien where MaGV = @id", db.getConnection);
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
        public bool updateTeacher(string id, string fname, string lname, string CCCD, DateTime date, string phone, MemoryStream picture, string gender, string address,  string email)
        {
            SqlCommand command = new SqlCommand("UPDATE GiangVien SET Ho= @fn, Ten=@ln,CCCD =@cccd, NgaySinh=@bdt, SDT=@phn,HinhAnh=@pic , GioiTinh=@gdr,  DiaChi=@adrs, Email =@email where MaGV=@id", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@cccd", SqlDbType.VarChar).Value = CCCD;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = date;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            if (picture != null)
                command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            else
                command.Parameters.Add("@pic", SqlDbType.Image).Value = DBNull.Value;

            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;

            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = address;
           
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

    }
}
