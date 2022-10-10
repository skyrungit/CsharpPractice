using System;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class Ex003
    {
        public void Run()
        {
            bool bCalculate01 = (1 + 2 == 3);
            bool bCalculate02 = ((12 > 8) && (8 < 20));
            bool isContainsWord = "Hello Csharp".Contains("Hello");

            Console.WriteLine("1 + 2 = 3 ? ({0})", bCalculate01);
            Console.WriteLine("12 > 8 and 8 < 20 ? ({0})", bCalculate02);
            Console.WriteLine("'Hello' in 'Hello Csharp' ? ({0})", isContainsWord);
        }
    }
}
