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
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                db.closeConnection();
            }
        }


    }


}
