using System;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    public class Ex008
    {
        public void Run()
        {
            Console.WriteLine("Input a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isEvenNumber = number % 2 == 0 ? true : false;

            if (number > 0 && isEvenNumber)
            {
                Console.WriteLine("{0} is possitive and even", number);
            }
            else if (number < 0 && isEvenNumber)
            {
                Console.WriteLine("{0} is negative and even", number);
            }
            else if (number > 0 && !isEvenNumber)
            {
                Console.WriteLine("{0} is possivie and odd", number);
            }
            else if (number < 0 && !isEvenNumber)
            {
                Console.WriteLine("{0} is negative and odd", number);
            }
            else
            {
                Console.WriteLine("{0} is zero");
            }

        }
    }
}
