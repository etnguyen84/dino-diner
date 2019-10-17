using Xunit;
using DinoDiner.Menu;
/* Author: Nathan Bean
 * Class: TriceritotsTest.cs
 */
namespace MenuTest.Sides
{
    /// <summary>
    /// checks for triceritots functions and properties
    /// </summary>
    public class TriceritotsTest
    {
        /// <summary>
        /// checks default price
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Triceritots tt = new Triceritots();
            Assert.Equal(0.99, tt.Price, 2);
        }
        /// <summary>
        /// checks default calories
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Triceritots tt = new Triceritots();
            Assert.Equal<uint>(352, tt.Calories);
        }
        /// <summary>
        /// checks correct ingredients
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Triceritots tt = new Triceritots();
            Assert.Contains<string>("Potato", tt.Ingredients);
            Assert.Contains<string>("Salt", tt.Ingredients);
            Assert.Contains<string>("Vegetable Oil", tt.Ingredients);
            Assert.Equal<int>(3, tt.Ingredients.Count);
        }
        /// <summary>
        /// checks correct default size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Triceritots tt = new Triceritots();
            Assert.Equal<Size>(Size.Small, tt.Size);
        }
        /// <summary>
        /// checks medium price
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Medium;
            Assert.Equal(1.45, tt.Price, 2);
        }
        /// <summary>
        /// checks medium calorie count
        /// </summary>
        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Medium;
            Assert.Equal<uint>(410, tt.Calories);
        }
        /// <summary>
        /// checks setting size to medium
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, tt.Size);
        }
        /// <summary>
        /// checks large price
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Large;
            Assert.Equal(1.95, tt.Price, 2);
        }
        /// <summary>
        /// checks calorie count in large
        /// </summary>
        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Large;
            Assert.Equal<uint>(590, tt.Calories);
        }
        /// <summary>
        /// checks ability to set to large
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, tt.Size);
        }
    }
}
