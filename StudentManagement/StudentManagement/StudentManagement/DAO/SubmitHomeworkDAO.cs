using StudentManagement.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.DAO
{
    public class SubmitHomeworkDAO
    {
        XJDBC db = new XJDBC();
        Data data = new Data();
        public bool checkExistSubmit(int idHW, string id_Course, string id_Student)
        {
            bool exists = false;

            string query = "SELECT COUNT(*) FROM ChiTietNopBai WHERE MaBT = @idHW AND MaKH = @id_Course AND MaSV = @id_Student";

            using (SqlCommand cmd = new SqlCommand(query, db.getConnection))
            {
                cmd.Parameters.AddWithValue("@idHW", idHW);
                cmd.Parameters.AddWithValue("@id_Course", id_Course);
                cmd.Parameters.AddWithValue("@id_Student", id_Student);

                db.openConnection();
                int count = (int)cmd.ExecuteScalar();
                exists = (count > 0);
            }
            db.closeConnection();
            return exists;
        }
        public SubmitHWDetail getSubmitInfor(SqlCommand cmd)
        {
            SubmitHWDetail entity = new SubmitHWDetail();
            try
            {
                db.openConnection();
                cmd.Connection = db.getConnection;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        entity.filename = reader.GetString(reader.GetOrdinal("TenFile"));
                        entity.statusSubmit = reader.GetString(reader.GetOrdinal("TrangThai"));
                        entity.submitDate = reader.GetDateTime(reader.GetOrdinal("NgayNop"));
                        //entity.Grade =reader.IsDBNull(reader.GetOrdinal("Diem")) ? -1 : reader.GetFloat(reader.GetOrdinal("Diem"));
                        if (reader.IsDBNull(reader.GetOrdinal("Diem")))
                        {
                            entity.Grade = -1; // hoặc giá trị mặc định khác tùy vào yêu cầu của bạn
                        }
                        else
                        {
                            entity.Grade = reader.GetDouble(reader.GetOrdinal("Diem"));
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { db.closeConnection(); }
            db.closeConnection();
            return entity;
        }
        public bool insert(string tableName, Dictionary<string, object> values)
        {
            return data.InsertData(tableName, values);
        }
        public bool update(string tableName, Dictionary<string, object> values, string condition)
        {
            return data.UpdateData(tableName, values, condition);
        }
        public bool updateSetNullGrade(string condition)
        {
            try
            {
                db.openConnection();
                string sql = "update ChiTietNopBai set Diem = null, TrangThai = 'Ungraded' where " + condition;
                SqlCommand cmd = new SqlCommand(sql, db.getConnection);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                db.closeConnection();
            }
        } 
        public bool delete(string tableName, Dictionary<string, object> values)
        {
            return data.Delete(tableName, values);
        }
        public (string file, string filename) openFile()
        {
            return data.openFile();
        }
        public void downloadFile(string filename, string sql)
        {
            data.downloadFile(filename, sql);
        }
        public void fillData(string sql, DataGridView dt, Dictionary<string, object> parameters)
        {
            data.fillData(sql, dt, parameters);
        }
        public void fillData(string sql, DataGridView dt)
        {
            data.fillData(sql, dt);
        }
        public int count(string sql)
        {
            return data.count(sql);
        }
    }
}
