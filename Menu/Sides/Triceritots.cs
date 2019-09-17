﻿using System;
using System.Collections.Generic;
using System.Text;
/* Triceritots.cs
 * Author: Ethan Nguyen
 */
namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Class for the triceritots side dish and ways to get information about the dish
    /// </summary>
    public class Triceritots : Side
    {
        private Size size;
        /// <summary>
        /// Constructor for the triceritots dish, sets initially to small
        /// </summary>
        public Triceritots()
        {
            Calories = 352;
            Price = 0.99;
        }

        /// <summary>
        /// Gets the list of ingredients for the fryceritops
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Potato");
                ingredients.Add("Salt");
                ingredients.Add("Vegetable Oil");
                return ingredients;
            }
        }

        /// <summary>
        /// Gets the size of the dish or updates the size, price, and calories of the dish.
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
                        Calories = 352;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        break;
                }
            }
        }

    }
}
