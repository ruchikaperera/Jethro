using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DBConnect
{
  public  class DBContext : IDBContext
    {
        private readonly string connectionString = "Data Source=SERVER\\ONIMTA;Initial Catalog=OnimtaWebInventory;Persist Security Info=True;User ID=sa;Password=it@onimta1+;MultipleActiveResultSets=True";

        public static SqlConnection sqlConnection;

        public DBContext()
        {

            sqlConnection = new SqlConnection(connectionString);

        }

        public IDbConnection DbConnector()
        {

            if (sqlConnection.State.ToString().Equals("Closed"))
            {
               
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                }
            }

            return sqlConnection;
        }

    }
    public interface IDBContext
    {
        IDbConnection DbConnector();



    }
}
