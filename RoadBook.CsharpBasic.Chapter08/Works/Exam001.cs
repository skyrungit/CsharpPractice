using System;
using System.IO;

namespace RoadBook.CsharpBasic.Chapter08.Works
{
    public class Exam001
    {
        private readonly string currentDIr = Environment.CurrentDirectory;
        public void Run()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(currentDIr);
            FileInfo[] files = dirInfo.GetFiles();

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = files[i];
                Console.WriteLine(file);
            }
        }
    }
}
