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
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        
        /// <summary>
        /// constructor for order control
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
            MountItemListener();
        }
        /// <summary>
        /// allows user to navigate to other pages
        /// </summary>
        public NavigationService NavigationService { get; set; }
        /// <summary>
        /// listener for hwen collection is changed
        /// </summary>
        private void MountItemListener()
        {
            if (DataContext is Order order)
            {
                order.Items.CollectionChanged += OnCollectionChanged;
            }
        }

        /// <summary>
        /// event whenever collection is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnCollectionChanged(object sender, EventArgs args)
        {

        }

        private void OnRemoveOrderItem(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if(sender is FrameworkElement element)
                {
                    if (element.DataContext is IOrderItem item)
                    {
                        order.Items.Remove(item);
                    }
                }
            }
        } 
        
        /// <summary>
        /// event whenever selected item is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnSelectionChanged(object sender, EventArgs args)
        {
            
            if (OrderItems.SelectedItem is Side side)
            {
                NavigationService?.Navigate(new SideSelection(side));
            } 
            else if (OrderItems.SelectedItem is Drink drink)
            {
                NavigationService?.Navigate(new DrinkSelection(drink));

            }
            else if (OrderItems.SelectedItem is Entree entree)
            {
                NavigationService?.Navigate(new EntreeSelection(entree));

            }
        }
        /// <summary>
        /// event for when data context is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            MountItemListener();
        }
        public void CheckItems(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                Console.WriteLine(CollectionViewSource.GetDefaultView(order.Items).CurrentItem);

            }

        }

        
    } 
}
