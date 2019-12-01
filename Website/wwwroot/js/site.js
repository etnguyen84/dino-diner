// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

var menuItems = document.getElementsByClassName("menu-item");

var form = document.getElementById("search-and-filter-form");

form.addEventListener("submit", function (event) {
    event.preventDefault();
    var i, item;

    var searchTerm = document.getElementById("search").value;

    var menuCategory = [];
    var menuCategoryCheckBoxes = document.getElementsByClassName("menu-category");
    for (i = 0; i < menuCategoryCheckBoxes.length; i++) {
        if (menuCategoryCheckBoxes[i].checked) {
            menuCategory.push(menuCategoryCheckBoxes[i].value);
        }
    }

    var minPrice = document.getElementById("minimum-price").value;
    if (minPrice == 0) minPrice = false;
    var maxPrice = document.getElementById("maximum-price").value;
    if (maxPrice == 0) maxPrice = false;

    var exclusions = [];
    var exlusionCheckBoxes = document.getElementsByClassName("exclude-ingredient");
    for (i = 0; i < exlusionCheckBoxes.length; i++) {
        if (exlusionCheckBoxes[i].checked) {
            exclusions.push(exlusionCheckBoxes[i].value);
        }
    }

    for (i = 0; i < menuItems.length; i++) {
        var item = menuItems[i];
        item.style.display = "block";

        if (searchTerm) {
            if (!item.dataset.description.toLowerCase().includes(searchTerm.toLowerCase())) {
                item.style.display = "none";
            }
        }

        if (menuCategory.length > 0) {
            if (!menuCategory.includes(item.dataset.category)) {
                item.style.display = "none"
            }
        }

        if (minPrice) {
            if (parseFloat(minPrice) > parseFloat(item.dataset.price)) {
                item.style.display = "none";
            }
        }

        if (maxPrice) {
            if (parseFloat(maxPrice) < parseFloat(item.dataset.price)) {
                item.style.display = "none";
            }
        }

        if (exclusions.length > 0) {
            var ingredients = item.getElementsByClassName("ingredient");

            for (var j = 0; j < ingredients.length; j++) {
                if (exclusions.includes(ingredients[j].dataset.ingredient)) {
                    item.style.display = "none";
                }
            }
        }
    }

});