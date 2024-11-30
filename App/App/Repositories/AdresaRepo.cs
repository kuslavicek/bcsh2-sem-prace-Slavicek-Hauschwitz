using App.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public class AdresaRepo
    {
        private readonly Database _database;
        public AdresaRepo()
        {
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
                return new Adresa(int.Parse(parts[5]), parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[3]), parts[4]);
            }

            throw new FormatException("Adresu není možné zpracovat.");
        }

        public void DeleteAdresa(int id)
        {
            var parameters = new Dictionary<string, object>
            {
                { "p_id", id },
                { "p_succes", null }
            };

            _database.ExecuteProcedure("delete_adresa", parameters);

            var succesValue = parameters["p_succes"];
            int succes = succesValue != null
                ? Convert.ToInt32(((Oracle.ManagedDataAccess.Types.OracleDecimal)succesValue).Value)
                : 0;

            if (succes == 1)
            {
                MessageBox.Show("Adresa byla úspěšně smazána.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Adresa nemohla být smazána, protože je přiřazena k entitě.", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void UpdateAdresa(Adresa adresa)
        {
            var parameters = new Dictionary<string, object>();

            if (adresa.Id != null)
            {
                parameters.Add("p_id", adresa.Id);
            }

            parameters.Add("p_ulice", adresa.Ulice);
            parameters.Add("p_mesto", adresa.Mesto);
            parameters.Add("p_psc", adresa.Psc);
            parameters.Add("p_cislo_popisne", adresa.CisloPopisne);
            parameters.Add("p_stat", adresa.Stat);

            if (adresa.Id == null)
            {
                _database.ExecuteProcedure("insert_adresa", parameters);
            }
            else
            {
                _database.ExecuteProcedure("update_adresa", parameters);
            }
        }
    }
}
