using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DAO
{
     class XJDBC
    {
        public  SqlConnection con = new SqlConnection(@"Data Source=admin-pc;Initial Catalog=QuanLyHocTap;Integrated Security=True");

        // get the connection
        public  SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }


        // open the connection
        public  void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }

        }


        // close the connection
        public  void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }

        }
        public  void Update(string sql, params object[] args)
        {
            try
            {
                SqlCommand command = new SqlCommand(sql, getConnection);
                for (int i = 0; i < args.Length; i++)
                {
                    command.Parameters.AddWithValue($"@param{i}", args[i]);
                }

                openConnection();
                command.ExecuteNonQuery();
                
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public  SqlDataReader Query(string sql, params object[] args)
        {
            try
            {
                SqlCommand command = new SqlCommand(sql, getConnection);
                for (int i = 0; i < args.Length; i++)
                {
                    command.Parameters.AddWithValue($"@param{i + 1}", args[i]);
                }

                openConnection();
               
                return command.ExecuteReader();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error occurred while executing query.", ex);
            }
        }
    }
}
