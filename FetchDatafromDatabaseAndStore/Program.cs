using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchDatafromDatabaseAndStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] dataFromMethod = GetDataFromCustomer(7,4);
            Console.WriteLine(dataFromMethod[0, 0]);
            Console.WriteLine(dataFromMethod[0, 1]);
            Console.WriteLine(dataFromMethod[0, 2]);
            Console.WriteLine(dataFromMethod[0, 3]);

            Console.WriteLine(dataFromMethod[1, 0]);
            Console.WriteLine(dataFromMethod[1, 1]);

            Console.WriteLine(dataFromMethod[2, 0]);
            Console.WriteLine(dataFromMethod[2, 1]);

            Console.WriteLine(dataFromMethod[3, 0]);
            Console.WriteLine(dataFromMethod[3, 1]);

            Console.WriteLine(dataFromMethod[4, 0]);
            Console.WriteLine(dataFromMethod[4, 1]);

            Console.WriteLine(dataFromMethod[5, 0]);
            Console.WriteLine(dataFromMethod[5, 1]);

            Console.WriteLine(dataFromMethod[6, 0]);
            Console.WriteLine(dataFromMethod[6, 1]);
            Console.ReadKey();
        }

        public static string[,] GetDataFromCustomer(int rowCount,int columns)
        {
            // Data Source – This is the name of the server on which the database resides. In our case, it resides on a machine called WIN-50GP30FGO75.
            // The Initial Catalog is used to specify the name of the database
            // The UserID and Password are the credentials required to connect to the database.

            string[,] data = new string[rowCount, columns];
            string connectionString;
            connectionString = @"Data Source=ANIKET-PC;Initial Catalog=myDatabase;User ID=sa;Password=sqlserver";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * from [myDatabase].[dbo].[Customer]", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //while (sqlDataReader.Read())
            //{
            //    Console.WriteLine("{0}  {1}", sqlDataReader.GetValue(0), sqlDataReader.GetValue(1));
            //}

            for (int i = 0; i < rowCount; i++)
            {
                sqlDataReader.Read();
                data[i, 0] = sqlDataReader["CustomerID"].ToString();
                data[i, 1] = sqlDataReader["CustomerName"].ToString();
                data[i, 2] = sqlDataReader["CustomerDomain"].ToString();
                data[i, 3] = sqlDataReader["JoiningDate"].ToString();
            }
                    

            sqlDataReader.Close();
            sqlConnection.Close();

            if (Debugger.IsAttached)
            {
                //Console.ReadKey();
            }

            return data;
        }

        public static void InsertDataIntoCustomer()
        {
            // Data Source – This is the name of the server on which the database resides. In our case, it resides on a machine called WIN-50GP30FGO75.
            // The Initial Catalog is used to specify the name of the database
            // The UserID and Password are the credentials required to connect to the database.

            string connectionString;
            connectionString = @"Data Source=ANIKET-PC;Initial Catalog=myDatabase;User ID=sa;Password=sqlserver";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * from [myDatabase].[dbo].[Customer]", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Console.WriteLine("{0}  {1}  {2}  {3}", sqlDataReader.GetValue(0), sqlDataReader.GetValue(1),sqlDataReader.GetValue(2), sqlDataReader.GetValue(3));
            }

            sqlDataReader.Close();
            sqlConnection.Close();

            if (Debugger.IsAttached)
            {
                Console.ReadKey();
            }
        }
    }
}
