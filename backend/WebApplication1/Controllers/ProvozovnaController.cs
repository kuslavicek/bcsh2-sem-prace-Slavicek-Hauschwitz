using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvozovnaController : ControllerBase
    {
        // GET: api/<ProvozovnaController>
        [HttpGet]
        public List<Provozovna> Get()
        {
            string result = Database.runProcedure("GetProvozovnaList", null);
            return JsonConvert.DeserializeObject<List<Provozovna>>(result);
        }

        // GET api/<ProvozovnaController>/5
        [HttpGet("{id}")]
        public Provozovna Get(int id)
        {
            string result = Database.runProcedure("GetProvozovna", new Param[]
            {
                new Param()
                {
                    Name="p_id",
                    type = Oracle.ManagedDataAccess.Client.OracleDbType.Decimal,
                    Value=id
                }
            });
            return Provozovna.FromString(result);
        }

        // POST api/<ProvozovnaController>
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
                string vlozeniAdresy = Database.runProcedure("CreateAdresa", adresa);
                adresaId = Database.runProcedure("GetIdAdresa", adresa);
            }
            Param[] parameters = new Param[]
            {
                new Param
                {
                    Name = "p_jmeno",
                    type = OracleDbType.Varchar2,
                    Value= HttpContext.Request.Query["jmeno"]
                },
                new Param
                {
                    Name = "p_pocetZamestnancu",
                    type = OracleDbType.Int64,
                    Value= Convert.ToInt64(HttpContext.Request.Query["pocetZamestnancu"])
                },
                new Param
                {
                    Name = "p_adresaId",
                    type = OracleDbType.Int64,
                    Value= adresaId
                }
            };
            string result = Database.runProcedure("InsertProvozovna", parameters);
            return result;
        }

        // PUT api/<ProvozovnaController>/5
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
                    Value = HttpContext.Request.Query["psc"]
                },
                new Param
                {
                    Name = "p_cislo_popisne",
                    type = OracleDbType.Int64,
                    Value = HttpContext.Request.Query["cislo_popisne"]
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
                new Param
                {
                    Name = "p_id",
                    type = OracleDbType.Int64,
                    Value= id
                },
                new Param
                {
                    Name = "p_jmeno",
                    type = OracleDbType.Varchar2,
                    Value= HttpContext.Request.Query["jmeno"]
                },
                new Param
                {
                    Name = "p_pocetZamestnancu",
                    type = OracleDbType.Int64,
                    Value= HttpContext.Request.Query["pocetZamestnancu"]
                },
                new Param
                {
                    Name = "p_adresaId",
                    type = OracleDbType.Varchar2,
                    Value= adresaId
                }
            };
            string result = Database.runProcedure("UpdateProvozovna", parameters);
            return result;
        }
    

        // DELETE api/<ProvozovnaController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            string result = Database.runProcedure("DeleteProvozovna", new Param[]
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
