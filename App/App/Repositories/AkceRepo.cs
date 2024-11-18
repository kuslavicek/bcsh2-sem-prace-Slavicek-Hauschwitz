using App.Model;
using App.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public class AkceRepo
    {
        private readonly Database _database;

        public AkceRepo()
        {
            _database = new Database();
        }
        public List<Akce> LoadAkce()
        {
            string query = "SELECT id, pocet_osob, datum, id_typ_akce, id_objednavka FROM v_akce";
            var data = _database.GetDataFromView(query);

            List<Akce> akceList = new List<Akce>();

            foreach (var item in data)
            {
                Akce akce = new Akce
                {
                    Id = Convert.ToInt32(item["ID"]),
                    PocetOsob = Convert.ToInt32(item["POCET_OSOB"]),
                    Datum = Convert.ToDateTime(item["DATUM"]),
                    IdTypAkce = Convert.ToInt32(item["ID_TYP_AKCE"]),
                    IdObjednavka = Convert.ToInt32(item["ID_OBJEDNAVKA"])
                };
                akceList.Add(akce);
            }

            return akceList;
        }

        public List<Akce> GetAkceByIdObjednavka(int idObjednavka)
        {
            string query = "SELECT id, pocet_osob, datum, id_typ_akce, id_objednavka FROM v_akce WHERE id_objednavka = :idObjednavka";

            var parameters = new Dictionary<string, object>
            {
                { "idObjednavka", idObjednavka }
            };

            var data = _database.GetDataFromView(query, parameters);

            List<Akce> akceList = new List<Akce>();

            foreach (var item in data)
            {
                Akce akce = new Akce
                {
                    Id = Convert.ToInt32(item["ID"]),
                    PocetOsob = Convert.ToInt32(item["POCET_OSOB"]),
                    Datum = Convert.ToDateTime(item["DATUM"]),
                    IdTypAkce = Convert.ToInt32(item["ID_TYP_AKCE"]),
                    IdObjednavka = Convert.ToInt32(item["ID_OBJEDNAVKA"])
                };
                akceList.Add(akce);
            }

            return akceList;
        }

        public string GetTypAkceById(int id)
        {
            if (Enum.IsDefined(typeof(TypyAkce), id))
            {
                return ((TypyAkce)id).ToString();
            }
            else
            {
                return "Neznámý typ akce";
            }
        }
    }
}
