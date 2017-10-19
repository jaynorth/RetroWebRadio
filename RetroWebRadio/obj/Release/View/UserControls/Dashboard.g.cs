﻿#pragma checksum "..\..\..\..\View\UserControls\Dashboard.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FD6A3B1AB155A88577A14CF0CDCDE29F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RetroWebRadio.View.UserControls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace RetroWebRadio.View.UserControls {
    
    
    /// <summary>
    /// Dashboard
    /// </summary>
    public partial class Dashboard : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\..\View\UserControls\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal RetroWebRadio.View.UserControls.Dashboard closed;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\View\UserControls\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock displayBox;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\View\UserControls\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock StationInfoText;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\View\UserControls\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button play_button;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\View\UserControls\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pause_button;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\View\UserControls\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button stop_button;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\View\UserControls\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider volumeSlider;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\View\UserControls\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement Player;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/RetroWebRadio;component/view/usercontrols/dashboard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\UserControls\Dashboard.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.closed = ((RetroWebRadio.View.UserControls.Dashboard)(target));
            return;
            case 2:
            this.displayBox = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.StationInfoText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.play_button = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\..\View\UserControls\Dashboard.xaml"
            this.play_button.Click += new System.Windows.RoutedEventHandler(this.playButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.pause_button = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\..\View\UserControls\Dashboard.xaml"
            this.pause_button.Click += new System.Windows.RoutedEventHandler(this.pause_button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.stop_button = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\..\View\UserControls\Dashboard.xaml"
            this.stop_button.Click += new System.Windows.RoutedEventHandler(this.stopButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.volumeSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 64 "..\..\..\..\View\UserControls\Dashboard.xaml"
            this.volumeSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.volumeSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Player = ((System.Windows.Controls.MediaElement)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
