using System;
using RoadBook.CsharpBasic.Chapter07.Examples.UserException;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    public class Ex008
    {
        public void Run()
        {
            Console.Write("Input 2 numbers: ");
            try
            {
                int number1 = Convert.ToInt32(Console.ReadLine());
                int number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(Divide(number1, number2));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private int Divide(int number1, int number2)
        {
            if (number2 == 0)
            {
                throw new MyStyleException("Can not divide 0!!");
            }

            return number1 / number2;
        }
    }
}
