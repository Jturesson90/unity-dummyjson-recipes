using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Recipes.Core.Models;
using Recipes.Core.Services;

[TestFixture]
public class CookBookServiceTests
{
    [Test]
    public async Task GetCookBook_CanDownloadApi()
    {
        var cookBookService = new CookBookService();
        var cookBook = await cookBookService.GetCookBookAsync();

        Assert.True(cookBook.Recipes.Any());
    }

    [Test]
    public async Task GetCookBook_GetCookBook()
    {
        var cookBookService = new CookBookService();
        var cookBook = await cookBookService.GetCookBookAsync();

        foreach (var recipe in cookBook.Recipes)
        {
            Assert.NotNull(recipe);
            Assert.NotNull(recipe.Id);
            Assert.NotNull(recipe.Name);
            Assert.NotNull(recipe.Ingredients);
            Assert.NotNull(recipe.Instructions);
        }
    }
}