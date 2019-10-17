﻿using System;
using System.Collections.Generic;
using System.Text;
/* Author: Ethan Nguyen
 * Class: Sodasaurus.cs
 */
namespace DinoDiner.Menu
{
    /// <summary>
    /// enum that has options for different soda flavors for the drink
    /// </summary>
    public enum SodasaurusFlavor
    {
        Cola,
        Orange,
        Vanilla,
        Chocolate,
        RootBeer,
        Cherry,
        Lime
    }
    /// <summary>
    /// class for the sodasaurus drink that inherits from the abstract drink class
    /// </summary>
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// property that for the soda flavor of the drink with a get and set
        /// </summary>
        public SodasaurusFlavor Flavor { get; set; }

        /// <summary>
        /// private property that holds the size of the dirnk
        /// </summary>
        private Size size;

        /// <summary>
        /// constructor for the sodasaurus object, setting its default to small
        /// </summary>
        public Sodasaurus()
        {
            Price = 1.50;
            Calories = 112;
        }

        /// <summary>
        /// Sets the ingredients for the drink and returns the list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
                return ingredients;
            }
        }

        /// <summary>
        /// Gets the size of the drink or sets the drink size, calories, and price
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
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                }
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
                specs.Add(Flavor.ToString() + "Flavor");
                if(!Ice)
                {
                    specs.Add("Hold Ice");
                }

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
                StringBuilder sb = new StringBuilder();
                sb.Append(Size.ToString() + " ");
                sb.Append(Flavor.ToString() + " ");
                sb.Append("Sodasaurus");

                return sb.ToString();
            }
        }

        /// <summary>
        /// Returns the size, characteristics, and name of the drink item
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Size.ToString() + " ");
            sb.Append(Flavor.ToString() + " ");
            sb.Append("Sodasaurus");

            return sb.ToString();
        }

    }
}
