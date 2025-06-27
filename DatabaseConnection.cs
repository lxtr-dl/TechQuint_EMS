using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechQuint_EMS
{
    internal class DatabaseConnection
    {
        private MySqlConnection connection;
        private MySqlConnection conn;
        //MySQL Workbench Connection
        public DatabaseConnection()
        {
            // Updated connection string to reference 'techquint' schema
            string connectionString = "Server=127.0.0.1;Database=techquint;Uid=root;Pwd=020820@Steph;";
            connection = new MySqlConnection(connectionString);

            // Ensure the other connection string is also updated if needed
            string connString = "Server=127.0.0.1;Database=techquint;Uid=root;Pwd=020820@Steph;";
            conn = new MySqlConnection(connString);
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
        public MySqlConnection GetConn()
        {
            return conn;
        }
    }
}
