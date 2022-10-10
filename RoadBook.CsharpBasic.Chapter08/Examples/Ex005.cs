using System;
using System.IO;
using System.Data.SqlClient;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    public class Ex005
    {
        private readonly string currentDir = Environment.CurrentDirectory;
        private readonly string connectionStr = string.Format("Data Source = {0}, {1};Initial Catalog = {2}; User ID = {3}; Password = {4}", "127.0.0.1", 1433, "testdb", "sa", "didtmdrb67");
        public void Run()
        {
            CheckedDirectory();
            TryConnectToDatabase();
        }
        private void CheckedDirectory()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(currentDir + @"\data");
            if(!directoryInfo.Exists) { directoryInfo.Create(); }
        }
        private void TryConnectToDatabase()
        {
            SqlConnection connection = new SqlConnection(connectionStr);
            string fileName = string.Format(@"\data\db{0}.log", DateTime.Now.ToString("yyyyMMddHHmmss"));
            using (StreamWriter sw = new StreamWriter(currentDir + fileName, true))
            {
                sw.WriteLine("[{0}] Try to connect DB...", DateTime.Now);
                connection.Open();
                sw.WriteLine("[{0}] DB Connection OK...", DateTime.Now);

                Model.User user = SetUser();
                string insertSQL = string.Format(" INSERT INTO TB_USER ( ID, NAME, AGE, JOB ) VALUES ( '{0}', '{1}', '{2}', '{3}' )", user.userID, user.Name, user.Age, user.Job);

                using (SqlCommand command = new SqlCommand(insertSQL, connection))
                {
                    int activeNumber = command.ExecuteNonQuery();
                    sw.WriteLine("Infected Data : " + activeNumber);
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
                Console.Write("Input New Member ID: ");
                user.userID = Console.ReadLine();
                Console.Write("Input New Member Name: ");
                user.Name = Console.ReadLine();
                Console.Write("Input New Member Age: ");
                user.Age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input New Member Job: ");
                user.Job = Console.ReadLine();

                Console.WriteLine("New Member : {0} / {1} / {2} / {3} True? (Y/N)", user.userID, user.Name, user.Age, user.Job);

                validate = Console.ReadLine().ToUpper() != "Y";

            } while (validate);

            return user; //get, set으로 user를 세팅하고 반환
        }
    }
}
