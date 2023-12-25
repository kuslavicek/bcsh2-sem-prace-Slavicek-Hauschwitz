using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
        public string Login([FromBody] string username, [FromBody] string password)
        {
            return null ;
        }

        // POST api/<UserController>
        [HttpPost]
        public string Register([FromBody] string username, [FromBody] string password)
        {
            return null;
        }
    }
}
