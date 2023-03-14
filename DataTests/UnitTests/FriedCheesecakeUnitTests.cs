using System;
using Xunit;
using FriedPiper.Data.MenuItems;
using FriedPiper.Data.Enums;
using System.ComponentModel;

namespace DataTests.UnitTests
{
    /// <summary>
    /// unit tests for the Fried Cheesecake class
    /// </summary>
    public class FriedCheesecakeUnitTests
    {
        /// <summary>
        /// checks if the name is correct
        /// </summary>
        /// <param name="size">The size of the fried Cheesecake</param>
        /// <param name="str">The string returned</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Fried Cheesecake")]
        [InlineData(ServingSize.Medium, "Medium Fried Cheesecake")]
        [InlineData(ServingSize.Large, "Large Fried Cheesecake")]
        public void ShouldBeNamedCorrectly(ServingSize size, string str)
        {
            FriedCheesecake friedCheesecake = new FriedCheesecake();
            friedCheesecake.Size = size;
            Assert.Equal(str, friedCheesecake.Name);
        }

        /// <summary>
        /// Tests if the size property works correctly
        /// </summary>
        /// <param name="size">THe size of the Fried Cheesecake</param>
        /// <param name="price">The price to check</param>
        [Theory]
        [InlineData(ServingSize.Small, 3.75)]
        [InlineData(ServingSize.Medium, 4.50)]
        [InlineData(ServingSize.Large, 5.25)]

        public void ShouldHaveCorrectPrice(ServingSize size, decimal price)
        {
            FriedCheesecake friedCheesecake = new FriedCheesecake();
            friedCheesecake.Size = size;
            Assert.Equal(price, friedCheesecake.Price);
        }

        /// <summary>
        /// checks if the Fried Cheesecake should be glazed by defualt
        /// </summary>
        [Fact]
        public void ShouldBeGlazedByDefault()
        {
            FriedCheesecake friedCheesecake = new FriedCheesecake();
            Assert.True(friedCheesecake.Glazed);
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
            FriedCheesecake friedCheesecake = new FriedCheesecake();
            friedCheesecake.Glazed = glazed;
            Assert.Equal(glazed, friedCheesecake.Glazed);
        }

        /// <summary>
        /// checks if the calories are correct
        /// </summary>
        /// <param name="size"> The size of the popper</param>
        /// <param name="glazed">sets if it is glazed</param>
        /// <param name="calories">the amount of calories, depending if its glazed and its size</param>
        [Theory]
        [InlineData(ServingSize.Small, true, 310 + 130)]
        [InlineData(ServingSize.Medium, true, 425 + 130)]
        [InlineData(ServingSize.Large, true, 620 + 130)]
        [InlineData(ServingSize.Small, false, 310)]
        [InlineData(ServingSize.Medium, false, 425)]
        [InlineData(ServingSize.Large, false, 620)]
        public void ShouldHaveCorrectCalories(ServingSize size, bool glazed, uint calories)
        {
            FriedCheesecake friedCheesecake = new FriedCheesecake();
            friedCheesecake.Size = size;
            friedCheesecake.Glazed = glazed;
            Assert.Equal(calories, friedCheesecake.Calories);
        }

        /// <summary>
        /// Checks to make sure Fried Cheesecake implements IMenuItems
        /// </summary>
        [Fact]
        public void ShouldImplementIMenuItem()
        {
            FriedCheesecake friedCheesecake = new FriedCheesecake();
            Assert.IsAssignableFrom<IMenuItem>(friedCheesecake);
        }

        /// <summary>
        /// Checks to make sure fried Cheesecake is extended from the popper class
        /// </summary>
        [Fact]
        public void ShouldExtendPopper()
        {
            FriedCheesecake friedCheesecake = new FriedCheesecake();
            Assert.IsAssignableFrom<Popper>(friedCheesecake);
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
            var friedCheesecake= new FriedCheesecake();
            Assert.PropertyChanged(friedCheesecake, propertyName, () => {
                friedCheesecake.Size = size;
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
            var friedCheesecake= new FriedCheesecake();
            Assert.PropertyChanged(friedCheesecake, propertyName, () => {
                friedCheesecake.Glazed = glazed;
            });
        }

        /// <summary>
        /// tests if it has INotifyChanged interface
        /// </summary>
        [Fact]
        public void FriedCheesecakeShouldImplementINotifyChanged()
        {
            var friedCheesecake= new FriedCheesecake();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(friedCheesecake);
        }

        /// <summary>
        /// checks if the ToString is correct
        /// </summary>
        /// <param name="size">The size of the fried Cheesecake</param>
        /// <param name="str">The string returned</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Fried Cheesecake")]
        [InlineData(ServingSize.Medium, "Medium Fried Cheesecake")]
        [InlineData(ServingSize.Large, "Large Fried Cheesecake")]
        public void ToStringShouldReturnExpectedValue(ServingSize size, string str)
        {
            FriedCheesecake friedCheesecake = new FriedCheesecake();
            friedCheesecake.Size = size;
            Assert.Equal(str, friedCheesecake.ToString());
        }
    }
}
