using System;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    public class Ex001
    {
        public void Run()
        {
            Console.Write("Input a number : ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number was : {0}", number);
        }
    }
}
