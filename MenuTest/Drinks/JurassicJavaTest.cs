using Xunit;
using DinoDiner.Menu;
/* Author: Ethan Nguyen
 * Class: JurassicJavaTest.cs
 */
namespace MenuTest.Drinks
{
    /// <summary>
    /// class to check if jurassic java holds correct properties and proper methods
    /// </summary>
    public class JurassicJavaTest
    {
        /// <summary>
        /// check default price
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal(0.59, java.Price, 2);
        }
        /// <summary>
        /// test to check default calories
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<uint>(2, java.Calories);
        }
        /// <summary>
        /// test to check default ice should be false
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.Ice);
        }
        /// <summary>
        /// should have no room for cream default
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSpaceForCream()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.RoomForCream);
        }
        /// <summary>
        /// should have correct ingredients
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurassicJava java = new JurassicJava();
            Assert.Contains<string>("Water", java.Ingredients);
            Assert.Contains<string>("Coffee", java.Ingredients);
            Assert.Equal<int>(2, java.Ingredients.Count);
        }
        /// <summary>
        /// should have correct default size as small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }
        /// <summary>
        /// should have correct price for medium
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal(.99, java.Price, 2);
        }
        /// <summary>
        ///  should have correct calorie count for medium
        /// </summary>
        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<uint>(4, java.Calories);
        }

        /// <summary>
        /// should be able to set size to medium
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, java.Size);
        }
        /// <summary>
        /// should have correct price for large
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal(1.49, java.Price, 2);
        }
        /// <summary>
        /// should have correct calories for large
        /// </summary>
        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<uint>(8, java.Calories);
        }
        /// <summary>
        /// should be able to set size to large
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, java.Size);
        }

        /// <summary>
        /// should be able to add ice
        /// </summary>
        [Fact]
        public void ShouldBeAbleToAddIce()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }
        /// <summary>
        /// should be able to leave room for cream
        /// </summary>
        [Fact]
        public void ShouldBeAbleToRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }
    }
}
