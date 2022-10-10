using System;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class Ex004
    {
        public void Run()
        {
            object objValue = 1;
            var vValue = "var";
            dynamic dValue = true;

            Console.WriteLine("object is {0}", objValue);
            Console.WriteLine("var is {0}", vValue);
            Console.WriteLine("dynamic is {0}", dValue);
        }
    }
}
