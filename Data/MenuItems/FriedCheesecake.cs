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
    /// The class for the menu item fried cheesecake
    /// </summary>
    public class FriedCheesecake : Popper, IMenuItem, IPopper
    {
        /// <summary>
        /// Override of base to string method
        /// </summary>
        /// <returns>the name of the object</returns>
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// The name of the fried cheesecake
        /// </summary>
        public string Name
        {
            get
            {
                return $"{Size} Fried Cheesecake";
            }
        }

        /// <summary>
        /// returns the price of the fried cheesecake
        /// </summary>
        public decimal Price
        {
            get
            {
                if (Size == ServingSize.Small) return 3.75m;
                if (Size == ServingSize.Medium) return 4.50m;
                if (Size == ServingSize.Large) return 5.25m;
                return 0;
                
            }
        }

        /// <summary>
        /// returns the amount of calories of the fried cheesecake
        /// </summary>
        public uint Calories
        {
            get
            {
                uint cal = 0;
                if (Size == ServingSize.Small) cal += 310;
                if (Size == ServingSize.Medium) cal += 425;
                if (Size == ServingSize.Large) cal += 620;
                if (Glazed) cal += 130;
                return cal;

            }
        }
    }
}
