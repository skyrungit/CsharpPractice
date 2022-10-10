using System;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    public class Ex005
    {
        public void Run()
        {
            const int number = 0;

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
        }
    }
}
