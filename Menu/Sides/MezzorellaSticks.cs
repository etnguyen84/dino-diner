using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
/* MezzorellaSticks.cs
 * Author: Ethan Nguyen
 */
namespace DinoDiner.Menu
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
            size = Size.Small;

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
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Size");

            }
        }

        /// <summary>
        /// Returns the size and name of the side item
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size.ToString() + " Mezzorella Sticks";
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

    }
}
