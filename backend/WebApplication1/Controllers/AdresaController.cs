using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using System.Reflection.Metadata;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdresaController : Controller
    {
        // GET api/<ZakaznikController>/
        [HttpGet]
        public List<Adresa> Get()
        {
            string result = Database.runProcedure("GetAdresy", null);
            return JsonConvert.DeserializeObject<List<Adresa>>(result);
        }

        // GET api/<AdresaController>/5
        [HttpGet("{id}")]
        public Adresa Get(int id)
        {
            string result = Database.runProcedure("GetAdresa", new Param[]
            {
                new Param()
                {
                    Name="p_id",
                    type = Oracle.ManagedDataAccess.Client.OracleDbType.Decimal,
                    Value=id
                }
            });
            return Adresa.FromString(result);


        }

        // POST: api/<AdresaController>/5
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
                        Value = HttpContext.Request.Query["ulice"]
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
            string result = Database.runProcedure("InsertZakaznik", adresa);
            return result;
        }
        // PUT: api/<AdresaController>/5
        [HttpPut("{id}")]
        public string Put(int id)
        {
            Param[] parameters = new Param[]
               {
                   new Param
                    {
                        Name = "p_id",
                        type = OracleDbType.Varchar2,
                        Value = HttpContext.Request.Query["id"]
                    },
                    new Param
                    {
                        Name = "p_jmeno",
                        type = OracleDbType.Varchar2,
                        Value = HttpContext.Request.Query["jmeno"]
                    },
                    new Param
                    {
                        Name = "p_email",
                        type = OracleDbType.Varchar2,
                        Value = HttpContext.Request.Query["email"]
                    },
                    new Param
                    {
                        Name = "p_telefon",
                        type = OracleDbType.Int64,
                        Value = HttpContext.Request.Query["telefon"]
                    },
                    new Param
                    {
                        Name = "p_adresa_id",
                        type = OracleDbType.Int64,
                        Value = id
                    },
            };
            string result = Database.runProcedure("UpdateAdresa", parameters);
            return result;
        }
        // DELETE api/<AdresaController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            string result = Database.runProcedure("DeleteAdresa", new Param[]
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
