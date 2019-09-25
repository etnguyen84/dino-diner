using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Class for the tyrannotea drink that inherits from the drink class
    /// </summary>
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// bool for if the drink should include cane sugar or not
        /// </summary>
        public bool Sweet
        {
            get
            {
                return Sweet;
            }
            set
            {
                Sweet = value;
                Size = size;
                if (Sweet)
                {
                    Calories *= 2;
                }
            }
        }

        /// <summary>
        /// bool for if the drink should include lemon or not
        /// </summary>
        public bool Lemon { get; protected set; }

        /// <summary>
        /// private Size property for the drink
        /// </summary>
        private Size size;

        /// <summary>
        /// Constructor for the TyrannoTea drink, default sets to a small drink
        /// </summary>
        public Tyrannotea()
        {
            Price = .99;
            Calories = 8;
        }
        /// <summary>
        /// Sets lemon equal to true, so the ingredients list will add lemon
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
        }

        /// <summary>
        /// Sets the ingredients for the drink and returns the list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Tea" };
                if (Sweet)
                {
                    ingredients.Add("Cane Sugar");
                    Calories *= 2;
                }
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
                    case Size.Small:
                        Price = 0.99;
                        Calories = 8;
                        Sweet = Sweet;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        Sweet = Sweet;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        Sweet = Sweet;
                        break;
                }
            }
        }
    }
}
