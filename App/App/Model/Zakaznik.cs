using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class Zakaznik
    {
        public int Id { get; set; }
        public string Jmeno { get; set; }
        public int Telefon { get; set; }
        public string Email { get; set; }
        public Adresa Adresa { get; set; }

        public Zakaznik(int id, string jmeno, int telefon, string email, Adresa adresa)
        {
            Id = id;
            Jmeno = jmeno;
            Telefon = telefon;
            Email = email;
            Adresa = adresa;
        }
    }
}
