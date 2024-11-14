using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class Zbozi
    {
        public int? Id { get; set; }
        public string Nazev { get; set; }
        public double ObsahAlkoholu { get; set; }
        public double Cena { get; set; }
        public char Typ { get; set; } // Typ zboží: "p" pro pivo, "c" pro cider
        public double SkladId { get; set; } // Povinný údaj
        public string? SkladNazev { get; set; } // Volitelný údaj (nepovinný)
        public string? OdrudaJablek { get; set; } // Pouze pro cider ("c")
        public double? Stupnovitost { get; set; } // Pouze pro pivo ("p")

        public Zbozi()
        {
        }
        public Zbozi(string nazev, double obsahAlkoholu, double cena, char typ, double skladId, string odrudaJablek, double stupnovitost)
        {
            Nazev = nazev;
            ObsahAlkoholu = obsahAlkoholu;
            Cena = cena;
            Typ = typ;
            SkladId = skladId;
            OdrudaJablek = odrudaJablek;
            Stupnovitost = stupnovitost;
        }

        public Zbozi(int id, string? nazev, double obsahAlkoholu, double cena, char typ, string? skladNazev, string odrudaJablek, double stupnovitost)
        {
            Id = id;
            Nazev = nazev;
            ObsahAlkoholu = obsahAlkoholu;
            Cena = cena;
            Typ = typ;
            SkladNazev = skladNazev;
            OdrudaJablek = odrudaJablek;
            Stupnovitost = stupnovitost;
        }
    }
}
