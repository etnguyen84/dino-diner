using System;
using System.Collections.Generic;
using System.Text;
/* Entree.cs
 * Author: Ethan Nguyen
 */
namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstract class for an entree object with price, calories, and ingredient list
    /// </summary>
    public abstract class Entree : IMenuItem
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the Calorie Count
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredient list
        /// </summary>
        public abstract List<string> Ingredients { get; }


    }
}
