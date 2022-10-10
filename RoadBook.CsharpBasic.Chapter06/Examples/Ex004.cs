using System;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    public class Ex004
    {
        public void Run()
        {
            string[] days = { "sunny", "sunny", "rainy", "cloudy", "rainy", "snow", "sunny" };

            int dayCnt = days.Length;

            int sunnyCnt = 0;
            int cloudyCnt = 0;
            int snowCnt = 0;
            int rainyCnt = 0;

            for (int i = 0; i < dayCnt; i++)
            {
                string weather = days[i];
                if (weather == "sunny") sunnyCnt++;
                if (weather == "cloudy") cloudyCnt++;
                if (weather == "snow") snowCnt++;
                if (weather == "rainy") rainyCnt++;
            }

            Console.WriteLine("SUNNY : {0} / CLOUDY : {1} / SNOW : {2} / RAINY : {3}", sunnyCnt, cloudyCnt, snowCnt, rainyCnt);
        }
    }
}
