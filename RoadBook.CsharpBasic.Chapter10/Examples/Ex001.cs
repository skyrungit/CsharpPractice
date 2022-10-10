using System;
using System.Data;
using System.Text;
using RoadBook.CsharpBasic.Chapter10.Models;
using RoadBook.CsharpBasic.Chapter10.Manager;
using System.Linq;

namespace RoadBook.CsharpBasic.Chapter10.Examples
{
    public class Ex001
    {
        public void Run()
        {
            DatabaseInfo dbInfo = new DatabaseInfo();
            dbInfo.Name = "RoadbookPractice";
            dbInfo.Ip = "127.0.0.1";
            dbInfo.Port = 1433;
            dbInfo.UserId = "sa";
            dbInfo.UserPassword = "didtmdrb67";

            MsSqlManager ms = new MsSqlManager();
            ms.Open(dbInfo);

            StringBuilder sbMessage = new StringBuilder();
            sbMessage.AppendLine("******************************");
            sbMessage.AppendLine("1. SELECT");
            sbMessage.AppendLine("2. INSERT");
            sbMessage.AppendLine("3. UPDATE");
            sbMessage.AppendLine("4. DELETE");
            sbMessage.AppendLine("5. QUIT");
            sbMessage.AppendLine("******************************");

            while (true)
            {
                Console.WriteLine(sbMessage.ToString());
                string input = Console.ReadLine();

                if (input == "0")
                {
                    ms.Close();

                    Console.WriteLine("BYT");
                    break;
                }
                else
                {
                    string index = string.Empty;
                    string title = string.Empty;
                    string summary = string.Empty;
                    string createUserNm = string.Empty;
                    string tags = string.Empty;
                    string createDate = string.Empty;

                    StringBuilder sbSQL = new StringBuilder();

                    switch (input)
                    {
                        case "1"://SELECT
                            DataTable dt = ms.Select("")
                        default:
                            break;
                    }
                }
            }
           
        }
    }
}
