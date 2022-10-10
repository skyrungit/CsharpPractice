using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter06.Works
{
    public class Exam003
    {
        public void Run()
        {
            Console.WriteLine("It is a free First In First Get");
            Console.Write("How many to get free? : ");
            int cnt = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();
            while (true)
            {
                Console.Write("Input a name (q : Exit) : ");
                string name = Console.ReadLine();
                if (name == "q" || name == "Q")
                {
                    break;
                }
                queue.Enqueue(name);
            }

            Console.WriteLine("Free goes to : ");
            for (int i = 0; i < cnt; i++)
            {
                Console.WriteLine("{0}", queue.Dequeue());
            }
        }
    }
}
