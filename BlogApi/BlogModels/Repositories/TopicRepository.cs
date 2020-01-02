using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogModels.Models
{
    public class TopicRepository : ITopicRepository
    {
        private readonly DBContext _context;
        public TopicRepository(DBContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Topic>> GetTopics()
        {
            var Topics = await _context.Topic
                .Include(T => T.TopicCategories)
                .ThenInclude(r => r.Category)
                .ToListAsync();
            return Topics;
        }
    }
}
