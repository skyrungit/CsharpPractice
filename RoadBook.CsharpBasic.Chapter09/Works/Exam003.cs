using System;
using System.Collections.Generic;
using System.Linq;

namespace RoadBook.CsharpBasic.Chapter09.Works
{
    public class Exam003
    {
        public void Run()
        {
            using (UserDataContext context = new UserDataContext())
            {
                TB_USER tb_user = new TB_USER()
                {
                    ID = "U008",
                    NAME = "Julie",
                    AGE = 32,
                    JOB = "Designer"
                };

                context.TB_USERs.InsertOnSubmit(tb_user);
                context.SubmitChanges();
            }
        }
    }
}
