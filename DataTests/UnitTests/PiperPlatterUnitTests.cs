using System;
using Xunit;
using FriedPiper.Data.MenuItems;
using FriedPiper.Data.Enums;
using System.ComponentModel;

namespace DataTests.UnitTests
{

    /// <summary>
    /// Holds the unit tests for the Piper platter
    /// </summary>
    public class PiperPlatterUnitTests
    {

        /// <summary>
        /// Checks if fried piper platter implements IMenuItem
        /// </summary>
        [Fact]
        public void ShouldImplementIMenuItem()
        {
            PiperPlatter piperPlatter = new PiperPlatter();
            Assert.IsAssignableFrom<IMenuItem>(piperPlatter);
        }

        /// <summary>
        /// checks if piper platter is named correctly 
        /// </summary>
        [Fact]
        public void ShouldBeNamedCorrectly()
        {
            PiperPlatter piperPlatter = new PiperPlatter();
            Assert.Equal("Piper Platter", piperPlatter.Name);
        }

        /// <summary>
        /// Checks to make sure the p[iper platter is priced correctly 
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPrice()
        {
            PiperPlatter piperPlatter = new PiperPlatter();
            Assert.Equal(12.00m, piperPlatter.Price);
        }

        /// <summary>
        /// Checks to make sure the piper platter has the correct amount of calories
        /// </summary>
        /// <param name="leftPie">flavor of the left pie</param>
        /// <param name="rightPie">flavor of the right pie</param>
        /// <param name="leftIce">flavor of right ice cream</param>
        /// <param name="rightIce">flavor of left ice cream</param>
        /// <param name="calories">The total calroies that it should be</param>
        [Theory]
        [InlineData(PieFilling.Apple,PieFilling.Apricot,IceCreamFlavor.Vanilla,IceCreamFlavor.Vanilla, 289 + 314+ 355 + 355)]
        [InlineData(PieFilling.Cherry, PieFilling.Blueberry, IceCreamFlavor.Chocolate, IceCreamFlavor.Strawberry, 287 + 314 + 353 + 321)]
        [InlineData(PieFilling.Cherry, PieFilling.Pecan, IceCreamFlavor.Vanilla, IceCreamFlavor.Strawberry, 287 + 314 + 355 + 321)]
        [InlineData(PieFilling.Apple, PieFilling.Pineapple, IceCreamFlavor.Vanilla, IceCreamFlavor.Chocolate, 289 + 302 + 355 + 353)]
        public void ShouldHaveCorrectCalories(PieFilling leftPie, PieFilling rightPie, IceCreamFlavor leftIce, IceCreamFlavor rightIce, uint calories)
        {
            PiperPlatter piperPlatter= new PiperPlatter();
            piperPlatter.LeftPie.Flavor = leftPie;
            piperPlatter.RightPie.Flavor = rightPie;
            piperPlatter.LeftIceCream.Flavor = leftIce;
            piperPlatter.RightIceCream.Flavor = rightIce;
            Assert.Equal(calories, piperPlatter.Calories);
        }

        /// <summary>
        /// Tests if Inotify works for left pie
        /// </summary>
        /// <param name="propertyName">the property to test</param>
        [Theory]
        [InlineData("LeftPie")]
        [InlineData("Calories")]
        public void ChangingLeftPieShouldNotifyOfChange(string propertyName)
        {
            var piperPlatter = new PiperPlatter();
            Assert.PropertyChanged(piperPlatter, propertyName, () => {
                piperPlatter.LeftPie = new FriedPie();
            });
        }

        /// <summary>
        /// Tests if Inotify works for right pie
        /// </summary>
        /// <param name="propertyName">the property to test</param>
        [Theory]
        [InlineData("RightPie")]
        [InlineData("Calories")]
        public void ChangingRightPieShouldNotifyOfChange(string propertyName)
        {
            var piperPlatter = new PiperPlatter();
            Assert.PropertyChanged(piperPlatter, propertyName, () => {
                piperPlatter.RightPie = new FriedPie();
            });
        }

        /// <summary>
        /// Tests if Inotify works for left ice cream
        /// </summary>
        /// <param name="propertyName">the property to test</param>
        [Theory]
        [InlineData("LeftIceCream")]
        [InlineData("Calories")]
        public void ChangingLeftIceCreamShouldNotifyOfChange(string propertyName)
        {
            var piperPlatter = new PiperPlatter();
            Assert.PropertyChanged(piperPlatter, propertyName, () => {
                piperPlatter.LeftIceCream = new FriedIceCream();
            });
        }

        /// <summary>
        /// Tests if Inotify works for right ice cream
        /// </summary>
        /// <param name="propertyName">the property to test</param>
        [Theory]
        [InlineData("RightIceCream")]
        [InlineData("Calories")]
        public void ChangingRightIceCreamShouldNotifyOfChange(string propertyName)
        {
            var piperPlatter = new PiperPlatter();
            Assert.PropertyChanged(piperPlatter, propertyName, () =>
            {
                piperPlatter.RightIceCream = new FriedIceCream();
            });
        }

        /// <summary>
        /// tests if it has INotifyChanged interface
        /// </summary>
        [Fact]
        public void PiperPlatterShouldImplementINotifyChanged()
        {
            var piperPlatter= new PiperPlatter();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(piperPlatter);
        }

        /// <summary>
        /// checks if the ToString works correctly
        /// </summary>
        [Fact]
        public void ToStringShouldReturnExpectedValue()
        {
            PiperPlatter piperPlatter = new PiperPlatter();
            Assert.Equal("Piper Platter", piperPlatter.ToString());
        }
    }
}
