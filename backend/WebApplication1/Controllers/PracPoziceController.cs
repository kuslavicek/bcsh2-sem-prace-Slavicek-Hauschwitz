using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PracPoziceController : ControllerBase
    {
        // GET: api/<PracPoziceController>
        [HttpGet]
        public List<PracovniPozice> Get()
        {
            string result = Database.runProcedure("GetPracovniPoziceList", null);
            return JsonConvert.DeserializeObject<List<PracovniPozice>>(result);
        }

        // GET api/<PracPoziceController>/5
        [HttpGet("{id}")]
        public PracovniPozice Get(int id)
        {
            string result = Database.runProcedure("GetPracovniPozice", new Param[]
            {
                new Param()
                {
                    Name="p_id",
                    type = OracleDbType.Decimal,
                    Value=id
                }
            });
            return PracovniPozice.FromString(result);
        }

        // POST api/<PracPoziceController>
        [HttpPost]
        public string Post()
        {
            Param[] parameters = new Param[]
            {
                new Param()
                {
                    Name = "p_jmeno",
                    type = OracleDbType.Varchar2,
                    Value = HttpContext.Request.Query["jmeno"]
                },
                new Param()
                {
                    Name = "p_plat",
                    type = OracleDbType.Decimal,
                    Value = HttpContext.Request.Query["plat"]
                }
            };
            string result = Database.runProcedure("InsertPracPozice", parameters);
            return result;

        }

        // PUT api/<PracPoziceController>/5
        [HttpPut("{id}")]
        public string Put(int id)
        {
            Param[] parameters = new Param[]
            {
                new Param()
                {
                    Name = "p_id",
                    type = OracleDbType.Varchar2,
                    Value = HttpContext.Request.Query["id"]
                },
                new Param()
                {
                    Name = "p_jmeno",
                    type = OracleDbType.Varchar2,
                    Value = HttpContext.Request.Query["jmeno"]
                },
                new Param()
                {
                    Name = "p_plat",
                    type = OracleDbType.Decimal,
                    Value = HttpContext.Request.Query["plat"]
                }
            };
            string result = Database.runProcedure("InsertPracPozice", parameters);
            return result;
        }

        // DELETE api/<PracPoziceController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            string result = Database.runProcedure("DeletePracPozice", new Param[]
            {
                new Param()
                {
                    Name="p_id",
                    type = OracleDbType.Int64,
                    Value=id
                }
            });
            return result;
        }
    }
}
