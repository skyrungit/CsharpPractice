using System;

namespace RoadBook.CsharpBasic.Chapter03.Works
{
    public class Exam001
    {
        public void Run()
        {
            Random random = new Random();
            int number01 = random.Next(0, 100);
            int number02 = random.Next(0, 100);
            Console.WriteLine("{0} + {1} = ?: ", number01, number02);

            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == number01 + number02)
            {
                Console.WriteLine("O");
            }
            else
            {
                Console.WriteLine("X");
            }

        }
    }
}
