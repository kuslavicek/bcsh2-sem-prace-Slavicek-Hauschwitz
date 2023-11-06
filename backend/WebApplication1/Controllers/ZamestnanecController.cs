using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZamestnanecController : ControllerBase
    {
        // GET: api/<ZamestnanecController>
        [HttpGet]
        public List<Zamestnanec> Get()
        {
            string result = Database.runProcedure("GetZamestnanci", null);
            return JsonConvert.DeserializeObject<List<Zamestnanec>>(result);
        }

        // GET api/<ZamestnanecController>/5
        [HttpGet("{id}")]
        public Zamestnanec Get(int id)
        {
            string result = Database.runProcedure("GetZamestnanec", new Param[]
            {
                new Param()
                {
                    Name="p_id",
                    type = Oracle.ManagedDataAccess.Client.OracleDbType.Decimal,
                    Value=id
                }
            });
            return Zamestnanec.FromString(result);
        }

        // POST api/<ZamestnanecController>
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
                    Name = "p_prijmeni",
                    type = OracleDbType.Varchar2,
                    Value = HttpContext.Request.Query["prijmeni"]
                },
                new Param()
                {
                    Name = "p_email",
                    type = OracleDbType.Varchar2,
                    Value = HttpContext.Request.Query["email"]
                },
                new Param()
                {
                    Name = "p_telefon",
                    type = OracleDbType.Int64,
                    Value = Convert.ToInt64(HttpContext.Request.Query["telefon"])
                },
                new Param()
                {
                    Name = "p_IdProvozovna",
                    type = OracleDbType.Int64,
                    Value = Convert.ToInt64(HttpContext.Request.Query["idProvozovna"])
                },
                new Param()
                {
                    Name = "p_IdPracPozice",
                    type = OracleDbType.Int64,
                    Value = Convert.ToInt64(HttpContext.Request.Query["idPracPozice"])
                },
                new Param()
                {
                    Name = "p_adresaId",
                    type = OracleDbType.Int64,
                    Value = adresaId
                },
            };
            string result = Database.runProcedure("InsertZamestnanec", parameters);
            return result;

        }

        // PUT api/<ZamestnanecController>/5
        [HttpPut("{id}")]
        public string Put(int id)
        {
            Param[] adresa = new Param[]
            {      
                new Param{
                    Name = "p_ulice",
                    type = OracleDbType.Varchar2,
                    Value = HttpContext.Request.Query["ulice"]
                },
                new Param
                {
                    Name = "p_mesto",
                    type = OracleDbType.Varchar2,
                    Value = HttpContext.Request.Query["ulice"]
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
                    Name = "p_prijmeni",
                    type = OracleDbType.Varchar2,
                    Value = HttpContext.Request.Query["prijmeni"]
                },
                new Param()
                {
                    Name = "p_email",
                    type = OracleDbType.Varchar2,
                    Value = HttpContext.Request.Query["email"]
                },
                new Param()
                {
                    Name = "p_telefon",
                    type = OracleDbType.Int64,
                    Value = Convert.ToInt64(HttpContext.Request.Query["telefon"])
                },
                new Param()
                {
                    Name = "p_idProvozovna",
                    type = OracleDbType.Int64,
                    Value = Convert.ToInt64(HttpContext.Request.Query["idProvozovna"])
                },
                new Param()
                {
                    Name = "p_idPracPozice",
                    type = OracleDbType.Int64,
                    Value = Convert.ToInt64(HttpContext.Request.Query["idPracPozice"])
                },
                new Param()
                {
                    Name = "p_adresaId",
                    type = OracleDbType.Int64,
                    Value = adresaId
                },
            };
            string result = Database.runProcedure("UpdateZamestnanec", parameters);
            return result;
        }

        // DELETE api/<ZamestnanecController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            string result = Database.runProcedure("DeleteZamestnanec", new Param[]
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
