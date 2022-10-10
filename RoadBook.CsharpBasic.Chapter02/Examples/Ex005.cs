using System;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class Ex005
    {
        public void Run()
        {
            object objHello = "Hello World";
            var vHello = "Hello World";
            dynamic dHello = "Hello World";

            bool isContainsWord01 = objHello.ToString().Contains("Hello");
            bool isContainsWord02 = vHello.Contains("Hello");
            bool isContainsWord03 = dHello.Contains("Hello");
            
            Console.WriteLine("Hello in object? {0}", isContainsWord01);
            Console.WriteLine("Hello in var? {0}", isContainsWord02);
            Console.WriteLine("Hello in dynamic? {0}", isContainsWord03);
        }
    }
}
