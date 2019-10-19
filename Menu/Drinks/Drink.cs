using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
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
    /// <summary>
    /// Abstract class for drink classes
    /// </summary>
    public abstract class Drink : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// getter and setter for pice
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// getter and setter for calories
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// getter for ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }
        /// <summary>
        /// getter and setter for Ice, starts at true
        /// </summary>
        public bool Ice { get; set; } = true;
        /// <summary>
        /// getter and setter for Size property
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// base constructor for a drink
        /// </summary>
        public Drink()
        {
            Size = Size.Small;
            Ice = true;
        }
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

        /// <summary>
        /// method to hold ice and have ice set to false
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
        }

        /// <summary>
        /// lets user get a description of the order item
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// lets user get the special instructions for the order of the menu item
        /// </summary>
        public abstract string[] Special { get; }

    }
}
