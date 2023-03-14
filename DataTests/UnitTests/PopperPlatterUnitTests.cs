using System;
using Xunit;
using FriedPiper.Data.MenuItems;
using FriedPiper.Data.Enums;
using System.ComponentModel;

namespace DataTests.UnitTests
{

    /// <summary>
    /// Holds the unit tests for the popper platter
    /// </summary>
    public class PopperPlatterUnitTests
    {

        /// <summary>
        /// Checks if popper platter implements IMenuItem
        /// </summary>
        [Fact]
        public void ShouldImplementIMenuItem()
        {
            PopperPlatter popperPlatter = new PopperPlatter();
            Assert.IsAssignableFrom<IMenuItem>(popperPlatter);
        }

        /// <summary>
        /// Checks the name of the popper platter
        /// </summary>
        /// <param name="size">the size of the popper platter</param>
        /// <param name="str">the correct output string</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Popper Platter")]
        [InlineData(ServingSize.Medium, "Medium Popper Platter")]
        [InlineData(ServingSize.Large, "Large Popper Platter")]
        public void ShouldBeNamedCorrectly(ServingSize size, string str)
        {
            PopperPlatter popperPlatter = new PopperPlatter();
            popperPlatter.Size = size;
            Assert.Equal(str, popperPlatter.Name);
        }

        /// <summary>
        /// The price of the popper platter
        /// </summary>
        /// <param name="size">The size of the popper platter</param>
        /// <param name="price">the correct price of the popper platter</param>
        [Theory]
        [InlineData(ServingSize.Small, 12.00)]
        [InlineData(ServingSize.Medium, 16.00)]
        [InlineData(ServingSize.Large, 20.00)]
        public void ShouldHaveCorrectPrice(ServingSize size, decimal price)
        {
            PopperPlatter popperPlatter = new PopperPlatter();
            popperPlatter.Size = size;
            Assert.Equal(price, popperPlatter.Price);
        }

        /// <summary>
        /// The amount of calories for a popper platter
        /// </summary>
        /// <param name="size">the size of the popper platter</param>
        /// <param name="calories">the correct amount a popper platter should have </param>
        /// /// <param name="glazed">if the ppopper platter is glazed</param>
        [Theory]
        [InlineData(ServingSize.Small, true, 520 + 240 + 160 + 500 + 310)]
        [InlineData(ServingSize.Medium, true, 520 + 360 + 240 + 750 + 425)]
        [InlineData(ServingSize.Large, true, 520 + 480 + 320 + 1000 + 620)]
        [InlineData(ServingSize.Small, false,  240 + 160 + 500 + 310)]
        [InlineData(ServingSize.Medium, false,  360 + 240 + 750 + 425)]
        [InlineData(ServingSize.Large, false,  480 + 320 + 1000 + 620)]
        public void ShouldHaveCorrectCalories(ServingSize size, bool glazed, uint calories)
        {
            PopperPlatter popperPlatter = new PopperPlatter();
            popperPlatter.Size = size;
            popperPlatter.Glazed = glazed;
            Assert.Equal(calories, popperPlatter.Calories);
        }

        /// <summary>
        /// Checks if you are able to set the glaze of the popper platter
        /// </summary>
        /// <param name="glazed">if its glazed</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldBeAbleToSetGlazed(bool glazed)
        {
            PopperPlatter popperPlatter= new PopperPlatter();
            popperPlatter.Glazed = glazed;
            Assert.Equal(glazed, popperPlatter.Glazed);
        }

        /// <summary>
        /// checks if possible to set the size
        /// </summary>
        /// <param name="size">the size you want</param>
        [Theory]
        [InlineData(ServingSize.Small)]
        [InlineData(ServingSize.Medium)]
        [InlineData(ServingSize.Large)]
        public void ShouldBeAbleToSetSize(ServingSize size)
        {
            PopperPlatter popperPlatter = new PopperPlatter();
            popperPlatter.Size = size;
            Assert.Equal(size, popperPlatter.Size);
        }
        

        /// <summary>
        /// Checks if it sets the poppers to glazed when you set popper platter to glazed
        /// </summary>
        /// <param name="glazed">if its glazed</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void SettingGlazedShouldAlsoSetPopperGlazed(bool glazed)
        {
            PopperPlatter popperPlatter = new PopperPlatter();
            popperPlatter.Glazed = glazed;
            Assert.Equal(glazed, popperPlatter.AppleFritters.Glazed);
            Assert.Equal(glazed, popperPlatter.FriedBananas.Glazed);
            Assert.Equal(glazed, popperPlatter.FriedCheesecake.Glazed);
            Assert.Equal(glazed, popperPlatter.FriedOreos.Glazed);
        }

        /// <summary>
        /// checks if setting the size of the popper platter sets the size of the poppers
        /// </summary>
        /// <param name="size"> the size to set it to</param>
        [Theory]
        [InlineData(ServingSize.Small)]
        [InlineData(ServingSize.Medium)]
        [InlineData(ServingSize.Large)]
        public void SettingSizeShouldAlsoSetPopperSize(ServingSize size)
        {
            PopperPlatter popperPlatter = new PopperPlatter();
            popperPlatter.Size = size;
            Assert.Equal(size, popperPlatter.AppleFritters.Size);
            Assert.Equal(size, popperPlatter.FriedBananas.Size);
            Assert.Equal(size, popperPlatter.FriedCheesecake.Size);
            Assert.Equal(size, popperPlatter.FriedOreos.Size);
        }

        /// <summary>
        /// Tests if Inotify works for apple fritters
        /// </summary>
        /// <param name="propertyName">the property to test</param>
        [Theory]
        [InlineData("AppleFritters")]
        [InlineData("Calories")]
        public void ChangingAppleFrittersShouldNotifyOfChange(string propertyName)
        {
            var popperPlatter = new PopperPlatter();
            Assert.PropertyChanged(popperPlatter, propertyName, () => {
                popperPlatter.AppleFritters = new AppleFritters();
            });
        }

        /// <summary>
        /// Tests if Inotify works for rfried bananas
        /// </summary>
        /// <param name="propertyName">the property to test</param>
        [Theory]
        [InlineData("FriedBananas")]
        [InlineData("Calories")]
        public void ChangingFriedBananasShouldNotifyOfChange(string propertyName)
        {
            var popperPlatter = new PopperPlatter();
            Assert.PropertyChanged(popperPlatter, propertyName, () => {
                popperPlatter.FriedBananas = new FriedBananas();
            });
        }

        /// <summary>
        /// Tests if Inotify works for fried cheesecake
        /// </summary>
        /// <param name="propertyName">the property to test</param>
        [Theory]
        [InlineData("FriedCheesecake")]
        [InlineData("Calories")]
        public void ChangingFriedCheesecakeShouldNotifyOfChange(string propertyName)
        {
            var popperPlatter = new PopperPlatter();
            Assert.PropertyChanged(popperPlatter, propertyName, () => {
                popperPlatter.FriedCheesecake = new FriedCheesecake();
            });
        }

        /// <summary>
        /// Tests if Inotify works for fried oreos
        /// </summary>
        /// <param name="propertyName">the property to test</param>
        [Theory]
        [InlineData("FriedOreos")]
        [InlineData("Calories")]
        public void ChangingFriedOreosShouldNotifyOfChange(string propertyName)
        {
            var popperPlatter = new PopperPlatter();
            Assert.PropertyChanged(popperPlatter, propertyName, () => {
                popperPlatter.FriedOreos = new FriedOreos();
            });
        }

        /// <summary>
        /// Tests if Inotify works for right ice cream
        /// </summary>
        /// <param name="propertyName">the property to test</param>
        /// <param name="size">The size of poppers to test</param>
        [Theory]
        [InlineData(ServingSize.Small, "Name")]
        [InlineData(ServingSize.Medium, "Name")]
        [InlineData(ServingSize.Large, "Name")]
        [InlineData(ServingSize.Small, "Calories")]
        [InlineData(ServingSize.Medium, "Calories")]
        [InlineData(ServingSize.Large, "Calories")]
        [InlineData(ServingSize.Small, "Size")]
        [InlineData(ServingSize.Medium, "Size")]
        [InlineData(ServingSize.Large, "Size")]
        public void ChangingSizeShouldNotifyOfChange(ServingSize size, string propertyName)
        {
            var popperPlatter = new PopperPlatter();
            Assert.PropertyChanged(popperPlatter, propertyName, () => {
                popperPlatter.Size = size;
            });
        }

        /// <summary>
        /// tests if it has INotifyChanged interface
        /// </summary>
        [Fact]
        public void PopperPlatterShouldImplementINotifyChanged()
        {
            var popperPlatter= new PopperPlatter();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(popperPlatter);
        }

        /// <summary>
        /// Checks the ToString of the popper platter
        /// </summary>
        /// <param name="size">the size of the popper platter</param>
        /// <param name="str">the correct output string</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Popper Platter")]
        [InlineData(ServingSize.Medium, "Medium Popper Platter")]
        [InlineData(ServingSize.Large, "Large Popper Platter")]
        public void ToStringShouldReturnExpectedValue(ServingSize size, string str)
        {
            PopperPlatter popperPlatter = new PopperPlatter();
            popperPlatter.Size = size;
            Assert.Equal(str, popperPlatter.ToString());
        }
    }
}
