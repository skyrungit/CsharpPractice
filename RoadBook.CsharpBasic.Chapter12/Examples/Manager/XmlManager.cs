using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Xml.Linq;

namespace RoadBook.CsharpBasic.Chapter12.Examples.Manager
{
    public class XmlManager
    {
        public enum USE_TYPE { WRITE, READ }; //이거 뭐냐
        private XDocument _xDoc; // 이것도 뭐냐

        private static char directorySeparator = System.IO.Path.DirectorySeparatorChar;
        private static string crawlDirectoryPath = Environment.CurrentDirectory + directorySeparator + "crawled";

        public XmlManager(USE_TYPE useType)
        {
            switch (useType)
            {
                case USE_TYPE.WRITE:
                    if (System.IO.Directory.Exists(crawlDirectoryPath))
                    {
                        System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(crawlDirectoryPath);

                        foreach (var file in di.GetFiles())
                        {
                            file.MoveTo(crawlDirectoryPath + directorySeparator + "backup" + directorySeparator + file.Name);
                        }
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(crawlDirectoryPath);
                        System.IO.Directory.CreateDirectory(crawlDirectoryPath + directorySeparator + "backup");
                    }

                    _xDoc = new XDocument(new XDeclaration("1.0", "utf-8", null), new XElement("result")); //이거 무엇?
                    break;

                case USE_TYPE.READ:
                    if (System.IO.Directory.Exists(crawlDirectoryPath))
                    {
                        System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(crawlDirectoryPath);
                        System.IO.FileInfo[] fi = di.GetFiles();

                        if (fi.Length > 0)
                        {
                            _xDoc = XDocument.Load(fi[0].FullName); //이거 무엇?
                        }
                    }
                    break;

                default:
                    break;
            }
        }

        public void Write(Model.Contents contents) // 이거 뭔지 볼 것
        {
            _xDoc.Element("result").Add(
                new XElement("row",
                    new XElement("idx", contents.Idx),
                    new XElement("title", new XCData(contents.Title)),
                    new XElement("summary", new XCData(contents.Summary)),
                    new XElement("create_date", contents.CreateDt),
                    new XElement("create_user", new XCData(contents.createUserNm)),
                    new XElement("tags", new XCData(contents.Tags))
                ));
        }

        public List<Model.Contents> Read() //이거 뭔지 볼것
        {
            return _xDoc.Descendants("row").Select(s => new Model.Contents()
            {
                Idx = Convert.ToInt32(s.Element("idx").Value),
                Title = s.Element("title").Value,
                Summary = s.Element("summary").Value,
                CreateDt = Convert.ToDateTime(s.Element("create_date").Value),
                createUserNm = s.Element("create_user").Value,
                Tags = s.Element("tags").Value
            }).ToList();
        }

        public void Save()
        {
            string filename = DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".xml";
            _xDoc.Save(crawlDirectoryPath + directorySeparator + filename);
        }

    }
}
