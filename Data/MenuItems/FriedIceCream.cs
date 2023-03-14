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
    /// class for the fried Ice cream menu item
    /// </summary>
    public class FriedIceCream : IMenuItem, INotifyPropertyChanged, ITreat
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
        /// private backing of the property flavor
        /// </summary>
        private IceCreamFlavor _flavor;
        /// <summary>
        /// Name of the fried ice cream
        /// </summary>
        public string Name
        {
            get
            {
                return $"Fried {Flavor} Ice Cream";
            }
        }
        
        /// <summary>
        /// The flavor of the fried ice cream
        /// </summary>
        public IceCreamFlavor Flavor 
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
        /// The price of the fried ice cream menu item
        /// </summary>
        public decimal Price { get; } = 3.50m;
           
        /// <summary>
        /// The amount of calories of the fried ice cream
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Flavor == IceCreamFlavor.Vanilla) return 355;
                if (Flavor == IceCreamFlavor.Chocolate) return 353;
                if (Flavor == IceCreamFlavor.Strawberry) return 321;
                return 0;
            }
        }

    }
}
