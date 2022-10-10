using System;
namespace RoadBook.CsharpBasic.Chapter05.Works
{
    public class Exam001
    {
        public void Run()
        {
            Console.WriteLine("Input 2 numers: ");
            int number01 = Convert.ToInt32(Console.ReadLine());
            int number02 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Calculator(number01, number02, '+'));
            Console.WriteLine(Calculator(number01, number02, '-'));
            Console.WriteLine(Calculator(number01, number02, '*'));
            Console.WriteLine(Calculator(number01, number02, '/'));

        }
        private string Calculator(int number01, int number02, char type)
        {
            switch (type)
            {
                case '+':
                    return string.Format("{0} + {1} = {2}", number01, number02, number01 + number02);
                case '-':
                    return string.Format("{0} - {1} = {2}", number01, number02, number01 - number02);
                case '*':
                    return string.Format("{0} * {1} = {2}", number01, number02, number01 * number02);
                case '/':
                    return string.Format("{0} / {1} = {2}", number01, number02, (double)number01 / number02);
                default:
                    return"";
            }
        }
    }
}
