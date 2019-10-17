using System;
using System.Collections.Generic;
using System.Text;
/* Author: Ethan Nguyen
 * Class: Side.cs
 */
namespace DinoDiner.Menu
{

    public enum Size
    {
        Small,
        Medium, 
        Large
    }

    public abstract class Side : IMenuItem, IOrderItem
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// lets user get a description of the order item
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// lets user get the special instructions for the order of the menu item
        /// </summary>
        public abstract string[] Special { get; }
    }
}
