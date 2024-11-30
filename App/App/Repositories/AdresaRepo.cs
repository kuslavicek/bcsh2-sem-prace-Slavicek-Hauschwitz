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

        public List<Adresa> Load()
        {
            string queryAdresa = "SELECT id, ulice, mesto, psc, cislo_popisne, stat FROM v_adresa";
            var dataAdresa = _database.GetDataFromView(queryAdresa);

            var adresaList = new List<Adresa>();

            foreach (var row in dataAdresa)
            {
                    var adresa = new Adresa(
                        id: Convert.ToInt32(row["ID"]),
                        mesto: row["MESTO"].ToString(),
                        psc: Convert.ToInt32(row["PSC"]),
                        ulice: row["ULICE"].ToString(),
                        cisloPopisne: Convert.ToInt32(row["CISLO_POPISNE"]),
                        stat: row["STAT"].ToString()
                    );

                    adresaList.Add(adresa);
            }

            return adresaList;
        }

        public Adresa ParseAdresa(string? adresaText)
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
