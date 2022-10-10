using System;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    public class Ex004
    {
        public void Run()
        {
            Bread custard_cream_bread = new Bread();
            custard_cream_bread.Shape = "Star";
            custard_cream_bread.Source = "Cream";
            Console.WriteLine("{0} {1} BREAD", custard_cream_bread.Shape, custard_cream_bread.Source);

            Bread pizza_bread = new Bread();
            pizza_bread.Shape = "Square";
            pizza_bread.Source = "Pizza";

            Console.WriteLine("{0} {1} BREAD", pizza_bread.Shape, pizza_bread.Source);
        }
    }

    class Bread
    {
        public string Shape { get; set; }
        public string Source { get; set; }
    }
}
