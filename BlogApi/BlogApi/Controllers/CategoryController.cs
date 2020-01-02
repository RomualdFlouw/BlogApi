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
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _context;
        public CategoryController(ICategoryRepository context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> ReturnAllCategoriesAsync()
        {
            var Categories = await _context.GetCategories();

            return Ok(Categories);
        }
    }
}