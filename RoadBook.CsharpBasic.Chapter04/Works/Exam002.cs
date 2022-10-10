using System;

namespace RoadBook.CsharpBasic.Chapter04.Works
{
    public class Exam002
    {
        public void Run()
        {
            Random rand = new Random();
            int number = rand.Next(1, 50);

            Console.WriteLine("Input a number (1~50): ");

            int guess;
            while ((guess = Convert.ToInt32(Console.ReadLine())) != number)
            {
                if (guess > number)
                {
                    Console.WriteLine("Down");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Up");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("You are right it's {0}", number);
        }
    }
}
