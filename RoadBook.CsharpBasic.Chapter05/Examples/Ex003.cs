using System;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    public class Ex003
    {
        public void Run()
        {
            Car003 car = new Car003();
            car.Size = "SUV3";
            car.Color = "Black";
            Console.WriteLine("Your car is {0} {1}", car.Color, car.Size);

            car.Engine_on();
            car.Go();
            car.Back();
            car.Left();
            car.Right();
            car.Engine_off();
        }
    }

    class Car003
    {
        #region >>Shape
        public string Size { get; set; }
        public string Color { set; get; }
        #endregion

        #region >>Method
        public void Engine_on()
        {
            Console.WriteLine("Start Engine.");
        }
        public void Engine_off()
        {
            Console.WriteLine("Engine Off.");
        }
        public void Go()
        {
            Console.WriteLine("Go Straight.");
        }
        public void Back()
        {
            Console.WriteLine("Go Back");
        }
        public void Left()
        {
            Console.WriteLine("Turn Left");
        }
        public void Right()
        {
            Console.WriteLine("Turn Right");
        }
        #endregion
    }
}
