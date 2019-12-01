using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        /// <summary>
        /// Menu variable for an instance of a menu to be in the html file
        /// </summary>
        public Menu _menu { get; private set; } = new Menu();

        /// <summary>
        /// search string
        /// </summary>
        [BindProperty]
        public string search { get; set; }

        /// <summary>
        /// menu category filter
        /// </summary>
        [BindProperty]
        public List<string> category { get; set; } = new List<string>();

        /// <summary>
        /// min price filter
        /// </summary>
        [BindProperty]
        public double minPrice { get; set; }

        /// <summary>
        /// max price filter
        /// </summary>
        [BindProperty]
        public double maxPrice { get; set; }

        /// <summary>
        /// list of excluded ingredients
        /// </summary>
        [BindProperty]
        public List<string> exclusions { get; set; } = new List<string>();

        /// <summary>
        /// Onget function, automatically generated
        /// </summary>
        public void OnGet()
        {
        }
    }
}