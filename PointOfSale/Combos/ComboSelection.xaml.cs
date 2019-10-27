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
    /* ComboSelection.xaml.cs
     * Author:EthanNguyen
     */
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        /// <summary>
        /// constructor for combo selection
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// navigates to customize page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectCustomize(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo());

        }
    }
}
