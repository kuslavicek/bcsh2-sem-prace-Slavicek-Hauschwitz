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

        public void DeletePozice(int id) {
            var parameters = new Dictionary<string, object> { { "p_id", id } };
            _database.ExecuteProcedure("delete_pracovni_pozice", parameters);
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
                _database.ExecuteProcedure("insert_pracovni_pozice", parameters);
            }
            else
            {
                _database.ExecuteProcedure("update_pracovni_pozice", parameters);
            }
        }
    }
}
