using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private SodasaurusFlavor flav = SodasaurusFlavor.Cola;
        /// <summary>
        /// property that for the soda flavor of the drink with a get and set
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get
            {
                return flav;
            }
            set
            {
                flav = value;
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// private property that holds the size of the dirnk
        /// </summary>
        private Size size;

        /// <summary>
        /// constructor for the sodasaurus object, setting its default to small
        /// </summary>
        public Sodasaurus()
        {
            size = Size.Small;
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
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Size");
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
                if(!Ice)
                {
                    specs.Add("Hold Ice");
                }

                return specs.ToArray();
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
