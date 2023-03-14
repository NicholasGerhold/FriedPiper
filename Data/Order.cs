using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using FriedPiper.Data.MenuItems;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Collections;


namespace FriedPiper.Data
{
    /// <summary>
    /// Contains the data for an order of menu items.
    /// </summary>
    public class Order :  INotifyCollectionChanged, INotifyPropertyChanged, ICollection
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;
        /// <summary>
        /// This contains all of the menu items in the class
        /// </summary>
        private Collection<IMenuItem> _order = new Collection<IMenuItem>();

        /// <summary>
        /// allows access to orders
        /// </summary>
        public Collection<IMenuItem> Orders { get { return _order; } }

        /// <summary>
        /// private backing of Number property
        /// </summary>
        private int _number;

        /// <summary>
        /// Keeps track of order number
        /// </summary>
        public int Number 
        {
            get { return _number; }
        }

        /// <summary>
        /// keeps track of when the order was placed
        /// </summary>
        public DateTime PlacedAt { get; } = DateTime.Now;

        /// <summary>
        /// keeps track of next order number
        /// </summary>
        private static int nextOrderNumber = 1;

        public Order()
        {
            _number = nextOrderNumber;
            nextOrderNumber++;
        }

        /// <summary>
        /// Adds an item to the order collection
        /// </summary>
        /// <param name="item"> the item to add</param>
        public void Add(IMenuItem item)
        {
            _order.Add(item);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

        /// <summary>
        /// Removes an item from the order
        /// </summary>
        /// <param name="item"> item to remove </param>
        public void Remove(IMenuItem item)
        {
            _order.Remove(item);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

        /// <summary>
        /// implements ICollection
        /// </summary>
        /// <param name="array">an array to copy to</param>
        /// <param name="index">an index</param>
        public void CopyTo(Array array, int index)
        {
            ((ICollection)_order).CopyTo(array, index);
        }

        /// <summary>
        /// An enumerator for the ICollections
        /// </summary>
        /// <returns>an enumerator</returns>
        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)_order).GetEnumerator();
        }

        /// <summary>
        /// The sales tax of the resteraunt
        /// </summary>
        public decimal SalesTaxRate { get; set; } = .09m;

        /// <summary>
        /// The subtotal of the order
        /// </summary>
        public decimal Subtotal
        {
            get
            {
                decimal sum = 0;
                foreach (IMenuItem item in _order)
                {
                    sum += item.Price;
                }
                return decimal.Truncate(sum *100)/100;
            }
        }

        /// <summary>
        /// The total amount of tax on the order
        /// </summary>
        public decimal Tax 
        {
            get
            {
                decimal tax = Subtotal * SalesTaxRate;
                return decimal.Truncate(tax * 100) / 100;
            }
        }

        /// <summary>
        /// The subtotal plus tax
        /// </summary>
        public decimal Total 
        {
            get
            {
                decimal total = Tax + Subtotal;
                return decimal.Truncate(total * 100) / 100;
            }
        }

        /// <summary>
        /// The total calories in the order
        /// </summary>
        public uint Calories 
        { 
            get
            {
                uint sum = 0;
                foreach(IMenuItem item in _order)
                {
                    sum += item.Calories;
                }
                return sum;
            }
        }

        /// <summary>
        /// Count for ICollections
        /// </summary>
        public int Count => ((ICollection)_order).Count;

        /// <summary>
        /// It may be synchronized or something?
        /// </summary>
        public bool IsSynchronized => ((ICollection)_order).IsSynchronized;

        /// <summary>
        /// It may be synchronized or something? part 2: Revenge from the dark side of the code
        /// </summary>
        public object SyncRoot => ((ICollection)_order).SyncRoot;
    }
}
