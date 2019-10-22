using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;
/* Author: Nathan Bean
* Class: TRexKingBurgerUnitTest.cs
*/
namespace MenuTest.Entrees
{
    public class TRexKingBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal(8.45, trex.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal<uint>(728, trex.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            TRexKingBurger trex = new TRexKingBurger();
            List<string> ingredients = trex.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            // Should be three patties
            int count = 0;
            foreach(string ingredient in ingredients)
            {
                if (ingredient.Equals("Steakburger Pattie")) count++;
            }
            Assert.Equal<int>(3, count);
            Assert.Contains<string>("Lettuce", ingredients);
            Assert.Contains<string>("Tomato", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Contains<string>("Mayo", ingredients);
            Assert.Equal<int>(11, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", trex.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", trex.Ingredients);
        }

        [Fact]
        public void HoldTomatoShouldRemoveTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.DoesNotContain<string>("Tomato", trex.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.DoesNotContain<string>("Onion", trex.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", trex.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", trex.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", trex.Ingredients);
        }

        [Fact]
        public void HoldMayoShouldRemoveMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.DoesNotContain<string>("Mayo", trex.Ingredients);
        }

        [Fact]
        public void HoldBunShouldChangeSpecialBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            Assert.Contains<string>("Hold Whole Wheat Bun", trex.Special);
        }

        [Fact]
        public void HoldLettuceShouldChangeSpecialLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.Contains<string>("Hold Lettuce", trex.Special);
        }

        [Fact]
        public void HoldTomatoShouldChangeSpecial()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.Contains<string>("Hold Tomato", trex.Special);
        }

        [Fact]
        public void HoldOnionShouldChangeSpecial()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.Contains<string>("Hold Onion", trex.Special);
        }

        [Fact]
        public void HoldPickleShouldChangeSpecialPickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.Contains<string>("Hold Pickle", trex.Special);
        }

        [Fact]
        public void HoldKetchupShouldChangeSpecialKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.Contains<string>("Hold Ketchup", trex.Special);
        }

        [Fact]
        public void HoldMustardShouldChangeSpecialMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.Contains<string>("Hold Mustard", trex.Special);
        }

        [Fact]
        public void HoldMayoShouldChangeSpecialMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.Contains<string>("Hold Mayo", trex.Special);
        }


        [Fact]
        public void HoldKetchupMustardShouldChangeSpecial()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.Contains<string>("Hold Ketchup", trex.Special);
            trex.HoldMustard();
            Assert.Contains<string>("Hold Mustard", trex.Special);
        }

        [Fact]
        public void HoldPickleBunShouldChangeSpecial()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.Contains<string>("Hold Pickle", trex.Special);
            trex.HoldBun();
            Assert.Contains<string>("Hold Whole Wheat Bun", trex.Special);
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Ingredients")]
        public void CheckAllNotifyPropertyChanges(string propertyName)
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, propertyName, () => trex.HoldBun());
            Assert.PropertyChanged(trex, propertyName, () => trex.HoldLettuce());
            Assert.PropertyChanged(trex, propertyName, () => trex.HoldTomato());
            Assert.PropertyChanged(trex, propertyName, () => trex.HoldOnion());
            Assert.PropertyChanged(trex, propertyName, () => trex.HoldPickle());
            Assert.PropertyChanged(trex, propertyName, () => trex.HoldKetchup());
            Assert.PropertyChanged(trex, propertyName, () => trex.HoldMustard());
            Assert.PropertyChanged(trex, propertyName, () => trex.HoldMayo());


        }


    }

}
