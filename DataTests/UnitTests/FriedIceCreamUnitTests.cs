using System;
using Xunit;
using FriedPiper.Data.MenuItems;
using FriedPiper.Data.Enums;
using System.ComponentModel;

namespace DataTests.UnitTests
{
    /// <summary>
    /// unit tests for the class
    /// </summary>
    public class FriedIceCreamUnitTests
    {
        /// <summary>
        /// Tests if the naming section of the fried Ice Cream works
        /// </summary>
        /// <param name="flavor">This is the test Flavor</param>
        /// <param name="str">This is the name that should be returned with that test filling</param>
        [Theory]
        [InlineData(IceCreamFlavor.Vanilla, "Fried Vanilla Ice Cream")]
        [InlineData(IceCreamFlavor.Chocolate, "Fried Chocolate Ice Cream")]
        [InlineData(IceCreamFlavor.Strawberry, "Fried Strawberry Ice Cream")]
        public void ShouldBeNamedCorrectly(IceCreamFlavor flavor, string str)
        {
            FriedIceCream friedIceCream = new FriedIceCream();
            friedIceCream.Flavor = flavor;
            Assert.Equal(str, friedIceCream.Name);
        }

        /// <summary>
        /// This tests if the price works correctly for fried ice cream
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPrice()
        {
            FriedPie friedPie = new FriedPie();
            Assert.Equal(3.50m, friedPie.Price);
        }



        /// <summary>
        /// This checks if the calories for each flavor of ice cream are correct
        /// </summary>
        /// <param name="flavor">the flavor of ice creamto check</param>
        /// <param name="calories">The amount of calories a flavor of that type should have</param>
        [Theory]
        [InlineData(IceCreamFlavor.Vanilla, 355)]
        [InlineData(IceCreamFlavor.Chocolate, 353)]
        [InlineData(IceCreamFlavor.Strawberry, 321)]
        public void ShouldHaveCorrectCalories(IceCreamFlavor flavor, uint calories)
        {
            FriedIceCream friedIceCream = new FriedIceCream();
            friedIceCream.Flavor = flavor;
            Assert.Equal(calories, friedIceCream.Calories);
        }

        /// <summary>
        /// Checks to make sure fried ice cream implements IMenuItems
        /// </summary>
        [Fact]
        public void ShouldImplementIMenuItem()
        {
            FriedIceCream friedIceCream = new FriedIceCream();
            Assert.IsAssignableFrom<IMenuItem>(friedIceCream);
        }

        /// <summary>
        /// This checks to make sure you can set each ice cream flavor
        /// </summary>
        /// <param name="flavor">The filling to put in the pie class</param>
        /// <param name="filling">The filling to check</param>
        [Theory]
        [InlineData(IceCreamFlavor.Vanilla, IceCreamFlavor.Vanilla)]
        [InlineData(IceCreamFlavor.Chocolate, IceCreamFlavor.Chocolate)]
        [InlineData(IceCreamFlavor.Strawberry, IceCreamFlavor.Strawberry)]
        public void ShouldBeAbleToSetPieFilling(IceCreamFlavor flavor, IceCreamFlavor filling)
        {
            FriedIceCream friedIceCream = new FriedIceCream();
            friedIceCream.Flavor = flavor;
            Assert.Equal(filling, friedIceCream.Flavor);
        }

        /// <summary>
        /// Tests if INotifyPropertChanged works
        /// </summary>
        /// <param name="flavor">The flavor of ice cream</param>
        /// <param name="propertyName">the name of property to test</param>
        [Theory]
        [InlineData(IceCreamFlavor.Vanilla, "Flavor")]
        [InlineData(IceCreamFlavor.Chocolate, "Flavor")]
        [InlineData(IceCreamFlavor.Strawberry, "Flavor")]
        [InlineData(IceCreamFlavor.Vanilla, "Calories")]
        [InlineData(IceCreamFlavor.Chocolate, "Calories")]
        [InlineData(IceCreamFlavor.Strawberry, "Calories")]
        [InlineData(IceCreamFlavor.Vanilla, "Name")]
        [InlineData(IceCreamFlavor.Chocolate, "Name")]
        [InlineData(IceCreamFlavor.Strawberry, "Name")]
        public void ChangingFlavorShouldNotifyOfChange(IceCreamFlavor flavor, string propertyName)
        {
            var iceCream = new FriedIceCream();
            Assert.PropertyChanged(iceCream, propertyName, () => {
                iceCream.Flavor = flavor;
            });
        }

        /// <summary>
        /// tests if it has INotifyChanged interface
        /// </summary>
        [Fact]
        public void FriedIceCreamShouldImplementINotifyChanged()
        {
            var friedIceCream= new FriedIceCream();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(friedIceCream);
        }

        /// <summary>
        /// Tests if the ToString of the fried Ice Cream works
        /// </summary>
        /// <param name="flavor">This is the test Flavor</param>
        /// <param name="str">This is the name that should be returned with that test filling</param>
        [Theory]
        [InlineData(IceCreamFlavor.Vanilla, "Fried Vanilla Ice Cream")]
        [InlineData(IceCreamFlavor.Chocolate, "Fried Chocolate Ice Cream")]
        [InlineData(IceCreamFlavor.Strawberry, "Fried Strawberry Ice Cream")]
        public void ToStringShouldReturnExpectedValue(IceCreamFlavor flavor, string str)
        {
            FriedIceCream friedIceCream = new FriedIceCream();
            friedIceCream.Flavor = flavor;
            Assert.Equal(str, friedIceCream.ToString());
        }
    }
}
