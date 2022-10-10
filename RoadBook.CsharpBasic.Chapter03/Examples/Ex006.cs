using System;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    public class Ex006
    {
        public void Run()
        {
            Console.WriteLine("Input a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("{0} is possitive", number);
            }
            else if (number < 0)
            {
                Console.WriteLine("{0} is negative", number);
            }
            else
            {
                Console.WriteLine("{0} is zero", number);
            }

            if (number%2 == 0)
            {
                Console.WriteLine("even number");
            }
            else
            {
                Console.WriteLine("odd number");
            }
        }
    }
}
