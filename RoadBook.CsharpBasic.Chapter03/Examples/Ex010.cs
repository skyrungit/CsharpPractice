using System;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    public class Ex010
    {
        public void Run()
        {
            Console.WriteLine("Input a move name: ");
            string movieTitle = Console.ReadLine();
            Console.WriteLine("Input rating (1~5): ");
            int rating = Convert.ToInt32(Console.ReadLine());

            switch (rating)
            {
                case 1:
                    Console.WriteLine("{0} rating is 1", movieTitle);
                    break;
                case 2:
                    Console.WriteLine("{0} rating is 2", movieTitle);
                    break;
                case 3:
                    Console.WriteLine("{0} rating is 3", movieTitle);
                    break;
                case 4:
                    Console.WriteLine("{0} rating is 4", movieTitle);
                    break;
                case 5:
                    Console.WriteLine("{0} rating is 5", movieTitle);
                    break;
                default:
                    Console.WriteLine("Rating Error");
                    break;
            }
        }

    }
}
