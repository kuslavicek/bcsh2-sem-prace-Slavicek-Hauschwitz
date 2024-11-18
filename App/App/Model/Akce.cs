using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class Akce
    {
        public int Id { get; set; }
        public int PocetOsob { get; set; }
        public DateTime Datum { get; set; }
        public int IdTypAkce { get; set; }
        public int IdObjednavka { get; set; }

        public Akce() { }

        public Akce(int id, int pocetOsob, DateTime datum, int idTypAkce, int idObjednavka)
        {
            Id = id;
            PocetOsob = pocetOsob;
            Datum = datum;
            IdTypAkce = idTypAkce;
            IdObjednavka = idObjednavka;
        }

        public override string ToString()
        {
            return $"Akce: Id={Id}, PocetOsob={PocetOsob}, Datum={Datum}, IdTypAkce={IdTypAkce}, IdObjednavka={IdObjednavka}";
        }
    }
}
