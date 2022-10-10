using System;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    public class Ex009
    {
        public void Run()
        {
            GasolineCar009 gasolineCar = new GasolineCar009();
            gasolineCar.Color = "Black";
            gasolineCar.Size = "SUV";
            ElectronicCar009 electronicCar = new ElectronicCar009();
            electronicCar.Color = "White";
            electronicCar.Size = "Small";

            Console.WriteLine("{0} {1} Gasoline", gasolineCar.Color, gasolineCar.Size);
            gasolineCar.InputGas();

            Console.WriteLine("{0} {1} Electric", electronicCar.Color, electronicCar.Size);
            electronicCar.InputGas();
        }
    }

    class Car009
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
        public virtual void InputGas()
        {
            Console.WriteLine("Input Gas.");
        }
    }

    class GasolineCar009 : Car009 
    {
        public override void InputGas()
        {
            Console.WriteLine("Input Gasoline.");
        }
    }
    class ElectronicCar009 : Car009
    {
        public override void InputGas()
        {
            Console.WriteLine("Input Electricity.");
        }
    }
}
