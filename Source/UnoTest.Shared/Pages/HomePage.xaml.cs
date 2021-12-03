using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UnoTest.Dialogs;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace UnoTest.Pages
{
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void OnBusinessClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(BusinessPage));
        }

        private void OnModelAfterNavigateClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ModelAfterNavigatePage), 12345);
        }

        private void OnDpModelAfterNavigateClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(DpModelAfterNavigate), 12345);
        }

        private async void OnTestDialogClick(object sender, RoutedEventArgs e)
        {
            await new TestDialog().ShowAsync();
        }

        private async void OnBusinessDialog1Click(object sender, RoutedEventArgs e)
        {
            await new BusinessDialog1().ShowAsync();
        }

        private async void OnBusinessDialog2Click(object sender, RoutedEventArgs e)
        {
            await new BusinessDialog2().ShowAsync();
        }
    }
}
