using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for Jurassic Java drink that inherits from the drink class
    /// </summary>
    public class JurassicJava : Drink
    {
        /// <summary>
        /// bool to allow room for cream or to top it off with coffee
        /// </summary>
        public bool RoomForCream { get; protected set; }

        /// <summary>
        /// bool to have the coffee be decaf or regular
        /// </summary>
        public bool Decaf {get; set;}

        /// <summary>
        /// private size property
        /// </summary>
        private Size size;

        /// <summary>
        /// Constructor for the JurassicJava drink, setting ice to false and size to small as a default
        /// </summary>
        public JurassicJava()
        {
            Ice = false;
            Price = .59;
            Calories = 2;
        }

        /// <summary>
        /// Sets the RoomForCream property to true, to allow the customer to add cream
        /// </summary>
        public void LeaveRoomForCream()
        {
            this.RoomForCream = true;
        }

        /// <summary>
        /// Sets the ice property to true, meaning their is ice in teh drink
        /// </summary>
        public void AddIce()
        {
            Ice = true;
        }

        /// <summary>
        /// Sets the ingredients for the drink and returns the list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Coffee" };
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
                        Price = 0.59;
                        Calories = 2;
                        break;
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        break;
                }
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
            if (Decaf)
            {
                sb.Append("Decaf ");
            }

            sb.Append("Jurassic Java");
            return sb.ToString();
        }


    }
}
