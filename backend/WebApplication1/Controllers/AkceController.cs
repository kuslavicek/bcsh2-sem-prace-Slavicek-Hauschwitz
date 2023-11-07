using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AkceController : ControllerBase
    {
        // GET: api/<AkceController>
        [HttpGet]
        public List<Akce> Get()
        {
            string result = Database.runProcedure("GetAkceList", null);
            return JsonConvert.DeserializeObject<List<Akce>>(result);
        }

        // GET api/<AkceController>/5
        [HttpGet("{id}")]
        public Akce Get(int id)
        {
            string result = Database.runProcedure("GetAkce", new Param[]
            {
                new Param()
                {
                    Name="p_id",
                    type = Oracle.ManagedDataAccess.Client.OracleDbType.Decimal,
                    Value=id
                }
            });
            return Akce.FromString(result);
        }

        // POST api/<AkceController>
        [HttpPost]
        public string Post()
        {
            Param[] parameters = new Param[]
            {
                new Param
                    {
                        Name = "p_pocet",
                        type = OracleDbType.Int64,
                        Value = Convert.ToInt64(HttpContext.Request.Query["pocet"])
                    },
                new Param
                    {
                        Name = "p_datum",
                        type = OracleDbType.Date,
                        Value = Convert.ToDateTime(HttpContext.Request.Query["datum"])
                    },
                new Param
                    {
                        Name = "p_typAkce",
                        type = OracleDbType.Int64,
                        Value = Convert.ToInt64(HttpContext.Request.Query["typ"])
                    },
                new Param
                    {
                        Name = "p_idObjednavky",
                        type = OracleDbType.Int64,
                        Value = Convert.ToInt64(HttpContext.Request.Query["idObjednavky"])
                    },
            };
            string result = Database.runProcedure("CreateAkce", parameters);
            return result;
        }

        // PUT api/<AkceController>/5
        [HttpPut("{id}")]
        public string Put(int id)
        {
            Param[] parameters = new Param[]
            {
                new Param
                    {
                        Name = "p_id",
                        type = OracleDbType.Int64,
                        Value = id
                    },
                new Param
                    {
                        Name = "p_pocet",
                        type = OracleDbType.Int64,
                        Value = Convert.ToInt64(HttpContext.Request.Query["pocet"])
                    },
                new Param
                    {
                        Name = "p_datum",
                        type = OracleDbType.Date,
                        Value = Convert.ToDateTime(HttpContext.Request.Query["datum"])
                    },
                new Param
                    {
                        Name = "p_typAkce",
                        type = OracleDbType.Int64,
                        Value = Convert.ToInt64(HttpContext.Request.Query["typ"])
                    },
                new Param
                    {
                        Name = "p_idObjednavky",
                        type = OracleDbType.Int64,
                        Value = Convert.ToInt64(HttpContext.Request.Query["idObjednavky"])
                    },
            };
            string result = Database.runProcedure("UpdateAkce", parameters);
            return result;
        }

        // DELETE api/<AkceController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            string result = Database.runProcedure("DeleteAkce", new Param[]
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
