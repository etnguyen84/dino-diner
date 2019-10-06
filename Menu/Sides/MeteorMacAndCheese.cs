using System;
using System.Collections.Generic;
using System.Text;
/* MeteorMacAndCheese.cs
 * Author: Ethan Nguyen
 */
namespace DinoDiner.Menu
{
    public class MeteorMacAndCheese : Side
    {
        private Size size;
        /// <summary>
        /// Constructor for the Meteor Mac and Cheese
        /// </summary>
        public MeteorMacAndCheese ()
        {
            Calories = 420;
            Price = 0.99;
        }


        /// <summary>
        /// Gets the list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
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
                        Calories = 420;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        break;
                }
            }
        }
        /// <summary>
        /// Returns the size and name of the side item
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size.ToString() + " Meteor Mac and Cheese";
        }

    }
}
