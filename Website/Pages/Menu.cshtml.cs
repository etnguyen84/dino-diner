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
        public Menu _menu { get; private set; }

        /// <summary>
        /// Onget function, automatically generated
        /// </summary>
        public void OnGet()
        {
            _menu = new Menu();
        }
    }
}