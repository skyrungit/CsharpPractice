using System;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    public class Ex002
    {
        public void Run()
        {
            Car002 car = new Car002();
            car.Size = "SUV";
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

    class Car002
    {
        #region >>Shape
        private string size;
        private string color;
        public string Size
        {
            set { size = value; }
            get { return size; }
        }
        public string Color
        {
            set { color = value; }
            get { return color; }
        }
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
