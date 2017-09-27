using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace XMLtest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stationList = new List<string>();




            string path = @"D:\Visual Studio Projects\Projects\RetroWebRadio\ViewModelsXML\XML\RadioStations.xml";
            XDocument doc = XDocument.Load(path);

            List<RadioStation> list = (from s in doc.Descendants("station")
                        select new RadioStation()
                        {
                            Id = (int)s.Element("id"),
                            Name = (string)s.Element("name"),
                            Category = (string)s.Element("category"),
                            Country = (string)s.Element("country"),
                            Url = (string)s.Element("url")          

                        }).ToList();

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.Url);
            //    Console.WriteLine(item.Country);
            //}

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
