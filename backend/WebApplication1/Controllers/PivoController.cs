using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PivoController : ControllerBase
    {
        // GET: api/<PivoController>
        [HttpGet]
        public List<Pivo> Get()
        {
            string result = Database.runProcedure("GetPivoList", null);
            return JsonConvert.DeserializeObject<List<Pivo>>(result);
        }
    }
}
