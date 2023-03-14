using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriedPiper.PointOfSale.OptionComponents
{
    /// <summary>
    /// an interface for menu item data controls
    /// </summary>
    public interface IMenuItemControl
    {
        object DataContext { get; set; }
    }
}
