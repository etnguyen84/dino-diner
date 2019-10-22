using Xunit;
using DinoDiner.Menu;
/* Author: Nathan Bean
 * Class: MeteorMacAndCheeseTest.cs
 */
namespace MenuTest.Sides
{
    /// <summary>
    /// Tests for Meteor Mac and Cheese side
    /// </summary>
    public class MeteorMacAndCheeseTest
    {
        /// <summary>
        /// checks default price
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.Equal(0.99, mmc.Price, 2);
        }
        /// <summary>
        /// checks default calories
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.Equal<uint>(420, mmc.Calories);
        }
        /// <summary>
        /// checks correct ingredient list
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.Contains<string>("Macaroni Noodles", mmc.Ingredients);
            Assert.Contains<string>("Cheese Product", mmc.Ingredients);
            Assert.Contains<string>("Pork Sausage", mmc.Ingredients);
            Assert.Equal<int>(3, mmc.Ingredients.Count);
        }

        /// <summary>
        /// checks correct default size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.Equal<Size>(Size.Small, mmc.Size);
        }

        /// <summary>
        /// checks correct medium price
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Medium;
            Assert.Equal(1.45, mmc.Price, 2);
        }
        /// <summary>
        /// checks medium calorie count
        /// </summary>
        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Medium;
            Assert.Equal<uint>(490, mmc.Calories);
        }
        /// <summary>
        /// checks setting size to medium
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, mmc.Size);
        }
        /// <summary>
        /// checks large price
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Large;
            Assert.Equal(1.95, mmc.Price, 2);
        }
        /// <summary>
        /// checks calorie count for large
        /// </summary>
        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Large;
            Assert.Equal<uint>(520, mmc.Calories);
        }
        /// <summary>
        /// checks ability to set to large
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, mmc.Size);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldHaveCorrectDescriptions(Size sz)
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = sz;
            Assert.Equal($"{sz} Meteor Mac and Cheese", mmc.Description);
        }

        [Theory]
        [InlineData(Size.Small, "Price", "Calories", "Size")]
        [InlineData(Size.Medium, "Price", "Calories", "Size")]
        [InlineData(Size.Large, "Price", "Calories", "Size")]
        public void CheckAllNotifyPropertyChanges(Size sz, string prop1, string prop2, string prop3)
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.PropertyChanged(mmc, prop1, () => mmc.Size = sz);
            Assert.PropertyChanged(mmc, prop2, () => mmc.Size = sz);
            Assert.PropertyChanged(mmc, prop3, () => mmc.Size = sz);

        }

    }
}
