﻿using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;
/* Author: Nathan Bean
* Class: PterodactylWingsUnitTest.cs
*/
namespace MenuTest.Entrees
{
    public class PterodactylWingsUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.Equal(7.21, pw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.Equal<uint>(318, pw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            PterodactylWings pw = new PterodactylWings();
            List<string> ingredients = pw.Ingredients;
            Assert.Contains<string>("Chicken", ingredients);
            Assert.Contains<string>("Wing Sauce", ingredients);
            Assert.Equal<int>(2, ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.Equal("Pterodactyl Wings", pw.Description);
        }

        [Fact]
        public void SpecialsShouldBeEmpty()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.Empty(pw.Special);
        }
    }
}
