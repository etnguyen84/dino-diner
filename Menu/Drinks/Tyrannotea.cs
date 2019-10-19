using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
/* Author: Ethan Nguyen
 * Class: Tyrannotea.cs
 */
namespace DinoDiner.Menu
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
                return sweet;
            }
            set
            {
                switch (size)
                {
                    case Size.Small:
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Calories = 16;
                        break;
                    case Size.Large:
                        Calories = 32;
                        break;
                }

                sweet = value;
                if (sweet)
                {
                    Calories *= 2;
                }
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Sweet");
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
        /// bool that represents whether the tea is sweet or not
        /// </summary>
        private bool sweet;

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
            NotifyOfPropertyChanged("Lemon");
            NotifyOfPropertyChanged("Special");

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
                        Sweet = sweet;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        Sweet = sweet;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        Sweet = sweet;
                        break;
                }
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
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
                if(Sweet)
                {
                    specs.Add("Sweet");
                }
                else
                {
                    specs.Add("Non-Sweet");
                }
                if(Lemon)
                {
                    specs.Add("Add Lemon");
                }
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
            if(Sweet)
            {
                sb.Append("Sweet ");
            }

            sb.Append("Tyrannotea");

            return sb.ToString();
        }
    }
}
