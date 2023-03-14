using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FriedPiper.Data.MenuItems
{
    /// <summary>
    /// A class representing the Piper Platter menu item
    /// </summary>
    /// <remarks> This contains 2 fired pies and 2 fried 
    /// ice creams of any flavor</remarks>
    public class PiperPlatter : IMenuItem, INotifyPropertyChanged, IPlatter
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
        /// private backing of Left Pie Property
        /// </summary>
        private FriedPie _leftPie = new FriedPie();
        /// <summary>
        /// private backing of Right Pie Property
        /// </summary>
        private FriedPie _rightPie = new FriedPie();
        /// <summary>
        /// private backing of Left Ice Cream Property
        /// </summary>
        private FriedIceCream _leftIceCream = new FriedIceCream();
        /// <summary>
        /// private backing of Right Ice Cream Property
        /// </summary>
        private FriedIceCream _rightIceCream = new FriedIceCream();

        /// <summary>
        /// A string returning the name of the piper platter
        /// </summary>
        public string Name { get; } = "Piper Platter";

        /// <summary>
        /// the first fried pie
        /// </summary>
        public FriedPie LeftPie
        {
            get { return _leftPie; }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LeftPie"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                _leftPie = value;
            }
        }

        /// <summary>
        /// The second fried pie
        /// </summary>
        public FriedPie RightPie
        {
            get { return _rightPie; }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RightPie"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                _rightPie = value;
            }
        }

        /// <summary>
        /// The first fried ice cream
        /// </summary>
        public FriedIceCream LeftIceCream
        {
            get { return _leftIceCream; }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LeftIceCream"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                _leftIceCream = value;
            }
        }

        /// <summary>
        /// The second fried ice cream
        /// </summary>
        public FriedIceCream RightIceCream
        {
            get { return _rightIceCream; }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RightIceCream"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                _rightIceCream = value;
            }
        }

        /// <summary>
        /// The calories of the total of all the items in the platter
        /// </summary>
        public uint Calories
        {
            get
            {
                return LeftPie.Calories + RightPie.Calories + LeftIceCream.Calories + RightIceCream.Calories;
            }
        }

        /// <summary>
        /// returns the price of the platter
        /// </summary>
        /// <value>In dollars</value>
        public decimal Price
        {
            get
            {
                return 12.00m;
            }
        }




    }
}
