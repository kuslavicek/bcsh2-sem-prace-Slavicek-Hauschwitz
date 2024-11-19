using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class Faktura
    {
        public int? Id { get; set; }
        public byte[] FakturaBlob { get; set; }
        public string NazevSouboru { get; set; }
        public DateTime DatumVlozeni { get; set; }
    }
}
