using Xunit;
using DinoDiner.Menu;
/* Author: Nathan Bean
 * Class: MezzorellaSticksTest.cs
 */
namespace MenuTest.Sides
{
    /// <summary>
    /// checks properties and functions for mezzorella sticks
    /// </summary>
    public class MezzorellaSticksTest
    {
        /// <summary>
        /// checks correct default price
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            Assert.Equal(0.99, ms.Price, 2);
        }
        /// <summary>
        /// checks default calories
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            Assert.Equal<uint>(540, ms.Calories);
        }
        /// <summary>
        /// checks correct ingredients
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            Assert.Contains<string>("Breading", ms.Ingredients);
            Assert.Contains<string>("Cheese Product", ms.Ingredients);
            Assert.Contains<string>("Vegetable Oil", ms.Ingredients);
            Assert.Equal<int>(3, ms.Ingredients.Count);
        }

        /// <summary>
        /// checks default size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            Assert.Equal<Size>(Size.Small, ms.Size);
        }

        /// <summary>
        /// checks correct medium price
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = Size.Medium;
            Assert.Equal(1.45, ms.Price, 2);
        }

        /// <summary>
        /// checks medium calories
        /// </summary>
        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = Size.Medium;
            Assert.Equal<uint>(610, ms.Calories);
        }
        /// <summary>
        /// checks setting size to medium
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, ms.Size);
        }
        /// <summary>
        /// checks correct price for large
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = Size.Large;
            Assert.Equal(1.95, ms.Price, 2);
        }
        /// <summary>
        /// checks calorie count for large
        /// </summary>
        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = Size.Large;
            Assert.Equal<uint>(720, ms.Calories);
        }

        /// <summary>
        /// checks setting size to large
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, ms.Size);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldHaveCorrectDescriptions(Size sz)
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = sz;
            Assert.Equal($"{sz} Mezzorella Sticks", ms.Description);
        }

        [Theory]
        [InlineData(Size.Small, "Price", "Calories", "Size")]
        [InlineData(Size.Medium, "Price", "Calories", "Size")]
        [InlineData(Size.Large, "Price", "Calories", "Size")]
        public void CheckAllNotifyPropertyChanges(Size sz, string prop1, string prop2, string prop3)
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            Assert.PropertyChanged(ms, prop1, () => ms.Size = sz);
            Assert.PropertyChanged(ms, prop2, () => ms.Size = sz);
            Assert.PropertyChanged(ms, prop3, () => ms.Size = sz);

        }

    }
}
