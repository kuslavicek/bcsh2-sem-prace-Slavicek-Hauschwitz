using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class ObjednaneZbozi
    {
        public int Id { get; set; }
        public int Mnozstvi { get; set; }
        public int IdObjednavka { get; set; }
        public int IdZbozi { get; set; }
    }
}
