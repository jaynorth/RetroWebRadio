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
        private double aspectRatio = 0.0;
        public MainWindowViewV2()
        {
            MainRadioViewModel MRVM = new MainRadioViewModel();
            DataContext = MRVM;
            InitializeComponent();
            Style = (Style)FindResource(typeof(Window));

            Loaded += Window_loaded;

            this.FontFamily = new FontFamily("Segoe UI Semibold");
            this.FontSize = 11;
            this.Foreground = Brushes.White;

        }

        private void Window_loaded(object sender, RoutedEventArgs e)
        {
            aspectRatio = this.ActualWidth / this.ActualHeight;
        }

        protected override void OnRenderSizeChanged(SizeChangedInfo sizeInfo)
        {
            if (aspectRatio > 0)
                // enforce aspect ratio by restricting height to stay in sync with width.  
                this.Height = this.ActualWidth * (1 / aspectRatio);
           
        }
    }
}
