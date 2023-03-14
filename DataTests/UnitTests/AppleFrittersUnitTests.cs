using System;
using Xunit;
using FriedPiper.Data.MenuItems;
using FriedPiper.Data.Enums;
using System.ComponentModel;

namespace DataTests.UnitTests
{
    /// <summary>
    /// unit tests for the apple fritter class
    /// </summary>
    public class AppleFrittersUnitTests
    {
        /// <summary>
        /// checks if the name is correct
        /// </summary>
        /// <param name="size">The size of the apple fritter</param>
        /// <param name="str">The string returned</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Apple Fritters")]
        [InlineData(ServingSize.Medium, "Medium Apple Fritters")]
        [InlineData(ServingSize.Large, "Large Apple Fritters")]
        public void ShouldBeNamedCorrectly(ServingSize size, string str)
        {
            AppleFritters fritter = new AppleFritters();
            fritter.Size = size;
            Assert.Equal(str, fritter.Name);
        }

        /// <summary>
        /// Tests if the size property works correctly
        /// </summary>
        /// <param name="size">THe size of the popper menu items</param>
        /// <param name="price">The price to check</param>
        [Theory]
        [InlineData(ServingSize.Small, 3.00)]
        [InlineData(ServingSize.Medium, 4.00)]
        [InlineData(ServingSize.Large, 5.00)]

        public void ShouldHaveCorrectPrice(ServingSize size, decimal price)
        {
            var appleFritters = new AppleFritters();
            appleFritters.Size = size;
            Assert.Equal(price, appleFritters.Price);
        }

        /// <summary>
        /// checks if the apple fritter should be glazed
        /// </summary>
        [Fact]
        public void ShouldBeGlazedByDefault()
        {
            var appleFritters = new AppleFritters();
            Assert.True(appleFritters.Glazed);
        }

        /// <summary>
        /// checls if you can change if its glazed
        /// </summary>
        /// <param name="glazed">whether of not its glazed</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldBeAbleToSetGlazed(bool glazed)
        {
            var appleFritters = new AppleFritters();
            appleFritters.Glazed = glazed;
            Assert.Equal(glazed, appleFritters.Glazed);
        }

        /// <summary>
        /// checks if the calories are correct
        /// </summary>
        /// <param name="size"> The size of the popper</param>
        /// <param name="glazed">sets if it is glazed</param>
        /// <param name="calories">the amount of calories, depending if its glazed</param>
        [Theory]
        [InlineData(ServingSize.Small, true, 370)]
        [InlineData(ServingSize.Medium, true, 490)]
        [InlineData(ServingSize.Large, true, 610)]
        [InlineData(ServingSize.Small, false, 240)]
        [InlineData(ServingSize.Medium, false, 360)]
        [InlineData(ServingSize.Large, false, 480)]
        public void ShouldHaveCorrectCalories(ServingSize size, bool glazed, uint calories)
        {
            var appleFritters = new AppleFritters();
            appleFritters.Size = size;
            appleFritters.Glazed = glazed;
            Assert.Equal(calories, appleFritters.Calories);
        }

        /// <summary>
        /// Checks to make sure fritters implements IMenuItems
        /// </summary>
        [Fact]
        public void ShouldImplementIMenuItem()
        {
            AppleFritters fritters = new AppleFritters();
            Assert.IsAssignableFrom<IMenuItem>(fritters);
        }

        /// <summary>
        /// Checks to make sure fritters is extended from the popper class
        /// </summary>
        [Fact]
        public void ShouldExtendPopper()
        {
            AppleFritters fritters = new AppleFritters();
            Assert.IsAssignableFrom<Popper>(fritters);
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
        public void ChangingSizeShouldNotifyOfChange(ServingSize size,  string propertyName)
        {
            var appleFritter = new AppleFritters();
            Assert.PropertyChanged(appleFritter, propertyName, () => {
                appleFritter.Size = size;
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
            var appleFritter = new AppleFritters();
            Assert.PropertyChanged(appleFritter, propertyName, () => {
                appleFritter.Glazed = glazed;
            });
        }

        /// <summary>
        /// tests if it has INotifyChanged interface
        /// </summary>
        [Fact]
        public void AppleFrittersShouldImplementINotifyChanged()
        {
            var appleFritter = new AppleFritters();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(appleFritter);
        }


        /// <summary>
        /// checks if the toString is correct
        /// </summary>
        /// <param name="size">The size of the apple fritter</param>
        /// <param name="str">The string returned</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Apple Fritters")]
        [InlineData(ServingSize.Medium, "Medium Apple Fritters")]
        [InlineData(ServingSize.Large, "Large Apple Fritters")]
        public void ToStringShouldReturnExpectedValue(ServingSize size, string str)
        {
            AppleFritters fritter = new AppleFritters();
            fritter.Size = size;
            Assert.Equal(str, fritter.ToString());
        }
    }
}
