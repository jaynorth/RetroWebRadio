﻿using RetroWebRadio.View.UserControls;
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
using Models.Model;
using WinformsVisualization;
using System.Windows.Forms.Integration;

namespace RetroWebRadio.View
{
    /// <summary>
    /// Logique d'interaction pour CopyMainWindow.xaml
    /// </summary>
    public partial class CopyMainWindow : Window
    {
        private double aspectRatio = 0.0;
        public CopyMainWindow()
        {
            MainRadioViewModel MRVM = new MainRadioViewModel();
            DataContext = MRVM;
            InitializeComponent();
            Style = (Style)FindResource(typeof(Window));

            Loaded += Window_loaded;

            this.FontFamily = new FontFamily("Segoe UI Semibold");
            this.FontSize = 11;
            this.Foreground = Brushes.White;

            RadioListsUC.StationSelectedEvent += ChangePlayerSource;
        }

        private void ChangePlayerSource(RadioStation CurrentStation)
        {

            dashboardUserControl.Player.IsMuted = true;
            System.Threading.Thread.Sleep(600);



            if (CurrentStation!=null)
            {
                System.Uri uri = new System.Uri(CurrentStation.Url);
                dashboardUserControl.Player.Source = uri;
                dashboardUserControl.Player.IsMuted = false;
            }        
                    
               
       

                
 
            

            

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

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            // Shutdown the application.
            dashboardUserControl.Player.IsMuted = true;
            dashboardUserControl.Player.Stop();
            //kill processes
            Environment.Exit(0);

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            App.Current.Shutdown();
          
        }
    }
}
