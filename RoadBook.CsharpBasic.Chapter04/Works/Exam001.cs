using System;

namespace RoadBook.CsharpBasic.Chapter04.Works
{
    public class Exam001
    {
        public void Run()
        {
            Console.WriteLine("Input an integer: ");

            int number = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = number; i > 0; i--)
            {
                fact *= i;
                Console.Write("{0}", i);
                if (i != 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" = {0}", fact);
                }
            }

        }
    }
}
