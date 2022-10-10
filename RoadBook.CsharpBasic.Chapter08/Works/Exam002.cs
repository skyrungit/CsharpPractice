using RoadBook.CsharpBasic.Chapter08.Model;
using System;
using System.Data.SqlTypes;
using System.IO;
using System.Threading;

namespace RoadBook.CsharpBasic.Chapter08.Works
{
    public class Exam002
    {
        Model.Account account;
        public void Run()
        {
            Console.WriteLine("*****Hello, this is ROAD BANK*****\r\n1: Create an Account\r\n2: Check Balence\r\n3: Deposit\r\n4: Withdraw\r\n0: Exit\r\n**********************************");

            Start();

            while (true)
            {
                int inputNumber = Convert.ToInt32(Console.ReadLine());

                if (inputNumber == 0)
                {
                    break;
                }
                switch (inputNumber)
                {
                    case 1:
                        Console.Write("Input Account Name : ");
                        string accountName = Console.ReadLine();
                        Console.Write("Input User Name : ");
                        string userName = Console.ReadLine();

                        CreateAccount(accountName, userName);
                        break;
                    case 2:
                        CheckBalence();
                        break;
                    case 3:
                        Console.Write("Input Deposit Amount : ");
                        int inputDeposit = Convert.ToInt32(Console.ReadLine());

                        Deposit(inputDeposit);
                        break;
                    case 4:
                        Console.Write("Input Withdraw Amount : ");
                        int outputwithdraw = Convert.ToInt32(Console.ReadLine());

                        Withdraw(outputwithdraw);
                        break;
                    default:
                        Console.WriteLine("Wrong Input.");
                        break;
                }
            }
            Exit();
        }

        private void Start()
        {
            string logFilePath = string.Format(@"{0}\banklog", Environment.CurrentDirectory);
            DirectoryInfo directory = new DirectoryInfo(logFilePath); //banklog Folder 위치

            if (directory.Exists && directory.GetFiles().Length > 0)
            {
                FileInfo file = directory.GetFiles()[0];
                string[] bankInfo = file.Name.Split('-');
                int money = 0;
                using (StreamReader sr = new StreamReader(file.FullName))
                {
                    money = Convert.ToInt32(sr.ReadLine());
                }

                account = new Model.Account()
                {
                    AccountName = bankInfo[0],
                    UserName = bankInfo[1],
                    Money = money
                };

                Console.WriteLine("Account Already Exists.");
            }
        }

        private void Exit()
        {
            if (account != null)
            {
                string directory = string.Format(@"{0}\bankLog\", Environment.CurrentDirectory);
                string filename = string.Format(@"{0}-{1}.txt", account.AccountName, account.UserName);

                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (StreamWriter sw = new StreamWriter(directory + filename, false))
                {
                    sw.WriteLine(account.Money);
                }
            }
            Console.WriteLine("Thank You.");

        }

        private void Withdraw(int outputwithdraw)
        {
            if (account.Money > outputwithdraw)
            {
                account.Money -= outputwithdraw;
                Console.WriteLine("{0} Withdrawed", outputwithdraw);
            }
            else
            {
                Console.WriteLine("Not enough money.");
            }
        }

        private void Deposit(int inputDeposit)
        {
            account.Money += inputDeposit;
            Console.WriteLine("{0} Depositted.", inputDeposit);
        }

        private void CheckBalence()
        {
            Console.WriteLine("Balence is : {0}", account.Money);
        }

        private void CreateAccount(string accountName, string userName)
        {
            account = new Model.Account();
            account.AccountName = accountName;
            account.UserName = userName;
            account.Money = 0;

            Console.WriteLine("{0}'s {1} Account is created!", account.UserName, account.AccountName);
        }
    }
}
