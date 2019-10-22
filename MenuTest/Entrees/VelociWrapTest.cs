using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

/* Author: Nathan Bean
* Class: VelociwrapUnitTest.cs
*/
namespace MenuTest.Entrees
{
    public class VelociWrapUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal(6.86, vw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal<uint>(356, vw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            VelociWrap vw = new VelociWrap();
            List<string> ingredients = vw.Ingredients;
            Assert.Contains<string>("Flour Tortilla", ingredients);
            Assert.Contains<string>("Chicken Breast", ingredients);
            Assert.Contains<string>("Romaine Lettuce", ingredients);
            Assert.Contains<string>("Ceasar Dressing", ingredients);
            Assert.Contains<string>("Parmesan Cheese", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldDressingShouldRemoveDressing()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            Assert.DoesNotContain<string>("Dressing", vw.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", vw.Ingredients);
        }

        [Fact]
        public void HoldCheeseShouldRemoveCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            Assert.DoesNotContain<string>("Parmesan Cheese", vw.Ingredients);
        }

        [Fact]
        public void HoldCheeseShouldChangeSpecial()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            Assert.Contains<string>("Hold Parmesan Cheese", vw.Special);
        }

        [Fact]
        public void HoldLettuceShouldChangeSpecial()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            Assert.Contains<string>("Hold Romaine Lettuce", vw.Special);
        }

        [Fact]
        public void HoldDressingShouldChangeSpecial()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            Assert.Contains<string>("Hold Caesar Dressing", vw.Special);
        }

        [Fact]
        public void HoldCheeseLettuceDressingShouldChangeSpecial()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            Assert.Contains<string>("Hold Parmesan Cheese", vw.Special);
            vw.HoldLettuce();
            Assert.Contains<string>("Hold Romaine Lettuce", vw.Special);
            vw.HoldDressing();
            Assert.Contains<string>("Hold Caesar Dressing", vw.Special);
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Ingredients")]
        public void CheckAllNotifyPropertyChanges(string propertyName)
        {
            VelociWrap vw = new VelociWrap();
            Assert.PropertyChanged(vw, propertyName, () => vw.HoldCheese());
            Assert.PropertyChanged(vw, propertyName, () => vw.HoldLettuce());
            Assert.PropertyChanged(vw, propertyName, () => vw.HoldDressing());

        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal("Veloci-Wrap", vw.Description);
        }




    }
}
