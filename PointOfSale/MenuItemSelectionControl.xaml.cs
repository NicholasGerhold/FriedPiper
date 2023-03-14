using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FriedPiper.PointOfSale.OptionComponents;
using FriedPiper.Data.MenuItems;

namespace FriedPiper.PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {


        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This class represents the click event for the Fried Pie class
        /// </summary>
        /// <param name="sender">the object that sent it</param>
        /// <param name="e">the event </param>
        void onFriedPieClick (object sender, RoutedEventArgs e)
        {
            var tempPie = new FriedPie();
            var tempControl = new FriedPieOptions();
            tempControl.DataContext = tempPie;
            var parent = this.Parent as Border;
            parent.Child = tempControl;
        }

        /// <summary>
        /// This class represents the click event for the Fried ice cream class
        /// </summary>
        /// <param name="sender">the event</param>
        /// <param name="e"> the object that sent it</param>
        void onFriedIceCreamClick(object sender, RoutedEventArgs e)
        {
            var tempIceCream = new FriedIceCream();
            var tempControl = new FriedIceCreamOptions();
            tempControl.DataContext = tempIceCream;
            var parent = this.Parent as Border;
            parent.Child = tempControl;
        }

        /// <summary>
        /// This class represents the click event for the Fried Candy Bar class
        /// </summary>
        /// <param name="sender">object that sent it</param>
        /// <param name="e">the event</param>
        void onFriedCandyBarClick(object sender, RoutedEventArgs e)
        {
            var tempCandyBar = new FriedCandyBar();
            var tempControl = new FriedCandyBarOption();
            tempControl.DataContext = tempCandyBar;
            var parent = this.Parent as Border;
            parent.Child = tempControl;
        }

        /// <summary>
        /// This class represents the click event for the Fried Twinkie class
        /// </summary>
        /// <param name="sender">object that sent it</param>
        /// <param name="e">the event</param>
        void onFriedTwinkieClick(object sender, RoutedEventArgs e)
        {
            var tempControl = new FriedTwinkieOptions();
            tempControl.DataContext = new FriedTwinkie();
            var parent = this.Parent as Border;
            parent.Child = tempControl;
        }



        /// <summary>
        /// This class represents the click event for the Apple fritters class
        /// </summary>
        /// <param name="sender">object that sent it</param>
        /// <param name="e">the event</param>
        void onAppleFrittersClick(object sender, RoutedEventArgs e)
        {
            var tempControl = new AppleFritterOptions();
            tempControl.DataContext = new AppleFritters();
            var parent = this.Parent as Border;
            parent.Child = tempControl;

        }
        /// <summary>
        /// This class represents the click event for the Fried Bananas class
        /// </summary>
        /// <param name="sender">object that sent it</param>
        /// <param name="e">the event</param>
        void onFriedBananasClick(object sender, RoutedEventArgs e)
        {
            var tempControl = new FriedBananasOptions();
            tempControl.DataContext = new FriedBananas();
            var parent = this.Parent as Border;
            parent.Child = tempControl;
        }
        /// <summary>
        /// This class represents the click event for the Fried oreos class
        /// </summary>
        /// <param name="sender">object that sent it</param>
        /// <param name="e">the event</param>
        void onFriedOreosClick(object sender, RoutedEventArgs e)
        {
            var tempControl = new FriedOreosOptions();
            tempControl.DataContext = new FriedOreos();
            var parent = this.Parent as Border;
            parent.Child = tempControl;
        }
        /// <summary>
        /// This class represents the click event for the Fried Cheesecake class
        /// </summary>
        /// <param name="sender">object that sent it</param>
        /// <param name="e">the event</param>
        void onFriedCheesecakeClick(object sender, RoutedEventArgs e)
        {
            var tempControl = new FriedCheesecakeOptions();
            tempControl.DataContext = new FriedCheesecake();
            var parent = this.Parent as Border;
            parent.Child = tempControl;
        }

        /// <summary>
        /// This class represents the click event for the Piper platter class
        /// </summary>
        /// <param name="sender">object that sent it</param>
        /// <param name="e">the event</param>
        void onPiperPlatterClick(object sender, RoutedEventArgs e)
        {
            var tempControl = new PiperPlatterOptions();
            tempControl.DataContext = new PiperPlatter();
            var parent = this.Parent as Border;
            parent.Child = tempControl;
      
        }
        /// <summary>
        /// This class represents the click event for the PopperPlatter class
        /// </summary>
        /// <param name="sender">object that sent it</param>
        /// <param name="e">the event</param>
        void onPopperPlatterClick(object sender, RoutedEventArgs e)
        {
            var tempControl = new PopperPlatterOptions();
            tempControl.DataContext = new PopperPlatter();
            var parent = this.Parent as Border;
            parent.Child = tempControl;
        }
    }
}
