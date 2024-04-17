using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.DAO
{
    public class Data
    {
        XJDBC db =new XJDBC();
        public void fillData(string sql , DataGridView dt)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql,db.getConnection);
                db.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                adapter.Fill(data);
                dt.DataSource = data;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message); 
            }
            finally { db.closeConnection(); }
        }

        public void fillData(string sql, DataGridView dt, Dictionary<string, object> parameters)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, db.getConnection);
                db.openConnection();

                // Add parameters to the command
                foreach (var param in parameters)
                {
                    cmd.Parameters.AddWithValue(param.Key, param.Value);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                adapter.Fill(data);
                dt.DataSource = data;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }

        public bool InsertData(string tableName, Dictionary<string, object> values)
        {
            try
            {
                string sql = $"INSERT INTO {tableName} ({string.Join(", ", values.Keys)}) VALUES ({string.Join(", ", values.Keys.Select(key => "@" + key))})";

                using (SqlCommand cmd = new SqlCommand(sql, db.getConnection))
                {
                    db.openConnection();

                    // Add parameters to the command
                    foreach (var param in values)
                    {
                        cmd.Parameters.AddWithValue("@" + param.Key, param.Value);
                    }
                    
                    cmd.ExecuteNonQuery();
                
                return true;
                }
           }
            catch (Exception e)
            {
                MessageBox.Show("Thêm dữ liệu lỗi!!!");
                return false;
            }
            finally
            {
                db.closeConnection();
            }
        }

        public bool Delete(string tableName, Dictionary<string, object> values)
        {
            try
            {
                string sql = $"DELETE FROM {tableName} WHERE {string.Join(" AND ", values.Keys.Select(key => $"{key} = @{key}"))}";

                using (SqlCommand cmd = new SqlCommand(sql, db.getConnection))
                {
                    db.openConnection();

                    // Add parameters to the command
                    foreach (var param in values)
                    {
                        cmd.Parameters.AddWithValue("@" + param.Key, param.Value);
                    }

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi xoá dữ liệu!!!");
                return false;
            }
            finally
            {
                db.closeConnection();
            }
        }
        public bool UpdateData(string tableName, Dictionary<string, object> values, string condition)
        {
           try
            {
                string sql = $"UPDATE {tableName} SET {string.Join(", ", values.Keys.Select(key => $"{key} = @{key}"))} WHERE {condition}";

                using (SqlCommand cmd = new SqlCommand(sql, db.getConnection))
                {
                    db.openConnection();

                    // Add parameters to the command
                    foreach (var param in values)
                    {
                        cmd.Parameters.AddWithValue("@" + param.Key, param.Value);
                    }

                    cmd.ExecuteNonQuery();
               
                    return true;
              }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu!!!");
                return false;
            }
            finally
            {
                db.closeConnection();
            }
        }

        public List<Dictionary<string, object>> SelectDataList(string tableName, List<string> columns, string condition)
        {
            try
            {
                string columnList = string.Join(", ", columns);
                string sql = $"SELECT {columnList} FROM {tableName}";

                if (!string.IsNullOrEmpty(condition))
                {
                    sql += $" WHERE {condition}";
                }

                using (SqlCommand cmd = new SqlCommand(sql, db.getConnection))
                {
                    db.openConnection() ;

                    List<Dictionary<string, object>> results = new List<Dictionary<string, object>>();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dictionary<string, object> row = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[reader.GetName(i)] = reader.GetValue(i);
                            }
                            results.Add(row);
                        }
                    }

                    return results;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn!");
                return null;
            }
            finally
            {
                db.closeConnection();
            }
        }

        public Dictionary<string, object> SelectData(string tableName, List<string> columns, string condition)
        {
            try
            {
                string columnList = string.Join(", ", columns);
                string sql = $"SELECT {columnList} FROM {tableName}";

                if (!string.IsNullOrEmpty(condition))
                {
                    sql += $" WHERE {condition}";
                }

                using (SqlCommand cmd = new SqlCommand(sql, db.getConnection))
                {
                    db.openConnection();

                    
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Dictionary<string, object> row = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[reader.GetName(i)] = reader.GetValue(i);
                            }
                            return row;
                        }
                    }

                    return null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn!");
                return null;
            }
            finally
            {
                db.closeConnection();
            }
        }
        public bool ValidateNotNull(params object[] properties)
        {
            foreach (object property in properties)
            {
                if (property == null || property.Equals(""))
                {
                    return false;
                }
            }
            return true;
        }

       
        public bool IsValidEmail(string email)
        {
            // Biểu thức chính quy để kiểm tra địa chỉ email
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Sử dụng Regex.IsMatch để kiểm tra email với biểu thức chính quy
            return Regex.IsMatch(email, pattern);
        }
        public bool IsValidPhoneNumber(string phoneNumber)
        {
            // Loại bỏ khoảng trắng và dấu gạch nối trong số điện thoại
            string cleanedPhoneNumber = phoneNumber.Replace(" ", "").Replace("-", "");

            // Kiểm tra xem số điện thoại có chỉ chứa các chữ số và có đúng 10 ký tự không
            return System.Text.RegularExpressions.Regex.IsMatch(cleanedPhoneNumber, @"^\d{10}$");
        }
        public bool IsValidVietnameseName(string name)
        {
            // Biểu thức chính quy để kiểm tra xem chuỗi có chứa ký tự tiếng Việt (bao gồm cả dấu) không
            string pattern = @"^[\p{L}\s]+$";

            // Sử dụng Regex.IsMatch để kiểm tra
            return System.Text.RegularExpressions.Regex.IsMatch(name, pattern);
        }

        public (string year, string semester) GetYearAndSemester( )
        {
            DateTime date = DateTime.Now;
            string year = date.Year.ToString();
            int month = date.Month;
            string semester = "HK1";

            if (month >= 1 && month <= 5)
                semester = "HK2";
            else if (month >= 6 && month <= 7)
                semester = "HK3";

            return (year, semester);
        }
        public (string file, string filename) openFile()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            string file = dlg.FileName;

            string filename = Path.GetFileName(file);

            return (file, filename);

        }
        public void downloadFile(string filename, string  sql)
        {
            string fileExtension = System.IO.Path.GetExtension(filename);

            
            SaveFileDialog sfd = new SaveFileDialog();


            sfd.Filter = $" files({fileExtension})|*{fileExtension}";
            sfd.ValidateNames = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Download(sfd.FileName, sql);
            }
        }
        private void Download(string namefile, string sql)
        {
            db.openConnection();
            bool em = false;
            SqlCommand cmd = new SqlCommand(sql, db.getConnection);
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
            if (reader.Read())
            {
                em = true;
                byte[] fileData = (byte[])reader.GetValue(0);
                using (FileStream fs = new FileStream(namefile, FileMode.Create, FileAccess.ReadWrite))
                {

                    using (BinaryWriter bw = new BinaryWriter(fs))
                    {
                        bw.Write(fileData);
                        bw.Close();
                    }
                }
                MessageBox.Show("Download File Successfully");
            }
            if (em == false)
            {
                MessageBox.Show("Download File Failed!!!");
            }
            reader.Close();

        }

        public string GetVideoId(string url)
        {
            if (url != "")
            {
                string pattern = @"(?:https?:\/\/)?(?:www\.)?(?:youtube\.com\/(?:[^\/\n\s]+\/\S+\/|(?:v|e(?:mbed)?)\/|\S*?[?&]v=)|youtu\.be\/)([a-zA-Z0-9_-]{11})";
                Regex regex = new Regex(pattern);
                Match match = regex.Match(url);

                if (match.Success)
                {
                    return match.Groups[1].Value;
                }
                else
                {

                    return "";
                }
            }
            else
                return "";
        }

    }


}
