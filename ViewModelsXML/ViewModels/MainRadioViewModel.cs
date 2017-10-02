using GalaSoft.MvvmLight.CommandWpf;
using Microsoft.Win32;
using Models.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using ViewModelsXML.ViewModels.Helpers;

namespace ViewModelsXML.ViewModels
{
    public partial class MainRadioViewModel : BaseViewModel
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

            List<RadioStation> list = (from station in doc.Descendants("station")
                                       select new RadioStation()
                                       {
                                         //  Id = (int)station.Element("id"),
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
        }

        private  static ObservableCollection<RadioStation> _stationList;

        public  static ObservableCollection<RadioStation> StationList
        {
            get { return _stationList; }
            set {
                _stationList = value;
               // OnPropertyChanged();
            }
        }

        private RadioStation _currentStation;
                    
        public RadioStation    CurrentStation
        {
            get { return _currentStation; }
            set {

                _currentStation = value;
                OnPropertyChanged();

            }
        }

    }
}
