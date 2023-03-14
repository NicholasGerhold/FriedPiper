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
using FriedPiper.Data.MenuItems;
using FriedPiper.PointOfSale.OptionComponents;

namespace FriedPiper.PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
            this.DataContext = new Order();
        }

        /// <summary>
        /// intercepts button click things
        /// </summary>
        /// <param name="sender">this random object</param>
        /// <param name="e">an event or something</param>
        private void onRemoveButtonClick(object sender, RoutedEventArgs e)
        {
            Order temp = this.DataContext as Order;
            Button tempButton = sender as Button;
            Grid tempGrid = tempButton.Parent as Grid;
            StackPanel tempStackPanel = tempGrid.Parent as StackPanel;
            IMenuItem tempMenu = tempStackPanel.DataContext as IMenuItem;
            temp.Remove(tempMenu);

        }

        /// <summary>
        /// Edits things or something
        /// </summary>
        /// <param name="sender">an thing</param>
        /// <param name="e">another slightly passive aggresive event xml comment tag for a parameter</param>
        private void onEditButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindow main = ((Grid)this.Parent).Parent as MainWindow;
            Order tempOrder = this.DataContext as Order;
            Button tempButton = sender as Button;
            Grid tempGrid = tempButton.Parent as Grid;
            StackPanel tempStackPanel = tempGrid.Parent as StackPanel;
            IMenuItem menu = tempStackPanel.DataContext as IMenuItem;


            if (menu is AppleFritters)
            {
                AppleFritterOptions tempControl = new AppleFritterOptions();
                tempControl.DataContext = menu;
                tempOrder.Remove(menu);
                main.containerBorder.Child = tempControl;
            } 
            else if (menu is FriedBananas)
            {
                FriedBananasOptions tempControl = new FriedBananasOptions();
                tempControl.DataContext = menu;
                tempOrder.Remove(menu);
                main.containerBorder.Child = tempControl;
            }
            else if (menu is FriedCandyBar)
            {
                FriedCandyBarOption tempControl = new FriedCandyBarOption();
                tempControl.DataContext = menu;
                tempOrder.Remove(menu);
                main.containerBorder.Child = tempControl;
            }
            else if (menu is FriedCheesecake)
            {
                FriedCheesecakeOptions tempControl = new FriedCheesecakeOptions();
                tempControl.DataContext = menu;
                tempOrder.Remove(menu);
                main.containerBorder.Child = tempControl;
            }
            else if (menu is FriedIceCream)
            {
                FriedIceCreamOptions tempControl = new FriedIceCreamOptions();
                tempControl.DataContext = menu;
                tempOrder.Remove(menu);
                main.containerBorder.Child = tempControl;
            }
            else if (menu is FriedOreos)
            {
                FriedOreosOptions tempControl = new FriedOreosOptions();
                tempControl.DataContext = menu;
                tempOrder.Remove(menu);
                main.containerBorder.Child = tempControl;
            }
            else if (menu is FriedPie)
            {
                FriedPieOptions tempControl = new FriedPieOptions();
                tempControl.DataContext = menu;
                tempOrder.Remove(menu);
                main.containerBorder.Child = tempControl;
            }
            else if (menu is FriedTwinkie)
            {
                FriedTwinkieOptions tempControl = new FriedTwinkieOptions();
                tempControl.DataContext = menu;
                tempOrder.Remove(menu);
                main.containerBorder.Child = tempControl;
            }
            else if (menu is PiperPlatter)
            {
                PiperPlatterOptions tempControl = new PiperPlatterOptions();
                tempControl.DataContext = menu;
                tempOrder.Remove(menu);
                main.containerBorder.Child = tempControl;
            }
            else if (menu is PopperPlatter)
            {
                PopperPlatterOptions tempControl = new PopperPlatterOptions();
                tempControl.DataContext = menu;
                tempOrder.Remove(menu);
                main.containerBorder.Child = tempControl;
            }

        }

        /// <summary>
        /// creates the storage for all options of menu items
        /// </summary>
        /// <param name="sender">an object</param>
        /// <param name="e"> EEEEEEEEEEE </param>
        private void onCreated(object sender, RoutedEventArgs e)
        {
            Order tempOrder = this.DataContext as Order;
            Border tempBorder = sender as Border;
            StackPanel tempStackPanel = ((Border)sender).Parent as StackPanel;
            IMenuItem menu = tempStackPanel.DataContext as IMenuItem;

            if (menu is Popper)
            {
                PopperCustomization tempCustomization = new PopperCustomization();
                tempCustomization.DataContext = menu;
                tempBorder.Child = tempCustomization;
            }
            else if (menu is PopperPlatter)
            {

            }
            else if (menu is PiperPlatter)
            {

            }
        }
    }
}
