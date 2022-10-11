using System;
using System.Data;
using System.Text;
using RoadBook.CsharpBasic.Chapter10.Models;
using RoadBook.CsharpBasic.Chapter10.Manager;
using System.Linq;
using Microsoft.SqlServer.Server;

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

                    Console.WriteLine("BYE");
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
                            DataTable dt = ms.Select("SELECT IDX, TITLE, SUMMARY, CREATE_DT, CREATE,USER,NM, TAGS, LIKE_CNT, CATEGORY_IDX, FROM TB_CONTENTS");
                            if (dt.Rows.Count > 0)
                            {
                                string[] columns = new string[dt.Columns.Count];
                                for (int idx = 0; idx < dt.Columns.Count; idx++)
                                {
                                    columns[idx] = dt.Columns[idx].ToString();

                                    Console.WriteLine(dt.Columns[idx] + "\t");
                                }

                                Console.WriteLine();

                                for (int idx = 0; idx < dt.Rows.Count; idx++)
                                {
                                    for (int idx_j = 0; idx_j < dt.Columns.Count; idx_j++)
                                    {
                                        Console.WriteLine(dt.Rows[idx][columns[idx_j]] + "\t");
                                    }

                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("No Data!!");
                            }

                            break;
                        case "2":

                        default:
                            break;
                    }
                }
            }

        }
    }
}
