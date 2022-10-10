using System;
using System.IO;
using System.Data.SqlClient;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    public class Ex008
    {
        private readonly string currentDir = Environment.CurrentDirectory;
        private readonly string connectionStr = string.Format("Data Source = {0}, {1}; Initial Catalog = {2}; User ID = {3}; Password = {4}", "127.0.0.1", 1433, "testdb", "sa", "didtmdrb67");
        public void Run()
        {
            CheckedDirectory();
            TryConnectToDatabase();
        }
        private void CheckedDirectory()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(currentDir + @"\data");
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
        }

        private void TryConnectToDatabase()
        {
            SqlConnection connection = new SqlConnection(connectionStr);
            string fileName = string.Format(@"\data\db{0}.log", DateTime.Now.ToString("yyyyMMddHHmmss"));

            using (StreamWriter sw = new StreamWriter(currentDir + fileName, true))
            {
                sw.WriteLine("[{0}] Try to connecto DB...", DateTime.Now);
                connection.Open();
                sw.WriteLine("[{0}] DB Connection OK...", DateTime.Now);

                Console.Write("Input Delete User ID : ");
                string userID = Console.ReadLine();

                string deleteSQL = string.Format(" DELETE FROM TB_USER WHERE ID = '{0}' ", userID);

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = deleteSQL;
                    int activeNumber = command.ExecuteNonQuery();

                    sw.WriteLine("Infected Data : ", +activeNumber);
                }

                sw.WriteLine("[{0}] Try to disconnect DB...", DateTime.Now);
                connection.Close();
                sw.WriteLine("[{0}] DB disconnection OK...", DateTime.Now);

            }
        }
    }
}
