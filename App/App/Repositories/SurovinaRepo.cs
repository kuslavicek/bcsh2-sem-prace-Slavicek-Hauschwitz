using App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public class SurovinaRepo
    {
        private readonly Database _database;
        public SurovinaRepo()
        {
            _database = new Database();
        }
        public List<Surovina> Load()
        {
            string querySurovina = "SELECT id, nazev, mnozstvi, nazev_sklad FROM v_surovina";

            var dataSurovina = _database.GetDataFromView(querySurovina);

            var surovinaList = new List<Surovina>();

            foreach (var row in dataSurovina)
            {
                var surovina = new Surovina(
                    id: Convert.ToInt32(row["ID"]),
                    nazev: row["NAZEV"].ToString(),
                    mnozstvi: Convert.ToDouble(row["MNOZSTVI"]),
                    nazevSklad: row["NAZEV_SKLAD"].ToString()
                );
                surovinaList.Add(surovina);
            }

            return surovinaList;
        }

        public void DeleteSurovina(int surovinaId)
        {
            var parameters = new Dictionary<string, object> { { "p_id", surovinaId } };
            _database.ExecuteProcedure("delete_surovina", parameters);
        }

        public void UpdateSurovina(Surovina surovina)
        {
            var parameters = new Dictionary<string, object>();

            // Přidání ID, pokud je přítomno
            if (surovina.Id != null)
            {
                parameters.Add("p_id", surovina.Id);
            }

            // Přidání dalších parametrů pro surovinu
            parameters.Add("p_nazev", surovina.Nazev);
            parameters.Add("p_mnozstvi", surovina.Mnozstvi);
            parameters.Add("p_id_sklad", surovina.IdSklad);


            if (surovina.Id == null)
            {
                _database.ExecuteProcedure("insert_surovina", parameters);
            }
            else
            {
                // Update existující suroviny
                _database.ExecuteProcedure("update_surovina", parameters);
            }
        }


    }
}
