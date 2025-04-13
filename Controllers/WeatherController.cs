using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Merhaba Mahmut, hava güneşli :)");
        }
    }
}