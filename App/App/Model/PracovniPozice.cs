using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class PracovniPozice
    {
        public int? Id { get; set; }
        public string Nazev { get; set; }
        public double Plat { get; set; }

        public PracovniPozice() { 
        }
    }
}
