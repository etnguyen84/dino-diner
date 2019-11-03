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

/* DrinkSelection.xaml.cs
 * Author: Ethan Nguyen
 */
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// private background variable to hold drink
        /// </summary>
        private Drink _drink;

        /// <summary>
        /// constructor for drink selection
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
            ResetDynamicButtons();
        }
        /// <summary>
        /// constructor for when drink is passed in
        /// </summary>
        /// <param name="drink"></param>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            _drink = drink;
            ResetDynamicButtons();

            if (drink is Sodasaurus)
            {
                SetSelectedDrink("Sodasaurus");
            }
            else if(drink is JurassicJava)
            {
                SetSelectedDrink("Jurassic Java");
            }
            else if(drink is Tyrannotea)
            {
                SetSelectedDrink("Tyrannotea");
            }
            else if (drink is Water)
            {
                SetSelectedDrink("Water");
            }

            SetSelectedSize(drink);
        }

        public void SelectFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());

        }
        /// <summary>
        /// adds soda to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectSodasaurus(object sender, RoutedEventArgs args)
        {
            SetSelectedDrink("Sodasaurus");
            if (DataContext is Order order)
            {
                _drink = new Sodasaurus();
                order.Add(_drink);
                SetSelectedSize(_drink);
            }

        }
        /// <summary>
        /// adds java to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectJurassicJava(object sender, RoutedEventArgs args)
        {
            SetSelectedDrink("Jurassic Java");
            if (DataContext is Order order)
            {
                _drink = new JurassicJava();
                order.Add(_drink);
                SetSelectedSize(_drink);
            }

        }
        /// <summary>
        /// adds tea to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectTyrannotea(object sender, RoutedEventArgs args)
        {
            SetSelectedDrink("Tyrannotea");
            if (DataContext is Order order)
            {
                _drink = new Tyrannotea();
                order.Add(_drink);
                SetSelectedSize(_drink);

            }

        }
        /// <summary>
        /// adds water to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectWater(object sender, RoutedEventArgs args)
        {
            SetSelectedDrink("Water");
            if (DataContext is Order order)
            {
                _drink = new Water();
                order.Add(_drink);
                SetSelectedSize(_drink);
            }

        }
        /// <summary>
        /// sets all buttons to collapsed
        /// </summary>
        public void ResetDynamicButtons()
        {
            uxlemon.Visibility = Visibility.Collapsed;
            uxflavor.Visibility = Visibility.Collapsed;
            uxdecaf.Visibility = Visibility.Collapsed;
            uxsweet.Visibility = Visibility.Collapsed;
            uxaddIce.Visibility = Visibility.Collapsed;
            uxholdIce.Visibility = Visibility.Collapsed;
            uxroom.Visibility = Visibility.Collapsed;

        }
        /// <summary>
        /// sets selected size
        /// </summary>
        /// <param name="drink"></param>
        void SetSelectedSize(Drink drink)
        {
            switch (drink.Size)
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
        /// sets selected drink buttons and highlights values
        /// </summary>
        /// <param name="drink"></param>
        void SetSelectedDrink(string drink)
        {
            ResetDynamicButtons();
            switch (drink)
            {
                case "Sodasaurus":
                    SodaButton.Background = new SolidColorBrush(Colors.LightBlue);
                    JavaButton.ClearValue(Button.BackgroundProperty);
                    TeaButton.ClearValue(Button.BackgroundProperty);
                    WaterButton.ClearValue(Button.BackgroundProperty);
                    uxflavor.Visibility = Visibility.Visible;
                    uxholdIce.Visibility = Visibility.Visible;
                    break;

                case "Jurassic Java":
                    SodaButton.ClearValue(Button.BackgroundProperty);
                    JavaButton.Background = new SolidColorBrush(Colors.LightBlue);
                    TeaButton.ClearValue(Button.BackgroundProperty);
                    WaterButton.ClearValue(Button.BackgroundProperty);
                    uxdecaf.Visibility = Visibility.Visible;
                    uxroom.Visibility = Visibility.Visible;
                    uxaddIce.Visibility = Visibility.Visible;
                    //uxholdIce.Visibility = Visibility.Visible;
                    break;
                case "Tyrannotea":
                    SodaButton.ClearValue(Button.BackgroundProperty);
                    JavaButton.ClearValue(Button.BackgroundProperty);
                    TeaButton.Background = new SolidColorBrush(Colors.LightBlue);
                    WaterButton.ClearValue(Button.BackgroundProperty);
                    uxlemon.Visibility = Visibility.Visible;
                    uxsweet.Visibility = Visibility.Visible;
                    uxholdIce.Visibility = Visibility.Visible;
                    break;
                case "Water":
                    SodaButton.ClearValue(Button.BackgroundProperty);
                    JavaButton.ClearValue(Button.BackgroundProperty);
                    TeaButton.ClearValue(Button.BackgroundProperty);
                    WaterButton.Background = new SolidColorBrush(Colors.LightBlue);
                    uxlemon.Visibility = Visibility.Visible;
                    uxholdIce.Visibility = Visibility.Visible;
                    break;
            }
        }

        /// <summary>
        /// makes drink small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetSmall(object sender, RoutedEventArgs args)
        {
            if ( _drink != null)
            {
                _drink.Size = DinoDiner.Menu.Size.Small;
                SetSelectedSize(_drink);
            }
           
        }
        /// <summary>
        /// makes drink medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetMedium(object sender, RoutedEventArgs args)
        {
            if (_drink != null)
            {
                _drink.Size = DinoDiner.Menu.Size.Medium;
                SetSelectedSize(_drink);
            }
        }
        /// <summary>
        /// makes drink large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetLarge(object sender, RoutedEventArgs args)
        {

            if (_drink != null)
            {
                _drink.Size = DinoDiner.Menu.Size.Large;
                SetSelectedSize(_drink);
            }
        }
        /// <summary>
        /// adds lemon to tea or water
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddLemon(object sender, RoutedEventArgs args)
        {
            /*
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Tyrannotea drink)
                {
                    drink.AddLemon();

                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Water drnk)
                {
                    drnk.AddLemon();
                }
            }*/
            if (_drink != null)
            {
                if (_drink is Tyrannotea tea)
                {
                    tea.AddLemon();
                }
                else if (_drink is Water w)
                {
                    w.AddLemon();
                }
            }
          
        }
        /// <summary>
        /// coffee is decaf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddDecaf(object sender, RoutedEventArgs args)
        {
            /*
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is JurassicJava drink)
                {
                        drink.Decaf = true;
                }
            }*/
            if (_drink != null)
            {
                if (_drink is JurassicJava j)
                {
                    j.Decaf = true;
                }
            }
        }
        /// <summary>
        /// leaves room for cream in coffee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddRoom(object sender, RoutedEventArgs args)
        {
            if (_drink != null)
            {
                if (_drink is JurassicJava j)
                {
                    j.LeaveRoomForCream();
                }
            }
        }
        /// <summary>
        /// makes tea sweet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddSweet(object sender, RoutedEventArgs args)
        {
            if (_drink != null)
            {
                if (_drink is Tyrannotea tea)
                {
                    tea.Sweet = true;
                }
            }
        }

        /// <summary>
        /// holds ice in drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldIce(object sender, RoutedEventArgs args)
        {
            if (_drink != null)
            {
                _drink.HoldIce();
            }
        }
        /// <summary>
        /// adds ice to coffee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddIce(object sender, RoutedEventArgs args)
        {
            if (_drink != null)
            {
                if (_drink is JurassicJava j)
                {
                    j.AddIce();
                }
            }
        }

        /// <summary>
        /// returns user to menu category selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void DoneClick(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }

    }
}
