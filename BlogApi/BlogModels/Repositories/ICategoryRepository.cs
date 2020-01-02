using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogModels.Models
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategories();
    }
}