using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    public class Ex006
    {
        public void Run()
        {
            Console.Write("Input a number : ");
            int number = 0;

            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception: Input number type.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow Exception: Outrange of int type.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Occured.");
                Console.WriteLine("Error Code: {0}", e.HResult);
                Console.WriteLine("Error Message: {0}", e.Message);
            }

            Console.WriteLine("Input number is {0}", number);
        }
    }
}
