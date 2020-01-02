using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogModels.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DBContext _context;
        public CategoryRepository(DBContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Category>> GetCategories()
        {
            //als ik enkel de categories ophaal krijg ik geen problemen maar zodra ik een include doe krijg een "loop"
            var Categories = await _context.Category
                //.Include(T => T.TopicCategories)
                //.ThenInclude(r => r.Topic)
                .ToListAsync();
            return Categories;

        }
    }
}
