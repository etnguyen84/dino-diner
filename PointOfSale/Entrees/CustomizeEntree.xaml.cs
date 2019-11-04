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
/* CustomizeEntree.xaml.cs
 * Author: Ethan Nguyen
 */
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
        /// <summary>
        /// backing variable for possible combo
        /// </summary>
        private CretaceousCombo _combo;

        /// <summary>
        /// default constructor, should never really reach here
        /// </summary>
        public CustomizeEntree()
        {
            InitializeComponent();
            ResetButtons();
            SetButtons();
        }
        /// <summary>
        /// constructor that takes in an entree
        /// </summary>
        /// <param name="entree"></param>
        public CustomizeEntree(Entree entree)
        {
            InitializeComponent();
            _entree = entree;
            ResetButtons();
            SetButtons();
        }
        /// <summary>
        /// constructor that takes in a cretaceous combo
        /// </summary>
        /// <param name="combo"></param>
        public CustomizeEntree(CretaceousCombo combo)
        {
            InitializeComponent();
            _combo = combo;
            _entree = combo.Entree;
            ResetButtons();
            SetButtons();
        }
        /// <summary>
        /// resests all buttons to collapsed
        /// </summary>
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
        /// <summary>
        /// sets the visibility of the buttons based on the entree
        /// </summary>
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
        /// <summary>
        /// holds bun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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
            if(_combo != null)
            {
                _combo.Entree = _entree;
            }
        }
        /// <summary>
        /// holds pepper
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldPeppers(object sender, RoutedEventArgs args)
        {
            if (_entree is Brontowurst bw)
            {
                bw.HoldPeppers();
            }
            if (_combo != null)
            {
                _combo.Entree = _entree;
            }
        }
        /// <summary>
        /// holds onion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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
            if (_combo != null)
            {
                _combo.Entree = _entree;
            }
        }
        /// <summary>
        /// adds another chicken nugget
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddNugget(object sender, RoutedEventArgs args)
        {
            if (_entree is DinoNuggets dn)
            {
                dn.AddNugget();
            }
            if (_combo != null)
            {
                _combo.Entree = _entree;
            }
        }
        /// <summary>
        /// holds peanut butter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldPB(object sender, RoutedEventArgs args)
        {
            if (_entree is PrehistoricPBJ pbj)
            {
                pbj.HoldPeanutButter();
            }
            if (_combo != null)
            {
                _combo.Entree = _entree;
            }
        }
        /// <summary>
        /// holds jelly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldJelly(object sender, RoutedEventArgs args)
        {
            if (_entree is PrehistoricPBJ pbj)
            {
                pbj.HoldJelly();
            }
            if (_combo != null)
            {
                _combo.Entree = _entree;
            }

        }
        /// <summary>
        /// holds pickle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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
            if (_combo != null)
            {
                _combo.Entree = _entree;
            }
        }

        /// <summary>
        /// holds lettuce
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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
            if (_combo != null)
            {
                _combo.Entree = _entree;
            }
        }
        /// <summary>
        /// holds tomato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldTomato(object sender, RoutedEventArgs args)
        {

            if (_entree is TRexKingBurger trex)
            {
                trex.HoldTomato();
            }
            if (_combo != null)
            {
                _combo.Entree = _entree;
            }

        }
        /// <summary>
        /// holds cheese
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldCheese(object sender, RoutedEventArgs args)
        {
            if (_entree != null)
            {

            }
            if (_entree is VelociWrap vw)
            {
                vw.HoldCheese();
            }
            if (_combo != null)
            {
                _combo.Entree = _entree;
            }

        }
        /// <summary>
        /// holds ketchup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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
            if (_combo != null)
            {
                _combo.Entree = _entree;
            }
        }
        /// <summary>
        /// holds mustard condiment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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
            if (_combo != null)
            {
                _combo.Entree = _entree;
            }
        }
        /// <summary>
        /// hold mayo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldMayo(object sender, RoutedEventArgs args)
        {

            if (_entree is TRexKingBurger trex)
            {
                trex.HoldMayo();
            }
            if (_combo != null)
            {
                _combo.Entree = _entree;
            }
        }
        /// <summary>
        /// Hold dressing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldDressing(object sender, RoutedEventArgs args)
        {
            if (_entree is VelociWrap vw)
            {
                vw.HoldDressing();
            }
            if (_combo != null)
            {
                _combo.Entree = _entree;
            }
        }

        /// <summary>
        /// returns user to menu category selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void DoneClick(object sender, RoutedEventArgs args)
        {
            if(_combo != null)
            {
                _combo.Entree = _entree;
                NavigationService.Navigate(new CustomizeCombo(_combo));

            } else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }

        }
    }
}
