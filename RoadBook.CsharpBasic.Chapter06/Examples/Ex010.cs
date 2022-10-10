using System;
using System.Collections;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    public class Ex010
    {
        public void Run()
        {
            Stack stk = new Stack();
            Console.WriteLine("* Start Point");
            for (int idx = 1; idx < 11; idx++)
            {
                Console.WriteLine("{0}th runner arrived", idx);
                stk.Push(string.Format("{0}th runner", idx));
            }
            Console.WriteLine("=====");
            Console.WriteLine("5~10 runners will fail.");
            for (int idx = 1; idx < 6; idx++)
            {
                stk.Pop();
            }

            Console.WriteLine("=====");
            Console.WriteLine("*Best 5");

            foreach (object obj in stk)
            {
                Console.WriteLine(obj.ToString());
            }
        }
    }
}
