using System;
using System.Collections;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    public class Ex012
    {
        public void Run()
        {
            Hashtable hst = new Hashtable();
            hst.Add("korea", "한국");
            hst.Add("japan", "일본");
            hst.Add("brazil", "브라질");
            hst.Add("china", "중국");
            hst.Add("canada", "캐나다");
            hst.Add("america", "미국");
            hst.Add("spain", "스페인");

            while (true)
            {
                Console.Write("Input a Country in English(Q:Exit) : ");
                string word = Console.ReadLine().ToLower();

                if (word == "q")
                {
                    break;
                }

                if (hst.Contains(word))
                {
                    Console.WriteLine("{0} : {1}", word, hst[word]);

                    Console.Write("Delete Word?(Y:Delete / N:No) : ");
                    string deleteYN = Console.ReadLine().ToUpper();

                    if (deleteYN == "Y")
                    {
                        hst.Remove(word);
                    }
                }
                else
                {
                    Console.Write("There is no word in hst. Wanna add?(Y:Add / N:No) : ");
                    string addYN = Console.ReadLine().ToUpper();

                    if (addYN == "Y")
                    {
                        Console.Write("Input Korean Meaning : ");
                        string korean = Console.ReadLine();
                        hst.Add(word, korean);
                    }
                }

            }

        }
    }
}
