using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Recipes.Core.Models;
using Recipes.Core.Net.Messages;

namespace Recipes.Core.Services
{
    public class CookBookService : ICookBookService
    {
        private const string RecipeURL = "https://dummyjson.com/recipes";
        private readonly HttpClient _client = new();

        public async Task<CookBook> GetCookBookAsync()
        {
            string content = await _client.GetStringAsync(RecipeURL);
            var cookBook = JsonConvert.DeserializeObject<CookBookApiResponse>(content);

            return new CookBook
            {
                Recipes = cookBook.Recipes
            };
        }
    }
}