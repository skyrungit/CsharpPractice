using System;
using System.Data.SqlClient;
using System.IO;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    public class Ex007
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

                Model.User user = SetUser();

                string updateSQL = string.Format(" UPDATE TB_USER SET NAME = '{0}', AGE = '{1}', JOB = '{2}' WHERE ID = '{3}' ", user.Name, user.Age, user.Job, user.userID);

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = updateSQL;
                    int activeNumber = command.ExecuteNonQuery();

                    sw.WriteLine("Infected Data : ", +activeNumber);
                }

                sw.WriteLine("[{0}] Try to disconnect DB...", DateTime.Now);
                connection.Close();
                sw.WriteLine("[{0}] DB disconnection OK...", DateTime.Now);

            }
        }

        private Model.User SetUser()
        {
            Model.User user = new Model.User();

            bool validate = false;
            do
            {
                Console.Write("Input User ID Trying to Modify: ");
                user.userID = Console.ReadLine();
                Console.Write("Input User Name: ");
                user.Name = Console.ReadLine();
                Console.Write("Input User Age: ");
                user.Age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input User Job: ");
                user.Job = Console.ReadLine();

                Console.WriteLine("Modify User : {0} / {1} / {2} / {3} True? (Y/N)", user.userID, user.Name, user.Age, user.Job);
                validate = Console.ReadLine().ToUpper() != "Y";
            } while (validate);
            return user;
        }
    }
}
