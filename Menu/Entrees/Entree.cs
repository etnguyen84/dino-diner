using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Text;
/* Entree.cs
 * Author: Ethan Nguyen
 */
namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstract class for an entree object with price, calories, and ingredient list
    /// </summary>
    public abstract class Entree : IMenuItem, IOrderItem, INotifyPropertyChanged
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

        /// <summary>
        /// lets user get a description of the order item
        /// </summary>
        public string Description {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// lets user get the special instructions for the order of the menu item
        /// </summary>
        public abstract string[] Special { get; }

        /// <summary>
        /// event handler for when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Helper method that invokes a new propertychanged event
        /// </summary>
        /// <param name="propertyName"> property that is being changed</param>
        public void NotifyOfPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}
