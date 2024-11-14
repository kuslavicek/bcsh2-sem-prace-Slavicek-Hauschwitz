using App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public class ZakaznikRepo
    {
        private readonly Database _database;
        public ZakaznikRepo() {
            _database = new Database();
        }
        public List<Zakaznik> Load()
        {
            string queryZakaznik = "SELECT zakaznik_id, jmeno, telefon, email, id_adresa ,adresa FROM v_zakaznik";
            var dataZakaznik = _database.GetDataFromView(queryZakaznik);

            var zakaznikList = new List<Zakaznik>();

            foreach (var row in dataZakaznik)
            {
                var adresaParts = row["ADRESA"].ToString()?.Split(new[] { ", " }, StringSplitOptions.None);

                if (adresaParts != null && adresaParts.Length == 5)
                {
                    var adresa = new Adresa(
                        id: Convert.ToInt32(row["ID_ADRESA"]),
                        mesto: adresaParts[0],
                        psc: int.Parse(adresaParts[1]),
                        ulice: adresaParts[2],
                        cisloPopisne: int.Parse(adresaParts[3]),
                        stat: adresaParts[4]
                    );

                    var zakaznik = new Zakaznik(
                        id: Convert.ToInt32(row["ZAKAZNIK_ID"]),
                        jmeno: row["JMENO"].ToString(),
                        telefon: Convert.ToInt32(row["TELEFON"]),
                        email: row["EMAIL"].ToString(),
                        adresa: adresa
                    );

                    zakaznikList.Add(zakaznik);
                }
                else
                {
                    throw new FormatException("Adresu není možné rozparsovat. Očekávaný formát: 'Mesto, PSC, Ulice, Cislo_popisne, Stat'.");
                }
            }

            return zakaznikList;
        }



        public void UpdateZakaznik(Zakaznik zakaznik)
        {
            var parametersZ = new Dictionary<string, object>();
            var parametersA = new Dictionary<string, object>();

            if (zakaznik.Id != null)
            {
                parametersZ.Add("p_id", zakaznik.Id);
            }

            parametersZ.Add("p_jmeno", zakaznik.Jmeno);
            parametersZ.Add("p_telefon", zakaznik.Telefon);
            parametersZ.Add("p_email", zakaznik.Email);

            parametersA.Add("p_ulice", zakaznik.Adresa.Ulice);
            parametersA.Add("p_mesto", zakaznik.Adresa.Mesto);
            parametersA.Add("p_psc", zakaznik.Adresa.Psc);
            parametersA.Add("p_cislo_popisne", zakaznik.Adresa.CisloPopisne);
            parametersA.Add("p_stat", zakaznik.Adresa.Stat);

            if (zakaznik.Id == null)
            {
                parametersA.Add("p_out_id", null);

                _database.ExecuteProcedure("insert_adresa", parametersA);

                var novaAdresaId = parametersA["p_out_id"];

                parametersZ.Add("p_id_adresa", novaAdresaId);

                _database.ExecuteProcedure("insert_zakaznik", parametersZ);
            }
            else
            {
                // Aktualizace adresy i zákazníka
                if (zakaznik.Adresa.Id != null)
                {
                    parametersA.Add("p_id", zakaznik.Adresa.Id);
                    _database.ExecuteProcedure("update_adresa", parametersA);
                }

                parametersZ.Add("p_id_adresa", zakaznik.Adresa.Id);
                _database.ExecuteProcedure("update_zakaznik", parametersZ);
            }
        }





        public void DeleteZakaznik(int zakaznikId)
        {
            var parameters = new Dictionary<string, object> { { "p_id", zakaznikId } };
            _database.ExecuteProcedure("delete_zakaznik", parameters);
        }
    }
}
