using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class Objednavka
    {
        public int Id { get; set; }
        public DateTime DatumZalozeni { get; set; }
        public double Cena { get; set; }
        public int IdZakaznik { get; set; }
        public int? IdFaktura { get; set; }

        public Objednavka(int id, DateTime datumZalozeni, double cena, int idZakaznik, int? idFaktura = null)
        {
            Id = id;
            DatumZalozeni = datumZalozeni;
            Cena = cena;
            IdZakaznik = idZakaznik;
            IdFaktura = idFaktura;
        }
    }
}
