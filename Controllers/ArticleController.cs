using daily_backend.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using daily_backend.Models;

namespace daily_backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public ArticleController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<Article>>> GetArticles()
        {
            var articles = await _context.Articles.ToListAsync();
            return Ok(articles);
        }
    }
}
