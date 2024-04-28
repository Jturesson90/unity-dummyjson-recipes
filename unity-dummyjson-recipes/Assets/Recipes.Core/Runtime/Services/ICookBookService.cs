using System.Threading.Tasks;
using Recipes.Core.Models;

namespace Recipes.Core.Services
{
    public interface ICookBookService
    {
        Task<CookBook> GetCookBookAsync();
    }
}