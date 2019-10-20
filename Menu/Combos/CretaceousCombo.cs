using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
/* Author: Ethan Nguyen
 * Class: CretaceousCombo.cs
 */
namespace DinoDiner.Menu
{

    /// <summary>
    /// A class representing a combo meal
    /// </summary>
    public class CretaceousCombo : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        //Backing Variables
        private Size size;

        private Entree entree;
        private Side side;
        private Drink drink;


        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets and sets the entree
        /// </summary>
        public Entree Entree {
            get
            {
                return entree;
            }
            set
            {
                //remove listener from old entree
                //set entree to new entree
                //add event listener to new entree
                //entree.PropertyChanged += OnItemPropertyChanged();
                entree = value;
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Entree");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Ingredients");

            }
        }

        /// <summary>
        /// Gets and sets the side
        /// </summary>
        public Side Side
        {
            get
            {
                return side;
            }
            set
            {
                //remove listener from old entree
                //set entree to new entree
                //add event listener to new entree
                //entree.PropertyChanged += OnItemPropertyChanged();
                side = value;
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Side");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Ingredients");

            }
        } 
        /// <summary>
        /// Gets and sets the drink
        /// </summary>
        public Drink Drink
        {
            get
            {
                return drink;
            }
            set
            {
                drink = value;
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Drink");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Ingredients");

            }
        }
        /// <summary>
        /// Gets the price of the combo
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }

        /// <summary>
        /// gets the calories of the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        /// <summary>
        /// Gets or sets the size of the combo
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Drink");
                NotifyOfPropertyChanged("Side");
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Special");
            }
        }
        /// <summary>
        /// Gets the list of ingredients for the combo
        ///</summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }
        /// <summary>
        /// Returns array of special instructions
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.AddRange(Entree.Special);
                special.Add(Side.Description);
                special.AddRange(Side.Special);
                special.Add(Drink.Description);
                special.AddRange(Drink.Special);
                return special.ToArray();
            }
        }
        /// <summary>
        /// returns description of the combo
        /// </summary>
        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(Entree.ToString() + " Combo");

                return sb.ToString();
            }
            
        }

        /// <summary>
        /// Constructs a new combo with the specificd entree
        /// </summary>
        /// <param name="entree">The entree to use</param>
        public CretaceousCombo(Entree entree)
        {
            this.Entree = entree;
            this.Side = new Fryceritops();
            this.Drink = new Sodasaurus();
        }

        /// <summary>
        /// Returns the name of the combo with the main entree
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Entree} Combo");

            return sb.ToString();
        }

        /// <summary>
        /// Helper method that invokes a new propertychanged event
        /// </summary>
        /// <param name="propertyName"> property that is being changed</param>
        public void NotifyOfPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
        /// <summary>
        /// Event listener for when entree/side/drink's property changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnItemPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            NotifyOfPropertyChanged(args.PropertyName);
            if(args.PropertyName != "Special" && args.PropertyName != "Calories" && args.PropertyName != "Price")
            {
                NotifyOfPropertyChanged("Special");
            }
        }
    }
}
