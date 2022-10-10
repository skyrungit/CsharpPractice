using System;

namespace RoadBook.CsharpBasic.Chapter06.Works
{
    public class Exam001
    {
        public void Run()
        {
            int[] ageArr = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Input {0}th person's age : ", i+1);
                int age = int.Parse(Console.ReadLine());
                ageArr[i] = age;
            }

            Console.WriteLine("Age Input Completed.");
            int st20 = 0;
            int st30 = 0;
            int st40 = 0;
            int st50 = 0;
            int st60 = 0;
            int lt60 = 0;

            for (int i = 0; i < ageArr.Length; i++)
            {
                if (ageArr[i] < 20)
                {
                    st20++;
                }
                else if (ageArr[i] < 30)
                {
                    st30++;
                }
                else if (ageArr[i] < 40)
                {
                    st40++;
                }
                else if (ageArr[i] < 50)
                {
                    st50++;
                }
                else if (ageArr[i] < 60)
                {
                    st60++;
                }
                else
                {
                    lt60++;
                }
            }
            Console.WriteLine("Less than 20 : {0}", st20);
            Console.WriteLine("Less than 30 : {0}", st30);
            Console.WriteLine("Less than 40 : {0}", st40);
            Console.WriteLine("Less than 50 : {0}", st50);
            Console.WriteLine("Less than 60 : {0}", st60);
            Console.WriteLine("Larger than 60 : {0}", lt60);


        }
    }
}
