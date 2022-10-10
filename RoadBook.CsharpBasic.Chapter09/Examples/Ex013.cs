using System;
using System.Collections.Generic;
using System.Linq;

namespace RoadBook.CsharpBasic.Chapter09.Examples
{
    public class Ex013
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

            students.GroupBy(s => s.Major, (key, g) => new { Major = key, Count = g.Count() }).ToList().ForEach(
                s => Console.WriteLine("{0} :{1}", s.Major, s.Count));
        }
    }
}
