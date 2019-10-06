using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DinoDiner.Menu
{
    /// <summary>
    /// class that defines the menu for the diner
    /// </summary>
    public class Menu
    {

        /// <summary>
        /// Returns all available menu items as a list of strings
        /// </summary>
        public List<string> AvailableMenuItems
        {
            get
            {
                List<string> menu = new List<string>();
                menu.AddRange(AvailableEntrees);
                menu.AddRange(AvailableSides);
                menu.AddRange(AvailableDrinks);
                menu.AddRange(AvailableCombos);
                return menu;
            }
        }


        /// <summary>
        /// Returns all available entrees as a list of strings
        /// </summary>
        public List<string> AvailableEntrees
        {
            get
            {
                List<string> entrees = new List<string>();
                entrees.Add("Brontowurst");
                entrees.Add("Dino-Nuggets");
                entrees.Add("Prehistoric PB&J");
                entrees.Add("Pterodactyl Wings");
                entrees.Add("Steakosaurus Burger");
                entrees.Add("T-Rex King Burger");
                entrees.Add("Veloci-Wrap");

                return entrees;
            }
        }


        /// <summary>
        /// Returns all available sides as a list of strings
        /// </summary>
        public List<string> AvailableSides
        {
            get
            {
                List<string> sides = new List<string>();
                sides.Add("Friceritops");
                sides.Add("Meteor Mac and Cheese");
                sides.Add("Mezzorella Sticks");
                sides.Add("Triceritots");
                return sides;
            }
        }


        /// <summary>
        /// Returns all available drinks as a list of strings
        /// </summary>
        public List<string> AvailableDrinks
        {
            get
            {
                List<string> drinks = new List<string>();
                drinks.Add("Jurassic Java");
                drinks.Add("Sodasaurus");
                drinks.Add("TyrannoTea");
                drinks.Add("Water");
                return drinks;
            }
        }

        /// <summary>
        /// Returns all available combos as a list of strings
        /// </summary>
        public List<string> AvailableCombos
        {
            get
            {
                List<string> combos = new List<string>();
                combos.Add("Brontowurst Combo");
                combos.Add("Dino-Nuggets Combo");
                combos.Add("Prehistoric PB&J Combo");
                combos.Add("Pterodactyl Wings Combo");
                combos.Add("Steakosaurus Burger Combo");
                combos.Add("T-Rex King Burger Combo");
                combos.Add("Veloci-Wrap Combo");

                return combos;

            }
        }

        /// <summary>
        /// returns a string containing all available menu items, each separated by a new line character
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string s in AvailableMenuItems)
            {
                sb.Append(s + "\n");
            }
            return sb.ToString();
        }


    }
}
