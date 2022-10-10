using System;
using System.IO;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    public class Ex003
    {
        private readonly string currentDir = Environment.CurrentDirectory;
        public void Run()
        {
            FileInfo fileInfo = new FileInfo(currentDir + @"\data\log.txt");

            Console.WriteLine("Saved Dir: {0}", fileInfo.DirectoryName);
            Console.WriteLine("File Name: {0}", fileInfo.Name);

            Console.WriteLine("===File Contents===");
            using (StreamReader sr = new StreamReader(fileInfo.FullName))
            {
                string line = string.Empty;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
