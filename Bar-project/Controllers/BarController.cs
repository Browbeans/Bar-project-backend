using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bar_project.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bar_project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BarController : ControllerBase
    {
        private readonly BarService _barService;

        public BarController(BarService barService) {
            _barService = barService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _barService.GetBarAsync());
        }
    }
}
