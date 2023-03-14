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
    /// The class representing the popper platter menu item
    /// </summary>
    public class PopperPlatter : IMenuItem, INotifyPropertyChanged, IPlatter
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
        /// private backing of apple fritters property
        /// </summary>
        private AppleFritters _appleFritters = new AppleFritters();

        /// <summary>
        /// private backing of fried bananas property
        /// </summary>
        private FriedBananas _friedBananas = new FriedBananas();

        /// <summary>
        /// private backing of fried Cheesecake property
        /// </summary>
        private FriedCheesecake _friedCheesecake = new FriedCheesecake();

        /// <summary>
        /// private backing of fried oreos property
        /// </summary>
        private FriedOreos _friedOreos = new FriedOreos();
        /// <summary>
        /// A private backing for the size property
        /// </summary>
        private ServingSize _size = ServingSize.Small;

        /// <summary>
        /// a private backing for the glazed property
        /// </summary>
        /// <remarks> Defaults true</remarks>
        private bool _glazed = true;


        /// <summary>
        /// This is the name of the popper platter menu item
        /// </summary>
        public string Name
        {
            get
            {
                return $"{Size} Popper Platter";
            }
        }

        /// <summary>
        /// This is the serving size of the popper platter class
        /// It sets all objects under it to have the same size
        /// </summary>
        public ServingSize Size 
        {
            get 
            { 
                return _size; 
            }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                _size = value;
                AppleFritters.Size = _size;
                FriedBananas.Size = _size;
                FriedCheesecake.Size = _size;
                FriedOreos.Size = _size;


            }
        }

        /// <summary>
        /// whether or not the popper platter class is glazed
        /// If it is all objects under are glazed as well
        /// </summary>
        public bool Glazed
        {
            get
            {
                return _glazed;
            }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Glazed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                _glazed = value;
                AppleFritters.Glazed = _glazed;
                FriedBananas.Glazed = _glazed;
                FriedCheesecake.Glazed = _glazed;
                FriedOreos.Glazed = _glazed;
            }
        }

        /// <summary>
        /// holds the apple fritter
        /// </summary>
        public AppleFritters AppleFritters
        {
            get { return _appleFritters; }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AppleFritters"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                _appleFritters = value;
            }
        }

        /// <summary>
        /// holds the fried banana part of the Popper platter class
        /// </summary>
        public FriedBananas FriedBananas
        {
            get { return _friedBananas; }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FriedBananas"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                _friedBananas = value;
            }
        }

        /// <summary>
        /// holds the fried cheesecake part of the popper platter class 
        /// </summary>
        public FriedCheesecake FriedCheesecake 
        {
            get { return _friedCheesecake; }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FriedCheesecake"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                _friedCheesecake = value;
            }
        }

        /// <summary>
        /// Holds the Fried oreo object of the popper platter class
        /// </summary>
        public FriedOreos FriedOreos
        {
            get { return _friedOreos; }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FriedOreos"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                _friedOreos = value;
            }
        }

        /// <summary>
        /// The sum total of all of the calories of all the items in the popper platter
        /// </summary>
        public uint Calories
        {
            get
            {
                return FriedOreos.Calories + FriedBananas.Calories + AppleFritters.Calories + FriedCheesecake.Calories;
            }
        }

        /// <summary>
        /// returns the price of the platter based on size
        /// </summary>
        /// <value> in Dollars</value>
        public decimal Price
        {
            get
            {
                if (Size == ServingSize.Small) return 12.00m;
                if (Size == ServingSize.Large) return 20.00m;
                if (Size == ServingSize.Medium) return 16.00m;
                return 0;
            }
        }
    }
}
