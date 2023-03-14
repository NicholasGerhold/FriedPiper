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

namespace FriedPiper.PointOfSale.CompleteOrderComponents
{
    /// <summary>
    /// Interaction logic for OrderTotalControl.xaml
    /// </summary>
    public partial class OrderTotalControl : UserControl
    {
        public OrderTotalControl()
        {
            InitializeComponent();
            this.DataContext = ((Order)((MainWindow)Application.Current.MainWindow).OrderSummary.DataContext);
        }
    }
}
