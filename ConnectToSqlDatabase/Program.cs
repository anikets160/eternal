using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectToSqlDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data Source – This is the name of the server on which the database resides. In our case, it resides on a machine called WIN-50GP30FGO75.
            // The Initial Catalog is used to specify the name of the database
            // The UserID and Password are the credentials required to connect to the database.

            string connectionString;
            connectionString = @"Data Source=ANIKET-PC;Initial Catalog=myDatabase;User ID=sa;Password=sqlserver";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT [CustomerID],[CustomerName] from [myDatabase].[dbo].[Customer]",sqlConnection);
            SqlDataReader sqlDataReader= sqlCommand.ExecuteReader();
            
            
            while (sqlDataReader.Read())
            {
                Console.WriteLine("{0}  {1}", sqlDataReader.GetValue(0), sqlDataReader.GetValue(1));
            }

            for (int i = 0; i < 2; i++)
            {

            }

            sqlDataReader.Close();
            sqlConnection.Close();

            if(Debugger.IsAttached)
            {
                Console.ReadKey();
            }

        }
    }
}
