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
    /* FlavorSelection.xaml.cs
     * Author: Ethan Nguyen
     */
    /// <summary>
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        /// <summary>
        /// private backing varaible for soda
        /// </summary>
        private Sodasaurus _soda;
        /// <summary>
        /// backing variable for combo
        /// </summary>
        private CretaceousCombo _combo;

        /// <summary>
        /// Constructor for page with drink passed in
        /// </summary>
        /// <param name="soda"></param>
        public FlavorSelection(Sodasaurus soda)
        {
            InitializeComponent();
            _soda = soda;

        }
        /// <summary>
        /// Constructor for page with combo passed in
        /// </summary>
        /// <param name="combo"></param>
        public FlavorSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            _combo = combo;
            _soda = combo.Drink as Sodasaurus;
        }

        /// <summary>
        /// sets flavor to cherry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetCherry(object sender, RoutedEventArgs args)
        {
            _soda.Flavor = SodasaurusFlavor.Cherry;

            if (_combo != null)
            {
                _combo.Drink = _soda;
                NavigationService.Navigate(new DrinkSelection(_combo));
            }
            else
            {
                NavigationService.Navigate(new DrinkSelection(_soda as Drink));
            }

        }
        /// <summary>
        /// sets flavor to chocolate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetChocolate(object sender, RoutedEventArgs args)
        {
            _soda.Flavor = SodasaurusFlavor.Chocolate;

            if (_combo != null)
            {
                _combo.Drink = _soda;
                NavigationService.Navigate(new DrinkSelection(_combo));
            }
            else
            {
                NavigationService.Navigate(new DrinkSelection(_soda as Drink));
            }
        }
        /// <summary>
        /// sets flavor to cola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetCola(object sender, RoutedEventArgs args)
        {
            _soda.Flavor = SodasaurusFlavor.Cola;

            if (_combo != null)
            {
                _combo.Drink = _soda;
                NavigationService.Navigate(new DrinkSelection(_combo));
            }
            else
            {
                NavigationService.Navigate(new DrinkSelection(_soda as Drink));
            }
        }
        /// <summary>
        /// sets flavor to lime
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetLime(object sender, RoutedEventArgs args)
        {
            _soda.Flavor = SodasaurusFlavor.Lime;

            if (_combo != null)
            {
                _combo.Drink = _soda;
                NavigationService.Navigate(new DrinkSelection(_combo));
            }
            else
            {
                NavigationService.Navigate(new DrinkSelection(_soda as Drink));
            }
        }
        /// <summary>
        /// sets flavor to orange
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetOrange(object sender, RoutedEventArgs args)
        {
            _soda.Flavor = SodasaurusFlavor.Orange;

            if (_combo != null)
            {
                _combo.Drink = _soda;
                NavigationService.Navigate(new DrinkSelection(_combo));
            }
            else
            {
                NavigationService.Navigate(new DrinkSelection(_soda as Drink));
            }
        }
        /// <summary>
        /// sets flavor to root beer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetRootBeer(object sender, RoutedEventArgs args)
        {
            _soda.Flavor = SodasaurusFlavor.RootBeer;

            if (_combo != null)
            {
                _combo.Drink = _soda;
                NavigationService.Navigate(new DrinkSelection(_combo));
            }
            else
            {
                NavigationService.Navigate(new DrinkSelection(_soda as Drink));
            }
        }
        /// <summary>
        /// sets flavor to vanilla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetVanilla(object sender, RoutedEventArgs args)
        {
            _soda.Flavor = SodasaurusFlavor.Vanilla;

            if (_combo != null)
            {
                _combo.Drink = _soda;
                NavigationService.Navigate(new DrinkSelection(_combo));
            }
            else
            {
                NavigationService.Navigate(new DrinkSelection(_soda as Drink));
            }
        }

    }
}
