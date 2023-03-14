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
    /// The class repressenting the fried candy bar menu item
    /// </summary>
    public class FriedCandyBar : IMenuItem, INotifyPropertyChanged, ITreat
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
        /// private backing field of CandyBar
        /// </summary>
        private CandyBar _candyBar;

        /// <summary>
        /// The name of the fried candybar
        /// </summary>
        public string Name
        {
            get
            {
                return $"Fried {CandyBar}";
            }
        }

        /// <summary>
        /// The type of candy bar 
        /// </summary>
        public CandyBar CandyBar 
        {
            get { return _candyBar; }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CandyBar"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                _candyBar = value;
            }
        }

        /// <summary>
        /// The price of a fried candy bar
        /// </summary>
        public decimal Price { get; } = 2.50m;
        
        /// <summary>
        /// The calory of a fried candy bar
        /// </summary>
        public uint Calories
        {
            get
            {
                if (CandyBar == CandyBar.Snickers) return 325;
                if (CandyBar == CandyBar.MilkyWay) return 213;
                if (CandyBar == CandyBar.Twix) return 396;
                if (CandyBar == CandyBar.ThreeMusketeers) return 350;
                if (CandyBar == CandyBar.ButterFingers) return 385;
                return 0;
            }
        }
    }
}
