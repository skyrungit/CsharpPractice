using System;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class Ex009
    {
        public void Run()
        {
            int number01 = 10;
            double number02 = number01;
            int number03 = (int)number02;

            Console.WriteLine("Type of nmber01 is {0}", number01.GetType());
            Console.WriteLine("Type of nmber02 is {0}", number02.GetType());
            Console.WriteLine("Type of nmber03 is {0}", number03.GetType());
        }
    }
}
