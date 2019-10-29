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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OrderControl.NavigationService = OrderUI.NavigationService;
            /*
            Order order = DataContext as Order;
            if(order != null)
            {
                order.Add(new DinoNuggets());
                order.Add(new Sodasaurus());
                Triceritots tots = new Triceritots();
                //tots.Size = DinoDiner.Menu.Size.Large;
                order.Add(tots);
                SteakosaurusBurger sb = new SteakosaurusBurger();
                sb.HoldBun();
                sb.HoldMustard();
                order.Add(sb);
                

            }*/
        }

        private void PassOnDataContext()
        {
            Page page = OrderUI.Content as Page;
            if (page != null)
            {
                page.DataContext = OrderUI.DataContext;

            }
        }

        public void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            PassOnDataContext();
        }

        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            PassOnDataContext();
        }

    }
}
