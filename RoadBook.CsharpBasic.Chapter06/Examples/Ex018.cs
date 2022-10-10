using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    public class Ex018
    {
        public void Run()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("korea", "한국");
            dict.Add("china", "중국");
            dict.Add("japan", "일본");
            dict.Add("brazil", "브라질");
            dict.Add("canada", "캐나다");
            dict.Add("america", "미국");
            dict.Add("spain", "스페인");

            while (true)
            {
                Console.Write("Input a country (Q: Exit) : ");
                string word = Console.ReadLine().ToLower();

                if (word == "q")
                {
                    break;
                }

                if (dict.ContainsKey(word))
                {
                    Console.WriteLine("{0} : {1}", word, dict[word]);

                    Console.Write("Delete word? (Y / N) : ");
                    string deleteYN = Console.ReadLine().ToUpper();

                    if (deleteYN == "Y")
                    {
                        dict.Remove(word);
                    }
                }
                else
                {
                    Console.Write("There is no word, wanna add? (Y / N) : ");
                    string addYN = Console.ReadLine().ToUpper();

                    if (addYN == "Y")
                    {
                        Console.Write("Input Korean : ");
                        string korean = Console.ReadLine();

                        dict.Add(word, korean);
                    }
                }

            }
        }
    }
}
