using System;
using System.Data.SqlClient;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    public class Ex006
    {
        private readonly string connectionStr = string.Format("Data Source={0}, {1}; Initial Catalog = {2}; User ID = {3}; Password = {4}", "127.0.0.1", 1433, "testdb", "sa", "didtmdrb67");

        public void Run()
        {
            string selectSQL = " SELECT ID, NAME, AGE, JOB FROM TB_USER ";
            
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectSQL, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine("User ID : {0}", reader["ID"]);
                        Console.WriteLine("User Name : {0}", reader["NAME"]);
                        Console.WriteLine("User Age : {0}", reader["AGE"]);
                        Console.WriteLine("User Job : {0}", reader["JOB"]);
                        Console.WriteLine("=====");
                    }
                }
                connection.Close();
            }
        }
    }
}
