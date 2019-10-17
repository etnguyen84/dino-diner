using System;
using System.Collections.Generic;
using System.Text;
/* Author: Ethan Nguyen
 * Class: IOrderItem.cs
 */
namespace DinoDiner.Menu
{
    /// <summary>
    /// public interface class for an order item, contains price, description and special
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// Lets user get the price of the item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// lets user get a description of the order item
        /// </summary>
        string Description { get; }


        /// <summary>
        /// Lets user get any special isntructions for the food instructions
        /// </summary>
        string[] Special { get; }
    }
}
