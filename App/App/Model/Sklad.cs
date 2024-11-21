using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class Sklad
    {
        public int? Id { get; set; }
        public string Nazev { get; set; }
        public double UzitnaPlocha { get; set; }
        public int? IdAdresa { get; set; }
        public Adresa Adresa { get; set; }

        public Sklad() { }

        public Sklad(int id, string nazev)
        {
            Id = id;
            Nazev = nazev;
        }
    }
}
