using System;
using System.Security.Cryptography.X509Certificates;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    public class Ex001
    {
        public void Run()
        {
            string weather = "sunny,sunny, rainy,cloudy, rainy,snow,snow";
            var weathers = weather.Split(',');

            Console.WriteLine(weather.GetType());
            Console.WriteLine(weathers.GetType());
        }
    }
}
