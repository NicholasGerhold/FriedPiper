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
using FriedPiper.Data;
using FriedPiper.PointOfSale.OptionComponents;
using FriedPiper.Data.MenuItems;

namespace FriedPiper.PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click event for the more items button
        /// </summary>
        /// <param name="sender">the object that sent the event</param>
        /// <param name="e">the event</param>
        void onSelectMoreItemsButtonClick(object sender, RoutedEventArgs e)
        {
            if (containerBorder.Child is IMenuItemControl)
            {
                Order temp = (Order)OrderSummary.DataContext;
                IMenuItemControl tempControl = (IMenuItemControl)containerBorder.Child;
                temp.Add((IMenuItem)tempControl.DataContext);
            }
            containerBorder.Child = new MenuItemSelectionControl();
            CompleteButton.IsEnabled = true;
            selectMoreItemsButton.Content = "Select More Items";
        }

        /// <summary>
        /// This cancels an order
        /// </summary>
        /// <param name="sender">The object that sent it</param>
        /// <param name="e"> E </param>
        private void onCancelOrderClick (object sender, RoutedEventArgs e)
        {
            OrderSummary.DataContext = new Order();
            CompleteButton.IsEnabled = true;
            this.containerBorder.Child = new MenuItemSelectionControl();
            selectMoreItemsButton.Content = "Select More Items";

        }

        /// <summary>
        /// This completes the order
        /// </summary>
        /// <param name="sender">the button clicked that completed the order</param>
        /// <param name="e"> Another E </param>
        private void onCompleteOrderClick(object sender, RoutedEventArgs e)
        {
            containerBorder.Child = new CompleteOrderControl();
            ((Button)sender).IsEnabled = false;
            selectMoreItemsButton.Content = "Return To Order";
        }
    }
}
