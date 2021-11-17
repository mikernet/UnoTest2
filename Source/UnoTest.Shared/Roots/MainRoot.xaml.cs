using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UnoTest.Pages;
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
    public sealed partial class MainRoot : Page
    {
        public MainRoot()
        {
            InitializeComponent();
            Loaded += OnLoaded;
            //SubFrame.Navigated += OnSubFrameNavigated;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            SubFrame.Navigate(typeof(HomePage));
        }

        private void OnBackClick(object sender, RoutedEventArgs e)
        {
            SubFrame.GoBack();
        }

        private void OnHomeClick(object sender, RoutedEventArgs e)
        {
            SubFrame.Navigate(typeof(HomePage));
        }

        //private void OnSubFrameNavigated(object sender, NavigationEventArgs e)
        //{
        //    var lastStackItem = SubFrame.BackStack.LastOrDefault();

        //    if (lastStackItem != null && lastStackItem.SourcePageType == e.SourcePageType && Equals(lastStackItem.Parameter, e.Parameter))
        //        SubFrame.BackStack.Remove(lastStackItem);
        //}
    }
}
