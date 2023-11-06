using Microsoft.AspNetCore.Mvc;
using Oracle.ManagedDataAccess.Client;
using Newtonsoft.Json;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurovinaController : ControllerBase
    {
        // GET: api/<SurovinaController>
        [HttpGet]
        public List<Surovina> Get()
        {
            string result = Database.runProcedure("GetSurovinaList", null);
            return JsonConvert.DeserializeObject<List<Surovina>>(result);
        }

        // GET api/<SurovinaController>/5
        [HttpGet("{id}")]
        public Surovina Get(int id)
        {
            string result = Database.runProcedure("GetSurovina", new Param[]
            {
                new Param()
                {
                    Name="p_id",
                    type = Oracle.ManagedDataAccess.Client.OracleDbType.Decimal,
                    Value=id
                }
            });
            Surovina sur = JsonConvert.DeserializeObject<Surovina>(result);
            return sur;
        }

        // POST api/<SurovinaController>
        [HttpPost]
        public string Post()
        {
            Param[] parameters = new Param[]
                { new Param{
                    Name = "p_nazev",
                    type = OracleDbType.Varchar2,
                    Value = HttpContext.Request.Query["nazev"]
                },
                new Param
                {
                    Name = "p_mnozstvi",
                    type = OracleDbType.Int32,
                    Value = Convert.ToInt32(HttpContext.Request.Query["mnozstvi"])
                },
                new Param
                {
                    Name = "p_idSklad",
                    type = OracleDbType.Int32,
                    Value = Convert.ToInt32(HttpContext.Request.Query["idSklad"])
                },
           };
            string result = Database.runProcedure("InsertSurovina", parameters);
            return result;
        }

        // PUT api/<SurovinaController>/5
        [HttpPut("{id}")]
        public string Put(int id)
        {
            Param[] parameters = new Param[]
                { new Param{
                    Name = "p_id",
                    type = OracleDbType.Int64,
                    Value = id
                },
                    new Param{
                    Name = "p_nazev",
                    type = OracleDbType.Varchar2,
                    Value = HttpContext.Request.Query["ulice"]
                },
                new Param
                {
                    Name = "p_mnozstvi",
                    type = OracleDbType.Decimal,
                    Value = HttpContext.Request.Query["mnozstvi"]
                },
                new Param
                {
                    Name = "p_idSklad",
                    type = OracleDbType.Int64,
                    Value = HttpContext.Request.Query["idSklad"]
                },
           };
            string result = Database.runProcedure("InsertSurovina", parameters);
            return result;
        }

        // DELETE api/<SurovinaController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            string result = Database.runProcedure("DeleteSurovina", new Param[]
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
