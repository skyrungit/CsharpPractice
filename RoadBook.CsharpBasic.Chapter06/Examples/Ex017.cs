using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    public class Ex017
    {
        public void Run()
        {
            Stack<string> stk = new Stack<string>();

            Console.WriteLine("* Start Point");
            for (int idx = 1; idx < 11; idx++)
            {
                Console.WriteLine("{0}th runner arrived", idx);
                stk.Push(string.Format("{0}th runner", idx));
            }
            Console.WriteLine("=====");
            Console.WriteLine("5~10 will fail.");
            for (int idx = 0; idx < 6; idx++)
            {
                stk.Pop();
            }
            Console.WriteLine("=====");

            Console.WriteLine("* Top 5");
            foreach (string str in stk)
            {
                Console.WriteLine(str);
            }
        }
    }
}
