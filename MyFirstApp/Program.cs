﻿using System;
using System.Data;

namespace JustForTest
{
    //Class안에 선언해도 되고 이렇게 밖에 선언해도 됨
    //delegate int Compare(int a, int b);
    class MainApp
    {
        delegate int Compare(int a, int b);

        static int AscendCompare(int a, int b)
        {
            if (a > b)
            {
                return 1;
            }
            else if (a == b)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        static int DescendCompare(int a, int b)
        {
            if (a < b)
            {
                return -1;
            }
            else if (a == b)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        static void BubbleSort(int[] dataSet, Compare comparer)
        {
            int i = 0;
            int j = 0;
            int temp = 0;
            for (i = 0; i < dataSet.Length-1; i++)
            {
                for (j = 0; j < dataSet.Length-i-1; j++)
                {
                    if (comparer(dataSet[j], dataSet[j+1]) > 0)
                    {
                        temp = dataSet[j + 1];
                        dataSet[j + 1] = dataSet[j];
                        dataSet[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 3, 7, 4, 2, 10 };
            Console.WriteLine("Sorting Ascending...");

            BubbleSort(array, new Compare(AscendCompare));

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]}");
            }
        }
    }
}
