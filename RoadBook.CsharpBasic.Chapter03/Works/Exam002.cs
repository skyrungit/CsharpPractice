using System;

namespace RoadBook.CsharpBasic.Chapter03.Works
{
    public class Exam002
    {
        public void Run()
        {
            Console.WriteLine("Input Midterm: ");
            int midterm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input FInal: ");
            int final = Convert.ToInt32(Console.ReadLine());

            double average = (double)(midterm + final) / 2;

            if (average >= 90)
            {
                Console.WriteLine("A");
            }
            else if (average >= 80)
            {
                Console.WriteLine("B");
            }
            else if (average >= 70)
            {
                Console.WriteLine("C");
            }
            else if (average >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
