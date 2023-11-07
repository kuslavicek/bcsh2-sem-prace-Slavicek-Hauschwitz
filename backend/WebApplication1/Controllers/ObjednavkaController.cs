using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjednavkaController : ControllerBase
    {
        // GET: api/<ObjednavkaController>
        [HttpGet]
        public List<Objednavka> Get()
        {
            string result = Database.runProcedure("GetObjednavkaList", null);
            return JsonConvert.DeserializeObject<List<Objednavka>>(result);
        }

        // GET api/<ObjednavkaController>/5
        [HttpGet("{id}")]
        public Objednavka Get(int id)
        {
            string result = Database.runProcedure("GetObjednavka", new Param[]
            {
                new Param()
                {
                    Name="p_id",
                    type = Oracle.ManagedDataAccess.Client.OracleDbType.Decimal,
                    Value=id
                }
            });
            return Objednavka.FromString(result);
        }

        // POST api/<ObjednavkaController>
        [HttpPost]
        public string Post()
        { 
            int idZakaznik = Convert.ToInt32(HttpContext.Request.Query["idZakaznik"]);
            string zakaznik = Database.runProcedure("GetZakaznik", new Param[]
            {
                new Param()
                {
                    Name="p_id",
                    type = Oracle.ManagedDataAccess.Client.OracleDbType.Decimal,
                    Value=idZakaznik
                }
            });
            int idAdresa =  Zakaznik.FromString(zakaznik).IdAdresa;
            Param[] parameters = new Param[]
            {
                new Param()
                {
                    Name = "p_datum",
                    type = OracleDbType.Date,
                    Value = DateTime.Now
                },
                new Param()
                {
                    Name = "p_cena",
                    type = OracleDbType.Decimal,
                    Value = Convert.ToDecimal(HttpContext.Request.Query["cena"])
                },
                new Param()
                {
                    Name = "p_idAdresa",
                    type = OracleDbType.Int64,
                    Value = idAdresa
                },
                new Param()
                {
                    Name = "p_idZakaznik",
                    type = OracleDbType.Int64,
                    Value = idZakaznik
                },
                new Param()
                {
                    Name = "p_idZamestnanec",
                    type = OracleDbType.Int64,
                    Value = Convert.ToInt64(HttpContext.Request.Query["idZamestnanec"])
                },
            };
            string result = Database.runProcedure("CreateObjednavka", parameters);
            return result;
        }

        // PUT api/<ObjednavkaController>/5
        [HttpPut("{id}")]
        public string Put(int id)
        {
            int idZakaznik = Convert.ToInt32(HttpContext.Request.Query["idZakaznik"]);
            string zakaznik = Database.runProcedure("GetZakaznik", new Param[]
            {
                new Param()
                {
                    Name="p_id",
                    type = Oracle.ManagedDataAccess.Client.OracleDbType.Decimal,
                    Value=idZakaznik
                }
            });
            int idAdresa = Zakaznik.FromString(zakaznik).IdAdresa;
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
                    Name = "p_datum",
                    type = OracleDbType.Date,
                    Value = DateTime.Now
                },
                new Param()
                {
                    Name = "p_cena",
                    type = OracleDbType.Decimal,
                    Value = Convert.ToDecimal(HttpContext.Request.Query["cena"])
                },
                new Param()
                {
                    Name = "p_idAdresa",
                    type = OracleDbType.Int32,
                    Value = idAdresa
                },
                new Param()
                {
                    Name = "p_idZakaznik",
                    type = OracleDbType.Int32,
                    Value = idZakaznik
                },
                new Param()
                {
                    Name = "p_idZamestnanec",
                    type = OracleDbType.Int32,
                    Value = HttpContext.Request.Query["idZamestnanec"]
                },
            };
            string result = Database.runProcedure("UpdateObjednavka", parameters);
            return result;
        }

        // DELETE api/<ObjednavkaController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            string result = Database.runProcedure("DeleteObjednavka", new Param[]
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
