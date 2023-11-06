using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypAkceController : ControllerBase
    {
        // GET: api/<TypAkceController>
        [HttpGet]
        public List<TypAkce> Get()
        {
            string result = Database.runProcedure("GetTypAkceList", null);
            return JsonConvert.DeserializeObject<List<TypAkce>>(result);
        }

        
    }
}
