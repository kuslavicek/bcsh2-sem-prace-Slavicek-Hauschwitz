using App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public class ProvozovnaRepo
    {
        private readonly Database _database;

        public ProvozovnaRepo()
        {
            _database = new Database();
        }

        public List<Provozovna> Load()
        {
            string query = "SELECT provozovna_id, nazev, pocet_zamestnancu, id_adresa, adresa FROM v_provozovna";
            var data = _database.GetDataFromView(query);

            List<Provozovna> provozovny = new List<Provozovna>();

            foreach (var item in data)
            {
                var adresaParts = item["ADRESA"].ToString()?.Split(new[] { ", " }, StringSplitOptions.None);
                if (adresaParts != null && adresaParts.Length == 5) {
                    var adresa = new Adresa(
                        id: Convert.ToInt32(item["ID_ADRESA"]),
                        mesto: adresaParts[0],
                        psc: int.Parse(adresaParts[1]),
                        ulice: adresaParts[2],
                        cisloPopisne: int.Parse(adresaParts[3]),
                        stat: adresaParts[4]
                    );

                    Provozovna provozovna = new Provozovna
                    {
                        Id = Convert.ToInt32(item["PROVOZOVNA_ID"]),
                        Nazev = item["NAZEV"].ToString(),
                        PocetZamestnancu = Convert.ToInt32(item["POCET_ZAMESTNANCU"]),
                        Adresa=adresa
                    };
                    provozovny.Add(provozovna);
                }
                else
                {
                    throw new FormatException("Adresu není možné rozparsovat. Očekávaný formát: 'Mesto, PSC, Ulice, Cislo_popisne, Stat'.");
                }
            }

            return provozovny;
        }
    }
}
