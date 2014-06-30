﻿using System.Linq;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
using Windows.UI.Xaml.Input;
using VLC_WINRT_APP.Helpers;
using VLC_WINRT_APP;
using VLC_WINRT_APP.ViewModels;
using VLC_WINRT_APP.ViewModels.Settings;
using WinRTXamlToolkit.Controls.Extensions;

namespace VLC_WINRT.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            this.InitializeComponent();
        }

        private void OpenSearchPane(object sender, RoutedEventArgs e)
        {
        }

        private void MovieListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!e.AddedItems.Any()) return;

        }

        private void MusicListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!e.AddedItems.Any()) return;
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}
