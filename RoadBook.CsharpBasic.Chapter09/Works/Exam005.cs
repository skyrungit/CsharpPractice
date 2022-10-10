using System;
using System.Collections.Generic;
using System.Linq;

namespace RoadBook.CsharpBasic.Chapter09.Works
{
    public class Exam005
    {
        public void Run()
        {
            using (UserDataContext context = new UserDataContext())
            {
                var tbUser = context.TB_USERs.Where(u => u.ID == "U004").First();

                context.TB_USERs.DeleteOnSubmit(tbUser);
                context.SubmitChanges();
            }
        }
    }
}
