using System;
using System.Collections;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    public class Ex009
    {
        public void Run()
        {
            Queue que = new Queue();

            for (int idx = 1; idx < 11; idx++)
            {
                que.Enqueue(string.Format("{0}th Passenger", idx));
            }

            Console.WriteLine("* Passenger Status");
            foreach (object obj in que)
            {
                Console.WriteLine(obj.ToString());
            }
            Console.WriteLine("======================");
            Console.WriteLine("Bus arrived. (6 people can get in)");

            for (int i = 0; i < 6; i++)
            {
                que.Dequeue();
            }

            Console.WriteLine("Bus departed.");
            Console.WriteLine("======================");

            Console.WriteLine("New Passengers are queued");
            que.Enqueue("New Passengers");

            Console.WriteLine("* Passenger Status");
            foreach (object obj in que)
            {
                Console.WriteLine(obj.ToString());
            }
            Console.WriteLine("==================");
        }
    }
}
