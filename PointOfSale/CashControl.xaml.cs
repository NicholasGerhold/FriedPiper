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

namespace FriedPiper.PointOfSale
{
    /// <summary>
    /// Interaction logic for CashControl.xaml
    /// </summary>
    public partial class CashControl : UserControl
    {
        public CashControl()
        {
            this.DataContext = new ModelView();
            InitializeComponent();
            
        }


        /// <summary>
        /// Click event for finalizing a sale
        /// </summary>
        /// <param name="sender">the sending object</param>
        /// <param name="e">e</param>
        public void onFinalizeClick(object sender, RoutedEventArgs e)
        {
            ((ModelView)((Button)sender).DataContext).PrintReceipt(((Order)((MainWindow)Application.Current.MainWindow).OrderSummary.DataContext), "Cash");
            ((MainWindow)Application.Current.MainWindow).OrderSummary.DataContext = new Order();
            ((MainWindow)Application.Current.MainWindow).containerBorder.Child = new MenuItemSelectionControl();
        }

    }


}
