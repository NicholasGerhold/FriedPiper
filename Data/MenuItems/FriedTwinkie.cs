using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FriedPiper.Data.MenuItems
{
    /// <summary>
    /// The class representing the fried twinky menu item
    /// </summary>
    public class FriedTwinkie : IMenuItem, INotifyPropertyChanged, ITreat
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
        /// The name of the fried twinky menu item
        /// </summary>
        public string Name { get; } = "Fried Twinky";

        /// <summary>
        /// The price of a fried twinky
        /// </summary>
        public decimal Price { get; } = 2.25m;

        /// <summary>
        /// The amount of calories of a fried twinky
        /// </summary>
        public uint Calories
        {
            get { return 420; }
        }
    }
}
