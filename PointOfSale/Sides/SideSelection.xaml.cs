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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        public SideSelection()
        {
            InitializeComponent();
            if (DataContext is Order order)
            {
                CollectionViewSource.GetDefaultView(order.Items).CurrentChanged += OnCurrentChanged;
            }
        }

        public void AddFryceritops(object sender, RoutedEventArgs args)
        {
            //Order order = DataContext as Order;
            if (DataContext is Order order)
            {
                Side side = new Fryceritops();
                order.Items.Add(side);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }
        public void AddMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Side side = new MeteorMacAndCheese();
                order.Items.Add(side);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }
        public void AddMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Side side = new MezzorellaSticks();
                order.Items.Add(side);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }
        public void AddTriceritots(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Side side = new Triceritots();
                order.Items.Add(side);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }

        public void SetSmall(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    side.Size = DinoDiner.Menu.Size.Small;
                }
            }
        }
        public void SetMedium(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    side.Size = DinoDiner.Menu.Size.Medium;
                }
            }
        }

        public void SetLarge(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if(CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    side.Size = DinoDiner.Menu.Size.Large;
                }
            }
        }

        public void OnCurrentChanged(object sender, EventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    switch (side.Size)
                    {
                        //set rado to side.Size property
                        //disable selection of new side

                    }
                }
            }
        }

    }
}
