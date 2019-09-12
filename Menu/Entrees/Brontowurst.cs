using System;
using System.Collections.Generic;
using System.Text;

/* Brontowurst.cs
 * Author: Ethan Nguyen
 */

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Brontowurst menu item class
    /// </summary>
    public class Brontowurst
    {
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        /// <summary>
        /// Creates list of ingredients for the dish
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {"Brautwurst"};
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");

                return ingredients;
            }
        }

        /// <summary>
        /// Constructs brontowurst item with set price and calories
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// Remove bun from item
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Remove peppers from item
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }

        /// <summary>
        /// Removes onion from item
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
        }

    }
}
