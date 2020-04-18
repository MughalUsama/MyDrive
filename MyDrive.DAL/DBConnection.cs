using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDrive_DAL
{
    class DBConnection : IDisposable 
    {
        String connString = System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
        SqlConnection connection = null;
     
        public DBConnection()
        {
            connection = new SqlConnection(connString);
            connection.Open();
        }

        public int ExecuteQuery(String sqlQuery)
        {
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            var count = command.ExecuteNonQuery();
            return count;
        }
        public Object ExecuteScalar(String sqlQuery)
        {
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            return command.ExecuteScalar();
        }
        public SqlDataReader ExecuteReader(String sqlQuery)
        {
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            return command.ExecuteReader();
        }
        public void Dispose()
        {
            if(connection!=null && connection.State==System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}