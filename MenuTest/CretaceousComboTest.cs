using Xunit;
using DinoDiner.Menu;
/* Author: Ethan Nguyen
 * Class: CretaceousComboTest.cs
 */
namespace MenuTest
{
    public class CretaceousComboTest
    {

        [Theory]
        [InlineData("Entree")]
        [InlineData("Price")]
        [InlineData("Calories")]
        [InlineData("Special")]
        [InlineData("Ingredients")]
        public void EntreeShouldNotifyChange(string prop)
        {
            CretaceousCombo cc = new CretaceousCombo(new VelociWrap());
            Assert.PropertyChanged(cc, prop, () => cc.Entree = new Brontowurst());
            Assert.PropertyChanged(cc, prop, () => cc.Entree = new DinoNuggets());
            Assert.PropertyChanged(cc, prop, () => cc.Entree = new PrehistoricPBJ());
            Assert.PropertyChanged(cc, prop, () => cc.Entree = new PterodactylWings());
            Assert.PropertyChanged(cc, prop, () => cc.Entree = new SteakosaurusBurger());
            Assert.PropertyChanged(cc, prop, () => cc.Entree = new TRexKingBurger());
            Assert.PropertyChanged(cc, prop, () => cc.Entree = new VelociWrap());
        }

        [Theory]
        [InlineData("Side")]
        [InlineData("Price")]
        [InlineData("Calories")]
        [InlineData("Special")]
        [InlineData("Ingredients")]
        public void SideShouldNotifyChange(string prop)
        {
            CretaceousCombo cc = new CretaceousCombo(new VelociWrap());
            Assert.PropertyChanged(cc, prop, () => cc.Side = new Triceritots());
            Assert.PropertyChanged(cc, prop, () => cc.Side = new MeteorMacAndCheese());
            Assert.PropertyChanged(cc, prop, () => cc.Side = new MezzorellaSticks());
            Assert.PropertyChanged(cc, prop, () => cc.Side = new Fryceritops());

        }

        [Theory]
        [InlineData("Drink")]
        [InlineData("Price")]
        [InlineData("Calories")]
        [InlineData("Special")]
        [InlineData("Ingredients")]
        public void DrinkShouldNotifyChange(string prop)
        {
            CretaceousCombo cc = new CretaceousCombo(new VelociWrap());
            Assert.PropertyChanged(cc, prop, () => cc.Drink = new JurassicJava());
            Assert.PropertyChanged(cc, prop, () => cc.Drink = new Sodasaurus());
            Assert.PropertyChanged(cc, prop, () => cc.Drink = new Tyrannotea());
            Assert.PropertyChanged(cc, prop, () => cc.Drink = new Water());
        }

        [Fact]
        public void DrinkShouldChangeSpecial()
        {
            CretaceousCombo cc = new CretaceousCombo(new VelociWrap());
            Assert.Contains<string>($"{cc.Drink}", cc.Special);
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            cc.Drink = tea;
            Assert.Contains<string>("Add Lemon", cc.Special);
            Assert.Contains<string>($"{cc.Drink}", cc.Special);

        }

        [Fact]
        public void EntreeShouldChangeSpecial()
        {
            CretaceousCombo cc = new CretaceousCombo(new VelociWrap());
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            sb.HoldKetchup();
            cc.Entree = sb;
            Assert.Contains<string>("Hold Whole Wheat Bun", cc.Special);
            Assert.Contains<string>("Hold Ketchup", cc.Special);

        }

        [Fact]
        public void SideShouldChangeSpecial()
        {
            CretaceousCombo cc = new CretaceousCombo(new SteakosaurusBurger());
            Assert.Contains<string>($"{cc.Side}", cc.Special);
            Triceritots tt = new Triceritots();
            cc.Side = tt;
            Assert.Contains<string>($"{cc.Side}", cc.Special);

        }


    }
}
