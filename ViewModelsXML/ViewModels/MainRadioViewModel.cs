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
using ViewModelsXML.Tools;
using ViewModelsXML.ViewModels.Helpers;

namespace ViewModelsXML.ViewModels
{
    public class MainRadioViewModel : BaseViewModel
    {
        public MainRadioViewModel()
        {
            ValidateXML xmlValidation = new ValidateXML();

            LoadXML(xmlValidation);
            _currentStation = StationList.FirstOrDefault();
       
            dirPath = @"..\..\..\ViewModelsXML\XML\ToBeProcessed";
            _fileList = new ObservableCollection<string>();
            GetFileListInDirectory(dirPath);
            _droppedItems = new ObservableCollection<string>();

            InitCommands();

            //load other view models

            dvm = new DashboardViewModel(this);
            pxmlvm = new ProcessXMLViewModel(this);
            rlvm = new RadioListsViewModel(this);

        }

        public RadioListsViewModel rlvm { get; set; }

        public DashboardViewModel dvm { get; set; }

        public ProcessXMLViewModel pxmlvm { get; set; }

        

        public ValidateXML xmlValidation { get; set; }

        private void InitCommands()
        {
            Import = new RelayCommand(AddDropped);
            Browse = new RelayCommand(BrowseForXML);
            Save = new RelayCommand(SaveListToXML);
            ToBeProcessed = new RelayCommand(ProcessFolderToXML);
            CleanList = new RelayCommand(CleanMainList);
            Remove = new RelayCommand(RemoveStation);
        }

       

        public RelayCommand Import { get; set; }

        public RelayCommand Remove { get; set; }
        public RelayCommand Browse { get; set; }
        public RelayCommand Save { get; set; }
        public RelayCommand ToBeProcessed { get; set; }
        public RelayCommand CleanList { get; set; }

        private void RemoveStation()
        {
            StationList.Remove(CurrentStation);
        }

        public void DoFileDrop(IEnumerable<String> filePaths)
        {

            foreach (var item in filePaths)
            {
                if (Path.GetExtension(item).ToUpper() == ".XML")
                {
                    DroppedItems.Add(item);
                }

                else
                {
                    MessageBox.Show(item + " is not an XML file");
                }
            }

        }


        private ObservableCollection<string> _droppedItems;

        public ObservableCollection<string> DroppedItems
        {
            get { return _droppedItems; }
            set
            {
                _droppedItems = value;

                OnPropertyChanged();
            }
        }

        private ObservableCollection<RadioStation> _stationList;

        public ObservableCollection<RadioStation> StationList
        {
            get { return _stationList; }
            set
            {
                _stationList = value;
                OnPropertyChanged();
            }
        }

        private RadioStation _currentStation;

        public RadioStation CurrentStation
        {
            get { return _currentStation; }
            set
            {

                _currentStation = value;
                OnPropertyChanged();

            }
        }

       
        public ObservableCollection<RadioStation> RadioList { get; set; }

        public string dirPath { get; set; }


        private void LoadXML(ValidateXML xmlValidation)
        {

            //Relative Path
            string path = "../../../ViewModelsXML/XML/Main/RadioStations.xml";



            xmlValidation.validate(path, false);

            XDocument doc = XDocument.Load(path);

            CreateCollectionFromXML(doc);

        }

        private void CreateCollectionFromXML(XDocument doc)
        {
            List<RadioStation> list = (from station in doc.Descendants("station")
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
        }

        private void ProcessFolderToXML()
        {
 
            if (Directory.Exists(dirPath))
            {
                ProcessFilesInDirectory(dirPath);
            }
            else
            {
                MessageBox.Show("No XML Files in this Directory: " + dirPath);
            }
        }

        private ObservableCollection<string> GetFileListInDirectory(string dirPath)
        {
            string[] fileEntries = Directory.GetFiles(dirPath, "*.xml");
            string fileName;

            foreach (var item in fileEntries)
            {
                fileName = Path.GetFileName(item);
                _fileList.Add(fileName);
            }

            return _fileList;
        }

        private ObservableCollection<string> _fileList;

        public ObservableCollection<string> FileList
        {
            get { return _fileList; }
            set
            {
                _fileList = value;

                OnPropertyChanged();

            }
        }

        private void AddDropped()
        {

            string xmlString;
            foreach (var item in _droppedItems)
            {
                //Process file
                xmlString = File.ReadAllText(item);
                XMLtolist(xmlString);
            }

            DroppedItems.Clear();
        }

        private void ProcessFilesInDirectory(string directoryPath)
        {
            string[] fileEntries = Directory.GetFiles(directoryPath, "*.xml");

            string fileName;
            string s = "";
            int i = 1;

            foreach (var item in fileEntries)
            {
                fileName = Path.GetFileName(item);
                s += i.ToString() + ") " + fileName + '\n';
                i++;
            }

            MessageBox.Show("The following " + fileEntries.Count() + " files will be processed :" + '\n' + s);


            string xmlString;
            string destinationFile;
            string destinationDir = @"..\..\..\ViewModelsXML\XML\Processed";
            foreach (var item in fileEntries)
            {
                //check if xml is valid
                xmlValidation.validate(item, true);

                //convert file to string
                xmlString = File.ReadAllText(item);

                //Process to List and update
                XMLtolist(xmlString);

                //Move file to Processed Folder
                //GetsFileName
                fileName = Path.GetFileName(item);
                //Rename File and append TimeStamp 
                fileName = TimeStamp.AppendTimeStamp(fileName);
                // Move File to Processed Folder 
                destinationFile = destinationDir + @"\" + fileName;
                File.Move(item, destinationFile);

                //Clear String (optional)
                xmlString = "";

                //Update FileList
                _fileList.Remove(fileName);

            }

        }

        private void BrowseForXML()
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "Xml files (*.xml)|*.xml|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                string fileText = File.ReadAllText(openFileDialog.FileName);
                MessageBox.Show("xml data copied");
                XMLtolist(fileText);
            }
            else
            {
                MessageBox.Show("no file was opened");
            }
        }


        private void XMLtolist(string xmlFileText)
        {
            XDocument doc = new XDocument();

            try
            {
                doc = XDocument.Parse(xmlFileText);
            }
            catch (XmlException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            

            List<RadioStation> newlist = (from station in doc.Descendants("station")
                                          select new RadioStation()
                                          {
                                              //  Id = (int)station.Element("id"),
                                              Name = (string)station.Element("name"),
                                              Category = (string)station.Element("category"),
                                              Country = (string)station.Element("country"),
                                              Url = (string)station.Element("url")

                                          }).ToList();
            RadioList = new ObservableCollection<RadioStation>(newlist);

            //find existing top Id in Main List

            //var topId = MainRadioViewModel.StationList.Max(t => t.Id);
            var topId = StationList.Max(t => t.Id);

            //This will update the list that displays the stations on the main window
            foreach (var item in RadioList)
            {
                item.Id = topId + 1;
                StationList.Add(item);
                topId++;
            }


        }
        private void CreateXmlFromList(ObservableCollection<RadioStation> MainRadiolist)
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

            Xmldoc.Save(@"..\..\..\ViewModelsXML\XML\Main\RadioStations.xml");
        }

        private void SaveListToXML()
        {
            CleanMainList();
            CreateXmlFromList(StationList);
            MessageBox.Show("XML File created and saved");
        }

        private void CleanMainList()
        {
            var query = StationList.GroupBy(x => x.Url.ToUpper()).Select(y => y.Last()).ToList();

            StationList = new ObservableCollection<RadioStation>(query);

            MessageBox.Show("Main List cleaned");

        }


    }
}
