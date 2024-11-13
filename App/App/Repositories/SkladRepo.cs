using App.Model;
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
            string query = "SELECT id, nazev FROM view_sklad_id_nazev";
            var data = _database.GetDataFromView(query);

            List<Sklad> sklady = new List<Sklad>();

            foreach (var item in data)
            {
                Sklad sklad = new Sklad
                {
                    Id = Convert.ToInt32(item["ID"]),
                    Nazev = item["NAZEV"].ToString()
                };
                sklady.Add(sklad);
            }

            return sklady;
        }
    }
}
