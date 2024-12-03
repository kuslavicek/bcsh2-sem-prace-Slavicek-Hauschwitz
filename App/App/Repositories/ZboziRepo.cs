using App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public class ZboziData
    {
        private readonly Database _database;

        public ZboziData()
        {
            _database = new Database();
        }

        public List<Zbozi> Load()
        {
            string queryPivo = "SELECT pivo_id, zbozi_nazev, obsah_alkoholu, cena, stupnovitost, sklad_nazev FROM v_pivo";
            string queryCider = "SELECT cider_id, zbozi_nazev, obsah_alkoholu, cena, odruda_jablek, sklad_nazev FROM v_cider";

            var dataPivo = _database.GetDataFromView(queryPivo);
            var dataCider = _database.GetDataFromView(queryCider);

            var zboziList = new List<Zbozi>();

            foreach (var row in dataPivo)
            {
                var pivo = new Zbozi(
                    id: Convert.ToInt32(row["PIVO_ID"]),
                    nazev: row["ZBOZI_NAZEV"].ToString(),
                    obsahAlkoholu: Convert.ToDouble(row["OBSAH_ALKOHOLU"]),
                    cena: Convert.ToDouble(row["CENA"]),
                    typ: 'p',
                    skladNazev: row["SKLAD_NAZEV"].ToString(),
                    odrudaJablek: string.Empty,
                    stupnovitost: Convert.ToDouble(row["STUPNOVITOST"])
                );
                zboziList.Add(pivo);
            }

            foreach (var row in dataCider)
            {
                var cider = new Zbozi(
                    id: Convert.ToInt32(row["CIDER_ID"]),
                    nazev: row["ZBOZI_NAZEV"].ToString(),
                    obsahAlkoholu: Convert.ToDouble(row["OBSAH_ALKOHOLU"]),
                    cena: Convert.ToDouble(row["CENA"]),
                    typ: 'c',
                    skladNazev: row["SKLAD_NAZEV"].ToString(),
                    odrudaJablek: row["ODRUDA_JABLEK"].ToString(),
                    stupnovitost: 0
                );
                zboziList.Add(cider);
            }

            return zboziList;
        }


        public void DeleteZbozi(int zboziId)
        {
            var parameters = new Dictionary<string, object> { { "p_id", zboziId } };
            _database.ExecuteProcedure("delete_pkg.delete_zbozi", parameters);
        }

        public void UpdateZbozi(Zbozi zbozi)
        {
            var parameters = new Dictionary<string, object>();

            if (zbozi.Id != null)
            {
                parameters.Add("p_id", zbozi.Id);
            }

            parameters.Add("p_nazev", zbozi.Nazev);
            parameters.Add("p_obsah_alkoholu", zbozi.ObsahAlkoholu);
            parameters.Add("p_cena", zbozi.Cena);
            parameters.Add("p_id_sklad", zbozi.SkladId);
            parameters.Add("p_typ", zbozi.Typ.ToString());

            if (zbozi.Typ == 'p')
            {
                parameters.Add("p_odruda_jablek", "");
                parameters.Add("p_stupnovitost", zbozi.Stupnovitost);
            }

            if (zbozi.Typ == 'c')
            {
                parameters.Add("p_odruda_jablek", zbozi.OdrudaJablek);
                parameters.Add("p_stupnovitost", DBNull.Value);
            }

            if (zbozi.Id == null)
            {
                _database.ExecuteProcedure("insert_update_pkg.insert_zbozi", parameters);
            }
            else
            {
                _database.ExecuteProcedure("insert_update_pkg.update_zbozi", parameters);
            }
        }

        public Zbozi LoadById(int id)
        {
            string queryPivo = "SELECT pivo_id, zbozi_nazev, obsah_alkoholu, cena, stupnovitost, sklad_nazev FROM v_pivo WHERE pivo_id = :id";
            string queryCider = "SELECT cider_id, zbozi_nazev, obsah_alkoholu, cena, odruda_jablek, sklad_nazev FROM v_cider WHERE cider_id = :id";
            var parameters = new Dictionary<string, object>
                {
                    { "id", id }
                };
            var dataPivo = _database.GetDataFromView(queryPivo, parameters);
            var dataCider = _database.GetDataFromView(queryCider, parameters);

            Zbozi zbozi = null;

            if (dataPivo.Any())
            {
                var row = dataPivo.First();
                zbozi = new Zbozi(
                    id: Convert.ToInt32(row["PIVO_ID"]),
                    nazev: row["ZBOZI_NAZEV"].ToString(),
                    obsahAlkoholu: Convert.ToDouble(row["OBSAH_ALKOHOLU"]),
                    cena: Convert.ToDouble(row["CENA"]),
                    typ: 'p',
                    skladNazev: row["SKLAD_NAZEV"].ToString(),
                    odrudaJablek: string.Empty,
                    stupnovitost: Convert.ToDouble(row["STUPNOVITOST"])
                );
            }
            else if (dataCider.Any())
            {
                var row = dataCider.First();
                zbozi = new Zbozi(
                    id: Convert.ToInt32(row["CIDER_ID"]),
                    nazev: row["ZBOZI_NAZEV"].ToString(),
                    obsahAlkoholu: Convert.ToDouble(row["OBSAH_ALKOHOLU"]),
                    cena: Convert.ToDouble(row["CENA"]),
                    typ: 'c',
                    skladNazev: row["SKLAD_NAZEV"].ToString(),
                    odrudaJablek: row["ODRUDA_JABLEK"].ToString(),
                    stupnovitost: 0
                );
            }

            return zbozi;
        }
    }
}
