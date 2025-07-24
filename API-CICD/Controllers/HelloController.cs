using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_CICD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello from Railway!");
        }
    }
}
