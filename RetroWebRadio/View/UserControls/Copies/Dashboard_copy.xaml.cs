﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using ViewModelsXML.ViewModels;

namespace RetroWebRadio.View.UserControls
{
    /// <summary>
    /// Logique d'interaction pour Dashboard.xaml
    /// </summary>
    public partial class Dashboard : UserControl
    {

        
        bool pause = false;
        DispatcherTimer dt = new DispatcherTimer();
        public Dashboard()
        {
            InitializeComponent();

            

            

            dt.Tick += new EventHandler(dt_Tick);
            dt.Interval = new TimeSpan(0, 0, 1);
            //Buffering

            Player.BufferingStarted += Player_BufferingStarted;

            Player.BufferingEnded += Player_BufferingEnded;

            Player.MediaEnded += Player_MediaEnded;

            Player.MediaOpened += Player_MediaOpened;

            Player.MediaFailed += Player_MediaFailed;

            Loaded += Dashboard_Loaded;

            
            

        }

        private void Dashboard_Loaded(object sender, RoutedEventArgs e)
        {
            //test.Text = "ActualHeight : " + ActualHeight + " ActualWidth : " + ActualWidth + " " + " ratio : " + ActualHeight / ActualWidth;


        }

        private void Player_MediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            displayBox.Text = "MediaFailed";
        }

        private void Player_MediaOpened(object sender, RoutedEventArgs e)
        {
            displayBox.Text = "Playing ..";
        }

        private void Player_MediaEnded(object sender, RoutedEventArgs e)
        {
            displayBox.Text = "MediaEnded";
        }

        private void Player_BufferingEnded(object sender, RoutedEventArgs e)
        {
            string s = "buffer ended";
            //BufferProgress.Value = Player.BufferingProgress * 100;
            double v = Player.BufferingProgress * 100;
            displayBox.Text = s + " " + v.ToString();

            string b = (Player.BufferingProgress * 100).ToString();
            displayBox.Text = "Buffer Progress " + b + " %";
            dt.Stop();
            displayBox.Text = "Playing ..";

 
            // displayBox.Text += " " + Player.NaturalDuration;
        }

        private void dt_Tick(object sender, EventArgs e)
        {

            string b = (Player.BufferingProgress * 100).ToString();
            displayBox.Text = "Buffer Progress " + b + " %";

        }

        private void Player_BufferingStarted(object sender, RoutedEventArgs e)
        {
            dt.Start();
            string s = "buffer started";
            displayBox.Text = s;
        }

        private void playButton_Click(object sender, RoutedEventArgs e)
        {

            Player.Play();
            displayBox.Text = "Attempt to play Stream";
            //RadioOff.IsChecked = true;
        
            pause_button.IsEnabled = true;
            pause = false;

        }

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            Player.Stop();
            displayBox.Text = "Stopped";
            //RadioOff.IsChecked = false;

            pause_button.IsEnabled = false;
        }



        private void volumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double vol;
            double v = volumeSlider.Value;
            double decibel = Math.Log(10, v) * -0.01;
            //volumeDisplay.Text = decibel.ToString();
            if (v > 0 && Double.IsNaN(decibel))
            {
                decibel = 1d;
                vol = 1d;
            }

            else if (decibel < 0 || Double.IsNaN(decibel))
            {
                vol = 0;
            }
            else
            {
                vol = decibel;
            }
            //volumeDisplay.Text = vol.ToString();

            Player.Volume = vol;
        }

        //private void StackPanel_SizeChanged(object sender, SizeChangedEventArgs e)
        //{
        //    volumeSlider.Height = volumeStack.ActualHeight - 5;

        //}

        private void pause_button_Click(object sender, RoutedEventArgs e)
        {
            if (pause)
            {
                Player.Play();
                pause = false;
                displayBox.Text = "Playing from pause";
            }
            else
            {
                Player.Pause();
                pause = true;
                displayBox.Text = "Paused";

            }

        }


    }
}