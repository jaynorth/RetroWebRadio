using Models.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using ViewModelsXML.ViewModels;
using System.IO;

namespace XMLtest
{
    class Program
    {
        static void Main(string[] args)
        {

            //Directory

            string dirPath = @"D:\Visual Studio Projects\Projects\RetroWebRadio\ViewModelsXML\XML\ToBeProcessed";

            if (Directory.Exists(dirPath))
            {
                ProcessFilesInDirectory(dirPath);
            }
        }

        private static void ProcessFilesInDirectory(string directoryPath)
        {
            string[] fileEntries = Directory.GetFiles(directoryPath, "*.xml");
            foreach (var item in fileEntries) 
            {
                Console.WriteLine(item);
            }
        }
    }
}
