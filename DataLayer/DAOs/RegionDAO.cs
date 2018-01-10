using DataLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DAOs
{
    public class RegionDAO : Interface <RegionDTO>
    {
        SqlConnection sqlConnection = null;
        public void Create()
        {
            using (sqlConnection = DatabaseConnectionFactory.GetConnection())
            {
                sqlConnection.Open();
                SqlCommand sqlCommand= sqlConnection.CreateCommand();
                string sqlQuery = @"alter table Order3 add LastName varchar(50)";
                sqlCommand.CommandText = sqlQuery;
                sqlCommand.CommandType = CommandType.Text;
                int result = sqlCommand.ExecuteNonQuery();
                Console.WriteLine(result);
                sqlConnection.Close();
            }
        }

        public void Delete(RegionDTO t)
        {
            throw new NotImplementedException();
        }

        public string Read(RegionDTO t)
        {
            throw new NotImplementedException();
        }

        public void Update(RegionDTO t)
        {
            throw new NotImplementedException();
        }
    }
}
