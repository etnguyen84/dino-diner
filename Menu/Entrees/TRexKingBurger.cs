using System;
using System.Collections.Generic;
using System.Text;
/* TRexKingBurger.cs
 * Author: Ethan Nguyen
 */
namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class for the TRexKingBurger with methods to affect ingredients
    /// </summary>
    public class TRexKingBurger
    {
        /// <summary>
        /// bool on the presence of a bun
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// bool on the presence of lettuce
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// bool on the presence of tomato
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// bool on the presence of onion
        /// </summary>
        private bool onion = true;

        /// <summary>
        /// bool on the presence of pickle
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// bool on the presence of ketchup
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// bool on the presence of mustard
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// bool on the presence of mayo
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// Price value of the TRexKingBurger
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Calorie Count of the TRexKingBurger
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Creates a list of ingredients for the burger, adding the ingredients to a list
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for the burger that sets its price and calorie count
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        /// <summary>
        /// Removes bun from burger
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Removes lettuce from burger
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Removes tomato from burger
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
        }

        /// <summary>
        /// Removes onion from burger
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }

        /// <summary>
        /// Removes pickle from burger
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// Removes ketchup from burger
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// Removes mustard from burger
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }

        /// <summary>
        /// Removes mayo from burger
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
        }
    }
}
