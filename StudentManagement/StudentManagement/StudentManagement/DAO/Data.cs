using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
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
                if (property == null)
                {
                    return false;
                }
            }
            return true;
        }

        public void downloadFile(string fileName)
        {
            db.openConnection();

        }

    }


}
