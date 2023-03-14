using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriedPiper.Data.MenuItems;

namespace FriedPiper.Data
{
    /// <summary>
    /// This class contains an instance of each possible menu option
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// This contains all of the possible treat options excluding platters
        /// </summary>
        public static IEnumerable<IMenuItem> Treats = new List<IMenuItem>();
        /// <summary>
        /// This contains all possible Popper combinations excluding platters
        /// </summary>
        public static IEnumerable<IMenuItem> Poppers = new List<IMenuItem>();
        /// <summary>
        /// contains all possible platter options
        /// </summary>
        public static IEnumerable<IMenuItem> Platters = new List<IMenuItem>();
        /// <summary>
        /// contains all possible menu options
        /// </summary>
        public static IEnumerable<IMenuItem> FullMenu = new List<IMenuItem>();

        static Menu()
        {

            ((List<IMenuItem>)Treats).Add(new FriedCandyBar() { CandyBar = Enums.CandyBar.Twix});
            ((List<IMenuItem>)Treats).Add(new FriedCandyBar() { CandyBar = Enums.CandyBar.MilkyWay});
            ((List<IMenuItem>)Treats).Add(new FriedCandyBar() { CandyBar = Enums.CandyBar.ThreeMusketeers});
            ((List<IMenuItem>)Treats).Add(new FriedCandyBar() { CandyBar = Enums.CandyBar.ButterFingers});
            ((List<IMenuItem>)Treats).Add(new FriedCandyBar() { CandyBar = Enums.CandyBar.Snickers});

            ((List<IMenuItem>)Treats).Add(new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla});
            ((List<IMenuItem>)Treats).Add(new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate});
            ((List<IMenuItem>)Treats).Add(new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry});


            ((List<IMenuItem>)Treats).Add(new FriedPie() { Flavor = Enums.PieFilling.Peach});
            ((List<IMenuItem>)Treats).Add(new FriedPie() { Flavor = Enums.PieFilling.Apple});
            ((List<IMenuItem>)Treats).Add(new FriedPie() { Flavor = Enums.PieFilling.Pecan});
            ((List<IMenuItem>)Treats).Add(new FriedPie() { Flavor = Enums.PieFilling.Cherry});
            ((List<IMenuItem>)Treats).Add(new FriedPie() { Flavor = Enums.PieFilling.Pineapple});
            ((List<IMenuItem>)Treats).Add(new FriedPie() { Flavor = Enums.PieFilling.Blueberry});
            ((List<IMenuItem>)Treats).Add(new FriedPie() { Flavor = Enums.PieFilling.Apricot});

            ((List<IMenuItem>)Treats).Add(new FriedTwinkie());

            ((List<IMenuItem>)Poppers).Add(new FriedOreos() { Size = Enums.ServingSize.Small, Glazed = true});
            ((List<IMenuItem>)Poppers).Add(new FriedOreos() { Size = Enums.ServingSize.Medium, Glazed = true });
            ((List<IMenuItem>)Poppers).Add(new FriedOreos() { Size = Enums.ServingSize.Large, Glazed = true });
            ((List<IMenuItem>)Poppers).Add(new FriedOreos() { Size = Enums.ServingSize.Small, Glazed = false });
            ((List<IMenuItem>)Poppers).Add(new FriedOreos() { Size = Enums.ServingSize.Medium, Glazed = false });
            ((List<IMenuItem>)Poppers).Add(new FriedOreos() { Size = Enums.ServingSize.Large, Glazed = false });

            ((List<IMenuItem>)Poppers).Add(new FriedBananas() { Size = Enums.ServingSize.Small, Glazed = true });
            ((List<IMenuItem>)Poppers).Add(new FriedBananas() { Size = Enums.ServingSize.Medium, Glazed = true });
            ((List<IMenuItem>)Poppers).Add(new FriedBananas() { Size = Enums.ServingSize.Large, Glazed = true });
            ((List<IMenuItem>)Poppers).Add(new FriedBananas() { Size = Enums.ServingSize.Small, Glazed = false });
            ((List<IMenuItem>)Poppers).Add(new FriedBananas() { Size = Enums.ServingSize.Medium, Glazed = false });
            ((List<IMenuItem>)Poppers).Add(new FriedBananas() { Size = Enums.ServingSize.Large, Glazed = false });

            ((List<IMenuItem>)Poppers).Add(new FriedCheesecake() { Size = Enums.ServingSize.Small, Glazed = true });
            ((List<IMenuItem>)Poppers).Add(new FriedCheesecake() { Size = Enums.ServingSize.Medium, Glazed = true });
            ((List<IMenuItem>)Poppers).Add(new FriedCheesecake() { Size = Enums.ServingSize.Large, Glazed = true });
            ((List<IMenuItem>)Poppers).Add(new FriedCheesecake() { Size = Enums.ServingSize.Small, Glazed = false });
            ((List<IMenuItem>)Poppers).Add(new FriedCheesecake() { Size = Enums.ServingSize.Medium, Glazed = false });
            ((List<IMenuItem>)Poppers).Add(new FriedCheesecake() { Size = Enums.ServingSize.Large, Glazed = false });

            ((List<IMenuItem>)Poppers).Add(new AppleFritters() { Size = Enums.ServingSize.Small, Glazed = true });
            ((List<IMenuItem>)Poppers).Add(new AppleFritters() { Size = Enums.ServingSize.Medium, Glazed = true });
            ((List<IMenuItem>)Poppers).Add(new AppleFritters() { Size = Enums.ServingSize.Large, Glazed = true });
            ((List<IMenuItem>)Poppers).Add(new AppleFritters() { Size = Enums.ServingSize.Small, Glazed = false });
            ((List<IMenuItem>)Poppers).Add(new AppleFritters() { Size = Enums.ServingSize.Medium, Glazed = false });
            ((List<IMenuItem>)Poppers).Add(new AppleFritters() { Size = Enums.ServingSize.Large, Glazed = false });

            ((List<IMenuItem>)Platters).Add(new PopperPlatter() { Size = Enums.ServingSize.Small, Glazed = true });
            ((List<IMenuItem>)Platters).Add(new PopperPlatter() { Size = Enums.ServingSize.Medium, Glazed = true });
            ((List<IMenuItem>)Platters).Add(new PopperPlatter() { Size = Enums.ServingSize.Large, Glazed = true });
            ((List<IMenuItem>)Platters).Add(new PopperPlatter() { Size = Enums.ServingSize.Small, Glazed = false });
            ((List<IMenuItem>)Platters).Add(new PopperPlatter() { Size = Enums.ServingSize.Medium, Glazed = false });
            ((List<IMenuItem>)Platters).Add(new PopperPlatter() { Size = Enums.ServingSize.Large, Glazed = false });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate},
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry},
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry},
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry},
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });


            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach},
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });


            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple},
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry},
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry},
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry},
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry},
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry},
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry},
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry},
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry},
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry},
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan},
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan  },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan  },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan  },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan  },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan  },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot},
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot},
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot},
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot},
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot},
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot},
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot},
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry }
            });


            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });


            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot}
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });


            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
                });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });


            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot }
            });






            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple}
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });


            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });


            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Apple }
            });












            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });


            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });


            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple},
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry}
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry }
            });











            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach}
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });


            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });


            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Peach }
            });





            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan}
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });


            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });


            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan }
            });



            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Cherry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });


            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Peach },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });


            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Blueberry },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Pecan },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });

            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            ((List<IMenuItem>)Platters).Add(new PiperPlatter()
            {
                LeftIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                RightIceCream = new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry },
                LeftPie = new FriedPie() { Flavor = Enums.PieFilling.Apricot },
                RightPie = new FriedPie() { Flavor = Enums.PieFilling.Pineapple }
            });
            FullMenu = new List<IMenuItem>(Platters);

            ((List<IMenuItem>)FullMenu).Add(new FriedCandyBar() { CandyBar = Enums.CandyBar.Twix });
            ((List<IMenuItem>)FullMenu).Add(new FriedCandyBar() { CandyBar = Enums.CandyBar.MilkyWay });
            ((List<IMenuItem>)FullMenu).Add(new FriedCandyBar() { CandyBar = Enums.CandyBar.ThreeMusketeers });
            ((List<IMenuItem>)FullMenu).Add(new FriedCandyBar() { CandyBar = Enums.CandyBar.ButterFingers });
            ((List<IMenuItem>)FullMenu).Add(new FriedCandyBar() { CandyBar = Enums.CandyBar.Snickers });

            ((List<IMenuItem>)FullMenu).Add(new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Vanilla });
            ((List<IMenuItem>)FullMenu).Add(new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Chocolate });
            ((List<IMenuItem>)FullMenu).Add(new FriedIceCream() { Flavor = Enums.IceCreamFlavor.Strawberry });


            ((List<IMenuItem>)FullMenu).Add(new FriedPie() { Flavor = Enums.PieFilling.Peach });
            ((List<IMenuItem>)FullMenu).Add(new FriedPie() { Flavor = Enums.PieFilling.Apple });
            ((List<IMenuItem>)FullMenu).Add(new FriedPie() { Flavor = Enums.PieFilling.Pecan });
            ((List<IMenuItem>)FullMenu).Add(new FriedPie() { Flavor = Enums.PieFilling.Cherry });
            ((List<IMenuItem>)FullMenu).Add(new FriedPie() { Flavor = Enums.PieFilling.Pineapple });
            ((List<IMenuItem>)FullMenu).Add(new FriedPie() { Flavor = Enums.PieFilling.Blueberry });
            ((List<IMenuItem>)FullMenu).Add(new FriedPie() { Flavor = Enums.PieFilling.Apricot });

            ((List<IMenuItem>)FullMenu).Add(new FriedTwinkie());

            ((List<IMenuItem>)FullMenu).Add(new FriedOreos() { Size = Enums.ServingSize.Small, Glazed = true });
            ((List<IMenuItem>)FullMenu).Add(new FriedOreos() { Size = Enums.ServingSize.Medium, Glazed = true });
            ((List<IMenuItem>)FullMenu).Add(new FriedOreos() { Size = Enums.ServingSize.Large, Glazed = true });
            ((List<IMenuItem>)FullMenu).Add(new FriedOreos() { Size = Enums.ServingSize.Small, Glazed = false });
            ((List<IMenuItem>)FullMenu).Add(new FriedOreos() { Size = Enums.ServingSize.Medium, Glazed = false });
            ((List<IMenuItem>)FullMenu).Add(new FriedOreos() { Size = Enums.ServingSize.Large, Glazed = false });

            ((List<IMenuItem>)FullMenu).Add(new FriedBananas() { Size = Enums.ServingSize.Small, Glazed = true });
            ((List<IMenuItem>)FullMenu).Add(new FriedBananas() { Size = Enums.ServingSize.Medium, Glazed = true });
            ((List<IMenuItem>)FullMenu).Add(new FriedBananas() { Size = Enums.ServingSize.Large, Glazed = true });
            ((List<IMenuItem>)FullMenu).Add(new FriedBananas() { Size = Enums.ServingSize.Small, Glazed = false });
            ((List<IMenuItem>)FullMenu).Add(new FriedBananas() { Size = Enums.ServingSize.Medium, Glazed = false });
            ((List<IMenuItem>)FullMenu).Add(new FriedBananas() { Size = Enums.ServingSize.Large, Glazed = false });

            ((List<IMenuItem>)FullMenu).Add(new FriedCheesecake() { Size = Enums.ServingSize.Small, Glazed = true });
            ((List<IMenuItem>)FullMenu).Add(new FriedCheesecake() { Size = Enums.ServingSize.Medium, Glazed = true });
            ((List<IMenuItem>)FullMenu).Add(new FriedCheesecake() { Size = Enums.ServingSize.Large, Glazed = true });
            ((List<IMenuItem>)FullMenu).Add(new FriedCheesecake() { Size = Enums.ServingSize.Small, Glazed = false });
            ((List<IMenuItem>)FullMenu).Add(new FriedCheesecake() { Size = Enums.ServingSize.Medium, Glazed = false });
            ((List<IMenuItem>)FullMenu).Add(new FriedCheesecake() { Size = Enums.ServingSize.Large, Glazed = false });

            ((List<IMenuItem>)FullMenu).Add(new AppleFritters() { Size = Enums.ServingSize.Small, Glazed = true });
            ((List<IMenuItem>)FullMenu).Add(new AppleFritters() { Size = Enums.ServingSize.Medium, Glazed = true });
            ((List<IMenuItem>)FullMenu).Add(new AppleFritters() { Size = Enums.ServingSize.Large, Glazed = true });
            ((List<IMenuItem>)FullMenu).Add(new AppleFritters() { Size = Enums.ServingSize.Small, Glazed = false });
            ((List<IMenuItem>)FullMenu).Add(new AppleFritters() { Size = Enums.ServingSize.Medium, Glazed = false });
            ((List<IMenuItem>)FullMenu).Add(new AppleFritters() { Size = Enums.ServingSize.Large, Glazed = false });

            ((List<IMenuItem>)FullMenu).Add(new PopperPlatter() { Size = Enums.ServingSize.Small, Glazed = true });
            ((List<IMenuItem>)FullMenu).Add(new PopperPlatter() { Size = Enums.ServingSize.Medium, Glazed = true });
            ((List<IMenuItem>)FullMenu).Add(new PopperPlatter() { Size = Enums.ServingSize.Large, Glazed = true });
            ((List<IMenuItem>)FullMenu).Add(new PopperPlatter() { Size = Enums.ServingSize.Small, Glazed = false });
            ((List<IMenuItem>)FullMenu).Add(new PopperPlatter() { Size = Enums.ServingSize.Medium, Glazed = false });
            ((List<IMenuItem>)FullMenu).Add(new PopperPlatter() { Size = Enums.ServingSize.Large, Glazed = false });
        }

    }
}
