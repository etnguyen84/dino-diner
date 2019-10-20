using Xunit;
using DinoDiner.Menu;
/* Author: Ethan Nguyen
 * Class: TyrannoteaTest.cs
 */
namespace MenuTest.Drinks
{   
    /// <summary>
    /// Class to check if the tyrannotea class has correct properties and methods
    /// </summary>
    public class TyrannoteaTest
    {
        /// <summary>
        /// check default price
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal(0.99, tea.Price, 2);
        }

        /// <summary>
        /// check default calorie count
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<uint>(8, tea.Calories);
        }
        /// <summary>
        /// check default ice value
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }
        /// <summary>
        /// check default lemon value
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Lemon);
        }
        /// <summary>
        /// check default sweet value
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Sweet);
        }
        /// <summary>
        /// check correct ingredient value
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Equal<int>(2, tea.Ingredients.Count);
        }
        /// <summary>
        /// check correct default size is small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, tea.Size);
        }
        /// <summary>
        /// check correct medium price
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal(1.49, tea.Price, 2);
        }
        /// <summary>
        /// check calorie count for medium
        /// </summary>
        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }
        /// <summary>
        /// check ability to set size to medium
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, tea.Size);
        }
        /// <summary>
        /// check price for large
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal(1.99, tea.Price, 2);
        }
        /// <summary>
        /// check calorie count for large
        /// </summary>
        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }
        /// <summary>
        /// check ability to set size to large
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, tea.Size);
        }
        /// <summary>
        /// check ability to hold ice
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIceToFalse()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }

        /// <summary>
        /// check ability to add lemon
        /// </summary>
        [Fact]
        public void ShouldAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.Lemon);
        }

        /// <summary>
        /// check if sweetener increases calories
        /// </summary>
        [Fact]
        public void SweetenerIncreasesCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;

            Assert.Equal<uint>(16, tea.Calories);
            tea.Size = Size.Medium;
            Assert.Equal<uint>(32, tea.Calories);
            tea.Size = Size.Large;
            Assert.Equal<uint>(64, tea.Calories);

        }
        /// <summary>
        /// check if removing the sweetener decreases calories
        /// </summary>
        [Fact]
        public void RemovingSweetenerDecreasesCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Sweet = false;

            Assert.Equal<uint>(8, tea.Calories);
            tea.Size = Size.Medium;

            Assert.Equal<uint>(16, tea.Calories);
            tea.Size = Size.Large;

            Assert.Equal<uint>(32, tea.Calories);
        }
        /// <summary>
        /// check correct ingredient value
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredientsWithLemonSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            tea.Sweet = true;
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Contains<string>("Cane Sugar", tea.Ingredients);
            Assert.Contains<string>("Lemon", tea.Ingredients);
            Assert.Equal<int>(4, tea.Ingredients.Count);
        }

        [Theory]
        [InlineData(Size.Small, "Price", "Calories", "Size")]
        [InlineData(Size.Medium, "Price", "Calories", "Size")]
        [InlineData(Size.Large, "Price", "Calories", "Size")]
        public void CheckSizePropertyChanges(Size sz, string prop1, string prop2, string prop3)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, prop1, () => tea.Size = sz);
            Assert.PropertyChanged(tea, prop2, () => tea.Size = sz);
            Assert.PropertyChanged(tea, prop3, () => tea.Size = sz);

        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldHaveCorrectDescriptions(Size sz)
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = sz;
            Assert.Equal($"{sz} Tyrannotea", tea.Description);
            tea.Sweet = true;
            Assert.Equal($"{sz} Sweet Tyrannotea", tea.Description);
        }

        [Fact]
        public void SweetShouldNotify()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Calories", () => tea.Sweet = true);
        }


        [Fact]
        public void LemonShouldNotify()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Special", () => tea.AddLemon());
        }

        [Fact]
        public void HoldIceShouldNotify()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Special", () => tea.HoldIce());
        }

        [Fact]
        public void LemonShouldAddSpecial()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.Contains<string>("Add Lemon", tea.Special);
        }

        [Fact]
        public void HoldIceShouldChangeSpecial()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.Contains<string>("Hold Ice", tea.Special);
        }

        [Fact]
        public void HoldLemonIceShouldChangeSpecial()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.Contains<string>("Hold Ice", tea.Special);
            tea.AddLemon();
            Assert.Contains<string>("Add Lemon", tea.Special);
        }




    }
}
