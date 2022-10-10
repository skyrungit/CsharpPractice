using System;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    public class Ex005
    {
        public void Run()
        {
            Console.WriteLine("Input a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = 1;

            for (int i = number; i > 0; i--)
            {
                result = result * i;
            }
            Console.WriteLine("{0}! is {1}", number, result);
        }
    }
}
