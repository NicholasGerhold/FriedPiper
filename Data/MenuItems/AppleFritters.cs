using System;
using FriedPiper.Data.Enums;
using System.ComponentModel;

namespace FriedPiper.Data.MenuItems
{
    /// <summary>
    /// A class representing the AppleFritters menu item at FriedPiper
    /// </summary>
    public class AppleFritters : Popper, IMenuItem, IPopper
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
        /// The name of the menu item
        /// </summary>
        public string Name
        {
            get
            {
                return $"{Size} Apple Fritters";
            }
        }

        /// <summary>
        /// The calories of the fritter
        /// </summary>
        public uint Calories
        {
            get
            {
                uint cals= 0;
                if (Size == ServingSize.Small) cals += 240;
                if (Size == ServingSize.Medium) cals += 360;
                if (Size == ServingSize.Large) cals += 480;
                if (Glazed) cals += 130;
                return cals;
            }
        }

        /// <summary>
        /// The price of the fritters in USD
        /// </summary>
        public decimal Price
        {
            get
            {
                if (Size == ServingSize.Small) return 3.00m;
                if (Size == ServingSize.Medium) return 4.00m;
                if (Size == ServingSize.Large) return 5.00m;
                return 4.00m;
            }
        }
    }
}
