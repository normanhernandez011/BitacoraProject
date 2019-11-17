using System.Threading.Tasks;
using Bitacora_Project.api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bitacora_Project.api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly DataContext _context;
        public CategoryController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> GetAll()
        {
            var categories = await _context.Categories.ToListAsync();

            return Ok(categories);
        }
    }
}