using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// class for a water drink that includes properties for size, price, and calories, as well as a method to add lemon
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// private property that holds the size of the drink
        /// </summary>
        private Size size;

        /// <summary>
        /// bool that represents on whether the drink has lemon or not
        /// </summary>
        public bool Lemon { get; protected set; } = false;
        /// <summary>
        /// constructor for the water object, defaults to small
        /// </summary>
        public Water()
        {
            Price = 0.10;
            Calories = 0;
        }

        /// <summary>
        /// Adds lemon to the drink by setting the lemon property to true
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }

        /// <summary>
        /// Creates a list of strings of ingredients and returns it
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water" };
                if (Lemon) ingredients.Add("Lemon");
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
                    default:
                        Price = 0.10;
                        Calories = 0;
                        break;
                }
            }
        }

    }
}
