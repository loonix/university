using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfRotaryControlDemo.ViewModel
{
    public class MainViewModel : System.ComponentModel.INotifyPropertyChanged
    {

        private int _temperature = 20;
        public int Temperature
        {
            get
            {
                return _temperature;
            }
            set
            {
                _temperature = value;
                NotifyPropertyChanged("Temperature");
            }
        }

        private double _volume = 1;
        public double Volume
        {
            get
            {
                return _volume;
            }
            set
            {
                _volume = value;
                NotifyPropertyChanged("Volume");
            }
        }

        private int _output = 20;
        public int Output
        {
            get
            {
                return _output;
            }
            set
            {
                _output = value;
                NotifyPropertyChanged("Output");
            }
        }

        #region INotifyPropertyChanged

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion INotifyPropertyChanged
    }
}
