using System;

namespace RoadBook.CsharpBasic.Chapter07.Works
{
    public class Exam001
    {
        public int Run()
        {
            int number = -1;
            bool isException = false;

            Console.Write("Input a number : ");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                isException = true;
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                isException = true;
            }
            finally
            {
                number = isException ? -1 : number;
            }
            return number;
        }
    }
}
