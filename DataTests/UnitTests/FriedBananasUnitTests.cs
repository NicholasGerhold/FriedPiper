using System;
using Xunit;
using FriedPiper.Data.MenuItems;
using FriedPiper.Data.Enums;
using System.ComponentModel;

namespace DataTests.UnitTests
{
    /// <summary>
    /// unit tests for the Fried Bananas class
    /// </summary>
    public class FriedBananasUnitTests
    {
        /// <summary>
        /// checks if the name is correct
        /// </summary>
        /// <param name="size">The size of the fried Bananas</param>
        /// <param name="str">The string returned</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Fried Bananas")]
        [InlineData(ServingSize.Medium, "Medium Fried Bananas")]
        [InlineData(ServingSize.Large, "Large Fried Bananas")]
        public void ShouldBeNamedCorrectly(ServingSize size, string str)
        {
            FriedBananas friedBananas = new FriedBananas();
            friedBananas.Size = size;
            Assert.Equal(str, friedBananas.Name);
        }

        /// <summary>
        /// Tests if the size property works correctly
        /// </summary>
        /// <param name="size">THe size of the fried banana</param>
        /// <param name="price">The price to check</param>
        [Theory]
        [InlineData(ServingSize.Small, 3.75)]
        [InlineData(ServingSize.Medium, 4.50)]
        [InlineData(ServingSize.Large, 5.25)]

        public void ShouldHaveCorrectPrice(ServingSize size, decimal price)
        {
            FriedBananas friedBananas = new FriedBananas();
            friedBananas.Size = size;
            Assert.Equal(price, friedBananas.Price);
        }

        /// <summary>
        /// checks if the Fried bananas are  glazed by default
        /// </summary>
        [Fact]
        public void ShouldBeGlazedByDefault()
        {
            FriedBananas friedBananas = new FriedBananas();
            Assert.True(friedBananas.Glazed);
        }

        /// <summary>
        /// checks if you can change if its glazed
        /// </summary>
        /// <param name="glazed">whether of not its glazed</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldBeAbleToSetGlazed(bool glazed)
        {
            FriedBananas friedBananas = new FriedBananas();
            friedBananas.Glazed = glazed;
            Assert.Equal(glazed, friedBananas.Glazed);
        }

        /// <summary>
        /// checks if the calories are correct
        /// </summary>
        /// <param name="size"> The size of the fried bananas</param>
        /// <param name="glazed">sets if it is glazed</param>
        /// <param name="calories">the amount of calories, depending if its glazed and size</param>
        [Theory]
        [InlineData(ServingSize.Small, true, 160 + 130)]
        [InlineData(ServingSize.Medium, true, 240 + 130)]
        [InlineData(ServingSize.Large, true, 320 + 130)]
        [InlineData(ServingSize.Small, false, 160)]
        [InlineData(ServingSize.Medium, false, 240)]
        [InlineData(ServingSize.Large, false, 320)]
        public void ShouldHaveCorrectCalories(ServingSize size, bool glazed, uint calories)
        {
            FriedBananas friedBananas = new FriedBananas();
            friedBananas.Size = size;
            friedBananas.Glazed = glazed;
            Assert.Equal(calories, friedBananas.Calories);
        }

        /// <summary>
        /// Checks to make sure Fried Banans implements IMenuItems
        /// </summary>
        [Fact]
        public void ShouldImplementIMenuItem()
        {
            FriedBananas friedBananas = new FriedBananas();
            Assert.IsAssignableFrom<IMenuItem>(friedBananas);
        }

        /// <summary>
        /// Checks to make sure Fried Banans is extended from the popper class
        /// </summary>
        [Fact]
        public void ShouldExtendPopper()
        {
            FriedBananas friedBananas = new FriedBananas();
            Assert.IsAssignableFrom<Popper>(friedBananas);
        }

        /// <summary>
        /// Confirms that INotifyProperty changed works correctly
        /// </summary>
        /// <param name="size">the size of the popper</param>
        /// <param name="propertyName">the name of the property to test</param>
        [Theory]
        [InlineData(ServingSize.Small, "Calories")]
        [InlineData(ServingSize.Medium, "Calories")]
        [InlineData(ServingSize.Large, "Calories")]
        [InlineData(ServingSize.Small, "Price")]
        [InlineData(ServingSize.Medium, "Price")]
        [InlineData(ServingSize.Large, "Price")]
        [InlineData(ServingSize.Small, "Name")]
        [InlineData(ServingSize.Medium, "Name")]
        [InlineData(ServingSize.Large, "Name")]
        [InlineData(ServingSize.Small, "Size")]
        [InlineData(ServingSize.Medium, "Size")]
        [InlineData(ServingSize.Large, "Size")]
        public void ChangingSizeShouldNotifyOfChange(ServingSize size, string propertyName)
        {
            var friedBanana = new FriedBananas();
            Assert.PropertyChanged(friedBanana, propertyName, () => {
                friedBanana.Size = size;
            });
        }

        /// <summary>
        /// Confirms that INotifyProperty changed works correctly
        /// </summary>
        /// <param name="glazed">the glaze of the popper</param>
        /// <param name="propertyName">the name of the property to test</param>
        [Theory]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        [InlineData(true, "Glazed")]
        [InlineData(false, "Glazed")]
        public void ChangingGlazedShouldNotifyOfChange(bool glazed, string propertyName)
        {
            var friedBanana = new FriedBananas();
            Assert.PropertyChanged(friedBanana, propertyName, () => {
                friedBanana.Glazed = glazed;
            });
        }

        /// <summary>
        /// tests if it has INotifyChanged interface
        /// </summary>
        [Fact]
        public void FriedBananasShouldImplementINotifyChanged()
        {
            var friedBananas= new FriedBananas();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(friedBananas);
        }

        /// <summary>
        /// checks if the tostring is correct
        /// </summary>
        /// <param name="size">The size of the fried Bananas</param>
        /// <param name="str">The string returned</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Fried Bananas")]
        [InlineData(ServingSize.Medium, "Medium Fried Bananas")]
        [InlineData(ServingSize.Large, "Large Fried Bananas")]
        public void ToStringShouldReturnExpectedValue(ServingSize size, string str)
        {
            FriedBananas friedBananas = new FriedBananas();
            friedBananas.Size = size;
            Assert.Equal(str, friedBananas.ToString());
        }
    }
}
