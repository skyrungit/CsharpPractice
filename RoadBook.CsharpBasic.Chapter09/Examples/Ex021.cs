﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace RoadBook.CsharpBasic.Chapter09.Examples
{
    public class Ex021
    {
        public void Run()
        {
            using (UserDataContext context = new UserDataContext())
            {
                var query = context.TB_USERs.Select(u => u);

                foreach (TB_USER item in query)
                {
                    Console.WriteLine(item.NAME);
                }
            }
        }
    }
}
