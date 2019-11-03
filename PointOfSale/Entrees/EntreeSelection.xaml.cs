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
        private Entree _entree;
        /// <summary>
        /// constructor for entree selection page
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// constructor with passing in of entree
        /// </summary>
        /// <param name="entree"></param>
        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            _entree = entree;
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
                _entree = new Brontowurst();
                order.Add(_entree);
                //CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
            NavigationService.Navigate(new CustomizeEntree(_entree));
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
                _entree = new SteakosaurusBurger();
                order.Add(_entree);
                //CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
            NavigationService.Navigate(new CustomizeEntree(_entree));

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
                _entree = new TRexKingBurger();
                order.Add(_entree);
               // CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
            NavigationService.Navigate(new CustomizeEntree(_entree));

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
                _entree = new PrehistoricPBJ();
                order.Add(_entree);
               // CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
            NavigationService.Navigate(new CustomizeEntree(_entree));

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
                _entree = new PterodactylWings();
                order.Add(_entree);
                //CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
            NavigationService.Navigate(new CustomizeEntree(_entree));

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
                _entree = new VelociWrap();
                order.Add(_entree);
                //CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
            NavigationService.Navigate(new CustomizeEntree(_entree));

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
                _entree = new DinoNuggets();
                order.Add(_entree);
                //CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
            NavigationService.Navigate(new CustomizeEntree(_entree));

        }




    }
}
