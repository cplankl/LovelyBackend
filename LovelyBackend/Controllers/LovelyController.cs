using Microsoft.AspNetCore.Mvc;

namespace LovelyBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LovelyController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "from API with love";
        }
    }
}