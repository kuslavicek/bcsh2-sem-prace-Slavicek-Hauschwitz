using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZakaznikController : ControllerBase
    {
        // GET: api/<ZakaznikController>
        [HttpGet]
        public List<Zakaznik> Get()
        {
            string result = Database.runProcedure("GetZakaznici", null);
            return JsonConvert.DeserializeObject<List<Zakaznik>>(result);
        }

        // GET api/<ZakaznikController>/5
        [HttpGet("{id}")]
        public Zakaznik Get(int id)
        {
            string result = Database.runProcedure("GetZakaznik", new Param[]
            {
                new Param()
                {
                    Name="p_id",
                    type = Oracle.ManagedDataAccess.Client.OracleDbType.Decimal,
                    Value=id
                }
            });
            return Zakaznik.FromString(result);
            

        }

        // POST api/<ZakaznikController>
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
                        type = OracleDbType.Int32,
                        Value = Convert.ToInt32(HttpContext.Request.Query["psc"])
                    },
                    new Param
                    {
                        Name = "p_cislo_popisne",
                        type = OracleDbType.Int32,
                        Value = Convert.ToInt32(HttpContext.Request.Query["cislo_popisne"])
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

            Param[] parameters2 = new Param[]
                {
                   
                    new Param
                    {
                        Name = "p_jmeno",
                        type = OracleDbType.Varchar2,
                        Value = HttpContext.Request.Query["jmeno"]
                    },
                    new Param
                    {
                        Name = "p_telefon",
                        type = OracleDbType.Int32,
                        Value = Convert.ToInt32(HttpContext.Request.Query["telefon"])
                    },
                    new Param
                    {
                        Name = "p_email",
                        type = OracleDbType.Varchar2,
                        Value = HttpContext.Request.Query["email"]
                    },
                    
                    new Param
                    {
                        Name = "p_id_adresa",
                        type = OracleDbType.Int32,
                        Value = adresaId
                    },
            };


            string result = Database.runProcedure("InsertZakaznik", parameters2);
            return result; 
        }

        // PUT api/<ZakaznikController>/5
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
            if(adresaId.Equals("0"))
            {
                Database.runProcedure("CreateAdresa", adresa);
                adresaId = Database.runProcedure("GetIdAdresa", adresa);
            }





            Param[] parameters = new Param[]
                {
                   new Param
                    {
                        Name = "p_id",
                        type = OracleDbType.Varchar2,
                        Value = id
                    },
                    new Param
                    {
                        Name = "p_jmeno",
                        type = OracleDbType.Varchar2,
                        Value = HttpContext.Request.Query["jmeno"]
                    },
                    new Param
                    {
                        Name = "p_telefon",
                        type = OracleDbType.Int32,
                        Value = Convert.ToInt32(HttpContext.Request.Query["telefon"])
                    },
                    new Param
                    {
                        Name = "p_email",
                        type = OracleDbType.Varchar2,
                        Value = HttpContext.Request.Query["email"]
                    },
                    
                    new Param
                    {
                        Name = "p_id_adresa",
                        type = OracleDbType.Int64,
                        Value = Convert.ToInt64(adresaId)
                    },
            };

            string result = Database.runProcedure("UpdateZakaznik", parameters);
            return result;
        }

        // DELETE api/<ZakaznikController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            string result = Database.runProcedure("DeleteZakaznik", new Param[]
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
