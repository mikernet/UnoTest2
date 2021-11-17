using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml;

namespace UnoTest.Converters
{
    public static class Convert
    {
        public static bool NullToTrue(object value) => value == null;

        public static bool NullToFalse(object value) => value != null;

        public static Visibility TrueToVisible(bool? value) => value == true ? Visibility.Visible : Visibility.Collapsed;

        public static Visibility FalseToVisible(bool value) => !value ? Visibility.Visible : Visibility.Collapsed;

        public static Visibility NullToVisible(object value) => value == null ? Visibility.Visible : Visibility.Collapsed;

        public static Visibility NullToCollapsed(object value) => value == null ? Visibility.Collapsed : Visibility.Visible;

        public static Visibility NullOrWhiteSpaceToCollapsed(string value) => string.IsNullOrWhiteSpace(value) ? Visibility.Collapsed : Visibility.Visible;

        public static Visibility ZeroToVisible(int value) => value == 0 ? Visibility.Visible : Visibility.Collapsed;

        public static Visibility ZeroToCollapsed(int value) => value == 0 ? Visibility.Collapsed : Visibility.Visible;

        public static Visibility FocusedToVisible(FocusState focusState) => focusState == FocusState.Unfocused ? Visibility.Collapsed : Visibility.Visible;

        public static double FocusedToOpaque(FocusState focusState) => focusState == FocusState.Unfocused ? 0 : 1;

        public static Visibility EqualsToVisible(object left, object right) => left == right ? Visibility.Visible : Visibility.Collapsed;

        public static Uri StringToPhoneUri(string phoneNumber)
        {
            try
            {
                return new Uri("tel:" + phoneNumber);
            }
            catch
            {
                return null;
            }
        }

        public static Uri StringToEmailUri(string email)
        {
            try
            {
                return new Uri("mailto:" + email);
            }
            catch
            {
                return null;
            }
        }

        public static Uri StringToWebsiteUri(string website)
        {
            if (string.IsNullOrWhiteSpace(website))
                return null;

            website = website.ToLower();

            if (!website.StartsWith("http://", StringComparison.OrdinalIgnoreCase) && !website.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
                website = "https://" + website;

            try
            {
                return new Uri(website);
            }
            catch
            {
                return null;
            }
        }
    }
}
