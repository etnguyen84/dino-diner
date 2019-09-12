using System.Collections.Generic;

/* PrehistoricPBJ.cs
 * Author: Ethan Nguyen
 */
namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// PrehistoricPBJ menu item dish
    /// </summary>
    public class PrehistoricPBJ
    {
        private bool peanutButter = true;
        private bool jelly = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        /// <summary>
        /// Creates a list of ingredients for the pbj
        /// </summary>
        public List<string> Ingredients
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
    }
}
