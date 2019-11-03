using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /* ComboSelection.xaml.cs
     * Author:EthanNguyen
     */
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        /// <summary>
        /// private backing variable for Cretaceous combo
        /// </summary>
        private CretaceousCombo _combo;

        /// <summary>
        /// constructor for combo selection
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds a brontowurst combo to order and goes to customize page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void BrontowurstCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                _combo = new CretaceousCombo(new Brontowurst());
                _combo.Size = DinoDiner.Menu.Size.Small;
                order.Add(_combo);
                NavigationService.Navigate(new CustomizeCombo(_combo));

            }
        }
        /// <summary>
        /// Adds a Steakosaurus Burger combo to order and goes to customize page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SteakBurgerCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                _combo = new CretaceousCombo(new SteakosaurusBurger());
                _combo.Size = DinoDiner.Menu.Size.Small;
                order.Add(_combo);
                NavigationService.Navigate(new CustomizeCombo(_combo));

            }
        }
        /// <summary>
        /// Adds a TRex King Burger combo to order and goes to customize page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void TRexKingCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                _combo = new CretaceousCombo(new TRexKingBurger());
                _combo.Size = DinoDiner.Menu.Size.Small;
                order.Add(_combo);
                NavigationService.Navigate(new CustomizeCombo(_combo));

            }
        }

        /// <summary>
        /// Adds a Prehistoric PBJ combo to order and goes to customize page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void PBJCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                _combo = new CretaceousCombo(new PrehistoricPBJ());
                _combo.Size = DinoDiner.Menu.Size.Small;
                order.Add(_combo);
                NavigationService.Navigate(new CustomizeCombo(_combo));

            }
        }
        /// <summary>
        /// Adds a Pterodactyl Wings combo to order and goes to customize page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void WingsCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                _combo = new CretaceousCombo(new PterodactylWings());
                _combo.Size = DinoDiner.Menu.Size.Small;
                order.Add(_combo);
                NavigationService.Navigate(new CustomizeCombo(_combo));

            }
        }
        /// <summary>
        /// Adds a Veloci-wrap combo to order and goes to customize page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void WrapCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                _combo = new CretaceousCombo(new VelociWrap());
                _combo.Size = DinoDiner.Menu.Size.Small;
                order.Add(_combo);
                NavigationService.Navigate(new CustomizeCombo(_combo));

            }
        }
        /// <summary>
        /// Adds a Dino-Nuggets combo to order and goes to customize page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void NuggetsCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                _combo = new CretaceousCombo(new DinoNuggets());
                _combo.Size = DinoDiner.Menu.Size.Small;
                order.Add(_combo);
                NavigationService.Navigate(new CustomizeCombo(_combo));

            }
        }

    }
}
