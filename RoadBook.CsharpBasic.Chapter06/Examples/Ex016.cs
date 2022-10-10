using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    public class Ex016
    {
        public void Run()
        {
            Queue<string> que = new Queue<string>();

            for (int idx = 1; idx < 11; idx++)
            {
                que.Enqueue(string.Format("{0}th Passenger", idx));
            }

            Console.WriteLine("* Passenger Status");
            foreach (object obj in que)
            {
                Console.WriteLine(obj.ToString());
            }
            Console.WriteLine("=======================");
            Console.WriteLine("Bus Arrived. (6 People can get in)");

            for (int i = 0; i < 6; i++)
            {
                que.Dequeue();
            }
            Console.WriteLine("Bus Departed.");
            Console.WriteLine("=======================");

            Console.WriteLine("New Passengers get in line.");
            que.Enqueue("New Passengers");

            Console.WriteLine("* Passenger Status");
            foreach (string str in que)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("=================");
        }
    }
}
