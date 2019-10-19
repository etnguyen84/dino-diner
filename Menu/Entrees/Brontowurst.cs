using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

/* Brontowurst.cs
 * Author: Ethan Nguyen
 */

namespace DinoDiner.Menu
{
    /// <summary>
    /// Brontowurst menu item class
    /// </summary>
    public class Brontowurst : Entree
    {
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

        /// <summary>
        /// Creates list of ingredients for the dish
        /// </summary>
        public override List<string> Ingredients
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
        /// Gets an array of special instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> specs = new List<string>();
                if (!bun) specs.Add("Hold Whole Wheat Bun");
                if (!peppers) specs.Add("Hold Peppers");
                if (!onions) specs.Add("Hold Onion");

                return specs.ToArray();
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
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ingredients");

        }

        /// <summary>
        /// Remove peppers from item
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ingredients");

        }

        /// <summary>
        /// Removes onion from item
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ingredients");

        }

        /// <summary>
        /// returns the entree item name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Brontowurst";
        }

    }
}
