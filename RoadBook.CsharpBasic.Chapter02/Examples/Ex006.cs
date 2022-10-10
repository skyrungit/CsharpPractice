using System;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class Ex006
    {   
        public void Run()
        {
            #region >> 정수형 변수
            sbyte ShortByteNumber = 127;
            byte byteNumber = 0;
            short shortNumber = 32767;
            int intNumber = 2000;
            long longNumber = 123455;
            #endregion

            #region >> 실수형 변수
            float floatNumber = 3.14f;
            double doubleNumber = 1.5;
            decimal decimalNumber = 5.5m;
            #endregion

            Console.WriteLine("정수 : {0}, {1}, {2}, {3}, {4}", ShortByteNumber, byteNumber, shortNumber, intNumber, longNumber);
            Console.WriteLine("실수 : {0}, {1}, {2}", floatNumber, doubleNumber, decimalNumber);

            #region >> 문자열 변수
            char ch = 'A';
            string strMessage = "Hello Csharp";
            #endregion

            Console.WriteLine(ch);
            Console.WriteLine("{0}{1}{2}{3}{4}", strMessage[0], strMessage[1], strMessage[2], strMessage[3], strMessage[4]);

            #region >> True or False
            bool bCalculate = (1 + 2 == 3);
            bool bCalculate2 = ((12 > 8) && (8 < 20));
            bool isContainsWord = "Hello Csharp".Contains("Hello");
            #endregion

            Console.WriteLine();

        }
    }
}