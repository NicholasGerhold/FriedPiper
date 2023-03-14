using System;
using Xunit;
using FriedPiper.PointOfSale;

namespace FriedPiper.PointOfSaleTests
{
    /// <summary>
    /// Tests for the model view
    /// </summary>
    public class ModelViewTests
    { 
        /// <summary>
        /// Tests if variable can be set: 
        /// </summary>
        /// <param name="number"> number of bills</param>
        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        [InlineData(10)]
        public void ShouldBeAbleToSetHundredCustomer(uint number)
        {
            var tempModel = new ModelView();
            tempModel.HundredCustomer = number;
            Assert.Equal(number, tempModel.HundredCustomer);
        }
        /// <summary>
        /// Tests if variable can be set: 
        /// </summary>
        /// <param name="number"> number of bills</param>
        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        [InlineData(10)]
        public void ShouldBeAbleToSetFiftyCustomer(uint number)
        {
            var tempModel = new ModelView();
            tempModel.FiftyCustomer = number;
            Assert.Equal(number, tempModel.FiftyCustomer);
        }
        /// <summary>
        /// Tests if variable can be set: 
        /// </summary>
        /// <param name="number"> number of bills</param>
        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        [InlineData(10)]
        public void ShouldBeAbleToSetTwentiesCustomer(uint number)
        {
            var tempModel = new ModelView();
            tempModel.TwentyCustomer = number;
            Assert.Equal(number, tempModel.TwentyCustomer);
        }
        /// <summary>
        /// Tests if variable can be set: 
        /// </summary>
        /// <param name="number"> number of bills</param>
        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        [InlineData(10)]
        public void ShouldBeAbleToSetTenCustomer(uint number)
        {
            var tempModel = new ModelView();
            tempModel.TenCustomer = number;
            Assert.Equal(number, tempModel.TenCustomer);

        }
        /// <summary>
        /// Tests if variable can be set: 
        /// </summary>
        /// <param name="number"> number of bills</param>
        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        [InlineData(10)]
        public void ShouldBeAbleToSetFiveCustomer(uint number)
        {
            var tempModel = new ModelView();
            tempModel.FiveCustomer = number;
            Assert.Equal(number, tempModel.FiveCustomer);
        }
        /// <summary>
        /// Tests if variable can be set: 
        /// </summary>
        /// <param name="number"> number of bills</param>
        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        [InlineData(10)]
        public void ShouldBeAbleToSetTwoCustomer(uint number)
        {
            var tempModel = new ModelView();
            tempModel.TwoCustomer = number;
            Assert.Equal(number, tempModel.TwoCustomer);
        }
        /// <summary>
        /// Tests if variable can be set: 
        /// </summary>
        /// <param name="number"> number of bills</param>
        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        [InlineData(10)]
        public void ShouldBeAbleToSetOneCustomer(uint number)
        {
            var tempModel = new ModelView();
            tempModel.OneCustomer = number;
            Assert.Equal(number, tempModel.OneCustomer);
        }
        /// <summary>
        /// Tests if variable can be set: 
        /// </summary>
        /// <param name="number"> number of bills</param>
        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        [InlineData(10)]
        public void ShouldBeAbleToSetDollarCoinCustomer(uint number)
        {
            var tempModel = new ModelView();
            tempModel.DollarCoinCustomer = number;
            Assert.Equal(number, tempModel.DollarCoinCustomer);
        }
        /// <summary>
        /// Tests if variable can be set: 
        /// </summary>
        /// <param name="number"> number of bills</param>
        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        [InlineData(10)]
        public void ShouldBeAbleToSetHalfDollarCoinCustomer(uint number)
        {
            var tempModel = new ModelView();
            tempModel.HalfDollarCoinCustomer = number;
            Assert.Equal(number, tempModel.HalfDollarCoinCustomer);
        }
        /// <summary>
        /// Tests if variable can be set: 
        /// </summary>
        /// <param name="number"> number of bills</param>
        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        [InlineData(10)]
        public void ShouldBeAbleToSetQuarterCustomer(uint number)
        {
            var tempModel = new ModelView();
            tempModel.QuarterCustomer = number;
            Assert.Equal(number, tempModel.QuarterCustomer);
        }
        /// <summary>
        /// Tests if variable can be set: 
        /// </summary>
        /// <param name="number"> number of bills</param>
        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        [InlineData(10)]
        public void ShouldBeAbleToSetDimeCustomer(uint number)
        {
            var tempModel = new ModelView();
            tempModel.DimeCustomer = number;
            Assert.Equal(number, tempModel.DimeCustomer);
        }
        /// <summary>
        /// Tests if variable can be set: 
        /// </summary>
        /// <param name="number"> number of bills</param>
        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        [InlineData(10)]
        public void ShouldBeAbleToSetNickleCustomer(uint number)
        {
            var tempModel = new ModelView();
            tempModel.NicklesCustomer = number;
            Assert.Equal(number, tempModel.NicklesCustomer);
        }

        /// <summary>
        /// Tests if variable can be set: 
        /// </summary>
        /// <param name="number"> number of bills</param>
        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        [InlineData(10)]
        public void ShouldBeAbleToSetPennies(uint number)
        {
            var tempModel = new ModelView();
            tempModel.PenniesCustomer = number;
            Assert.Equal(number, tempModel.PenniesCustomer);
        }





                /// <summary>
        /// Tests if variable can be set: 
        /// </summary>
        /// <param name="number"> number of bills</param>
        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        [InlineData(10)]
        public void ShouldBeAbleToSetHundredChange(uint number)
        {
            var tempModel = new ModelView();
            tempModel.HundredChange= number;
            Assert.Equal(number, tempModel.HundredChange);
        }
        /// <summary>
        /// Tests if variable can be set: 
        /// </summary>
        /// <param name="number"> number of bills</param>
        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        [InlineData(10)]
        public void ShouldBeAbleToSetFiftyChange(uint number)
        {
            var tempModel = new ModelView();
            tempModel.FiftyChange = number;
            Assert.Equal(number, tempModel.FiftyChange);
        }
        /// <summary>
        /// Tests if variable can be set: 
        /// </summary>
        /// <param name="number"> number of bills</param>
        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        [InlineData(10)]
        public void ShouldBeAbleToSetTwentiesChange(uint number)
        {
            var tempModel = new ModelView();
            tempModel.TwentyChange = number;
            Assert.Equal(number, tempModel.TwentyChange);
        }
        /// <summary>
        /// Tests if variable can be set: 
        /// </summary>
        /// <param name="number"> number of bills</param>
        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        [InlineData(10)]
        public void ShouldBeAbleToSetTenChange(uint number)
        {
            var tempModel = new ModelView();
            tempModel.TenChange = number;
            Assert.Equal(number, tempModel.TenChange);

        }
        /// <summary>
        /// Tests if variable can be set: 
        /// </summary>
        /// <param name="number"> number of bills</param>
        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        [InlineData(10)]
        public void ShouldBeAbleToSetFiveChange(uint number)
        {
            var tempModel = new ModelView();
            tempModel.FiveChange = number;
            Assert.Equal(number, tempModel.FiveChange);
        }
        /// <summary>
        /// Tests if variable can be set: 
        /// </summary>
        /// <param name="number"> number of bills</param>
        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        [InlineData(10)]
        public void ShouldBeAbleToSetTwoChange(uint number)
        {
            var tempModel = new ModelView();
            tempModel.TwoChange = number;
            Assert.Equal(number, tempModel.TwoChange);
        }
        /// <summary>
        /// Tests if variable can be set: 
        /// </summary>
        /// <param name="number"> number of bills</param>
        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        [InlineData(10)]
        public void ShouldBeAbleToSetOneChange(uint number)
        {
            var tempModel = new ModelView();
            tempModel.OneChange = number;
            Assert.Equal(number, tempModel.OneChange);
        }
        /// <summary>
        /// Tests if variable can be set: 
        /// </summary>
        /// <param name="number"> number of bills</param>
        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        [InlineData(10)]
        public void ShouldBeAbleToSetDollarCoinChange(uint number)
        {
            var tempModel = new ModelView();
            tempModel.DollarCoinChange = number;
            Assert.Equal(number, tempModel.DollarCoinChange);
        }
        /// <summary>
        /// Tests if variable can be set: 
        /// </summary>
        /// <param name="number"> number of bills</param>
        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        [InlineData(10)]
        public void ShouldBeAbleToSetHalfDollarCoinChange(uint number)
        {
            var tempModel = new ModelView();
            tempModel.HalfDollarCoinChange = number;
            Assert.Equal(number, tempModel.HalfDollarCoinChange);
        }
        /// <summary>
        /// Tests if variable can be set: 
        /// </summary>
        /// <param name="number"> number of bills</param>
        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        [InlineData(10)]
        public void ShouldBeAbleToSetQuarterChange(uint number)
        {
            var tempModel = new ModelView();
            tempModel.QuarterChange = number;
            Assert.Equal(number, tempModel.QuarterChange);
        }
        /// <summary>
        /// Tests if variable can be set: 
        /// </summary>
        /// <param name="number"> number of bills</param>
        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        [InlineData(10)]
        public void ShouldBeAbleToSetDimeChange(uint number)
        {
            var tempModel = new ModelView();
            tempModel.DimeChange = number;
            Assert.Equal(number, tempModel.DimeChange);
        }
        /// <summary>
        /// Tests if variable can be set: 
        /// </summary>
        /// <param name="number"> number of bills</param>
        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        [InlineData(10)]
        public void ShouldBeAbleToSetNickleChange(uint number)
        {
            var tempModel = new ModelView();
            tempModel.NickleChange = number;
            Assert.Equal(number, tempModel.NickleChange);
        }

        /// <summary>
        /// Tests if variable can be set: 
        /// </summary>
        /// <param name="number"> number of bills</param>
        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        [InlineData(10)]
        public void ShouldBeAbleToSetPenniesChange(uint number)
        {
            var tempModel = new ModelView();
            tempModel.PennieChange = number;
            Assert.Equal(number, tempModel.PennieChange);
        }
    }
}
