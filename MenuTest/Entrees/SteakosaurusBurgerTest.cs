using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;
/* Author: Nathan Bean
* Class: SteakosaurusBurgerUnitTest.cs
*/
namespace MenuTest.Entrees
{
    public class SteakosaurusBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal(5.15, sb.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal<uint>(621, sb.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            List<string> ingredients = sb.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Steakburger Pattie", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", sb.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", sb.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", sb.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", sb.Ingredients);
        }

        [Fact]
        public void HoldBunShouldChangeSpecialBun()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            Assert.Contains<string>("Hold Whole Wheat Bun", sb.Special);
        }

        [Fact]
        public void HoldPickleShouldChangeSpecialPickle()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.Contains<string>("Hold Pickle", sb.Special);
        }

        [Fact]
        public void HoldKetchupShouldChangeSpecialKetchup()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.Contains<string>("Hold Ketchup", sb.Special);
        }

        [Fact]
        public void HoldMustardShouldChangeSpecialMustard()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Assert.Contains<string>("Hold Mustard", sb.Special);
        }

 
        [Fact]
        public void HoldKetchupMustardShouldChangeSpecial()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.Contains<string>("Hold Ketchup", sb.Special);
            sb.HoldMustard();
            Assert.Contains<string>("Hold Mustard", sb.Special);
        }

        [Fact]
        public void HoldPickleBunShouldChangeSpecial()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.Contains<string>("Hold Pickle", sb.Special);
            sb.HoldBun();
            Assert.Contains<string>("Hold Whole Wheat Bun", sb.Special);
        }
        [Theory]
        [InlineData("Special")]
        [InlineData("Ingredients")]
        public void CheckAllNotifyPropertyChanges(string propertyName)
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.PropertyChanged(sb, propertyName, () => sb.HoldBun());
            Assert.PropertyChanged(sb, propertyName, () => sb.HoldPickle());
            Assert.PropertyChanged(sb, propertyName, () => sb.HoldKetchup());
            Assert.PropertyChanged(sb, propertyName, () => sb.HoldMustard());

        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal("Steakosaurus Burger", sb.Description);
        }


    }

}
