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
    /// Interaction logic for CustomizeEntree.xaml
    /// </summary>
    public partial class CustomizeEntree : Page
    {
        /// <summary>
        /// backing variable to hold entree
        /// </summary>
        private Entree _entree;

        public CustomizeEntree()
        {
            InitializeComponent();
            ResetButtons();
            SetButtons();
        }

        public CustomizeEntree(Entree entree)
        {
            InitializeComponent();
            _entree = entree;
            ResetButtons();
            SetButtons();
        }

        private void ResetButtons()
        {
            uxBun.Visibility = Visibility.Collapsed;
            uxCheese.Visibility = Visibility.Collapsed;
            uxDressing.Visibility = Visibility.Collapsed;
            uxJelly.Visibility = Visibility.Collapsed;
            uxKetchup.Visibility = Visibility.Collapsed;
            uxLettuce.Visibility = Visibility.Collapsed;
            uxMayo.Visibility = Visibility.Collapsed;
            uxMustard.Visibility = Visibility.Collapsed;
            uxNugget.Visibility = Visibility.Collapsed;
            uxOnion.Visibility = Visibility.Collapsed;
            uxPB.Visibility = Visibility.Collapsed;
            uxPeppers.Visibility = Visibility.Collapsed;
            uxPickle.Visibility = Visibility.Collapsed;
            uxTomato.Visibility = Visibility.Collapsed;
        }

        private void SetButtons()
        {
            if (_entree is Brontowurst bw)
            {
                uxBun.Visibility = Visibility.Visible;
                uxPeppers.Visibility = Visibility.Visible;
                uxOnion.Visibility = Visibility.Visible;
            }
            else if (_entree is DinoNuggets dn)
            {
                uxNugget.Visibility = Visibility.Visible;
            }
            else if (_entree is PrehistoricPBJ pbj)
            {
                uxPB.Visibility = Visibility.Visible;
                uxJelly.Visibility = Visibility.Visible;
            }
            else if (_entree is PterodactylWings pw)
            {
                //has nothing
            }
            else if (_entree is SteakosaurusBurger sb)
            {
                uxBun.Visibility = Visibility.Visible;
                uxPickle.Visibility = Visibility.Visible;
                uxKetchup.Visibility = Visibility.Visible;
                uxMustard.Visibility = Visibility.Visible;
            }
            else if (_entree is TRexKingBurger trex)
            {
                uxBun.Visibility = Visibility.Visible;
                uxLettuce.Visibility = Visibility.Visible;
                uxTomato.Visibility = Visibility.Visible;
                uxOnion.Visibility = Visibility.Visible;
                uxPickle.Visibility = Visibility.Visible;
                uxKetchup.Visibility = Visibility.Visible;
                uxMustard.Visibility = Visibility.Visible;
                uxMayo.Visibility = Visibility.Visible;
            }
            else if (_entree is VelociWrap vw)
            {
                uxDressing.Visibility = Visibility.Visible;
                uxLettuce.Visibility = Visibility.Visible;
                uxCheese.Visibility = Visibility.Visible;
            }
        }

        public void HoldBun(object sender, RoutedEventArgs args)
        {
            if (_entree is Brontowurst bw)
            {
                bw.HoldBun();
            }
            else if (_entree is SteakosaurusBurger sb)
            {
                sb.HoldBun();
            }
            else if (_entree is TRexKingBurger trex)
            {
                trex.HoldBun();
            }
        }
        
        public void HoldPeppers(object sender, RoutedEventArgs args)
        {
            if (_entree is Brontowurst bw)
            {
                bw.HoldPeppers();
            }
        }

        public void HoldOnion(object sender, RoutedEventArgs args)
        {
            if (_entree is Brontowurst bw)
            {
                bw.HoldOnion();
            }
            else if (_entree is TRexKingBurger trex)
            {
                trex.HoldOnion();
            }
        }

        public void AddNugget(object sender, RoutedEventArgs args)
        {
            if (_entree is DinoNuggets dn)
            {
                dn.AddNugget();
            }
        }

        public void HoldPB(object sender, RoutedEventArgs args)
        {
            if (_entree is PrehistoricPBJ pbj)
            {
                pbj.HoldPeanutButter();
            }
        }

        public void HoldJelly(object sender, RoutedEventArgs args)
        {
            if (_entree is PrehistoricPBJ pbj)
            {
                pbj.HoldJelly();
            }

        }
        public void HoldPickle(object sender, RoutedEventArgs args)
        {
            if (_entree is SteakosaurusBurger sb)
            {
                sb.HoldPickle();
            }
            else if (_entree is TRexKingBurger trex)
            {
                trex.HoldPickle();
            }
        }

        public void HoldLettuce(object sender, RoutedEventArgs args)
        {
             if (_entree is TRexKingBurger trex)
            {
                trex.HoldLettuce();
            }
            else if (_entree is VelociWrap vw)
            {
                vw.HoldLettuce();
            }
        }
        public void HoldTomato(object sender, RoutedEventArgs args)
        {
            if (_entree is TRexKingBurger trex)
            {
                trex.HoldTomato();
            }
        }
        public void HoldCheese(object sender, RoutedEventArgs args)
        {
            if (_entree is VelociWrap vw)
            {
                vw.HoldCheese();
            }
        }

        public void HoldKetchup(object sender, RoutedEventArgs args)
        {
            if (_entree is SteakosaurusBurger sb)
            {
                sb.HoldKetchup();
            }
            else if (_entree is TRexKingBurger trex)
            {
                trex.HoldKetchup();
            }
        }
        public void HoldMustard(object sender, RoutedEventArgs args)
        {
            if (_entree is SteakosaurusBurger sb)
            {
                sb.HoldMustard();
            }
            else if (_entree is TRexKingBurger trex)
            {
                trex.HoldMustard();
            }
        }
        public void HoldMayo(object sender, RoutedEventArgs args)
        {

            if (_entree is TRexKingBurger trex)
            {
                trex.HoldMayo();
            }
        }
        public void HoldDressing(object sender, RoutedEventArgs args)
        {
            if (_entree is VelociWrap vw)
            {
                vw.HoldDressing();
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
