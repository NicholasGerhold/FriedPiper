using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriedPiper.Data.MenuItems
{
    /// <summary>
    /// An interface containing properties that all menu
    /// items have in common
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// A string containing the name of the menu item
        /// </summary>
        string Name { get; }

        /// <summary>
        /// A decimal containing the price of the menu item
        /// </summary>
        decimal Price { get; }

        /// <summary>
        /// The Calories of the menu item
        /// </summary>
        uint Calories { get; }
    }
}
