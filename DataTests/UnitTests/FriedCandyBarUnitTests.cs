using System;
using Xunit;
using FriedPiper.Data.MenuItems;
using FriedPiper.Data.Enums;
using System.ComponentModel;

namespace DataTests.UnitTests
{
    /// <summary>
    /// unit tests for the fried candy bar class
    /// </summary>
    public class FriedCandyBarUnitTests
    {
        /// <summary>
        /// Tests if the naming section of the fried candy bars works
        /// </summary>
        /// <param name="type">This is the type of candybar to test</param>
        /// <param name="str">This is the name that should be returned with that test type</param>
        [Theory]
        [InlineData(CandyBar.ButterFingers, "Fried ButterFingers")]
        [InlineData(CandyBar.MilkyWay, "Fried MilkyWay")]
        [InlineData(CandyBar.Snickers, "Fried Snickers")]
        [InlineData(CandyBar.ThreeMusketeers, "Fried ThreeMusketeers")]
        [InlineData(CandyBar.Twix, "Fried Twix")]
        public void ShouldBeNamedCorrectly(CandyBar type, string str)
        {
            FriedCandyBar friedCandyBar = new FriedCandyBar();
            friedCandyBar.CandyBar = type;
            Assert.Equal(str, friedCandyBar.Name);
        }

        /// <summary>
        /// This tests if the price works correctly for fried candy bars
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPrice()
        {
            FriedCandyBar friedCandyBar = new FriedCandyBar();
            Assert.Equal(2.50m, friedCandyBar.Price);
        }



        /// <summary>
        /// This checks if the calories for each type of candybar are correct
        /// </summary>
        /// <param name="type">the type of candy bar to check</param>
        /// <param name="calories">The amount of calories a candybar of that type should have</param>
        [Theory]
        [InlineData(CandyBar.ButterFingers, 385)]
        [InlineData(CandyBar.MilkyWay, 213)]
        [InlineData(CandyBar.Snickers, 325)]
        [InlineData(CandyBar.ThreeMusketeers, 350)]
        [InlineData(CandyBar.Twix, 396)]
        public void ShouldHaveCorrectCalories(CandyBar type, uint calories)
        {
            FriedCandyBar friedCandyBar = new FriedCandyBar();
            friedCandyBar.CandyBar = type;
            Assert.Equal(calories, friedCandyBar.Calories);
        }

        /// <summary>
        /// Checks to make sure fried candy bar implements IMenuItems
        /// </summary>
        [Fact]
        public void ShouldImplementIMenuItem()
        {
            FriedCandyBar friedCandyBar = new FriedCandyBar();
            Assert.IsAssignableFrom<IMenuItem>(friedCandyBar);
        }

        /// <summary>
        /// This checks to make sure you can set each type of candy bar
        /// </summary>
        /// <param name="type">The type to put in the fried candy bar class</param>
        /// <param name="filling">The type to reference check to</param>
        [Theory]
        [InlineData(CandyBar.ButterFingers, CandyBar.ButterFingers)]
        [InlineData(CandyBar.MilkyWay, CandyBar.MilkyWay)]
        [InlineData(CandyBar.Snickers, CandyBar.Snickers)]
        [InlineData(CandyBar.ThreeMusketeers, CandyBar.ThreeMusketeers)]
        [InlineData(CandyBar.Twix, CandyBar.Twix)]
        public void ShouldBeAbleToSetPieFilling(CandyBar type, CandyBar filling)
        {
            FriedCandyBar friedCandyBar = new FriedCandyBar();
            friedCandyBar.CandyBar = type;
            Assert.Equal(filling, friedCandyBar.CandyBar);
        }


        /// <summary>
        /// tests if changing the candy bar flavor properly works
        /// </summary>
        /// <param name="flavor">the flavor to check</param>
        /// <param name="propertyName"> the name of property to check</param>
        [Theory]
        [InlineData(CandyBar.ButterFingers, "Calories")]
        [InlineData(CandyBar.MilkyWay, "Calories")]
        [InlineData(CandyBar.Snickers, "Calories")]
        [InlineData(CandyBar.ThreeMusketeers, "Calories")]
        [InlineData(CandyBar.Twix, "Calories")]
        [InlineData(CandyBar.ButterFingers, "Name")]
        [InlineData(CandyBar.MilkyWay, "Name")]
        [InlineData(CandyBar.Snickers, "Name")]
        [InlineData(CandyBar.ThreeMusketeers, "Name")]
        [InlineData(CandyBar.Twix, "Name")]
        [InlineData(CandyBar.ButterFingers, "CandyBar")]
        [InlineData(CandyBar.MilkyWay, "CandyBar")]
        [InlineData(CandyBar.Snickers, "CandyBar")]
        [InlineData(CandyBar.ThreeMusketeers, "CandyBar")]
        [InlineData(CandyBar.Twix, "CandyBar")]
        public void ChangingFlavorShouldNotifyOfChange(CandyBar flavor, string propertyName)
        {
            var candyBar = new FriedCandyBar();
            Assert.PropertyChanged(candyBar, propertyName, () =>
            {
                candyBar.CandyBar = flavor;
            });
        }

        /// <summary>
        /// tests if it has INotifyChanged interface
        /// </summary>
        [Fact]
        public void FriedCandyBarShouldImplementINotifyChanged()
        {
            var friedCandyBar= new FriedCandyBar();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(friedCandyBar);
        }

        /// <summary>
        /// Tests if the ToString of the fried candy bars works
        /// </summary>
        /// <param name="type">This is the type of candybar to test</param>
        /// <param name="str">This is the name that should be returned with that test type</param>
        [Theory]
        [InlineData(CandyBar.ButterFingers, "Fried ButterFingers")]
        [InlineData(CandyBar.MilkyWay, "Fried MilkyWay")]
        [InlineData(CandyBar.Snickers, "Fried Snickers")]
        [InlineData(CandyBar.ThreeMusketeers, "Fried ThreeMusketeers")]
        [InlineData(CandyBar.Twix, "Fried Twix")]
        public void ToStringShouldReturnExpectedValue(CandyBar type, string str)
        {
            FriedCandyBar friedCandyBar = new FriedCandyBar();
            friedCandyBar.CandyBar = type;
            Assert.Equal(str, friedCandyBar.ToString());
        }
    }
}
