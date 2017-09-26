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

namespace ViewModelsXML.ViewModels
{
    public class MainRadioViewModel
    {
        public MainRadioViewModel()
        {
           
            LoadXML();

            _currentStation = StationList.FirstOrDefault();

        }

        private void LoadXML()
        {
            string path = @"D:\Visual Studio Projects\Projects\RetroWebRadio\ViewModelsXML\XML\RadioStations.xml";
            XDocument doc = XDocument.Load(path);

            List<RadioStation> list = new List<RadioStation>();
              
            list = (from s in doc.Descendants("station")
                                       select new RadioStation()
                                       {
                                           Id = (int)s.Element("id"),
                                           Name = (string)s.Element("name"),
                                           Genre = (string)s.Element("genre"),
                                           Country = (string)s.Element("country"),
                                           Url = (string)s.Element("url")

                                       }).ToList();

            StationList = new ObservableCollection<RadioStation>(list);
        }

        private ObservableCollection<RadioStation> _stationList;

        public ObservableCollection<RadioStation> StationList
        {
            get { return _stationList; }
            set { _stationList = value; }
        }

        private RadioStation _currentStation;
                    
        public RadioStation    CurrentStation
        {
            get { return _currentStation; }
            set { _currentStation = value; }
        }



    }
}
