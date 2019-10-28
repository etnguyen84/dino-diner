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
        public FlavorSelection()
        {
            InitializeComponent();
            /*
            if (DataContext is Order order)
            {
                CollectionViewSource.GetDefaultView(order.Items).CurrentChanged += OnCurrentChanged;
            }*/
        }

        /// <summary>
        /// sets flavor to cherry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetCherry(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus drink)
                {
                    drink.Flavor = SodasaurusFlavor.Cherry;
                    NavigationService.Navigate(new DrinkSelection(drink));

                }
            }
        }
        /// <summary>
        /// sets flavor to chocolate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetChocolate(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus drink)
                {
                    drink.Flavor = SodasaurusFlavor.Chocolate;
                    NavigationService.Navigate(new DrinkSelection(drink));

                }
            }
        }
        /// <summary>
        /// sets flavor to cola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetCola(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus drink)
                {
                    //drink.Flavor = SodasaurusFlavor.Cola;
                    NavigationService.Navigate(new DrinkSelection(drink));

                }
            }
        }
        /// <summary>
        /// sets flavor to lime
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetLime(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus drink)
                {
                    drink.Flavor = SodasaurusFlavor.Lime;
                    NavigationService.Navigate(new DrinkSelection(drink));

                }
            }
        }
        /// <summary>
        /// sets flavor to orange
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetOrange(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus drink)
                {
                    drink.Flavor = SodasaurusFlavor.Orange;
                    NavigationService.Navigate(new DrinkSelection(drink));

                }
            }
        }
        /// <summary>
        /// sets flavor to root beer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetRootBeer(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus drink)
                {
                    drink.Flavor = SodasaurusFlavor.RootBeer;
                    NavigationService.Navigate(new DrinkSelection(drink));

                }
            }
        }
        /// <summary>
        /// sets flavor to vanilla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetVanilla(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus drink)
                {
                    drink.Flavor = SodasaurusFlavor.Vanilla;
                    NavigationService.Navigate(new DrinkSelection(drink));
                }
            }
        }

    }
}
