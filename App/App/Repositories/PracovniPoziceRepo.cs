using App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public class PracovniPoziceRepo
    {
        private readonly Database _database;
        public PracovniPoziceRepo() {
            _database = new Database();
        }

        public List<ListViewItem> Load()
        {
            string query = "SELECT id, nazev, plat FROM v_pracovni_pozice";

            var dataPozice = _database.GetDataFromView(query);

            var poziceList = new List<ListViewItem>();

            foreach (var row in dataPozice)
            {
                var item = new ListViewItem(new[]
                {
                    row["NAZEV"].ToString(),
                    row["PLAT"].ToString(),
                });

                item.Tag = row["ID"];
                poziceList.Add(item);
            }

            return poziceList;
        }

        public Dictionary<int, string> LoadPracovniPoziceForSelect()
        {
            string query = "SELECT id, nazev FROM v_pracovni_pozice";

            var dataPozice = _database.GetDataFromView(query);

            var poziceDict = new Dictionary<int, string>();

            foreach (var row in dataPozice)
            {
                int id = int.Parse(row["ID"].ToString());
                string nazev = row["NAZEV"].ToString();

                poziceDict[id] = nazev;
            }

            return poziceDict;
        }

        public PracovniPozice GetPoziceByID(int? id)
        {
            if (id!=null) {
                string query = "SELECT id, nazev, plat FROM v_pracovni_pozice WHERE id = :id";
                var parameters = new Dictionary<string, object>
            {
                { "id", id }
            };

                var dataPozice = _database.GetDataFromView(query, parameters);
                var pozice = new PracovniPozice();
                foreach (var row in dataPozice)
                {
                    pozice.Id = Convert.ToInt32(row["ID"]);
                    pozice.Nazev = row["NAZEV"].ToString();
                    pozice.Plat = double.Parse(row["PLAT"].ToString());
                }

                return pozice;
            }
            return null;
        }

        public void DeletePozice(int id) {
            var parameters = new Dictionary<string, object> { { "p_id", id } };
            _database.ExecuteProcedure("delete_pkg.delete_pracovni_pozice", parameters);
        }

        public void UpdatePozice(PracovniPozice pozice) {
            var parameters = new Dictionary<string, object>();

            if (pozice.Id != null)
            {
                parameters.Add("p_id", pozice.Id);
            }

            parameters.Add("p_nazev", pozice.Nazev);
            parameters.Add("p_plat", pozice.Plat);


            if (pozice.Id == null)
            {
                _database.ExecuteProcedure("insert_update_pkg.insert_pracovni_pozice", parameters);
            }
            else
            {
                _database.ExecuteProcedure("insert_update_pkg.update_pracovni_pozice", parameters);
            }
        }
    }
}
