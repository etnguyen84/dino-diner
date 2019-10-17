using Xunit;
using DinoDiner.Menu;
/* Author: Ethan Nguyen
 * Class: SodasaurusTest.cs
 */
namespace MenuTest.Drinks
{
    /// <summary>
    /// Class for unit tests for sodasaurus class
    /// </summary>
    public class SodasaurusTest
    {
        /// <summary>
        /// Check default price
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal(1.50, soda.Price, 2);
        }

        /// <summary>
        /// check default calories
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<uint>(112, soda.Calories);
        }

        /// <summary>
        /// check default ice
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<bool>(true, soda.Ice);
        }

        /// <summary>
        /// check correct ingredients in list
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Contains<string>("Water", soda.Ingredients);
            Assert.Contains<string>("Natural Flavors", soda.Ingredients);
            Assert.Contains<string>("Cane Sugar", soda.Ingredients);
            Assert.Equal<int>(3, soda.Ingredients.Count);
        }

        /// <summary>
        /// check correct default size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<Size>(Size.Small, soda.Size);
        }

        /// <summary>
        /// check correct medium price
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal(2.00, soda.Price, 2);
        }

        /// <summary>
        /// check correct medium calorie count
        /// </summary>
        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<uint>(156, soda.Calories);
        }

        /// <summary>
        /// check correct medium size
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, soda.Size);
        }

        /// <summary>
        /// check correct price for large size
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal(2.50, soda.Price, 2);
        }

        /// <summary>
        ///  check correct large calorie count
        /// </summary>
        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<uint>(208, soda.Calories);
        }

        /// <summary>
        /// check ability to set size to large
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, soda.Size);
        }

        /// <summary>
        /// check ability to set ice to false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIceToFalse()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }

        /// <summary>
        /// check ability to set flavors
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavors()
        {
            Sodasaurus soda = new Sodasaurus();

            foreach (SodasaurusFlavor sf in System.Enum.GetValues(typeof(SodasaurusFlavor)))
            {
                soda.Flavor = sf;
                Assert.Equal<SodasaurusFlavor>(sf, soda.Flavor);
            }
        }


    }
}
