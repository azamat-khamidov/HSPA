using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Atlanta", "New York", "Chicago" };
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "Atlanta";
        }
    }
}
