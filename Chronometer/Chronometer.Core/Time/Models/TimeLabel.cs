using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Chronometer.Core.Time.Models
{
    public class TimeLabel : INotifyPropertyChanged
    {
        private int _seconds = 0;
        
        public event PropertyChangedEventHandler PropertyChanged;

        public int Seconds 
        {
            get
            {
                return _seconds;
            }
            set 
            {
                _seconds = value;
                NotifyPropertyChanged("Seconds");
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
