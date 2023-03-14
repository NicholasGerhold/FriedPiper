using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FriedPiper.Data;
using FriedPiper.Data.MenuItems;

namespace Website.Pages
{
    /// <summary>
    /// Class for the backend logic of the index page
    /// </summary>
    public class IndexModel : PageModel
    {
        /// <summary>
        /// ? came default
        /// </summary>
        private readonly ILogger<IndexModel> _logger;

        /// <summary>
        /// Stores the current Items
        /// </summary>
        public IEnumerable<IMenuItem> Items { get; set; }

        /// <summary>
        /// An array to hold the words to search for
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; }

        /// <summary>
        /// Holds the Category of treat to search for
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string[] Catergory { get; set; }

        /// <summary>
        /// The min price to search for
        /// </summary>
        public decimal? PriceMin { get; set; }

        /// <summary>
        /// THe max price to search for
        /// </summary>
        public decimal? PriceMax { get; set; }

        /// <summary>
        /// The min calories to search for
        /// </summary>
        public uint? CaloriesMin { get; set; }

        /// <summary>
        /// The max Calories to search for
        /// </summary>
        public uint? CaloriesMax { get; set; }

        ///<summary>
        ///Gets the posssible Categories
        /// </summary>
        public string[] PossibleCategories
        {
            get => new string[]
                {
                    "Treats",
                    "Poppers",
                    "Platters",
                };
        }

        public IndexModel()
        {
            //_logger = logger;
        }

        /// <summary>
        /// on get
        /// </summary>
        public void OnGet()
        {
            string temp = Request.Query["PriceMin"];
            if (temp != null && String.Compare(temp, "") != 0)
            {
                PriceMin = decimal.Parse(temp);
            }
            else
            {
                PriceMin = null;
            }
            temp = Request.Query["PriceMax"];
            if (temp != null && String.Compare(temp, "") != 0)
            {
                PriceMax = decimal.Parse(temp);
            }
            else
            {
                PriceMax = null;
            }
            temp = Request.Query["CaloriesMin"];
            if (temp != null && String.Compare(temp, "") != 0)
            {
                CaloriesMin = uint.Parse(temp);
            }
            else
            {
                CaloriesMin = null;
            }
            temp = Request.Query["CaloriesMax"];
            if (temp != null && String.Compare(temp, "") != 0)
            {
                CaloriesMax = uint.Parse(temp);
            }
            else
            {
                CaloriesMax = null;
            }

            Items = Menu.FullMenu;
            if (SearchTerms != null)
            {
                Items = Items.Where(item => item.Name != null &&
                item.Name.Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));
            }
            if (Catergory != null && Catergory.Length != 0)
            {
                List<IMenuItem> list = new List<IMenuItem>();
                if (Catergory.Contains("Treats"))
                {
                    list.AddRange(Items.Where(item => item.Name != null &&
                        item is ITreat)
                    );
                }
                if (Catergory.Contains("Poppers"))
                {
                    list.AddRange(Items.Where(item => item.Name != null &&
                        item is Popper)
                    );
                }
                if (Catergory.Contains("Platter"))
                {
                    list.AddRange(Items.Where(item => item.Name != null &&
                        item is IPlatter)
                    );
                }
                Items = new List<IMenuItem>(list);
            }
            if (PriceMax == null && PriceMin == null) temp = "";
            else
            {
                if (PriceMax == null)
                {
                    Items = Items.Where(item =>
                    item.Price >= PriceMin
                    );
                }
                else if (PriceMin == null)
                {
                    Items = Items.Where(item =>
                    item.Price <= PriceMax
                    );
                }
                else
                {
                    Items = Items.Where(item =>
                    item.Price >= PriceMin &&
                    item.Price <= PriceMax
                    );
                }

            }
            if (CaloriesMax == null && CaloriesMin == null) temp = "";
            else
            {
                if (CaloriesMax == null)
                {
                    Items = Items.Where(item =>
                    item.Calories >= CaloriesMin
                    );
                }
                else if (PriceMin == null)
                {
                    Items = Items.Where(item =>
                    item.Calories <= CaloriesMax
                    );
                }
                else
                {
                    Items = Items.Where(item =>
                    item.Calories >= CaloriesMin &&
                    item.Calories <= CaloriesMax
                    );
                }

            }

        }
    }
}
