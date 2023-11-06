using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PivovarController : ControllerBase
    {
        // GET: api/<PivovarController>
        [HttpGet]
        public List<Pivovar> Get()
        {
            string result = Database.runProcedure("GetPivovarList", null);
            return JsonConvert.DeserializeObject<List<Pivovar>>(result);
        }

        // GET api/<PivovarController>/5
        [HttpGet("{id}")]
        public Pivovar Get(int id)
        {
            string result = Database.runProcedure("GetPivovar", new Param[]
            {
                new Param()
                {
                    Name="p_id",
                    type = Oracle.ManagedDataAccess.Client.OracleDbType.Decimal,
                    Value=id
                }
            });
            return Pivovar.FromString(result);
        }

        // POST api/<PivovarController>
        [HttpPost]
        public string Post()
        {
            Param[] adresa = new Param[]
            { new Param{
                    Name = "p_ulice",
                    type = OracleDbType.Varchar2,
                    Value = HttpContext.Request.Query["ulice"]
                },
                new Param
                {
                    Name = "p_mesto",
                    type = OracleDbType.Varchar2,
                    Value = HttpContext.Request.Query["mesto"]
                },
                new Param
                {
                    Name = "p_psc",
                    type = OracleDbType.Int64,
                    Value = Convert.ToInt64(HttpContext.Request.Query["psc"])
                },
                new Param
                {
                    Name = "p_cislo_popisne",
                    type = OracleDbType.Int64,
                    Value = Convert.ToInt64(HttpContext.Request.Query["cislo_popisne"])
                },
                new Param
                {
                    Name = "p_stat",
                    type = OracleDbType.Varchar2,
                    Value = HttpContext.Request.Query["stat"]
                } };
            string adresaId = Database.runProcedure("GetIdAdresa", adresa);
            if (adresaId.Equals("0"))
            {
                Database.runProcedure("CreateAdresa", adresa);
                adresaId = Database.runProcedure("GetIdAdresa", adresa);
            }
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
                    Name = "p_kategorie",
                    type = OracleDbType.Varchar2,
                    Value = HttpContext.Request.Query["kategorie"]
                },
                new Param()
                {
                    Name = "p_idAdresa",
                    type = OracleDbType.Int64,
                    Value = adresaId.ToString()
                }
            };
            string result = Database.runProcedure("InsertPivovar", parameters);
            return result;

        }

        // PUT api/<PivovarController>/5
        [HttpPut("{id}")]
        public string Put(int id)
        {
            Param[] adresa = new Param[]
            { new Param{
                    Name = "p_ulice",
                    type = OracleDbType.Varchar2,
                    Value = HttpContext.Request.Query["ulice"]
                },
                new Param
                {
                    Name = "p_mesto",
                    type = OracleDbType.Varchar2,
                    Value = HttpContext.Request.Query["mesto"]
                },
                new Param
                {
                    Name = "p_psc",
                    type = OracleDbType.Int64,
                    Value = Convert.ToInt64(HttpContext.Request.Query["psc"])
                },
                new Param
                {
                    Name = "p_cislo_popisne",
                    type = OracleDbType.Int64,
                    Value = Convert.ToInt64(HttpContext.Request.Query["cislo_popisne"])
                },
                new Param
                {
                    Name = "p_stat",
                    type = OracleDbType.Varchar2,
                    Value = HttpContext.Request.Query["stat"]
                } };
            string adresaId = Database.runProcedure("GetIdAdresa", adresa);
            if (adresaId.Equals("0"))
            {
                Database.runProcedure("CreateAdresa", adresa);
                adresaId = Database.runProcedure("GetIdAdresa", adresa);
            }
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
                    Name = "p_kategorie",
                    type = OracleDbType.Varchar2,
                    Value = HttpContext.Request.Query["kategorie"]
                },
                new Param()
                {
                    Name = "p_idAdresa",
                    type = OracleDbType.Int64,
                    Value = adresaId.ToString()
                }
            };
            string result = Database.runProcedure("UpdatePivovar", parameters);
            return result;

        }

        // DELETE api/<PivovarController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            string result = Database.runProcedure("DeletePivovar", new Param[]
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
