using System;
using System.Collections.Generic;
using System.Text;
/* MezzorellaSticks.cs
 * Author: Ethan Nguyen
 */
namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Class for the mezzorella sticks side dish
    /// </summary>
    public class MezzorellaSticks : Side
    {
        private Size size;
        /// <summary>
        /// Constructor for the mezzorella sticks
        /// </summary>
        public MezzorellaSticks()
        {
            Price = 0.99;
            Calories = 540;
        }


        /// <summary>
        /// Gets the list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Breading", "Cheese Product", "Vegetable Oil" };
                return ingredients;
            }
        }
        /// <summary>
        /// Returns the size of the side dish or updates the size/price/calories of the side dish
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 540;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
                        break;
                }
            }
        }
    }
}
