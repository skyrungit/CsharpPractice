using System;

namespace RoadBook.CsharpBasic.Chapter05.Works
{
    public class Exam003
    {
        public void Run()
        {
            bool _input = true;
            int number;
            int money;

            do
            {
                Console.WriteLine("***HELLO THIS IS ROAD BANK***" +
                                  "\r\n0: 계좌 만들기" +
                                  "\r\n1: 잔액 조회" +
                                  "\r\n2: 입금" +
                                  "\r\n3: 출금" +
                                  "\r\n0. 종료" +
                                  "\r\n******************************");

                number = Convert.ToInt32(Console.ReadLine());
                if (number == 1)
                {
                    Console.WriteLine("You have ${0}\r\n", wallet);
                }
                else if (number == 2)
                {
                    Console.WriteLine("Input money +++");
                    money = Convert.ToInt32(Console.ReadLine());
                    wallet += money;
                }
                else if (number == 3)
                {
                    Console.WriteLine("Input money ---");
                    money = Convert.ToInt32(Console.ReadLine());
                    if (money > wallet)
                    {
                        Console.WriteLine("MONEY > WALLET");
                    }
                    else
                    {
                        wallet -= money;
                    }
                }
                else if (number == 9)
                {
                    string name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Input New Account Name: ");
                    Console.WriteLine("New Account Name : {0}", name);

                    string account = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Input Your Name: ");
                    Console.WriteLine("Your Name : {0}", account);

                    int wallet Convert.Toint32(Console.ReadLine());
                    Console.WriteLine("Input Your Name: ");
                    Console.WriteLine("Your Name : {0}", account);

                    Console.WriteLine("{0}'s {1} is created!", name, account);
                    User newuser = new User(name, account, wallet);
                }
                else if (number == 0)
                {
                    _input = false;
                    Console.WriteLine("BYE");
                }
                else
                {
                    Console.WriteLine("Input 0~4");
                }

            } while (_input == true);
        }
    }


}
