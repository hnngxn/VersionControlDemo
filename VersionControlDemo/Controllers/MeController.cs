using Microsoft.AspNetCore.Mvc;

namespace VersionControlDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { name = "Han Nguyen" });
        }
    }
}