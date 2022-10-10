using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    public class Ex004
    {
        public void Run()
        {
            Console.Write("Input a number : ");

            try
            {
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Input number is {0}", number);
            }
            catch (Exception e)
            {
                Console.WriteLine("An Exception Occured.");
                Console.WriteLine("Error Code : {0}", e.HResult);
                Console.WriteLine("Error Message : {0}", e.Message);
            }
        }
    }
}
