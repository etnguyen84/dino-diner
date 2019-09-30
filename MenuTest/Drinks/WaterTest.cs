using Xunit;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks
{
    /// <summary>
    /// class to check if water class has correct properties and methods
    /// </summary>
    public class WaterTest
    {

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water water = new Water();
            Assert.Equal(.10, water.Price, 2);
        }

        /// <summary>
        /// check default calories
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water water = new Water();
            Assert.Equal<uint>(0, water.Calories);
        }

        /// <summary>
        /// check default ice
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Water water = new Water();
            Assert.Equal<bool>(true, water.Ice);
        }

        /// <summary>
        /// check correct ingredients in list
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Water water = new Water();
            Assert.Contains<string>("Water", water.Ingredients);
            Assert.Equal<int>(1, water.Ingredients.Count);
        }

        /// <summary>
        /// check correct default size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Water water = new Water();
            Assert.Equal<Size>(Size.Small, water.Size);
        }

        /// <summary>
        /// check correct medium price
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal(.10, water.Price, 2);
        }

        /// <summary>
        /// check correct medium calorie count
        /// </summary>
        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<uint>(0, water.Calories);
        }

        /// <summary>
        /// check correct medium size
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, water.Size);
        }

        /// <summary>
        /// check correct price for large size
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal(.10, water.Price, 2);
        }

        /// <summary>
        ///  check correct large calorie count
        /// </summary>
        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<uint>(0, water.Calories);
        }

        /// <summary>
        /// check ability to set size to large
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, water.Size);
        }

        /// <summary>
        /// check ability to set ice to false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIceToFalse()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.False(water.Ice);
        }
        /// <summary>
        /// should be able to add lemon to drink
        /// </summary>
        [Fact]
        public void ShouldAddLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.True(water.Lemon);
            Assert.Contains<string>("Lemon", water.Ingredients);

        }
    }
}
