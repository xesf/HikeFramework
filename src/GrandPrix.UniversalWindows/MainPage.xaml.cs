﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using GrandPrix.Game.WindowsUniversal;
using Hike.Framework.WindowsUniversal.Platform.UniversalWindows;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GrandPrix.UniversalWindows
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        GrandPrixGame _game;
        public MainPage()
        {
            this.InitializeComponent();

            var launchArguments = string.Empty;
            _game = HKGameUniversalWindows<GrandPrixGame>.Create(launchArguments, Window.Current.CoreWindow, swapChainPanel);
        }
    }
}
