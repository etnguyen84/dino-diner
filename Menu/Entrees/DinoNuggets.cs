using System;
using System.Collections.Generic;
using System.Text;

/* DinoNuggets.cs
 * Author: Ethan Nguyen
 */

namespace DinoDiner.Menu.Entrees
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

        /// Price of the menu item
        /// </summary>
        public double Price { get; set; }



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
        }
    }
}
