﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
/* Fryceritops.cs
 * Author: Ethan Nguyen
 */
namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the fryceritops side
    /// </summary>
    public class Fryceritops : Side 
    {
        private Size size;
        /// <summary>
        /// Constructor for the fryceritops
        /// </summary>
        public Fryceritops()
        {
            Size = Size.Small;
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
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                }
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Description");

            }
        }

        /// <summary>
        /// Returns the size and name of the side item
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size.ToString() + " Fryceritops";
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
