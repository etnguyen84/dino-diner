using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;
/* Author: Nathan Bean
 * Class: BrontowurstUnitTest.cs
 */
namespace MenuTest.Entrees
{
    public class BrontowurstUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal(5.36, bw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal<uint>(498, bw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Brontowurst bw = new Brontowurst();
            List<string> ingredients = bw.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Brautwurst", ingredients);
            Assert.Contains<string>("Peppers", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Equal<int>(4, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", bw.Ingredients);
        }

        [Fact]
        public void HoldPeppersShouldRemovePeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.DoesNotContain<string>("Peppers", bw.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.DoesNotContain<string>("Onion", bw.Ingredients);
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal("Brontowurst", bw.Description);
        }

        [Fact]
        public void HoldOnionShouldChangeSpecial()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.Contains<string>("Hold Onion", bw.Special);
        }

        [Fact]
        public void HoldPeppersShouldChangeSpecial()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.Contains<string>("Hold Peppers", bw.Special);
        }

        [Fact]
        public void HoldBunShouldChangeSpecial()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.Contains<string>("Hold Whole Wheat Bun", bw.Special);
        }

        [Fact]
        public void HoldPeppersBunAndOnionShouldChangeSpecial()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.Contains<string>("Hold Peppers", bw.Special);
            bw.HoldBun();
            Assert.Contains<string>("Hold Whole Wheat Bun", bw.Special);
            bw.HoldOnion();
            Assert.Contains<string>("Hold Onion", bw.Special);
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Ingredients")]
        public void CheckAllNotifyPropertyChanges(string propertyName)
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, propertyName, () => bw.HoldOnion() );
            Assert.PropertyChanged(bw, propertyName, () => bw.HoldPeppers());
            Assert.PropertyChanged(bw, propertyName, () => bw.HoldBun());

        }


    }

}
