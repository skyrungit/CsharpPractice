using System;

namespace RoadBook.CsharpBasic.Chapter04.Works
{
    public class Exam003
    {
        public void Run()
        {
            bool _input = true;
            int number;
            double wallet = 0;
            int money;

            do
            {
                Console.WriteLine("***HELLO THIS IS ROAD BANK***" +
                                  "\r\n1: 잔액조회" +
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
