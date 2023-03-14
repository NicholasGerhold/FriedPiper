using System;
using Xunit;
using FriedPiper.Data.MenuItems;
using FriedPiper.Data.Enums;
using System.ComponentModel;

namespace DataTests.UnitTests
{
    /// <summary>
    /// unit tests for the fired oreosclass
    /// </summary>
    public class FriedOreosUnitTests
    {
        /// <summary>
        /// checks if the name is correct
        /// </summary>
        /// <param name="size">The size of the fried oreos</param>
        /// <param name="str">The string returned</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Fried Oreos")]
        [InlineData(ServingSize.Medium, "Medium Fried Oreos")]
        [InlineData(ServingSize.Large, "Large Fried Oreos")]
        public void ShouldBeNamedCorrectly(ServingSize size, string str)
        {
            FriedOreos friedOreos = new FriedOreos();
            friedOreos.Size = size;
            Assert.Equal(str, friedOreos.Name);
        }

        /// <summary>
        /// Tests if the size property works correctly
        /// </summary>
        /// <param name="size">THe size of the fried oreos</param>
        /// <param name="price">The price to check</param>
        [Theory]
        [InlineData(ServingSize.Small, 3.75)]
        [InlineData(ServingSize.Medium, 4.50)]
        [InlineData(ServingSize.Large, 5.25)]

        public void ShouldHaveCorrectPrice(ServingSize size, decimal price)
        {
            FriedOreos friedOreos = new FriedOreos();
            friedOreos.Size = size;
            Assert.Equal(price, friedOreos.Price);
        }

        /// <summary>
        /// checks if the fried oreos are glazed by default
        /// </summary>
        [Fact]
        public void ShouldBeGlazedByDefault()
        {
            FriedOreos friedOreos = new FriedOreos();
            Assert.True(friedOreos.Glazed);
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
            FriedOreos friedOreos = new FriedOreos();
            friedOreos.Glazed = glazed;
            Assert.Equal(glazed, friedOreos.Glazed);
        }

        /// <summary>
        /// checks if the calories are correct
        /// </summary>
        /// <param name="size"> The size of the popper</param>
        /// <param name="glazed">sets if it is glazed</param>
        /// <param name="calories">the amount of calories, depending if its glazed</param>
        [Theory]
        [InlineData(ServingSize.Small, true, 500 + 130)]
        [InlineData(ServingSize.Medium, true, 750 + 130)]
        [InlineData(ServingSize.Large, true, 1000 + 130)]
        [InlineData(ServingSize.Small, false, 500)]
        [InlineData(ServingSize.Medium, false, 750)]
        [InlineData(ServingSize.Large, false, 1000)]
        public void ShouldHaveCorrectCalories(ServingSize size, bool glazed, uint calories)
        {
            FriedOreos friedOreos = new FriedOreos();
            friedOreos.Size = size;
            friedOreos.Glazed = glazed;
            Assert.Equal(calories, friedOreos.Calories);
        }

        /// <summary>
        /// Checks to make sure fried oreos implements IMenuItems
        /// </summary>
        [Fact]
        public void ShouldImplementIMenuItem()
        {
            FriedOreos friedOreos = new FriedOreos();
            Assert.IsAssignableFrom<IMenuItem>(friedOreos);
        }

        /// <summary>
        /// Checks to make sure fried oreos is extended from the popper class
        /// </summary>
        [Fact]
        public void ShouldExtendPopper()
        {
            FriedOreos friedOreos = new FriedOreos();
            Assert.IsAssignableFrom<Popper>(friedOreos);
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
            var friedOreos= new FriedOreos();
            Assert.PropertyChanged(friedOreos, propertyName, () => {
                friedOreos.Size = size;
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
            var friedOreos= new FriedOreos();
            Assert.PropertyChanged(friedOreos, propertyName, () => {
                friedOreos.Glazed = glazed;
            });
        }

        /// <summary>
        /// tests if it has INotifyChanged interface
        /// </summary>
        [Fact]
        public void FriedOreosShouldImplementINotifyChanged()
        {
            var friedOreos= new FriedOreos();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(friedOreos);
        }

        /// <summary>
        /// checks if the ToString is correct
        /// </summary>
        /// <param name="size">The size of the fried oreos</param>
        /// <param name="str">The string returned</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Fried Oreos")]
        [InlineData(ServingSize.Medium, "Medium Fried Oreos")]
        [InlineData(ServingSize.Large, "Large Fried Oreos")]
        public void ToStringShouldReturnExpectedValue(ServingSize size, string str)
        {
            FriedOreos friedOreos = new FriedOreos();
            friedOreos.Size = size;
            Assert.Equal(str, friedOreos.ToString());
        }
    }
}
