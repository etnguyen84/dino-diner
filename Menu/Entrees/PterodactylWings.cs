using System;
using System.Collections.Generic;
using System.Text;

/* PterodactylWings.cs
 * Author: Ethan Nguyen
 */

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class for the Pterodactyl Wings menu item
    /// </summary>
    public class PterodactylWings : Entree
    {

        /// <summary>
        /// Creates a list of ingredients that hold chicken and wing sauce for the wings
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for Pterodactyl Wings with a set price and calories
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

    }
}
