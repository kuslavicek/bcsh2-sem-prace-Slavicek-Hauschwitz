using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class Adresa
    {
        public int? Id { get; set; }
        public string Mesto { get; set; }
        public string Ulice { get; set; }
        public int CisloPopisne { get; set; }
        public int Psc { get; set; }
        public string Stat { get; set; }

        public Adresa(int? id, string mesto, string ulice, int cisloPopisne, int psc, string stat)
        {
            Id = id;
            Mesto = mesto;
            Ulice = ulice;
            CisloPopisne = cisloPopisne;
            Psc = psc;
            Stat = stat;
        }
    }

}
