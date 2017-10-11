using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Schema;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSchemaSet schema = new XmlSchemaSet();
            string xsdPath = @"D:\Visual Studio Projects\Projects\RetroWebRadio\ViewModelsXML\XML\Main\RadioStations.xsd";
            schema.Add("", xsdPath);

            string xmlPath = @"D:\Visual Studio Projects\Projects\RetroWebRadio\ViewModelsXML\XML\Main\RadioStations.xml";

            XDocument doc = XDocument.Load(xmlPath);

            bool ValidationErrors = false;

            doc.Validate(schema, (s, e) =>
            {
                Console.WriteLine(e.Message);
                ValidationErrors = true;
            });

            if (ValidationErrors)
            {
                Console.WriteLine("validation failed");
            }
            else
            {
                Console.WriteLine("validation Succeeded");
            }
           
        }
    }
}
