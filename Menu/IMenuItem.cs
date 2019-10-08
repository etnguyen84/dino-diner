using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface that names the Price, calories, and ingredients variable
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// lets user get the price of the item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// lets user get the calorie count of the item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// lets user get the ingredient count of the item
        /// </summary>
        List<string> Ingredients { get; }

    }
}
