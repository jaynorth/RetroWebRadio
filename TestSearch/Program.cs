using Models.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ViewModelsXML.ViewModels.Helpers;

namespace TestSearch
{
    public class Program: BaseViewModel
    {
        public static void LoadListView(IEnumerable<RadioStation> StationList, string searchString = "")
        {
            IEnumerable<RadioStation> query;
            if (!(searchString.Length > 1))
            {
                query = StationList;
            }
            else
            {
                query =
                (from station in StationList
                 where station.Name.ToUpper().Contains(searchString.ToUpper())

                || station.Country.ToUpper().Contains(searchString.ToUpper())
                || station.Category.ToUpper().Contains(searchString.ToUpper())

                 orderby station.Name
                 select station);
            }

            foreach (var filteredCompany in query)
            {
                Console.WriteLine("****");
                Console.Write(filteredCompany.Name + " ");
                Console.Write(filteredCompany.Country + " ");
                Console.Write(filteredCompany.Category);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            string MainXmlFilePath = "../../../ViewModelsXML/XML/Main/RadioStations.xml";

            XDocument doc = XDocument.Load(MainXmlFilePath);

            RadioStationRepository rsRep = new RadioStationRepository();

            ObservableCollection<RadioStation> StationList = new ObservableCollection<RadioStation>();

            StationList = rsRep.GetStations(doc);

            //foreach (var item in StationList)
            //{
            //    Console.WriteLine(item.Name);
                
            //}

            string searchString = "deP";

            LoadListView(StationList, searchString);
        }

        
    }
}
