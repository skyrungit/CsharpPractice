using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter09.Examples
{
    public class Ex014
    {
        public void Run()
        {
            List<Models.Student> students = new List<Models.Student>()
            {
            new Models.Student { ID = "S001", Name = "Dexter", Grade = 3, Major = "Software" },
            new Models.Student { ID = "S002", Name = "Jeffrey", Grade = 4, Major = "Software" },
            new Models.Student { ID = "S003", Name = "Pil", Grade = 4, Major = "Software" },
            new Models.Student { ID = "S004", Name = "Khan", Grade = 2, Major = "Software" },
            new Models.Student { ID = "S005", Name = "Sven", Grade = 2, Major = "Software" },
            new Models.Student { ID = "S006", Name = "Ellin", Grade = 3, Major = "Design" },
            new Models.Student { ID = "S007", Name = "Sienna", Grade = 4, Major = "Design" },
            new Models.Student { ID = "S008", Name = "Clint", Grade = 3, Major = "Software" },
            new Models.Student { ID = "S009", Name = "Mike", Grade = 2, Major = "Advertisement" },
            new Models.Student { ID = "S010", Name = "Peter", Grade = 1, Major = "Theater" },
            };

            Dictionary<string, int> dictMajorCount = new Dictionary<string, int>();

            for (int idx = 0; idx < students.Count; idx++)
            {
                if (!dictMajorCount.ContainsKey(students[idx].Major))
                {
                    dictMajorCount.Add(students[idx].Major, 1);
                }
                else
                {
                    dictMajorCount[students[idx].Major] += 1;
                }
            }

            foreach (var key in dictMajorCount.Keys)
            {
                Console.WriteLine("{0} : {1}", key, dictMajorCount[key]);
            }
        }
    }
}
