using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogModels.Models
{
    public interface ITopicRepository
    {
        Task<IEnumerable<Topic>> GetTopics();
    }
}