using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace UnoTest.Roots
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginRoot : Page
    {
        public LoginRoot()
        {
            InitializeComponent();
            Loaded += OnLoaded;
        }

        private async void OnLoaded(object sender, RoutedEventArgs e)
        {
            App.RootFrame.IsEnabled = false;
            await Task.Delay(2000);
            App.RootFrame.IsEnabled = true;
        }

        private async void OnLoginClick(object sender, RoutedEventArgs e)
        {
            App.RootFrame.IsEnabled = false;
            await Task.Delay(2000);
            App.RootFrame.IsEnabled = true;

            Frame.Navigate(typeof(MainRoot));
        }
    }
}
