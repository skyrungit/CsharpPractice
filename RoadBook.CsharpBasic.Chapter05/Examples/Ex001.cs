using System;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    public class Ex001
    {
        public void Run()
        {
            Car001 car = new Car001();
            car.setSize("SUV");
            car.setColor("Black");
            Console.WriteLine("Your car is {0} {1}", car.getColor(), car.getSize());

            car.Engine_on();
            car.Go();
            car.Back();
            car.Left();
            car.Right();
            car.Engine_off();
        }
    }

    class Car001
    {
        #region >>Shape
        private string size;
        private string color;

        public void setSize(string siz)
        {
            this.size = siz;
        }
        public string getSize()
        {
            return size;
        }

        public void setColor(string colour)
        {
            this.color = colour;
        }
        public string getColor()
        {
            return color;
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
