using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriedPiper.PointOfSale;
using System.ComponentModel;
using FriedPiper.Data;
using FriedPiper.Data.MenuItems;

namespace FriedPiper.PointOfSale
{
    /// <summary>
    /// creates the logic for the cash portion
    /// </summary>
    public class ModelView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// holds the amount of cash in the drawer: Hundreds
        /// </summary>
        public uint HundredDrawer { get { return RoundRegister.CashDrawer.Hundreds; } }
        /// <summary>
        /// holds the amount of cash in the drawer: Fifties
        /// </summary>
        public uint FiftyDrawer { get { return RoundRegister.CashDrawer.Fifties; } }
        /// <summary>
        /// holds the amount of cash in the drawer: Twenties
        /// </summary>
        public uint TwentyDrawer { get { return RoundRegister.CashDrawer.Twenties; } }
        /// <summary>
        /// holds the amount of cash in the drawer: Tens
        /// </summary>
        public uint TenDrawer { get { return RoundRegister.CashDrawer.Tens; } }
        /// <summary>
        /// holds the amount of cash in the drawer: Fives
        /// </summary>
        public uint FiveDrawer { get { return RoundRegister.CashDrawer.Fives; } }
        /// <summary>
        /// holds the amount of cash in the drawer: Twos
        /// </summary>
        public uint TwoDrawer { get { return RoundRegister.CashDrawer.Twos; } }
        /// <summary>
        /// holds the amount of cash in the drawer: Ones
        /// </summary>
        public uint OneDrawer { get { return RoundRegister.CashDrawer.Ones; } }
        /// <summary>
        /// holds the amount of cash in the drawer: Dollar Coins
        /// </summary>
        public uint DollarCoinDrawer { get { return RoundRegister.CashDrawer.DollarCoins; } }
        /// <summary>
        /// holds the amount of cash in the drawer: Half Dollar coins
        /// </summary>
        public uint HalfDollarCoinDrawer { get { return RoundRegister.CashDrawer.HalfDollarCoins; } }
        /// <summary>
        /// holds the amount of cash in the drawer: Quarters
        /// </summary>
        public uint QuarterDrawer { get { return RoundRegister.CashDrawer.Quarters; } }
        /// <summary>
        /// holds the amount of cash in the drawer: Dimes
        /// </summary>
        public uint DimeDrawer { get { return RoundRegister.CashDrawer.Dimes; } }
        /// <summary>
        /// holds the amount of cash in the drawer: Nickles
        /// </summary>
        public uint NickleDrawer { get { return RoundRegister.CashDrawer.Nickles; } }
        /// <summary>
        /// holds the amount of cash in the drawer: Pennies
        /// </summary>
        public uint PennieDrawer { get { return RoundRegister.CashDrawer.Pennies; } }


        /// <summary>
        /// keeps track of total customer input money
        /// </summary>
        public decimal TotalCustomerMoney
        {
            get
            {

                return HundredCustomer * 100 + FiftyCustomer * 50 + TwentyCustomer * 20 + TenCustomer * 10 + FiveCustomer * 5 + TwoCustomer * 2 + OneCustomer + DollarCoinCustomer
                    + HalfDollarCoinCustomer * .5m + QuarterCustomer *.25m + DimeCustomer *.1m + NicklesCustomer * .05m + PenniesCustomer * .01m;
             }
        }

        /// <summary>
        /// private backing of 100 customer
        /// </summary>
        private uint _hundredCustomer = 0;

        /// <summary>
        /// amount of hundreds
        /// </summary>
        public uint HundredCustomer 
        { 
            get { return _hundredCustomer; } 
            set {
                _hundredCustomer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HundredCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCustomerMoney"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChangeDue"));
            } 
        }
        /// <summary>
        /// backing for Fifty Customer
        /// </summary>
        private uint _fiftyCustomer = 0;
        /// <summary>
        /// public property of fifty customer
        /// </summary>
        public uint FiftyCustomer 
        {
            get { return _fiftyCustomer; }
            set
            {
                _fiftyCustomer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftyCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCustomerMoney"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChangeDue"));
            }
        }

        /// <summary>
        /// private backing of twenty
        /// </summary>
        private uint _twentyCustomer = 0;
        /// <summary>
        /// public face of twenty customer
        /// </summary>
        public uint TwentyCustomer
        {
            get { return _twentyCustomer; }
            set
            {
                _twentyCustomer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentyCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCustomerMoney"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChangeDue"));
            }
        }

        /// <summary>
        /// private backing of ten customer
        /// </summary>
        private uint _tenCustomer = 0;
        /// <summary>
        /// stores the amount of tens
        /// </summary>
        public uint TenCustomer
        {
            get { return _tenCustomer; }
            set
            {
                _tenCustomer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TenCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCustomerMoney"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChangeDue"));
            }
        }

        /// <summary>
        /// private backing of five customer
        /// </summary>
        private uint _fiveCustomer = 0;
        /// <summary>
        /// stores the amount of fives
        /// </summary>
        public uint FiveCustomer
        {
            get { return _fiveCustomer; }
            set
            {
                _fiveCustomer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiveCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCustomerMoney"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChangeDue"));
            }
        }

        /// <summary>
        /// private backing of two customer
        /// </summary>
        private uint _twoCustomer = 0;
        /// <summary>
        /// amount of twos
        /// </summary>
        public uint TwoCustomer
        {
            get { return _twoCustomer; }
            set
            {
                _twoCustomer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwoCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCustomerMoney"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChangeDue"));
            }
        }

        /// <summary>
        /// private backing
        /// </summary>
        private uint _oneCustomer = 0;
        /// <summary>
        /// contains the amount of ones
        /// </summary>
        public uint OneCustomer
        {
            get { return _oneCustomer; }
            set
            {
                _oneCustomer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OneCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCustomerMoney"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChangeDue"));
            }
        }

        /// <summary>
        /// private backing of dollar coin
        /// </summary>
        public uint _dollarCoinCustomer = 0;
        /// <summary>
        /// stores the amount of dollar coins
        /// </summary>
        public uint DollarCoinCustomer
        {
            get { return _dollarCoinCustomer; }
            set
            {
                _dollarCoinCustomer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DollarCoinCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCustomerMoney"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChangeDue"));
            }
        }

        /// <summary>
        /// private backing
        /// </summary>
        private uint _halfDollarCoinCustomer = 0;
        /// <summary>
        /// amount of half dollar coins
        /// </summary>
        public uint HalfDollarCoinCustomer
        {
            get { return _halfDollarCoinCustomer; }
            set
            {
                _halfDollarCoinCustomer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollarCoinCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCustomerMoney"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChangeDue"));
            }
        }

        /// <summary>
        /// private backing of quarters
        /// </summary>
        private uint _quartersCustomer = 0;
        /// <summary>
        /// amount of quarters
        /// </summary>
        public uint QuarterCustomer
        {
            get { return _quartersCustomer; }
            set
            {
                _quartersCustomer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QuarterCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCustomerMoney"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChangeDue"));
            }
        }

        /// <summary>
        /// private backing of dimes
        /// </summary>
        private uint _dimes = 0;
        /// <summary>
        /// amount of dimes
        /// </summary>
        public uint DimeCustomer
        {
            get { return _dimes; }
            set
            {
                _dimes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DimeCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCustomerMoney"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChangeDue"));
            }
        }

        /// <summary>
        /// private backing
        /// </summary>
        private uint _nicklesCustomer = 0;
        /// <summary>
        /// The amount of Nickles
        /// </summary>
        public uint NicklesCustomer
        {
            get { return _nicklesCustomer; }
            set
            {
                _nicklesCustomer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NickleCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCustomerMoney"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChangeDue"));
            }
        }

        /// <summary>
        /// private backing
        /// </summary>
        private uint _penniesCustomer = 0;
        /// <summary>
        /// amount of pennies
        /// </summary>
        public uint PenniesCustomer
        {
            get { return _penniesCustomer; }
            set
            {
                _penniesCustomer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PenniesCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCustomerMoney"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChangeDue"));
            }
        }

        /// <summary>
        /// private backing
        /// </summary>
        private decimal _totalChangeDue = 0;
        /// <summary>
        /// amount of change due
        /// </summary>
        public decimal TotalChangeDue
        {
            get { return _totalChangeDue; }
            set
            {
                _totalChangeDue = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChangeDue"));
            }
        } 

        /// <summary>
        /// private backing of 100 customer
        /// </summary>
        private uint _hundredChange = 0;

        /// <summary>
        /// amount of hundreds
        /// </summary>
        public uint HundredChange
        {
            get { return _hundredChange; }
            set
            {
                _hundredChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HundredChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChangeDue"));
            }
        }
        /// <summary>
        /// backing for Fifty Customer
        /// </summary>
        private uint _fiftyChange = 0;
        /// <summary>
        /// public property of fifty customer
        /// </summary>
        public uint FiftyChange
        {
            get { return _fiftyChange; }
            set
            {
                _fiftyChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftyChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChangeDue"));
            }
        }

        /// <summary>
        /// private backing of twenty
        /// </summary>
        private uint _twentyChange = 0;
        /// <summary>
        /// public face of twenty customer
        /// </summary>
        public uint TwentyChange
        {
            get { return _twentyChange; }
            set
            {
                _twentyChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentyChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChangeDue"));
            }
        }

        /// <summary>
        /// private backing of ten customer
        /// </summary>
        private uint _tenChange = 0;
        /// <summary>
        /// stores the amount of tens
        /// </summary>
        public uint TenChange
        {
            get { return _tenChange; }
            set
            {
                _tenChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TenChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChangeDue"));
            }
        }

        /// <summary>
        /// private backing of five customer
        /// </summary>
        private uint _fiveChange = 0;
        /// <summary>
        /// stores the amount of fives
        /// </summary>
        public uint FiveChange
        {
            get { return _fiveChange; }
            set
            {
                _fiveChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiveChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChangeDue"));
            }
        }

        /// <summary>
        /// private backing of two customer
        /// </summary>
        private uint _twoChange = 0;
        /// <summary>
        /// amount of twos
        /// </summary>
        public uint TwoChange
        {
            get { return _twoChange; }
            set
            {
                _twoChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwoChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChangeDue"));
            }
        }

        /// <summary>
        /// private backing
        /// </summary>
        private uint _oneChange = 0;
        /// <summary>
        /// contains the amount of ones
        /// </summary>
        public uint OneChange
        {
            get { return _oneChange; }
            set
            {
                _oneChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OneChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChangeDue"));
            }
        }

        /// <summary>
        /// private backing of dollar coin
        /// </summary>
        public uint _dollarCoinChange = 0;
        /// <summary>
        /// stores the amount of dollar coins
        /// </summary>
        public uint DollarCoinChange
        {
            get { return _dollarCoinChange; }
            set
            {
                _dollarCoinChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DollarCoinChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChangeDue"));
            }
        }

        /// <summary>
        /// private backing
        /// </summary>
        private uint _halfDollarCoinChange = 0;
        /// <summary>
        /// amount of half dollar coins
        /// </summary>
        public uint HalfDollarCoinChange
        {
            get { return _halfDollarCoinChange; }
            set
            {
                _halfDollarCoinChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollarCoinChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChangeDue"));
            }
        }

        /// <summary>
        /// private backing of quarters
        /// </summary>
        private uint _quartersChange = 0;
        /// <summary>
        /// amount of quarters
        /// </summary>
        public uint QuarterChange
        {
            get { return _quartersChange; }
            set
            {
                _quartersChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QuarterChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChangeDue"));
            }
        }

        /// <summary>
        /// private backing of dimes
        /// </summary>
        private uint _dimesChange = 0;
        /// <summary>
        /// amount of dimes
        /// </summary>
        public uint DimeChange
        {
            get { return _dimesChange; }
            set
            {
                _dimesChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DimeChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChangeDue"));
            }
        }

        /// <summary>
        /// private backing
        /// </summary>
        private uint _nickleChange = 0;
        /// <summary>
        /// The amount of Nickles
        /// </summary>
        public uint NickleChange
        {
            get { return _nickleChange; }
            set
            {
                _nickleChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NickleChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChangeDue"));
            }
        }

        /// <summary>
        /// private backing
        /// </summary>
        private uint _pennieChange = 0;
        /// <summary>
        /// amount of pennies
        /// </summary>
        public uint PennieChange
        {
            get { return _pennieChange; }
            set
            {
                _pennieChange = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PennieChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChangeDue"));
            }
        }

        /// <summary>
        /// private backing
        /// </summary>
        private decimal _amountDue = 0;
        /// <summary>
        /// the amount due
        /// </summary>
        public decimal AmountDue
        {
            get
            {
                if (_amountDue < 0)
                {
                    return -1 * _amountDue;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                _amountDue = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
            }
        }

        /// <summary>
        /// Sets the change that can be given
        /// </summary>
        /// <param name="total">The total to find</param>
        public void CreateChange(decimal total)
        {
            decimal tempTotal = TotalCustomerMoney - total;
            if (tempTotal <= 0)
            {
                AmountDue = tempTotal;
                TotalChangeDue = 0;
                HundredChange = 0;
                FiftyChange = 0;
                TwentyChange = 0;
                TenChange = 0;
                OneChange = 0;
                DollarCoinChange = 0;
                HalfDollarCoinChange = 0;
                QuarterChange = 0;
                DimeChange = 0;
                NickleChange = 0;
                PennieChange = 0;
                return;
            }

            TotalChangeDue = tempTotal;


            uint tempBill = (uint)tempTotal / (100);
            if(tempBill != 0)
            {
                if ( tempBill >= HundredDrawer)
                {
                    tempTotal -= 100 * HundredDrawer;
                    HundredChange = HundredDrawer;
                }
                else
                {
                    tempTotal -= tempBill * 100;
                    HundredChange = tempBill;
                }
            }

            tempBill = (uint)tempTotal / (50);
            if (tempBill != 0)
            {
                if (tempBill >= FiftyDrawer)
                {
                    tempTotal -= 50 * FiftyDrawer;
                    FiftyChange = FiftyDrawer;
                }
                else
                {
                    tempTotal -= tempBill * 50;
                    FiftyChange = tempBill;
                }
            }

            tempBill = (uint)tempTotal / (20);
            if (tempBill != 0)
            {
                if (tempBill >= TwentyDrawer)
                {
                    tempTotal -= 20 * TwentyDrawer;
                    TwentyChange = TwentyDrawer;
                }
                else
                {
                    tempTotal -= tempBill * 20;
                    TwentyChange = tempBill;
                }
            }

            tempBill = (uint)tempTotal / (10);
            if (tempBill != 0)
            {
                if (tempBill >= TenDrawer)
                {
                    tempTotal -= 10 * TenDrawer;
                    TenChange = TenDrawer;
                }
                else
                {
                    tempTotal -= tempBill * 10;
                    TenChange = tempBill;
                }
            }

            tempBill = (uint)tempTotal / (5);
            if (tempBill != 0)
            {
                if (tempBill >= FiveDrawer)
                {
                    tempTotal -= 5 * FiveDrawer;
                    FiveChange = FiveDrawer;
                }
                else
                {
                    tempTotal -= tempBill * 5;
                    FiveChange = tempBill;
                }
            }

            tempBill = (uint)tempTotal / (2);
            if (tempBill != 0)
            {
                if (tempBill >= TwoDrawer)
                {
                    tempTotal -= 2 * TwoDrawer;
                    TwoChange = TwoDrawer;
                }
                else
                {
                    tempTotal -= tempBill * 2;
                    TwoChange = tempBill;
                }
            }

            tempBill = (uint)tempTotal / (1);
            if (tempBill != 0)
            {
                if (tempBill >= OneDrawer)
                {
                    tempTotal -= OneDrawer;
                    OneChange = OneDrawer;
                }
                else
                {
                    tempTotal -= tempBill;
                    OneChange = tempBill;
                }
            }

            tempBill = ((uint)(tempTotal * 100)) / (50);
            if (tempBill != 0)
            {
                if (tempBill >= HalfDollarCoinDrawer)
                {
                    tempTotal -= (decimal)(50 * HalfDollarCoinDrawer)/100;
                    HalfDollarCoinChange = HalfDollarCoinDrawer;
                }
                else
                {
                    tempTotal -= (decimal)(50 * tempBill)/100;
                    HalfDollarCoinChange = tempBill;
                }
            }

            tempBill = ((uint)(tempTotal * 100)) / (25);
            if (tempBill != 0)
            {
                if (tempBill >= QuarterDrawer)
                {
                    tempTotal -= (decimal)(25 * QuarterDrawer)/100;
                    QuarterChange = QuarterDrawer;
                }
                else
                {
                    tempTotal -= (decimal)(25 *tempBill)/100;
                    QuarterChange = tempBill;
                }
            }

            tempBill = ((uint)(tempTotal * 100)) / (10);
            if (tempBill != 0)
            {
                if (tempBill >= DimeDrawer)
                {
                    tempTotal -= (decimal)(10 * DimeDrawer)/100;
                    DimeChange = DimeDrawer;
                }
                else
                {
                    tempTotal -= (decimal)(10 * tempBill)/100;
                    DimeChange = tempBill;
                }
            }

            tempBill = ((uint)(tempTotal * 100)) / (5);
            if (tempBill != 0)
            {
                if (tempBill >= NickleDrawer)
                {
                    tempTotal -= (decimal)(5 * NickleDrawer)/100;
                    NickleChange = NickleDrawer;
                }
                else
                {
                    tempTotal -= (decimal)(5 * tempBill)/100;
                    NickleChange = tempBill;
                }
            }

            tempBill = ((uint)(tempTotal * 100)) / (1);
            if (tempBill != 0)
            {
                if (tempBill >= PennieDrawer)
                {
                    tempTotal -= (decimal)(1 * PennieDrawer)/100;
                    PennieChange = PennieDrawer;
                }
                else
                {
                    tempTotal -= (decimal)(1 * tempBill)/100;
                    PennieChange = tempBill;
                }
            }



        }

        /// <summary>
        /// This prints a reciept
        /// </summary>
        /// <param name="order">the order to print a recipe for</param>
        /// <param name="str">the type of payment</param>
        public void PrintReceipt(Order order, string str)
        {
            RoundRegister.ReceiptPrinter.PrintLine(order.Number.ToString());
            RoundRegister.ReceiptPrinter.PrintLine(order.PlacedAt.ToString());
            RoundRegister.ReceiptPrinter.PrintLine("");
            foreach (IMenuItem item in order.Orders)
            {
                if (item is PiperPlatter piper)
                {
                    RoundRegister.ReceiptPrinter.PrintLine(piper.ToString());
                    RoundRegister.ReceiptPrinter.PrintLine(piper.LeftPie.ToString());
                    RoundRegister.ReceiptPrinter.PrintLine(piper.RightPie.ToString());
                    RoundRegister.ReceiptPrinter.PrintLine(piper.LeftIceCream.ToString());
                    RoundRegister.ReceiptPrinter.PrintLine(piper.RightIceCream.ToString());
                    RoundRegister.ReceiptPrinter.PrintLine("         $" + piper.Price.ToString());
                }
                else if (item is PopperPlatter popper)
                {
                    RoundRegister.ReceiptPrinter.PrintLine(popper.ToString());
                    RoundRegister.ReceiptPrinter.PrintLine(popper.FriedOreos.ToString());
                    RoundRegister.ReceiptPrinter.PrintLine(popper.AppleFritters.ToString());
                    RoundRegister.ReceiptPrinter.PrintLine(popper.FriedCheesecake.ToString());
                    RoundRegister.ReceiptPrinter.PrintLine(popper.FriedBananas.ToString());
                    if (popper.Glazed) RoundRegister.ReceiptPrinter.PrintLine("Popper Platter is Glazed");
                    RoundRegister.ReceiptPrinter.PrintLine ("         $" + popper.Price.ToString());
                }
                else if (item is Popper)
                {
                    RoundRegister.ReceiptPrinter.PrintLine(item.ToString());
                    if (((Popper)item).Glazed) RoundRegister.ReceiptPrinter.PrintLine("Popper is Glazed");
                    RoundRegister.ReceiptPrinter.PrintLine("         $" + ((IMenuItem)item).Price.ToString());
                }
                else
                {
                    RoundRegister.ReceiptPrinter.PrintLine(item.ToString());
                    RoundRegister.ReceiptPrinter.PrintLine("         $" + item.Price.ToString());
                }
                RoundRegister.ReceiptPrinter.PrintLine("");
            }

            RoundRegister.ReceiptPrinter.PrintLine("");
            RoundRegister.ReceiptPrinter.PrintLine("SubTotal: " + order.Subtotal);
            RoundRegister.ReceiptPrinter.PrintLine("Tax: " + order.Tax);
            RoundRegister.ReceiptPrinter.PrintLine("Total: " + order.Total);
            RoundRegister.ReceiptPrinter.PrintLine("Paid With " + str);
            RoundRegister.ReceiptPrinter.PrintLine("Total Change " + TotalChangeDue);

            RoundRegister.ReceiptPrinter.CutTape();

            RoundRegister.CashDrawer.Open();

        }
    }
}
