using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class Surovina
    {
        public int? Id { get; set; }
        public string? Nazev { get; set; }
        public double Mnozstvi { get; set; }
        public int? IdSklad { get; set; }
        public string? NazevSklad { get; set; }

        public Surovina(int id, string? nazev, double mnozstvi, int? idSklad = null, string? nazevSklad = null)
        {
            Id = id;
            Nazev = nazev;
            Mnozstvi = mnozstvi;
            IdSklad = idSklad;
            NazevSklad = nazevSklad;
        }

        public Surovina(string nazev, double mnozstvi, int idSklad, string? nazevSklad = null)
        {
            Nazev = nazev;
            Mnozstvi = mnozstvi;
            IdSklad = idSklad;
            NazevSklad = nazevSklad;
        }

    }

}
