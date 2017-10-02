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

            var query = MainRadioViewModel.StationList.GroupBy(x => x.Name.ToUpper()).Select(y => y.First()).ToList();
            ObservableCollection<RadioStation> List = new ObservableCollection<RadioStation>(query);

            foreach (var item in List)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Url);
                Console.WriteLine("***");
            }
        }
    }
}
