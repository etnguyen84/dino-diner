using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
/* Author: Ethan Nguyen
 * Class: Menu.cs
 */
namespace DinoDiner.Menu
{
    /// <summary>
    /// class that defines the menu for the diner
    /// </summary>
    public class Menu
    {

        /// <summary>
        /// Returns all available menu items 
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> i = new List<IMenuItem>(AvailableEntrees);
                i.AddRange(AvailableSides);
                i.AddRange(AvailableDrinks);
                i.AddRange(AvailableCombos);

                return i;
            }
        }


        /// <summary>
        /// Returns all available entrees as a list of strings
        /// </summary>
        public List<Entree> AvailableEntrees
        {
            get
            {
                return new List<Entree>() {
                    new Brontowurst(),
                    new DinoNuggets(),
                    new PrehistoricPBJ(),
                    new PterodactylWings(),
                    new SteakosaurusBurger(),
                    new TRexKingBurger(),
                    new VelociWrap()
                };
            }
        }


        /// <summary>
        /// Returns all available sides as a list
        /// </summary>
        public List<Side> AvailableSides
        {
            get
            {
                return new List<Side>() {
                    new Fryceritops(),
                    new MeteorMacAndCheese(),
                    new MezzorellaSticks(),
                    new Triceritots()
                };
            }
        }


        /// <summary>
        /// Returns all available drinks as a list
        /// </summary>
        public List<Drink> AvailableDrinks
        {
            get
            {
                return new List<Drink>() {
                    new JurassicJava(),
                    new Sodasaurus(),
                    new Tyrannotea(),
                    new Water()
                };
            }
        }

        /// <summary>
        /// Returns all available combos as a list
        /// </summary>
        public List<CretaceousCombo> AvailableCombos
        {
            get
            {
                List<CretaceousCombo> combos = new List<CretaceousCombo>(AvailableEntrees.Count);
                for (int i = 0; i < AvailableEntrees.Count; i++)
                {
                    combos.Add(new CretaceousCombo(AvailableEntrees[i]));
                }

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
            for (int i = 0; i < AvailableMenuItems.Count; i++)
            {
                sb.Append(AvailableMenuItems[i].ToString() + "\n");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Returns a hashset of unique strings of potential ingredients
        /// </summary>
        public SortedSet<string> PossibleIngredients
        {
            get
            {
                SortedSet<string> possible = new SortedSet<string>();

                foreach(IMenuItem item in AvailableMenuItems) {
                    foreach(string i in item.Ingredients)
                    {
                        possible.Add(i);
                    }
                }

                return possible;
            }
        }


    }
}
