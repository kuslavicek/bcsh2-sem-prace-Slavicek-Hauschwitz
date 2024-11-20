using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class Zamestnanec
    {
        public int? Id { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Email { get; set; }
        public double Telefon { get; set; }
        public int? IdProvozovna { get; set; }
        public int? IdPracovniPozice { get; set; }
        public int? IdNadrizeny { get; set; }

        public Zamestnanec() { 
        }
    }
}
