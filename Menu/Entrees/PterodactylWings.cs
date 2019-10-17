using System;
using System.Collections.Generic;
using System.Text;

/* PterodactylWings.cs
 * Author: Ethan Nguyen
 */

namespace DinoDiner.Menu
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
        /// Gets an array of special instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> specs = new List<string>();

                return specs.ToArray();
            }
        }

        /// <summary>
        /// returns description of item
        /// </summary>
        public override string Description
        {
            get
            {
                return "Pterodactyl Wings";
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

        /// <summary>
        /// Returns name of the entree item
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }

    }
}
