using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter09.Examples
{
    public class Ex001
    {
        public void Run()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> tmpNumbers = new List<int>();

            //Find Even Number
            for (int idx = 0; idx < numbers.Length; idx++)
            {
                if (numbers[idx] %2 == 0)
                {
                    tmpNumbers.Add(numbers[idx]);
                }
            }

            for (int i = 0; i < tmpNumbers.Count; i++)
            {
                Console.WriteLine(tmpNumbers[i]);
            }

            tmpNumbers.Clear();

            //Find Odd Number
            tmpNumbers = numbers.Where(n => (n % 2)==1).ToList();

            for (int i = 0; i < tmpNumbers.Count; i++)
            {
                Console.WriteLine(tmpNumbers[i]);
            }
        }
    }
}
