using System;

namespace RoadBook.CsharpBasic.Chapter02.Works
{
    public class Exam002
    {
        public void Run()
        {
            Console.WriteLine("Input Number01: ");
            int number01 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input Number02: ");
            int number02 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", number01, number02, number01+number02);
            Console.WriteLine("{0} - {1} = {2}", number01, number02, number01-number02);
            Console.WriteLine("{0} * {1} = {2}", number01, number02, number01*number02);
            Console.WriteLine("{0} / {1} = {2}", number01, number02, (double)number01/number02);

        }

    }
}
