using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Booking.com.Database
{
    public class DatabaseHelper
    {
        const string server = @"LAP-BSANDI\MSSQLSERVER15";
        const string database = "Booking";
        private static string connectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", server, database);

        //select
        public static DataTable ExecuteSql(string sqlCommand)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sqlCommand, connection);                    
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);                    
                    return dt;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        //update - delete - insert
    }
}