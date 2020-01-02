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
            //als ik enkel de topics ophaal krijg ik geen problemen maar zodra ik een include doe krijg een "loop"
            var Topics = await _context.Topic
                //.Include(T => T.TopicCategories)
                //.ThenInclude(r => r.Category)
                .ToListAsync();
            return Topics;
        }
    }
}
