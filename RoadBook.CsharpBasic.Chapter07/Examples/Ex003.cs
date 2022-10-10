using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    public class Ex003
    {
        public void Run()
        {
            Console.Write("Input a number : ");
            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Input number is : {0}", number);
            }
            catch (Exception)
            {
                Console.WriteLine("An Exception occured.");
            }
        }
    }
}
