using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class Zakaznik
    {
        public int? Id { get; set; }
        public string Jmeno { get; set; }
        public double Telefon { get; set; }
        public string Email { get; set; }
        public double? CenovaHladina { get; set; }
        public Adresa? Adresa { get; set; }
        public int? IdAdresa { get; set; }

        public Zakaznik(int? id, string jmeno, double telefon, string email,double? cenovaHladina, Adresa? adresa, int? idAdresa)
        {
            Id = id;
            Jmeno = jmeno;
            Telefon = telefon;
            Email = email;
            Adresa = adresa;
            CenovaHladina = cenovaHladina;
            IdAdresa = idAdresa;
        }
    }
}
