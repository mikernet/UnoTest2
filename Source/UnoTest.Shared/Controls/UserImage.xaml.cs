using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

namespace UnoTest.Controls
{
    public sealed partial class UserImage : UserControl
    {
        private double _size;
        private string _initials;
        private char? _imageId;
        private BitmapImage _imageSource;

        public double Size {
            get => _size;
            set {
                _size = Width = Height = value;
                Root.CornerRadius = new CornerRadius(value / 2);
            }
        }

        public string Initials {
            get => _initials;
            set {
                _initials = value;
                Bindings.Update();
            }
        }

        public char? ImageId {
            get => _imageId;
            set {
                _imageId = value;

                if (value != null) {
                    _imageSource = new BitmapImage(new Uri("https://static.iratio.ca/test/" + value + ".png"));
                }
                else {
                    _imageSource = null;
                }

                Bindings.Update();
            }
        }

        public BitmapImage ImageSource => _imageSource;

        public UserImage()
        {
            InitializeComponent();
        }
    }
}
