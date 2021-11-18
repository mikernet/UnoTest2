using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
#if __ANDROID__
using Android.Views.InputMethods;
#endif

namespace UnoTest.Behaviors
{
    public static class Actions
    {
        public static readonly DependencyProperty EnterProperty = DependencyProperty.RegisterAttached(
            "Enter", typeof(EnterAction), typeof(Actions), new PropertyMetadata(EnterAction.None, OnEnterChanged));

        public static void SetEnter(Control tb, EnterAction action)
        {
            tb.SetValue(EnterProperty, action);
        }

        public static EnterAction GetEnter(Control tb)
        {
            return (EnterAction)tb.GetValue(EnterProperty);
        }

        private static void OnEnterChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var action = (EnterAction)e.NewValue;

            if (d is TextBox tb) {
                tb.KeyUp -= OnTextBoxKeyUp;

                if (action == EnterAction.None)
                    return;

                tb.KeyUp += OnTextBoxKeyUp;

#if __ANDROID__
                tb.ImeOptions = action == EnterAction.Done ? ImeAction.Done : ImeAction.Next;
#elif __IOS__
                tb.ReturnKeyType = action == EnterAction.Done ? UIKit.UIReturnKeyType.Done : UIKit.UIReturnKeyType.Next;
#endif
            }
            else if (d is PasswordBox pb) {
                pb.KeyUp -= OnTextBoxKeyUp;

                if (action == EnterAction.None)
                    return;

                pb.KeyUp += OnTextBoxKeyUp;

#if __ANDROID__
                pb.ImeOptions = action == EnterAction.Done ? ImeAction.Done : ImeAction.Next;
#elif __IOS__
                pb.ReturnKeyType = action == EnterAction.Done ? UIKit.UIReturnKeyType.Done : UIKit.UIReturnKeyType.Next;
#endif
            }
            else {
                throw new ArgumentException("Invalid control type.", nameof(d));
            }
        }

        private static void OnTextBoxKeyUp(object sender, KeyRoutedEventArgs e)
        {
            var control = (Control)sender;

            if (e.Key == VirtualKey.Enter) {
                if (GetEnter(control) == EnterAction.Done || !FocusManager.TryMoveFocus(FocusNavigationDirection.Next)) {
                    var isTabStop = control.IsTabStop;
                    control.IsTabStop = false;
                    control.IsEnabled = false;
                    control.IsEnabled = true;
                    control.IsTabStop = isTabStop;
                }

                e.Handled = true;
            }
        }
    }
}
