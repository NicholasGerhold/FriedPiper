using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Website.Pages;


namespace FriedPiper.DataTests.UnitTests
{
    /// <summary>
    /// contains all of the unit tests for the index model
    /// </summary>
    public class IndexUnitTests
    {
        /// <summary>
        /// Checks if a word filter works
        /// </summary>
        /// <param name="word"> the word to filter</param>
        /// <param name="wordsExpected">The amount of return words expected</param>
        /*
        [Theory]
        [InlineData("Twix", 1)]
        [InlineData("Platter", 447)]
        [InlineData("tt", 447)]
        [InlineData("exit", 0)]
        */
        /*
        //No Idea why this wont run, it doesnt even get to any of the debug statments on the first line
        [Fact]
        public void ShouldFilterWithWords()
        {
            IndexModel page = new IndexModel();
            page.SearchTerms = "tt";
            page.OnGet();
            Assert.Equal(447, page.Items.Count());
        }
        */
        
    }
}
