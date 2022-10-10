using System;
using System.IO;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    public class Ex002
    {
        private readonly string currentDir = Environment.CurrentDirectory;
        public void Run()
        {
            using (StreamWriter sw = new StreamWriter(currentDir + @"\data\log.txt", true))
            {
                sw.WriteLine("Running Time: {0}", DateTime.Now);
            }
        }
    }
}
