using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using ViewModelsXML.ViewModels;

namespace XMLtest
{
    class Program
    {
        static void Main(string[] args)
        {

            MainRadioViewModel m = new MainRadioViewModel();
            //foreach (var item in MainRadioViewModel.StationList)
            //{
            //    Console.WriteLine(item.Id);
            //}

            var query = MainRadioViewModel.StationList.OrderByDescending(t => t.Id).Select(t => t.Id).Take(1);

                       

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}
