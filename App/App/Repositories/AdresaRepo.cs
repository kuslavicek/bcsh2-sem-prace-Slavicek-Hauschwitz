using App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public class AdresaRepo
    {
        private readonly Database _database;
        public AdresaRepo() {
            _database = new Database();
        }
        public Adresa ParseAdresa(string adresaText)
        {
            var parts = adresaText.Split(new[] { ", " }, StringSplitOptions.None);

            if (parts.Length == 6)
            {
                return new Adresa(int.Parse(parts[5]),parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[3]), parts[4]);
            }

            throw new FormatException("Adresu není možné zpracovat.");
        }
    }
}
