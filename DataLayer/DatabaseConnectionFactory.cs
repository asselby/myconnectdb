using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLayer
{
    public class DatabaseConnectionFactory
    {
        private static string ConnectString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["MyConnectionStringOne"].ToString();
            }

        }

        public static SqlConnection GetConnection()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectString);
            return sqlConnection;
        }
    }
}
