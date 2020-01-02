using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogModels.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicController : ControllerBase
    {
        private readonly ITopicRepository _context;
        public TopicController(ITopicRepository context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Topic>>> ReturnAllTopicsAsync()
        {
            var Topics = await _context.GetTopics();

            return Ok(Topics);
        }
    }
}