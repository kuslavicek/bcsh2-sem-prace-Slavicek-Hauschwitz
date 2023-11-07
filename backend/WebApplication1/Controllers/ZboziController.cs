using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZboziController : ControllerBase
    {
        // GET: api/<ZboziController>
        [HttpGet]
        public List<Zbozi> Get()
        {
            string result = Database.runProcedure("GetZboziList", null);
            return JsonConvert.DeserializeObject<List<Zbozi>>(result);
        }

        // GET api/<ZboziController>/5
        [HttpGet("{id}")]
        public Zbozi Get(int id)
        {
            string result = Database.runProcedure("GetZbozi", new Param[]
             {
                new Param()
                {
                    Name="p_id",
                    type = Oracle.ManagedDataAccess.Client.OracleDbType.Decimal,
                    Value=id
                }
             });
            return Zbozi.FromString(result);
        }

        // POST api/<ZboziController>
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
                    Name = "p_obsah",
                    type = OracleDbType.Decimal,
                    Value = Convert.ToDecimal(HttpContext.Request.Query["obsah"])
                },
                new Param()
                {
                    Name = "p_typ",
                    type = OracleDbType.Char,
                    Value = HttpContext.Request.Query["typ"]
                },
                new Param()
                {
                    Name = "p_cena",
                    type = OracleDbType.Decimal,
                    Value = Convert.ToDecimal(HttpContext.Request.Query["cena"])
                },
                new Param()
                {
                    Name = "p_idSklad",
                    type = OracleDbType.Int64,
                    Value = Convert.ToInt64(HttpContext.Request.Query["idSklad"])
                },
            };
            string result = Database.runProcedure("InsertZbozi", parameters);
            return result;
        }

        // PUT api/<ZboziController>/5
        [HttpPut("{id}")]
        public string Put(int id)
        {
            Param[] parameters = new Param[]
            {
                new Param()
                {
                    Name = "p_id",
                    type = OracleDbType.Int64,
                    Value = id
                },
                new Param()
                {
                    Name = "p_jmeno",
                    type = OracleDbType.Varchar2,
                    Value = HttpContext.Request.Query["jmeno"]
                },
                new Param()
                {
                    Name = "p_obsah",
                    type = OracleDbType.Decimal,
                    Value = Convert.ToDecimal(HttpContext.Request.Query["obsah"])
                },
                new Param()
                {
                    Name = "p_typ",
                    type = OracleDbType.Char,
                    Value = HttpContext.Request.Query["typ"]
                },
                new Param()
                {
                    Name = "p_cena",
                    type = OracleDbType.Decimal,
                    Value = Convert.ToDecimal(HttpContext.Request.Query["cena"])
                },
                new Param()
                {
                    Name = "p_idSklad",
                    type = OracleDbType.Int64,
                    Value = Convert.ToInt64(HttpContext.Request.Query["idSklad"])
                },
            };
            string result = Database.runProcedure("UpdateZbozi", parameters);
            return result;
        }

        // DELETE api/<ZboziController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            string result = Database.runProcedure("DeleteZbozi", new Param[]
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
