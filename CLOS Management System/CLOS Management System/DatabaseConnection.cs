using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CLOS_Management_System
{
    class DatabaseConnection
    {
        private static DatabaseConnection Instance;
        private SqlConnection connection;

        private DatabaseConnection() { }

        public static DatabaseConnection getInstance()
        {
            if(Instance == null)
                Instance = new DatabaseConnection();
            return Instance;
        }

        public SqlConnection getConnection()
        {
            connection = new SqlConnection(ConnectionString.connection);
            if (connection.State != ConnectionState.Open)
                connection.Open();
            return connection;
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
    }
}
