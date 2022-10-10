using System;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    public class Ex010
    {
        public void Run()
        {
            Random rand = new Random();
            int target_number = rand.Next(1, 10);
            Console.WriteLine("Guess a number(1~10): ");

            int count = 0;
            bool isMatched = false;
            do
            {
                if ((Convert.ToInt32(Console.ReadLine())) == target_number)
                {
                    isMatched = true;
                    Console.WriteLine("You tried {0} times", count);
                }
                else
                {
                    Console.WriteLine("Wrong");
                    count++;
                }
            } while (isMatched == false);
        }
    }
}
