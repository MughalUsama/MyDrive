using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MyDrive_DAL
{
    class DBConnection : IDisposable 
    {
        String connString = System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
        MySqlConnection connection = null;
     
        public DBConnection()
        {
            connection = new MySqlConnection(connString);
            connection.Open();
        }

        public int ExecuteQuery(String sqlQuery)
        {
            MySqlCommand command = new MySqlCommand(sqlQuery, connection);
            var count = command.ExecuteNonQuery();
            return count;
        }
        public Object ExecuteScalar(String sqlQuery)
        {
            MySqlCommand command = new MySqlCommand(sqlQuery, connection);
            return command.ExecuteScalar();
        }
        public MySqlDataReader ExecuteReader(String sqlQuery)
        {
            MySqlCommand command = new MySqlCommand(sqlQuery, connection);
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