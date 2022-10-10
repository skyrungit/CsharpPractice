using System;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    public class Ex002
    {
        public void Run()
        {
            string[] weathers = new string[7];

            weathers[0] = "sunny";
            weathers[1] = "sunny";
            weathers[2] = "rainy";
            weathers[3] = "cloudy";
            weathers[4] = "rainy";
            weathers[5] = "snow";
            weathers[6] = "sunny";

            int dayCnt = weathers.Length;
            int sunnyCnt = 0;
            int cloudyCnt = 0;
            int rainyCnt = 0;
            int snowCnt = 0;

            for (int i = 0; i < dayCnt; i++)
            {
                string weather = weathers[i];
                if (weather == "sunny")
                {
                    sunnyCnt++;
                }
                else if (weather == "cloudy")
                {
                    cloudyCnt++;
                }
                else if (weather == "rainy")
                {
                    rainyCnt++;
                }
                else if (weather == "snow")
                {
                    snowCnt++;
                }
            }

            Console.WriteLine("SUNNY : {0} / CLOUDY : {1} / RAINY : {2} / SNOW : {3}", sunnyCnt, cloudyCnt, rainyCnt, snowCnt);
        }
    }
}
