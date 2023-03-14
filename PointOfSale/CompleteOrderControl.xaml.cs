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
using FriedPiper.PointOfSale.CompleteOrderComponents;


namespace FriedPiper.PointOfSale
{
    /// <summary>
    /// Interaction logic for CompleteOrderControl.xaml
    /// </summary>
    public partial class CompleteOrderControl : UserControl
    {
        public CompleteOrderControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Takes you to the cash payment scree
        /// </summary>
        /// <param name="sender">the button that sent the event</param>
        /// <param name="e">the event</param>
        public void onCashClick (object sender, RoutedEventArgs e)
        {
            Border tempBorder = this.Parent as Border;
            CashControl tempCashControl = new CashControl();
            //tempCashControl.DataContext = new ModelView();
            tempBorder.Child = tempCashControl;
            
        }

        /// <summary>
        /// Takes you to the creditpayment screen
        /// </summary>
        /// <param name="sender">The button that sent the event</param>
        /// <param name="e">the event</param>
        public void onCreditClick(object sender, RoutedEventArgs e)
        {
            Grid tempGrid = ((Border)this.Parent).Parent as Grid;
            MainWindow mainWindow = tempGrid.Parent as MainWindow;
            decimal orderPrice = ((Order)mainWindow.OrderSummary.DataContext).Total;
            RoundRegister.CardTransactionResult temp = RoundRegister.CardReader.RunCard();

            if (temp == RoundRegister.CardTransactionResult.Approved)
            {
                ModelView tempModel = new();
                tempModel.PrintReceipt(((Order)mainWindow.OrderSummary.DataContext), "Credit");
                mainWindow.OrderSummary.DataContext = new Order();

            }
            else if (temp == RoundRegister.CardTransactionResult.Declined)
            {
                mainWindow.containerBorder.Child = new DeclinedControl();
                mainWindow.CompleteButton.IsEnabled = true;
            }
            else if (temp == RoundRegister.CardTransactionResult.ReadError)
            {
                mainWindow.containerBorder.Child = new ReadErrorControl();
                mainWindow.CompleteButton.IsEnabled = true;
            }
            else if (temp == RoundRegister.CardTransactionResult.InsufficientFunds)
            {
                mainWindow.containerBorder.Child = new InsufficentFundsControl();
                mainWindow.CompleteButton.IsEnabled = true;
            }
            else if (temp == RoundRegister.CardTransactionResult.IncorrectPin)
            {
                mainWindow.containerBorder.Child = new IncorrectPinControl();
                mainWindow.CompleteButton.IsEnabled = true;
            }
        }

        /// <summary>
        /// Processes a debit payment
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">event</param>
        public void onDebitClick(object sender, RoutedEventArgs e)
        {
            Grid tempGrid = ((Border)this.Parent).Parent as Grid;
            MainWindow mainWindow = tempGrid.Parent as MainWindow;
            decimal orderPrice = ((Order)mainWindow.OrderSummary.DataContext).Total;
            RoundRegister.CardTransactionResult temp = RoundRegister.CardReader.RunCard();

            if (temp == RoundRegister.CardTransactionResult.Approved)
            {
                ModelView tempModel = new();
                tempModel.PrintReceipt(((Order)mainWindow.OrderSummary.DataContext), "Debit");
                mainWindow.OrderSummary.DataContext = new Order();

            }
            else if (temp == RoundRegister.CardTransactionResult.Declined)
            {
                mainWindow.containerBorder.Child = new DeclinedControl();
                mainWindow.CompleteButton.IsEnabled = true;
            }
            else if (temp == RoundRegister.CardTransactionResult.ReadError)
            {
                mainWindow.containerBorder.Child = new ReadErrorControl();
                mainWindow.CompleteButton.IsEnabled = true;
            }
            else if (temp == RoundRegister.CardTransactionResult.InsufficientFunds)
            {
                mainWindow.containerBorder.Child = new InsufficentFundsControl();
                mainWindow.CompleteButton.IsEnabled = true;
            }
            else if (temp == RoundRegister.CardTransactionResult.IncorrectPin)
            {
                mainWindow.containerBorder.Child = new IncorrectPinControl();
                mainWindow.CompleteButton.IsEnabled = true;
            }
        }
    }
}
