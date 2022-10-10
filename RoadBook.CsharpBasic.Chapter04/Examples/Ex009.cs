using System;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    public class Ex009
    {
        public void Run()
        {
            Random random = new Random();
            int target_number = random.Next(1, 10);

            Console.WriteLine("Input your guess (1~10, input 0 for hint): ");
            int count = 1;
            int answer;
            while ((answer = Convert.ToInt32(Console.ReadLine())) != target_number)
            {
                if (answer == 0)
                {
                    Console.WriteLine("Hint : Target number % 2 = {0}", target_number%2);
                    continue;
                }
                Console.WriteLine("Wrong");
                count++;
            }
            Console.WriteLine("You tried {0} times", count);
        }
    }
}
