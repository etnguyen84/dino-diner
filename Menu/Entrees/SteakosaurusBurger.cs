using System;
using System.Collections.Generic;
using System.Text;

/* SteakosaurusBurger.cs
 * Author: Ethan Nguyen
 */

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class for the 1/2 lb Steakosaurus Burger
    /// </summary>
    public class SteakosaurusBurger : Entree
    {
        /// <summary>
        /// bool on the presence of a bun
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// bool on the presence of pickles
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// bool on the presence of ketchup
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// bool on the presence of  mustard
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// Creates a list of ingredients for the burger, including pattie, bun, pickles, ketchup, and mustard
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for a steakosaurus burger 
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// Removes the bun from the burger
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }
        
        /// <summary>
        /// Removes the pickle from the burger
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// Removes ketchup from the burger
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// Removes mustard from the burger
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }


    }
}
