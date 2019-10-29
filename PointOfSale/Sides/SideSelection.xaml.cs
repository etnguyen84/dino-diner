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
    /* SideSelection.xaml.cs
   * Author:EthanNguyen
   */
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        /// <summary>
        /// constructor for side selection page
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
            if (DataContext is Order order)
            {
                CollectionViewSource.GetDefaultView(order.Items).CurrentChanged += OnCurrentChanged;
            }
        }
        private Side _side;
        /// <summary>
        /// constructor for side selection page with side value
        /// </summary>
        /// <param name="side"></param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            DataContext = side;
            _side = side;
            SetSelectedSide(_side);
        }
        /*
        void SelectSide(Side side)
        {
            if (DataContext is Order order)
            {
                order.Add(side);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                DataContext = side;
                SetSelectedSide(side);
            }
        }*/

        /// <summary>
        /// sets the selected side
        /// </summary>
        /// <param name="side"></param>
        void SetSelectedSide(Side side)
        {
            if(side is Fryceritops fry)
            {
                Fryceritops.Background = new SolidColorBrush(Colors.LightBlue);
                Triceritots.ClearValue(Button.BackgroundProperty);
                MeteorMacAndCheese.ClearValue(Button.BackgroundProperty);
                MezzorellaSticks.ClearValue(Button.BackgroundProperty);
            }
            else if (side is Triceritots tots)
            {
                Fryceritops.ClearValue(Button.BackgroundProperty);
                Triceritots.Background = new SolidColorBrush(Colors.LightBlue);
                MeteorMacAndCheese.ClearValue(Button.BackgroundProperty);
                MezzorellaSticks.ClearValue(Button.BackgroundProperty);
            }
            else if (side is MeteorMacAndCheese mac)
            {
                Fryceritops.ClearValue(Button.BackgroundProperty);
                Triceritots.ClearValue(Button.BackgroundProperty);
                MeteorMacAndCheese.Background = new SolidColorBrush(Colors.LightBlue);
                MezzorellaSticks.ClearValue(Button.BackgroundProperty);
            }
            else if (side is MezzorellaSticks sticks)
            {
                Fryceritops.ClearValue(Button.BackgroundProperty);
                Triceritots.ClearValue(Button.BackgroundProperty);
                MeteorMacAndCheese.ClearValue(Button.BackgroundProperty);
                MezzorellaSticks.Background = new SolidColorBrush(Colors.LightBlue);
            }

            switch (side.Size)
            {
                case DinoDiner.Menu.Size.Small:
                    SmallButton.Background = new SolidColorBrush(Colors.LightBlue);
                    MediumButton.ClearValue(Button.BackgroundProperty);
                    LargeButton.ClearValue(Button.BackgroundProperty);
                    break;

                case DinoDiner.Menu.Size.Medium:
                    MediumButton.Background = new SolidColorBrush(Colors.LightBlue);
                    SmallButton.ClearValue(Button.BackgroundProperty);
                    LargeButton.ClearValue(Button.BackgroundProperty);
                    break;
                case DinoDiner.Menu.Size.Large:
                    LargeButton.Background = new SolidColorBrush(Colors.LightBlue);
                    SmallButton.ClearValue(Button.BackgroundProperty);
                    MediumButton.ClearValue(Button.BackgroundProperty);
                    break;
            }
        }
        /// <summary>
        /// adds fryceritops to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddFryceritops(object sender, RoutedEventArgs args)
        {
            _side = new Fryceritops();
            if (DataContext is Order order)
            {
                Side side = new Fryceritops();
                order.Add(side);
                SetSelectedSide(side);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }
        /// <summary>
        /// adds meteor mac and cheese to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            _side = new MeteorMacAndCheese();

            if (DataContext is Order order)
            {
                Side side = new MeteorMacAndCheese();
                order.Add(side);
                SetSelectedSide(side);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }
        /// <summary>
        /// adds mezzorella sticks to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            _side = new MezzorellaSticks();

            if (DataContext is Order order)
            {
                Side side = new MezzorellaSticks();
                order.Add(side);
                SetSelectedSide(side);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }
        /// <summary>
        /// adds triceritots to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddTriceritots(object sender, RoutedEventArgs args)
        {
            _side = new Triceritots();

            if (DataContext is Order order)
            {
                Side side = new Triceritots();
                order.Add(side);
                SetSelectedSide(side);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }
        /// <summary>
        /// sets size to small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>

        public void SetSmall(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    order.Remove(side);
                    _side.Size = DinoDiner.Menu.Size.Small;
                    SetSelectedSide(_side);
                    order.Add(_side);
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
        }
        /// <summary>
        /// sets size to medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetMedium(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    order.Remove(side);
                    _side.Size = DinoDiner.Menu.Size.Medium;
                    SetSelectedSide(_side);
                    order.Add(_side);
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
        }
        /// <summary>
        /// sets size to large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetLarge(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if(CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    order.Remove(side);
                    _side.Size = DinoDiner.Menu.Size.Large;
                    SetSelectedSide(_side);
                    order.Add(_side);
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
        }
        /// <summary>
        /// event for when current is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnCurrentChanged(object sender, EventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    SetSelectedSide(side);
                }
            }
        }

    }
}
