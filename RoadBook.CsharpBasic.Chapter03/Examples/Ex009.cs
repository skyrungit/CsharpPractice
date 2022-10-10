using System;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    public class Ex009
    {
        public void Run()
        {
            Console.WriteLine("Input a move name: ");
            string movieTitle = Console.ReadLine();
            Console.WriteLine("Input rating (1~5): ");
            int rating = Convert.ToInt32(Console.ReadLine());

            if (rating == 1)
            {
                Console.WriteLine("{0} Rating is 1", movieTitle);
            }
            else if (rating == 2)
            {
                Console.WriteLine("{0} Rating is 2", movieTitle);
            }
            else if (rating == 3)
            {
                Console.WriteLine("{0} Rating is 3", movieTitle);
            }
            else if (rating == 4)
            {
                Console.WriteLine("{0} Rating is 4", movieTitle);
            }
            else if (rating == 5)
            {
                Console.WriteLine("{0} Rating is 5", movieTitle);
            }
            else
            {
                Console.WriteLine("rating Error");
            }
        }
    }
}
