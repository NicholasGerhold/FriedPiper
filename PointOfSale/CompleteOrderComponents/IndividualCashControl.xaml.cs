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
    /// Interaction logic for IndividualCashControl.xaml
    /// </summary>
    public partial class IndividualCashControl : UserControl
    {
        /// <summary>
        /// holds the label of the control
        /// </summary>
        public static DependencyProperty LabelProperty = DependencyProperty.Register("Label", typeof(string), typeof(IndividualCashControl), new PropertyMetadata(""));

        /// <summary>
        /// Creates the dependence property for the value, allowing data binding
        /// </summary>
        public static DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(uint), typeof(IndividualCashControl));

        /// <summary>
        /// a dependency property or something
        /// </summary>
        public static DependencyProperty ChangeTotalProperty = DependencyProperty.Register("ChangeTotal", typeof(uint), typeof(IndividualCashControl));

        /// <summary>
        /// public facing end of the Change Dependency property 
        /// </summary>
        public uint ChangeTotal
        {
            get { return (uint)GetValue(ChangeTotalProperty); }
            set { SetValue(ChangeTotalProperty, value); }
        }


        /// <summary>
        /// public facing property of dependency property
        /// </summary>
        public uint Value
        {
            get { return (uint)GetValue(ValueProperty);}
            set { SetValue(ValueProperty, value); }
        }

        /// <summary>
        /// outward facing property of the cashControl
        /// </summary>
        public string Label
        {
            get { return (string)GetValue(LabelProperty);}
            set { SetValue(LabelProperty, value); }
        }

        public IndividualCashControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// this
        /// </summary>
        /// <param name="sender">e</param>
        /// <param name="e">e</param>
        private void onAddClick (object sender, RoutedEventArgs e)
        {
            
            Value++;
            ((ModelView)this.DataContext).CreateChange(((Order)((MainWindow)Application.Current.MainWindow).OrderSummary.DataContext).Total);
        }

        /// <summary>
        /// this
        /// </summary>
        /// <param name="sender">e</param>
        /// <param name="e">e</param>
        private void onSubClick(object sender, RoutedEventArgs e)
        {
            Value--;
            ((ModelView)this.DataContext).CreateChange(((Order)((MainWindow)Application.Current.MainWindow).OrderSummary.DataContext).Total);
        }
    }
}
