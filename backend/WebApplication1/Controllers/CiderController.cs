using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CiderController : ControllerBase
    {
        // GET: api/<CiderController>
        [HttpGet]
        public List<Cider> Get()
        {
            string result = Database.runProcedure("GetCiderList", null);
            return JsonConvert.DeserializeObject<List<Cider>>(result);
        }

        // GET api/<CiderController>/5
        [HttpGet("{id}")]
        public Cider Get(int id)
        {
            string result = Database.runProcedure("GetCider", new Param[]
             {
                new Param()
                {
                    Name="p_id",
                    type = Oracle.ManagedDataAccess.Client.OracleDbType.Decimal,
                    Value=id
                }
             });
            return Cider.FromString(result);
        }

     }

        
}
