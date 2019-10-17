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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public DrinkSelection()
        {
            InitializeComponent();
            ResetDynamicButtons();

        }
        public void SelectFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());

        }
        public void SelectSodasaurus(object sender, RoutedEventArgs args)
        {
            ResetDynamicButtons();
            uxflavor.Visibility = Visibility.Visible;

        }
        public void SelectJurassicJava(object sender, RoutedEventArgs args)
        {
            ResetDynamicButtons();
            uxdecaf.Visibility = Visibility.Visible;

        }
        public void SelectTyrannotea(object sender, RoutedEventArgs args)
        {
            ResetDynamicButtons();
            uxlemon.Visibility = Visibility.Visible;
            uxsweet.Visibility = Visibility.Visible;

        }
        public void SelectWater(object sender, RoutedEventArgs args)
        {
            ResetDynamicButtons();
            uxlemon.Visibility = Visibility.Visible;
        }

        public void ResetDynamicButtons()
        {
            uxlemon.Visibility = Visibility.Collapsed;
            uxflavor.Visibility = Visibility.Collapsed;
            uxdecaf.Visibility = Visibility.Collapsed;
            uxsweet.Visibility = Visibility.Collapsed;

        }
    }
}
