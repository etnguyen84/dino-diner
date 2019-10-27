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
    /*  EntreeSelection.xaml.cs
     *  Author: Ethan Nguyen
     */

    /// <summary>
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        /// <summary>
        /// constructor for entree selection page
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
            if (DataContext is Order order)
            {
                CollectionViewSource.GetDefaultView(order.Items).CurrentChanged += OnCurrentChanged;
            }
        }
        /// <summary>
        /// constructor with passing in of entree
        /// </summary>
        /// <param name="entree"></param>
        public EntreeSelection(Entree entree)
        {
            DataContext = entree;
        }
        /// <summary>
        /// handles when current value is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnCurrentChanged(object sender, EventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    //SetSelectedSide(side);
                }
            }
        }
        /// <summary>
        /// adds brontowurst to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddBrontowurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Entree entree = new Brontowurst();
                order.Items.Add(entree);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// adds steakosaurus to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddSteakosaurus(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Entree entree = new SteakosaurusBurger();
                order.Items.Add(entree);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
            NavigationService.Navigate(new MenuCategorySelection());

        }
        /// <summary>
        /// adds trex king burger to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddTRex(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Entree entree = new TRexKingBurger();
                order.Items.Add(entree);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
            NavigationService.Navigate(new MenuCategorySelection());

        }
        /// <summary>
        /// adds prehistoric pbj to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Entree entree = new PrehistoricPBJ();
                order.Items.Add(entree);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
            NavigationService.Navigate(new MenuCategorySelection());

        }
        /// <summary>
        /// adds pterodactyl wings to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Entree entree = new PterodactylWings();
                order.Items.Add(entree);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
            NavigationService.Navigate(new MenuCategorySelection());

        }
        /// <summary>
        /// Adds veloci-wrap to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddWrap(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Entree entree = new VelociWrap();
                order.Items.Add(entree);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
            NavigationService.Navigate(new MenuCategorySelection());

        }
        /// <summary>
        /// Adds Dino-Nuggets to Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Entree entree = new DinoNuggets();
                order.Items.Add(entree);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
            NavigationService.Navigate(new MenuCategorySelection());

        }


    }
}
