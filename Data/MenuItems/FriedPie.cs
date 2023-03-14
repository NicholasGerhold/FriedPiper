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
    /// Class for the Fried Pie menu item
    /// </summary>
    public class FriedPie : IMenuItem, INotifyPropertyChanged, ITreat
    {

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Override of base to string method
        /// </summary>
        /// <returns>the name of the object</returns>
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// private backing of Flavor property
        /// </summary>
        private PieFilling _flavor;
        /// <summary>
        /// Name of the fried pie with filling
        /// </summary>
        public string Name
        {
            get
            {
                return $"Fried {Flavor} Pie";
            }

        }

        /// <summary>
        /// The Filling for the pie
        /// </summary>
        public PieFilling Flavor 
        { 
            get { return _flavor; }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                _flavor = value;
            }
        }

        /// <summary>
        /// The price of a pie
        /// </summary>
        public decimal Price { get; } = 3.50m;

        /// <summary>
        /// The amount of calories of a pie
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Flavor == PieFilling.Cherry) return 287;
                if (Flavor == PieFilling.Peach) return 304;
                if (Flavor == PieFilling.Apricot) return 314;
                if (Flavor == PieFilling.Pineapple) return 302;
                if (Flavor == PieFilling.Blueberry) return 314;
                if (Flavor == PieFilling.Apple) return 289;
                if (Flavor == PieFilling.Pecan) return 314;
                return 0;



            }
        }
    }
}
