using RoadBook.CsharpBasic.Chapter08.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter08.Works
{
    public class Exam004
    {
        private readonly string connectionStr = string.Format("Data Source = {0}, {1}; Initial Catalog = {2}; User ID={3}; Password={4}", "127.0.0.1", 1433, "testdb", "sa", "didtmdrb67");

        SqlConnection connection;
        public void Run()
        {
            Console.WriteLine("1: Input Grade");
            Console.WriteLine("2: Ask About Grade");
            Console.WriteLine("3: Check Grade");
            Console.WriteLine("0: Exit");

            connection = new SqlConnection(connectionStr);
            connection.Open();
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 0)
                {
                    break;
                }
                switch (input)
                {
                    case 1:
                        Create();
                        break;
                    case 2:
                        Modify();
                        break;
                    case 3:
                        Read();
                        break;
                    default:
                        Console.WriteLine("Wrong Input.");
                        break;
                }
            }
            connection.Close();
        }

        private void Read()
        {
            string selectSQL = string.Format(" SELECT STUDENT_NAME, STUDENT_ID, SUBJECT, SCORE FROM TB_GRADE ");

            using (SqlCommand command = new SqlCommand(selectSQL, connection))
            {
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("Student Name: {0}", reader["STUDENT_NAME"]);
                    Console.WriteLine("Student No.: {0}", reader["STUDENT_ID"]);
                    Console.WriteLine("Subject: {0}", reader["SUBJECT"]);
                    Console.WriteLine("Grade: {0}", reader["SCORE"]);
                    Console.WriteLine("=====");
                }
                reader.Close();
            }
        }

        private void Modify()
        {
            Console.Write("Input Student No.: ");
            string sID = Console.ReadLine();

            string selectSQL = string.Format(" SELECT SUBJECT, SCORE FROM TB_GRADE WHERE STUDENT_ID = '{0}' ", sID);

            using (SqlCommand command = new SqlCommand(selectSQL, connection))
            {
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("Subject : {0}", reader["SUBJECT"]);
                    Console.WriteLine("Grade : {0}", reader["Score"]);
                    Console.WriteLine("=====");
                }
                reader.Close();
            }

            Console.Write("Input Modify Subject: ");
            string subject = Console.ReadLine();
            Console.Write("Input Grade: ");
            int score = Convert.ToInt32(Console.ReadLine());

            string updateSQL = string.Format(" UPDATE TB_GRADE SET SCORE='{0}' WHERE STUDENT_ID='{1}' AND SUBJECT='{2}' ", score, sID, subject);

            using (SqlCommand command = new SqlCommand(updateSQL, connection))
            {
                int activeNumber = command.ExecuteNonQuery();
                Console.WriteLine("Infected Data: " +activeNumber);
            }
        }

        private void Create()
        {
            Console.Write("Input Student Name: ");
            string sName = Console.ReadLine();
            Console.Write("Input Student No.: ");
            string sID = Console.ReadLine();
            Console.Write("Input Subject Name: ");
            string subject = Console.ReadLine();
            Console.Write("Input Grade: ");
            int score = Convert.ToInt32(Console.ReadLine());
            string insertSQL = string.Format(" INSERT INTO TB_GRADE (STUDENT_NAME, STUDENT_ID, SUBJECT, SCORE) VALUES ( '{0}', '{1}', '{2}', '{3}' )", sName, sID, subject, score);

            using (SqlCommand command = new SqlCommand(insertSQL, connection))
            {
                int activeNumber = command.ExecuteNonQuery();
                Console.WriteLine("Infected Data : " + activeNumber);
            }
        }
    }
}
