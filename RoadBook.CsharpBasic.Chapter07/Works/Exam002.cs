using System;

namespace RoadBook.CsharpBasic.Chapter07.Works
{
    public class Exam002
    {
        public void Run()
        {
            int number = 0;
            Console.Write("Input a number: ");
            try
            {
                number = Convert.ToByte(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
