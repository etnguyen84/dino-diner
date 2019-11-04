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
        }
        private Side _side;
        private CretaceousCombo _combo;
        /// <summary>
        /// constructor for side selection page with side value
        /// </summary>
        /// <param name="side"></param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            _side = side;
            SetSelectedSide(_side);
        }

        public SideSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            _combo = combo;
            SetSelectedSide(_combo.Side);
            _side = combo.Side;
        }


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
            
            if (DataContext is Order order)
            {
                _side = new Fryceritops();
                if(_combo != null)
                {
                    _side.Size= _combo.Size;
                    _combo.Side = _side;
                }
                else
                {
                    _side.Size = DinoDiner.Menu.Size.Small;
                    order.Add(_side);
                }
                SetSelectedSide(_side);


            }
        }
        /// <summary>
        /// adds meteor mac and cheese to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                _side = new MeteorMacAndCheese();
                if (_combo != null)
                {
                    _side.Size = _combo.Size;
                    _combo.Side = _side;
                }
                else
                {
                    _side.Size = DinoDiner.Menu.Size.Small;
                    order.Add(_side);
                }
                SetSelectedSide(_side);

            }
        }
        /// <summary>
        /// adds mezzorella sticks to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                _side = new MezzorellaSticks();
                if (_combo != null)
                {
                    _side.Size = _combo.Size;
                    _combo.Side = _side;
                }
                else
                {
                    _side.Size = DinoDiner.Menu.Size.Small;
                    order.Add(_side);
                }
                SetSelectedSide(_side);

            }
        }
        /// <summary>
        /// adds triceritots to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddTriceritots(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                _side = new Triceritots();
                if (_combo != null)
                {
                    _side.Size = _combo.Size;
                    _combo.Side = _side;
                }
                else
                {
                    _side.Size = DinoDiner.Menu.Size.Small;
                    order.Add(_side);
                }
                SetSelectedSide(_side);
            }
        }
        /// <summary>
        /// sets size to small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>

        public void SetSmall(object sender, RoutedEventArgs args)
        {
            _side.Size = DinoDiner.Menu.Size.Small;
            SetSelectedSide(_side);

            if (_combo != null)
            {
                _combo.Side = _side;
                NavigationService.Navigate(new CustomizeCombo(_combo));
            }
            else if (_side != null)
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
        /// <summary>
        /// sets size to medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetMedium(object sender, RoutedEventArgs args)
        {
            _side.Size = DinoDiner.Menu.Size.Medium;
            SetSelectedSide(_side);

            if (_combo != null)
            {
                _combo.Side = _side;
                NavigationService.Navigate(new CustomizeCombo(_combo));
            }
            else if (_side != null)
            {
                NavigationService.Navigate(new MenuCategorySelection());

            }
        }
        /// <summary>
        /// sets size to large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetLarge(object sender, RoutedEventArgs args)
        {
            _side.Size = DinoDiner.Menu.Size.Large;
            SetSelectedSide(_side);

            if (_combo != null)
            {
                _combo.Side = _side;
                NavigationService.Navigate(new CustomizeCombo(_combo));
            }
            else if (_side != null)
            {
                NavigationService.Navigate(new MenuCategorySelection());

            }
        }
    }
}
