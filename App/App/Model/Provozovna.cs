using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class Provozovna
    {
        public Provozovna(int? Id, string Nazev, int PocetOsob, Adresa? Adresa, int? idAdresa)
        {
            this.Id = Id;
            this.Nazev = Nazev;
            this.PocetZamestnancu = PocetOsob;
            this.Adresa = Adresa;
            this.IdAdresa = idAdresa;
        }

        public Provozovna() { 
        }

        public int? Id { get; set; }
        public string Nazev { get; set; }
        public int PocetZamestnancu { get; set; }
        public Adresa? Adresa { get; set; }
        public int? IdAdresa { get; set; }
    }
}
