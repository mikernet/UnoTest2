using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using UnoTest.Dialogs;
using UnoTest.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace UnoTest.Pages
{
    public sealed partial class BusinessPage : Page
    {
        public Business Model { get; set; }

        public List<string> ComboBoxItems { get; } = new List<string>
        {
            "Item 1",
            "Item 2",
            "Item 3",
            "Item 4",
        };

        public BusinessPage()
        {
            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            App.RootFrame.IsEnabled = false;
            await Task.Delay(2000);

            Model = Business.GetTestBusiness();
            Bindings.Update();
            App.RootFrame.IsEnabled = true;
        }

        private async void OnEmployeeProfileClick(object sender, RoutedEventArgs e)
        {
            var employee = (Employee)((FrameworkElement)sender).Tag;
            await new MessageDialog($"Employee {employee.Name} clicked.").ShowAsync();
        }

        private async void OnTestDialogClick(object sender, RoutedEventArgs e)
        {
            await new TestDialog().ShowAsync();
        }

        private IList<Employee> FilterEmployees(IList<Employee> employees, string filter)
        {
            if (string.IsNullOrWhiteSpace(filter))
                return employees;

            string[] filterParts = filter.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return employees.Where(e => MatchesFilter(e.Name, filterParts)).ToList();
        }

        private static bool MatchesFilter(string value, string[] filterParts)
        {
            foreach (string filterPart in filterParts)
            {
                if (!value.Split(' ', StringSplitOptions.RemoveEmptyEntries).Any(v => v.StartsWith(filterPart, StringComparison.OrdinalIgnoreCase)))
                    return false;
            }

            return true;
        }
    }
}
