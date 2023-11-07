using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjednaneZboziController : ControllerBase
    {
        // GET: api/<ObjednaneZboziController>
        [HttpGet]
        public List<ObjednaneZbozi> Get()
        {
            string result = Database.runProcedure("GetObjednaneZboziList", null);
            return JsonConvert.DeserializeObject<List<ObjednaneZbozi>>(result);
        }

        // GET api/<ObjednaneZboziController>/5
        [HttpGet("{id}")]
        public ObjednaneZbozi Get(int id)
        {
            string result = Database.runProcedure("GetObjednaneZbozi", new Param[]
            {
                new Param()
                {
                    Name="p_id",
                    type = Oracle.ManagedDataAccess.Client.OracleDbType.Decimal,
                    Value=id
                }
            });
            return ObjednaneZbozi.FromString(result);
        }

        // POST api/<ObjednaneZboziController>
        [HttpPost]
        public string Post()
        {
            Param[] parameters = new Param[]
            { new Param{
                    Name = "p_mnozstvi",
                    type = OracleDbType.Int64,
                    Value = Convert.ToInt64(HttpContext.Request.Query["mnozstvi"])
                },
                new Param
                {
                    Name = "p_idObjednavka",
                    type = OracleDbType.Int64,
                    Value = Convert.ToInt64(HttpContext.Request.Query["idObjednavka"])
                },
                new Param
                {
                    Name = "p_idZbozi",
                    type = OracleDbType.Int64,
                    Value = Convert.ToInt64(HttpContext.Request.Query["idZbozi"])
                }
            };
            string result = Database.runProcedure("CreateObjednaneZbozi", parameters);
            return result;
        }

        // PUT api/<ObjednaneZboziController>/5
        [HttpPut("{id}")]
        public string Put(int id)
        {
            Param[] parameters = new Param[]
            {
                new Param{
                    Name = "p_id",
                    type = OracleDbType.Int64,
                    Value = id
                },
                new Param{
                    Name = "p_mnozstvi",
                    type = OracleDbType.Int64,
                    Value = Convert.ToInt64(HttpContext.Request.Query["mnozstvi"])
                },
                new Param
                {
                    Name = "p_idObjednavka",
                    type = OracleDbType.Int64,
                    Value = Convert.ToInt64(HttpContext.Request.Query["idObjednavka"])
                },
                new Param
                {
                    Name = "p_idZbozi",
                    type = OracleDbType.Int64,
                    Value = Convert.ToInt64(HttpContext.Request.Query["idZbozi"])
                }
            };
            string result = Database.runProcedure("UpdateObjednaneZbozi", parameters);
            return result;
        }

        // DELETE api/<ObjednaneZboziController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            string result = Database.runProcedure("DeleteObjednaneZbozi", new Param[]
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
