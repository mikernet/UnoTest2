using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace UnoTest.Models
{
    public class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected bool SetProperty<T>(ref T valueHolder, T value, PropertyChangedEventArgs e)
        {
            if (!EqualityComparer<T>.Default.Equals(valueHolder, value))
            {
                valueHolder = value;
                OnPropertyChanged(e);
                return true;
            }

            return false;
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}
