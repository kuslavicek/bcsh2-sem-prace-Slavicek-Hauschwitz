using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Jmeno { get; set; }
        public string Heslo { get; set; }
        public string Role { get; set; }
        public int boolean { get; set; }
        public int IdZamestnanec { get; set; }
    }
}
