using System;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    public class Ex008
    {
        public void Run()
        {
            GasolineCar008 gasolineCar = new GasolineCar008();
            gasolineCar.Color = "Black";
            gasolineCar.Size = "SUV";
            ElectronicCar008 electronicCar = new ElectronicCar008();
            electronicCar.Color = "White";
            electronicCar.Size = "Small";

            Console.WriteLine("{0} {1} Gasoline", gasolineCar.Color, gasolineCar.Size);
            gasolineCar.Go();

            Console.WriteLine("{0} {1} Electric", electronicCar.Color, electronicCar.Size);
            electronicCar.Right();
        }
    }

    class Car008
    {
        public string Color { get; set; }
        public string Size { get; set; }

        public void Engine_on()
        {
            Console.WriteLine("Turn on Engine.");
        }
        public void Engine_off()
        {
            Console.WriteLine("Turn off Engine.");
        }
        public void Go()
        {
            Console.WriteLine("Go Straight.");
        }
        public void Back()
        {
            Console.WriteLine("Go Back.");
        }
        public void Right()
        {
            Console.WriteLine("Turn Right.");
        }
        public void Left()
        {
            Console.WriteLine("Turn Left.");
        }
    }

    class GasolineCar008 : Car008 { }
    class ElectronicCar008 : Car008 { }
}
