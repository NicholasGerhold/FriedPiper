using System;
using Xunit;
using FriedPiper.Data.MenuItems;
using FriedPiper.Data.Enums;
using System.ComponentModel;

namespace DataTests.UnitTests
{

    /// <summary>
    /// Holds the unit tests for the fried twinky class
    /// </summary>
    public class FriedTwinkieUnitTests
    {

        /// <summary>
        /// Checks if fried twinkie implements IMenuItem
        /// </summary>
        [Fact]
        public void ShouldImplementIMenuItem()
        {
            FriedTwinkie friedTwinky = new FriedTwinkie();
            Assert.IsAssignableFrom<IMenuItem>(friedTwinky);
        }

        /// <summary>
        /// checks if fried twinkie is named correctly 
        /// </summary>
        [Fact]
        public void ShouldBeNamedCorrectly()
        {

            FriedTwinkie friedTwinky = new FriedTwinkie();
            Assert.Equal("Fried Twinky", friedTwinky.Name);
        }

        /// <summary>
        /// Checks to make sure the twinky is priced correctly 2.25
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPrice()
        {
            FriedTwinkie friedTwinky = new FriedTwinkie();
            Assert.Equal(2.25m, friedTwinky.Price);
        }

        /// <summary>
        /// Checks to make sure the twinky have the correct calories 420
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCalories()
        {
            FriedTwinkie friedTwinky = new FriedTwinkie();
            Assert.Equal((uint)420, friedTwinky.Calories) ;
        }

        /// <summary>
        /// tests if it has INotifyChanged interface
        /// </summary>
        [Fact]
        public void FriedTwinkieShouldImplementINotifyChanged()
        {
            var friedTwinkie = new FriedTwinkie();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(friedTwinkie);
        }

        /// <summary>
        /// checks if the ToString Works correctly
        /// </summary>
        [Fact]
        public void ToStringShouldReturnExpectedValue()
        {

            FriedTwinkie friedTwinky = new FriedTwinkie();
            Assert.Equal("Fried Twinky", friedTwinky.ToString());
        }
    }
}
