using Microsoft.AspNetCore.Mvc;

namespace Stefanini.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TesteController() : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            return Ok("Teste");
        }
    }
}
