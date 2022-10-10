using System;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    public class Ex003
    {
        public void Run()
        {
            const int zero = 0;

            if (zero == 0)
            {
                Console.WriteLine("The first if");
                Console.WriteLine("zero is 0");
            }
            else
            {
                Console.WriteLine("The first else");
                Console.WriteLine("Else excepted.");
            }

            if (zero == 1)
            {
                Console.WriteLine("The second if");
                Console.WriteLine("zero is not 1");
            }
            else
            {
                Console.WriteLine("The Second else");
                Console.WriteLine("elseelselse");
            }
        }
    }
}
