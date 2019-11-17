using System.Threading.Tasks;
using Bitacora_Project.api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bitacora_Project.api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ActividadesController : ControllerBase
    {
        private readonly DataContext _context;
        public ActividadesController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> GetAll()
        {
            var Actividades = await _context.Actividades.ToListAsync();

            return Ok(Actividades);
        }
    }
}