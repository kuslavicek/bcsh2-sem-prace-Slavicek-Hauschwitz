using Microsoft.AspNetCore.Mvc;
using Oracle.ManagedDataAccess.Client;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
        public string Get()
        {
            string username = HttpContext.Request.Query["username"];
            string password= HttpContext.Request.Query["password"];
            
            string result = Database.runProcedure("Login", new Param[]
            {
                new Param()
                {
                    Name="p_name",
                    type = OracleDbType.Varchar2,
                    Value=username
                },
                new Param()
                {
                    Name="p_password",
                    type = OracleDbType.Varchar2,
                    Value=password
                }
            }) ;
            return result;
        }

        // POST api/<UserController>
        [HttpPost]
        public string Post()
        {
            string username = HttpContext.Request.Query["username"];
            string password = HttpContext.Request.Query["password"];

            string result = Database.runProcedure("Register_User", new Param[]
            {
                new Param()
                {
                    Name="p_name",
                    type = OracleDbType.Varchar2,
                    Value=username
                },
                new Param()
                {
                    Name="p_password",
                    type = OracleDbType.Varchar2,
                    Value=password
                }
            });
            return result;
        }
    }
}
