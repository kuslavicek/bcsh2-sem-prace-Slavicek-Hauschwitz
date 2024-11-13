using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class Adresa
    {
        public string Mesto { get; set; }
        public string Ulice { get; set; }
        public string CisloPopisne { get; set; }
        public string Stat { get; set; }

        public Adresa(string mesto, string ulice, string cisloPopisne, string stat)
        {
            Mesto = mesto;
            Ulice = ulice;
            CisloPopisne = cisloPopisne;
            Stat = stat;
        }
    }
}
