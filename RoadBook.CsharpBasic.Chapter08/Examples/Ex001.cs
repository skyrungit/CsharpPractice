using System;
using System.IO;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    public class Ex001
    {
        private readonly string currentDirectory = Environment.CurrentDirectory;
        public void Run()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(currentDirectory + @"\data");
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
                Console.WriteLine("Directory is created.");
            }
            Console.WriteLine("Directory: {0}", directoryInfo.FullName);
        }
    }
}
