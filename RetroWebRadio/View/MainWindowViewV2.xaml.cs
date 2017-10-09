using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ViewModelsXML.ViewModels;

namespace RetroWebRadio.View
{
    /// <summary>
    /// Logique d'interaction pour MainWindowView.xaml
    /// </summary>
    public partial class MainWindowViewV2 : Window
    {
        public MainWindowViewV2()
        {
            
            DataContext = new MainRadioViewModel();
            InitializeComponent();

        }
    }
}
