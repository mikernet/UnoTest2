using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UnoTest.Models;
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
    public sealed partial class DpModelAfterNavigate : Page
    {
        public static readonly DependencyProperty ModelProperty = DependencyProperty.Register(
             nameof(Model), typeof(AfterNavigateModel), typeof(DpModelAfterNavigate), new PropertyMetadata(null));

        public AfterNavigateModel Model
        {
            get => (AfterNavigateModel)GetValue(ModelProperty);
            private set => SetValue(ModelProperty, value);
        }

        public DpModelAfterNavigate()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Model = new AfterNavigateModel { Data = (int)e.Parameter };
        }
    }
}
