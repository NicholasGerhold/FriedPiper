using System;
using Xunit;
using FriedPiper.Data.MenuItems;
using FriedPiper.Data.Enums;
using System.ComponentModel;

namespace DataTests.UnitTests
{
    /// <summary>
    /// unit tests for the Fried Pie class
    /// </summary>
    public class FriedPieUnitTests
    {
        /// <summary>
        /// Tests if the naming section of the fried pies works
        /// </summary>
        /// <param name="filling">This is the test filling</param>
        /// <param name="str">This is the name that should be returned with that test filling</param>
        [Theory]
        [InlineData(PieFilling.Apple, "Fried Apple Pie")]
        [InlineData(PieFilling.Apricot, "Fried Apricot Pie")]
        [InlineData(PieFilling.Blueberry, "Fried Blueberry Pie")]
        [InlineData(PieFilling.Cherry, "Fried Cherry Pie")]
        [InlineData(PieFilling.Peach, "Fried Peach Pie")]
        [InlineData(PieFilling.Pecan, "Fried Pecan Pie")]
        [InlineData(PieFilling.Pineapple, "Fried Pineapple Pie")]
        public void ShouldBeNamedCorrectly(PieFilling filling, string str)
        {
            FriedPie friedPie = new FriedPie();
            friedPie.Flavor = filling;
            Assert.Equal(str, friedPie.Name);
        }

        /// <summary>
        /// This tests if the price works correctly for fried pies
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPrice()
        {
            FriedPie friedPie = new FriedPie();
            Assert.Equal(3.50m, friedPie.Price);
        }



        /// <summary>
        /// This checks if the calories for each pie are correct
        /// </summary>
        /// <param name="filling">the filling of pie to check</param>
        /// <param name="calories">The amount of calories a pie of that type should have</param>
        [Theory]
        [InlineData(PieFilling.Apple, 289)]
        [InlineData(PieFilling.Apricot, 314)]
        [InlineData(PieFilling.Blueberry, 314)]
        [InlineData(PieFilling.Cherry, 287)]
        [InlineData(PieFilling.Peach, 304)]
        [InlineData(PieFilling.Pecan, 314)]
        [InlineData(PieFilling.Pineapple, 302)]

        public void ShouldHaveCorrectCalories(PieFilling filling, uint calories)
        {
            FriedPie friedPie = new FriedPie();
            friedPie.Flavor = filling;
            Assert.Equal(calories, friedPie.Calories);
        }

        /// <summary>
        /// Checks to make sure fried pie implements IMenuItems
        /// </summary>
        [Fact]
        public void ShouldImplementIMenuItem()
        {
            FriedPie friedPie = new FriedPie();
            Assert.IsAssignableFrom<IMenuItem>(friedPie);
        }

        /// <summary>
        /// This checks to make sure you can set each pie filling
        /// </summary>
        /// <param name="flav">The filling to put in the pie class</param>
        /// <param name="filling">The filling to check</param>
        [Theory]
        [InlineData(PieFilling.Apple, PieFilling.Apple)]
        [InlineData(PieFilling.Apricot, PieFilling.Apricot)]
        [InlineData(PieFilling.Blueberry, PieFilling.Blueberry)]
        [InlineData(PieFilling.Cherry, PieFilling.Cherry)]
        [InlineData(PieFilling.Peach, PieFilling.Peach)]
        [InlineData(PieFilling.Pecan, PieFilling.Pecan)]
        [InlineData(PieFilling.Pineapple, PieFilling.Pineapple)]
        public void ShouldBeAbleToSetPieFilling(PieFilling flav, PieFilling filling)
        {
            FriedPie friedPie = new FriedPie();
            friedPie.Flavor = flav;
            Assert.Equal(filling, friedPie.Flavor);
        }


        /// <summary>
        /// unit test testing if the property changed works correctly
        /// </summary>
        /// <param name="flavor">the flavor to test the pie with</param>
        /// <param name="propertyName">the name of the property to test</param>
        [Theory]
        [InlineData(PieFilling.Peach, "Flavor")]
        [InlineData(PieFilling.Apricot, "Flavor")]
        [InlineData(PieFilling.Pineapple, "Flavor")]
        [InlineData(PieFilling.Blueberry, "Flavor")]
        [InlineData(PieFilling.Apple, "Flavor")]
        [InlineData(PieFilling.Pecan, "Flavor")]
        [InlineData(PieFilling.Peach, "Calories")]
        [InlineData(PieFilling.Apricot, "Calories")]
        [InlineData(PieFilling.Pineapple, "Calories")]
        [InlineData(PieFilling.Blueberry, "Calories")]
        [InlineData(PieFilling.Apple, "Calories")]
        [InlineData(PieFilling.Pecan, "Calories")]
        [InlineData(PieFilling.Peach, "Name")]
        [InlineData(PieFilling.Apricot, "Name")]
        [InlineData(PieFilling.Pineapple, "Name")]
        [InlineData(PieFilling.Blueberry, "Name")]
        [InlineData(PieFilling.Apple, "Name")]
        [InlineData(PieFilling.Pecan, "Name")]
        public void ChangingFlavorShouldNotifyOfChange(PieFilling flavor, string propertyName)
        {
            var pie = new FriedPie();
            Assert.PropertyChanged(pie, propertyName, () => {
                pie.Flavor = flavor;
            });
        }

        /// <summary>
        /// tests if it has INotifyChanged interface
        /// </summary>
        [Fact]
        public void FriedPieShouldImplementINotifyChanged()
        {
            var friedPie= new FriedPie();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(friedPie);
        }

        /// <summary>
        /// Tests if the ToString of the fried pies works
        /// </summary>
        /// <param name="filling">This is the test filling</param>
        /// <param name="str">This is the name that should be returned with that test filling</param>
        [Theory]
        [InlineData(PieFilling.Apple, "Fried Apple Pie")]
        [InlineData(PieFilling.Apricot, "Fried Apricot Pie")]
        [InlineData(PieFilling.Blueberry, "Fried Blueberry Pie")]
        [InlineData(PieFilling.Cherry, "Fried Cherry Pie")]
        [InlineData(PieFilling.Peach, "Fried Peach Pie")]
        [InlineData(PieFilling.Pecan, "Fried Pecan Pie")]
        [InlineData(PieFilling.Pineapple, "Fried Pineapple Pie")]
        public void ToStringShouldReturnExpectedValue(PieFilling filling, string str)
        {
            FriedPie friedPie = new FriedPie();
            friedPie.Flavor = filling;
            Assert.Equal(str, friedPie.ToString());
        }
    }
}
