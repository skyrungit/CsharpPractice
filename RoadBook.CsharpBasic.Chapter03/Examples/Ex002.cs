using System;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    public class Ex002
    {
        public void Run()
        {
            const int zero = 0;

            if (zero == 0)
            {
                Console.WriteLine("The first if");
            }

            if (zero == 0)
            {
                Console.WriteLine("The second if");
                Console.WriteLine("zero is 0");
            }

            if (zero == 1)
            {
                Console.WriteLine("The third if");
                Console.WriteLine("zero is not 1");
            }
        }
    }
}
