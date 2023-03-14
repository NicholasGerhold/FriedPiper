using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FriedPiper.Data.MenuItems;
using FriedPiper.Data;
using System.ComponentModel;

namespace FriedPiper.DataTests.UnitTests
{
    /// <summary>
    /// contains the unit tests for the static menu class
    /// </summary>
    public class MenuUnitTest
    {
        /// <summary>
        /// Tests if the count is correct
        /// </summary>
        [Fact]
        public void ShouldHaveProperNumberOfItemsTreats()
        {
            Assert.Equal(1 + 3 + 7 + 5, Menu.Treats.Count());
        }

        /// <summary>
        /// Tests if the count is correct
        /// </summary>
        [Fact]
        public void ShouldHaveProperNumberOfItemsPoppers()
        {
            Assert.Equal(4 * 3 * 2, Menu.Poppers.Count());
        }

        /// <summary>
        /// Tests if the count is correct
        /// </summary>
        [Fact]
        public void ShouldHaveProperNumberOfItemsPlatters()
        {
            Assert.Equal(3 * 2 + 3 * 3 * 7 * 7, Menu.Platters.Count());
        }

        /// <summary>
        /// t
        /// </summary>
        [Fact]
        public void TreatsHaveCorrectName()
        {
            List<string> temp = new List<string>();
            temp.Add("Fried Twix");
            temp.Add("Fried MilkyWay");
            temp.Add("Fried ThreeMusketeers");
            temp.Add("Fried ButterFingers");
            temp.Add("Fried Snickers");

            temp.Add("Fried Vanilla Ice Cream");
            temp.Add("Fried Chocolate Ice Cream");
            temp.Add("Fried Strawberry Ice Cream");

            temp.Add("Fried Peach Pie");
            temp.Add("Fried Apple Pie");
            temp.Add("Fried Pecan Pie");
            temp.Add("Fried Cherry Pie");
            temp.Add("Fried Pineapple Pie");
            temp.Add("Fried Blueberry Pie");
            temp.Add("Fried Apricot Pie");

            temp.Add("Fried Twinky");

            int num = 0;

            foreach (IMenuItem item in Menu.Treats)
            {
                Assert.Equal(temp.ElementAt(num), item.Name);
                num++;
            }
        }

        /// <summary>
        ///checks if the name of the poppers are correct
        /// </summary>
        [Fact]
        public void PoppersHaveCorrectName()
        {
            List<string> temp = new List<string>();
            temp.Add("Small Fried Oreos");
            temp.Add("Medium Fried Oreos");
            temp.Add("Large Fried Oreos");
            temp.Add("Small Fried Oreos");
            temp.Add("Medium Fried Oreos");
            temp.Add("Large Fried Oreos");

            temp.Add("Small Fried Bananas");
            temp.Add("Medium Fried Bananas");
            temp.Add("Large Fried Bananas");
            temp.Add("Small Fried Bananas");
            temp.Add("Medium Fried Bananas");
            temp.Add("Large Fried Bananas");

            temp.Add("Small Fried Cheesecake");
            temp.Add("Medium Fried Cheesecake");
            temp.Add("Large Fried Cheesecake");
            temp.Add("Small Fried Cheesecake");
            temp.Add("Medium Fried Cheesecake");
            temp.Add("Large Fried Cheesecake");

            temp.Add("Small Apple Fritters");
            temp.Add("Medium Apple Fritters");
            temp.Add("Large Apple Fritters");
            temp.Add("Small Apple Fritters");
            temp.Add("Medium Apple Fritters");
            temp.Add("Large Apple Fritters");
            int num = 0;

            foreach (IMenuItem item in Menu.Poppers)
            {
                Assert.Equal(temp.ElementAt(num), item.Name);
                num++;
            }
        }

        /// <summary>
        /// This tests if the platters all have the right name
        /// </summary>
        [Fact]
        public void PlatterHasCorrectNames()
        {
            List<string> temp = new List<string>();
            temp.Add("Small Popper Platter");
            temp.Add("Medium Popper Platter");
            temp.Add("Large Popper Platter");
            temp.Add("Small Popper Platter");
            temp.Add("Medium Popper Platter");
            temp.Add("Large Popper Platter");

            int num = 0;
            foreach (IMenuItem item in Menu.Platters)
            {
                if (num < 6)
                {
                    Assert.Equal(temp.ElementAt(num), item.Name);
                } else
                {
                    Assert.Equal("Piper Platter", item.Name);
                }
                num++;
            }
        }

        /// <summary>
        /// Tests if the treats has the correct items
        /// </summary>
        [Fact]
        public void TreatsHasCorrectItems()
        {
            List<IMenuItem> temp = new List<IMenuItem>(Menu.Treats);

            Assert.Collection(temp,
                item => Assert.Contains("Fried Twix", item.Name),
                item => Assert.Contains("Fried MilkyWay", item.Name),
                item => Assert.Contains("Fried ThreeMusketeers", item.Name),
                item => Assert.Contains("Fried ButterFinger", item.Name),
                item => Assert.Contains("Fried Snickers", item.Name),
                item => Assert.Contains("Fried Vanilla Ice Cream", item.Name),
                item => Assert.Contains("Fried Chocolate Ice Cream", item.Name),
                item => Assert.Contains("Fried Strawberry Ice Cream", item.Name),
                item => Assert.Contains("Fried Peach Pie", item.Name),
                item => Assert.Contains("Fried Apple Pie", item.Name),
                item => Assert.Contains("Fried Pecan Pie", item.Name),
                item => Assert.Contains("Fried Cherry Pie", item.Name),
                item => Assert.Contains("Fried Pineapple Pie", item.Name),
                item => Assert.Contains("Fried Blueberry Pie", item.Name),
                item => Assert.Contains("Fried Apricot Pie", item.Name),
                item => Assert.Contains("Fried Twinky", item.Name)
                );
        }

        /// <summary>
        /// Tests if the Poppers has the correct items
        /// </summary>
        [Fact]
        public void PoppersHasCorrectItems()
        {
            List<IMenuItem> temp = new List<IMenuItem>(Menu.Poppers);

            Assert.Collection(temp,
                item => Assert.Contains("Small Fried Oreos", item.Name),
                item => Assert.Contains("Medium Fried Oreos", item.Name),
                item => Assert.Contains("Large Fried Oreos", item.Name),
                item => Assert.Contains("Small Fried Oreos", item.Name),
                item => Assert.Contains("Medium Fried Oreos", item.Name),
                item => Assert.Contains("Large Fried Oreos", item.Name),
                item => Assert.Contains("Small Fried Bananas", item.Name),
                item => Assert.Contains("Medium Fried Bananas", item.Name),
                item => Assert.Contains("Large Fried Bananas", item.Name),
                item => Assert.Contains("Small Fried Bananas", item.Name),
                item => Assert.Contains("Medium Fried Bananas", item.Name),
                item => Assert.Contains("Large Fried Bananas", item.Name),
                item => Assert.Contains("Small Fried Cheesecake", item.Name),
                item => Assert.Contains("Medium Fried Cheesecake", item.Name),
                item => Assert.Contains("Large Fried Cheesecake", item.Name),
                item => Assert.Contains("Small Fried Cheesecake", item.Name),
                item => Assert.Contains("Medium Fried Cheesecake", item.Name),
                item => Assert.Contains("Large Fried Cheesecake", item.Name),
                item => Assert.Contains("Small Apple Fritters", item.Name),
                item => Assert.Contains("Medium Apple Fritters", item.Name),
                item => Assert.Contains("Large Apple Fritters", item.Name),
                item => Assert.Contains("Small Apple Fritters", item.Name),
                item => Assert.Contains("Medium Apple Fritters", item.Name),
                item => Assert.Contains("Large Apple Fritters", item.Name)
                );
        }
        /// <summary>
        /// Tests if the Platters has the correct items
        /// </summary>
        [Fact]
        public void PlattersHasCorrectItems()
        {
            List<IMenuItem> temp = new List<IMenuItem>(Menu.Platters);

            Assert.Collection(temp,
                item => Assert.Contains("Small Popper Platter", item.Name),
                item => Assert.Contains("Medium Popper Platter", item.Name),
                item => Assert.Contains("Large Popper Platter", item.Name),
                item => Assert.Contains("Small Popper Platter", item.Name),
                item => Assert.Contains("Medium Popper Platter", item.Name),
                item => Assert.Contains("Large Popper Platter", item.Name),

                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name),
                item => Assert.Contains("Piper Platter", item.Name)
                );
        }
    }
}
