using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriedPiper.Data.Enums;
using System.ComponentModel;

namespace FriedPiper.Data.MenuItems
{
    /// <summary>
    /// This is a base class for inheritance for the popper menu item type
    /// </summary>
    public abstract class Popper :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// A method to use the INotify Property Changed class in an inherited class
        /// </summary>
        /// <param name="propertyName">the property to invoke property changed with</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        /// <summary>
        /// private backing of glazed property
        /// </summary>
        private bool _glazed = true;

        /// <summary>
        /// private backing of Size property
        /// </summary>
        private ServingSize _size;

        /// <summary>
        /// Whether the poppers are glazed or not
        /// </summary>
        public bool Glazed
        {
            get { return _glazed; }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Glazed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                _glazed = value;
            }
        }

        /// <summary>
        /// The Serving size of the popper
        /// </summary>
        public ServingSize Size
        {
            get { return _size; }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                _size = value;
            }
        }

    }
}
