using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

/* DinoNuggets.cs
 * Author: Ethan Nguyen
 */

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the DinoNuggets menu item
    /// </summary>
    public class DinoNuggets: Entree
    {
        /// <summary>
        /// Number of chicken nuggets in the order
        /// </summary>
        private uint nuggets = 6;

        /// <summary>
        /// Creates a list of ingredients filled with chicken nuggets
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < nuggets; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
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
                uint n = nuggets - 6;
                if( n > 0)
                {
                    specs.Add(n + " Extra Nuggets");
                }
                return specs.ToArray();
            }
        }

        /// <summary>
        /// Constructor for DinoNugget item with a set price and calories
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * nuggets;
        }

        /// <summary>
        /// Adds a nugget to the ingredient list and increases price and calorie count
        /// </summary>
        public void AddNugget()
        {
            this.nuggets++;
            this.Ingredients.Add("Chicken Nugget");
            this.Price += .25;
            this.Calories += 59;
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Calories");
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ingredients");


        }

        /// <summary>
        /// Returns name of the entree item
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    }
}
