using App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public class TypAkceRepo
    {
        private Database _database;
        public TypAkceRepo()
        {
            this._database = new Database();
        }

        public Dictionary<int, string> LoadTypyAkceForSelect()
        {
            string query = "SELECT id, nazev FROM v_typy_akce";

            var dataTypy = _database.GetDataFromView(query);

            var typyDict = new Dictionary<int, string>();

            foreach (var row in dataTypy)
            {
                int id = int.Parse(row["ID"].ToString());
                string nazev = row["NAZEV"].ToString();

                typyDict[id] = nazev;
            }

            return typyDict;
        }

        public TypAkce GetTypAkceByAkce(int id)
        {
            var parameters = new Dictionary<string, object>
            {
                { "id", id }
            };
            string query = "SELECT id, nazev FROM v_typy_akce WHERE id = :id";

            var dataTypy = _database.GetDataFromView(query, parameters);

            TypAkce typ = null;

            foreach (var row in dataTypy)
            {
                typ = new TypAkce
                {
                    Id = int.Parse(row["ID"].ToString()),
                    Nazev = row["NAZEV"].ToString()
                };
            }

            return typ;
        }
        public void DeleteTypAkce(int id)
        {
            var parameters = new Dictionary<string, object> { { "p_id", id } };
            _database.ExecuteProcedure("delete_pkg.delete_typ_akce", parameters);
        }
        public void UpdateTypAkce(TypAkce typ)
        {
            var parameters = new Dictionary<string, object>();
            if (typ.Id != null)
            {
                parameters.Add("p_id", typ.Id);
            }
            parameters.Add("p_nazev", typ.Nazev);
            if (typ.Id != null)
            {
                _database.ExecuteProcedure("insert_update_pkg.update_typ_akce", parameters);
            }
            else
            {
                _database.ExecuteProcedure("insert_update_pkg.insert_typ_akce", parameters);
            }

        }
    }
}
