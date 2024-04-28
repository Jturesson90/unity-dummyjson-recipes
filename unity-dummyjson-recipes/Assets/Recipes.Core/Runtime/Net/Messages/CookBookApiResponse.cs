using Recipes.Core.Models;

namespace Recipes.Core.Net.Messages
{
    public class CookBookApiResponse
    {
        public Recipe[] Recipes { get; set; }
    }
}