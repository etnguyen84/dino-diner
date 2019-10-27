using Xunit;
using DinoDiner.Menu;

/* Author: Nathan Bean
 * Class: FryceritopsTest.cs
 */
namespace MenuTest.Sides
{
    /// <summary>
    /// tests for fryceritops side
    /// </summary>
    public class FryceritopsTest
    {
        /// <summary>
        /// checks for correct default price
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Equal(0.99, ft.Price, 2);
        }

        /// <summary>
        /// checks for correct default calories
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Equal<uint>(222, ft.Calories);
        }

        /// <summary>
        /// checks for correct ingredients list
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Contains<string>("Potato", ft.Ingredients);
            Assert.Contains<string>("Salt", ft.Ingredients);
            Assert.Contains<string>("Vegetable Oil", ft.Ingredients);
            Assert.Equal<int>(3, ft.Ingredients.Count);
        }

        /// <summary>
        /// checks correct default size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Equal<Size>(Size.Small, ft.Size);
        }

        /// <summary>
        /// checks medium price
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Medium;
            Assert.Equal(1.45, ft.Price, 2);
        }
        /// <summary>
        /// checks medium calories
        /// </summary>
        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Medium;
            Assert.Equal<uint>(365, ft.Calories);
        }

        /// <summary>
        /// checks medium size
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, ft.Size);
        }
        /// <summary>
        /// checks large price
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Large;
            Assert.Equal(1.95, ft.Price, 2);
        }
        /// <summary>
        /// checks large calorie count
        /// </summary>
        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Large;
            Assert.Equal<uint>(480, ft.Calories);
        }
        /// <summary>
        /// checks ability to set to large
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, ft.Size);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldHaveCorrectDescriptions(Size sz)
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = sz;
            Assert.Equal($"{sz} Fryceritops", ft.Description);
        }

        [Theory]
        [InlineData(Size.Small, "Price", "Calories", "Size")]
        [InlineData(Size.Medium, "Price", "Calories", "Size")]
        [InlineData(Size.Large, "Price", "Calories", "Size")]
        public void CheckAllNotifyPropertyChanges(Size sz, string prop1, string prop2, string prop3)
        {
            Fryceritops ft = new Fryceritops();
            Assert.PropertyChanged(ft, prop1, () => ft.Size = sz);
            Assert.PropertyChanged(ft, prop2, () => ft.Size = sz);
            Assert.PropertyChanged(ft, prop3, () => ft.Size = sz);

        }








        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void FryceritopsDescriptionTest(Size size)
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = size;
            Assert.Equal($"{size} Fryceritops", ft.Description);
        }

        [Fact]
        public void FryceritopsSpecialsTest()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Empty(ft.Special);
        }

        [Fact]
        public void FryceritopsNotifyPropertyChangedTest()
        {
            Fryceritops ft = new Fryceritops();

           /* Assert.PropertyChanged(ft, "Price", () =>
            {
                ft.Price = 10;
            });
            Assert.PropertyChanged(ft, "Calories", () =>
            {
                ft.Calories = 10;
            });*/

            string[] sizeProperties = { "Size", "Price", "Calories", "Description" };
            foreach (string property in sizeProperties)
                Assert.PropertyChanged(ft, property, () =>
                {
                    ft.Size = Size.Large;
                });
        }
    }
}
