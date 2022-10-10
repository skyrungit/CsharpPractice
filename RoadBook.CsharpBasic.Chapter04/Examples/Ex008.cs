using System;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    public class Ex008
    {
        public void Run()
        {
            Random random = new Random();
            int target_number = random.Next(1, 10);
            //Console.WriteLine(target_number);

            Console.WriteLine("Input your guess(1~9): ");

            int count = 1;
            while (Convert.ToInt32(Console.ReadLine()) != target_number)
            {
                Console.WriteLine("Try Again!");
                count++;
            }
            Console.WriteLine("You tried {0} times", count);
        }
    }
}
