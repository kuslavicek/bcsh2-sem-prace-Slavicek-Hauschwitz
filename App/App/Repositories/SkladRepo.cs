using App.Model;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public class SkladRepo
    {
        private readonly Database _database;

        public SkladRepo()
        {
            _database = new Database();
        }

        public List<Sklad> GetSklady()
        {
            string query = "SELECT id, nazev, uzitna_plocha, id_adresa, adresa FROM v_sklad";
            var data = _database.GetDataFromView(query);

            List<Sklad> sklady = new List<Sklad>();

            foreach (var item in data)
            {
                var adresaParts = item["ADRESA"].ToString().Split(new[] { ", " }, StringSplitOptions.None);

                if (adresaParts != null) {
                    var adresa = new Adresa(
                        id: Convert.ToInt32(item["ID_ADRESA"]),
                        mesto: adresaParts[0],
                        psc: int.Parse(adresaParts[1]),
                        ulice: adresaParts[2],
                        cisloPopisne: int.Parse(adresaParts[3]),
                        stat: adresaParts[4]
                    );
                    Sklad sklad = new Sklad
                    {
                        Id = Convert.ToInt32(item["ID"]),
                        Nazev = item["NAZEV"].ToString(),
                        UzitnaPlocha = double.Parse(item["UZITNA_PLOCHA"].ToString()),
                        IdAdresa = Convert.ToInt32(item["ID_ADRESA"].ToString()),
                        Adresa = adresa
                    };
                    sklady.Add(sklad);
                }
            }

            return sklady;
        }

        public Dictionary<int, string> LoadSkladyForSelect()
        {
            string query = "SELECT id, nazev FROM v_sklad";

            var data = _database.GetDataFromView(query);

            var skladyDict = new Dictionary<int, string>();

            foreach (var row in data)
            {
                int id = int.Parse(row["ID"].ToString());
                string nazev = row["NAZEV"].ToString();

                skladyDict[id] = nazev;
            }

            return skladyDict;
        }

        public void DeleteSklad(int id)
        {
            var parameters = new Dictionary<string, object>
            {
                { "p_id", id },
                { "p_empty", false }
            };

            _database.ExecuteProcedure("delete_sklad", parameters);

            if (bool.Parse(parameters["p_empty"].ToString()) ==false)
            {
                MessageBox.Show("Ve skladu se nacházejí suroviny, nebo zboží, proto nebylo možné sklad odstranit", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Sklad byl úspěšně smazán.");
            }
        }


        public void UpdateSklad(Sklad sklad) {
            var parameters = new Dictionary<string, object>();
            if (sklad.Id != null && sklad.IdAdresa!=null)
            {
                parameters.Add("p_id", sklad.Id);
                parameters.Add("p_id_adresa", sklad.IdAdresa);
            }
            parameters.Add("p_nazev", sklad.Nazev);
            parameters.Add("p_uzitna_plocha", sklad.UzitnaPlocha);
            parameters.Add("p_ulice", sklad.Adresa.Ulice);
            parameters.Add("p_mesto", sklad.Adresa.Ulice);
            parameters.Add("p_psc", sklad.Adresa.Psc);
            parameters.Add("p_cislo_popisne", sklad.Adresa.CisloPopisne);
            parameters.Add("p_stat", sklad.Adresa.Stat);

            if (sklad.Id != null && sklad.IdAdresa != null)
            {
                _database.ExecuteProcedure("update_sklad", parameters);
            }
            else
            {
                _database.ExecuteProcedure("insert_sklad", parameters);
            }
        }
    }
}
