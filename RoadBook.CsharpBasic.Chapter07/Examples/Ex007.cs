using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    public class Ex007
    {
        public void Run()
        {
            Console.WriteLine("Input a number : ");

            int number = -1;
            bool isException = false;

            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception: Input is not a number");
                isException = true;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow Exception: Exceed number range");
                isException = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected Exception.");
                Console.WriteLine("Error Code: {0}", e.HResult);
                Console.WriteLine("Error Message: {0}", e.Message);
                isException = true;
            }
            finally
            {
                if (isException)
                {
                    number = 0;
                }
            }

            Console.WriteLine("Input number is {0}", number);
        }
    }
}
