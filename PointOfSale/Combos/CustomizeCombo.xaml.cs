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
    /* CustomizeCombo.xaml.cs
    * Author:EthanNguyen
    */
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        /*
        private Side _side;
        private Drink _drink;
        private Entree _entree;*/
        private CretaceousCombo _combo;

        /// <summary>
        /// constructor for customize combo
        /// </summary>
        public CustomizeCombo()
        {
            InitializeComponent();
        }

        public CustomizeCombo(CretaceousCombo combo)
        {
            InitializeComponent();
            _combo = combo;
            SetSelectedSize();
        }

        /// <summary>
        /// navigate to side selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection(_combo.Side));
        }
        /// <summary>
        /// navigate to select drinks page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection(_combo.Drink));
        }

        void SetSelectedSize()
        {
            switch (_combo.Size)
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
        public void SetSmall(object sender, RoutedEventArgs args)
        {
            if (_combo != null)
            {
                _combo.Size = DinoDiner.Menu.Size.Small;
            }
        }
        /// <summary>
        /// sets size to medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetMedium(object sender, RoutedEventArgs args)
        {
            if (_combo != null)
            {
                _combo.Size = DinoDiner.Menu.Size.Medium;
            }
        }
        /// <summary>
        /// sets size to large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetLarge(object sender, RoutedEventArgs args)
        {
            if (_combo != null)
            {
                _combo.Size = DinoDiner.Menu.Size.Large;
            }


        }
    }
}
