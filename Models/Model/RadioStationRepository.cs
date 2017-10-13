using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace Models.Model
{



   public class RadioStationRepository
    {
        public RadioStationRepository()
        {
            
            list = new List<RadioStation>();
            StationList = new ObservableCollection<RadioStation>();
        }

        public ObservableCollection<RadioStation> StationList { get; set; }
        public List<RadioStation> list { get; set; }
        public ObservableCollection<RadioStation> GetStations(XDocument doc)
        {
           var list = (from station in doc.Descendants("station")
                                       select new RadioStation()
                                       {
                                           Id = (int)station.Attribute("id"),
                                           Name = (string)station.Element("name"),
                                           Category = (string)station.Element("category"),
                                           Country = (string)station.Element("country"),
                                           Url = (string)station.Element("url")

                                       }).ToList();
            int Id = 10;

            foreach (var item in list)
            {
                item.Id = Id;
                Id++;
            }

            StationList = new ObservableCollection<RadioStation>(list);

            return StationList;
            
        }

        public void AddStations(XDocument doc, ObservableCollection<RadioStation> StationList)
        {
            List<RadioStation> newlist = (from station in doc.Descendants("station")
                                          select new RadioStation()
                                          {
                                              //  Id = (int)station.Element("id"),
                                              Name = (string)station.Element("name"),
                                              Category = (string)station.Element("category"),
                                              Country = (string)station.Element("country"),
                                              Url = (string)station.Element("url")

                                          }).ToList();

            //find existing top Id in Main List

            //var topId = MainRadioViewModel.StationList.Max(t => t.Id);
            var topId = StationList.Max(t => t.Id);

            //This will update the list that displays the stations on the main window
            foreach (var item in newlist)
            {
                item.Id = topId + 1;
                StationList.Add(item);
                topId++;
            }
        }

        public void RemoveStation(RadioStation CurrentStation,  ObservableCollection<RadioStation> StationList)
        {

            StationList.Remove(CurrentStation);
        }

        public XDocument CreateNewXML(ObservableCollection<RadioStation> MainRadiolist)
        {
   

            XDocument Xmldoc = new XDocument(

                new XDeclaration("1.0", "utf-8", "yes"),

                new XComment("Main List of Radio Stations XML"),

                new XElement("stations",

                    from station in MainRadiolist
                    select new XElement("station", new XAttribute("id", station.Id),
                            new XElement("url", station.Url),
                            new XElement("name", station.Name),
                            new XElement("category", station.Category),
                          
                            new XElement("country", station.Country))

                ));

            return Xmldoc;
          
      
        }

        public ObservableCollection<RadioStation> CleanMainList(ObservableCollection<RadioStation> StationList)
        {
            var query = StationList.GroupBy(x => x.Url.ToUpper()).Select(y => y.Last()).ToList();

            StationList = new ObservableCollection<RadioStation>(query);

            MessageBox.Show("Main List cleaned");

            return StationList;

        }

        public void SaveXML(XDocument doc)
        {
            doc.Save(@"..\..\..\ViewModelsXML\XML\Main\RadioStations.xml");
        }
    }


   

}
