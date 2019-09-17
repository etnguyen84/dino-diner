using System;
using System.Collections.Generic;
using System.Text;

/* VelociWrap.cs
 * Author: Ethan Nguyen
 */

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class for the VelociWrap item and choices of ingredients
    /// </summary>
    public class VelociWrap : Entree
    {
        /// <summary>
        /// bool on the presence of caesar dressing
        /// </summary>
        private bool dressing = true;

        /// <summary>
        /// bool on the presence of lettuce in the wrap
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// bool on the presence of cheese in the wrap
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// Creates a list of ingredients for the wrap, including tortilla, chicken, dressing, lettuce, and cheese
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for the velociwrap and sets price and calorie count
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// Removes dressing from the wrap
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }

        /// <summary>
        /// Removes lettuce from the wrap
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Removes cheese from the wrap
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
        }
    }
}
