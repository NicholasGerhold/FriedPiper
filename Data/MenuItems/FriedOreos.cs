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
    /// The class representing the fried oreo menu item
    /// </summary>
    public class FriedOreos : Popper, IMenuItem, IPopper
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
        /// The name of the fried oreo menu item
        /// </summary>
        public string Name
        {
            get
            {
                return $"{Size} Fried Oreos";
            }
        }


        /// <summary>
        /// returns the price of the fried oreos
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
        /// returns the amount of calories of the fried oreos
        /// </summary>
        public uint Calories
        {
            get
            {
                uint cal = 0;
                if (Size == ServingSize.Small) cal += 500;
                if (Size == ServingSize.Medium) cal += 750;
                if (Size == ServingSize.Large) cal += 1000;
                if (Glazed) cal += 130;
                return cal;

            }
        }


    }
}
