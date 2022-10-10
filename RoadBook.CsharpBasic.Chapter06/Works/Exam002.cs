using System;

namespace RoadBook.CsharpBasic.Chapter06.Works
{
    public class Exam002
    {
        public void Run()
        {
            int[] numArr = new int[5];
            for (int i = 0; i < numArr.Length; i++)
            {
                Console.Write("Input a number : ");
                numArr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numArr.Length; i++)
            {
                for (int j = 0; j < numArr.Length - 1 - i; j++)
                {
                    if (numArr[j] > numArr[j + 1])
                    {
                        int a = numArr[j];
                        numArr[j] = numArr[j + 1];
                        numArr[j + 1] = a;
                    }
                }
            }
            for (int i = 0; i < numArr.Length; i++)
            {
                if (i < numArr.Length - 1)
                {
                    Console.Write("{0}, ", numArr[i]);
                }
                else
                {
                    Console.Write("{0}", numArr[i]);
                }
            }
        }
    }
}
