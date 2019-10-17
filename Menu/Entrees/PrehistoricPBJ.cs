using System.Collections.Generic;

/* PrehistoricPBJ.cs
 * Author: Ethan Nguyen
 */
namespace DinoDiner.Menu
{
    /// <summary>
    /// PrehistoricPBJ menu item dish
    /// </summary>
    public class PrehistoricPBJ : Entree
    {
        private bool peanutButter = true;
        private bool jelly = true;


        /// <summary>
        /// Creates a list of ingredients for the pbj
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for the PBJ item with set price and calories
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// Gets an array of special instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> specs = new List<string>();
                if (!peanutButter) specs.Add("Hold Peanut Butter");
                if (!jelly) specs.Add("Hold Jelly");

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
                return "Prehistoric PB&J";
            }
        }

        /// <summary>
        /// Removes peanut butter from item
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }

        /// <summary>
        /// Removes jelly from item
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
        /// <summary>
        /// Returns name of the entree item
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }
    }
}
