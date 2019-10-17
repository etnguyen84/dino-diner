using System;
using System.Collections.Generic;
using System.Text;
/* Author: Ethan Nguyen
 * Class: Drink.cs
 */
namespace DinoDiner.Menu
{
    /*public enum Size
    {
        Small,
        Medium,
        Large
    }*/

    public abstract class Drink : IMenuItem, IOrderItem
    {
        public double Price { get; set; }

        public uint Calories { get; set; }

        public abstract List<string> Ingredients { get; }

        public bool Ice { get; set; } = true;

        public abstract Size Size { get; set; }

        public Drink()
        {
            Size = Size.Small;
            Ice = true;
        }

        public void HoldIce()
        {
            this.Ice = false;
        }

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
