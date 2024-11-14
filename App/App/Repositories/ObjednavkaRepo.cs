using App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public class ObjednavkaRepo
    {
        private readonly Database _database;

        public ObjednavkaRepo()
        {
            _database = new Database();
        }

        public List<ListViewItem> Load()
        {
            string queryObjednavka = "SELECT id, datum_zalozeni, cena, zakaznik, faktura FROM v_objednavka";

            var dataObjednavka = _database.GetDataFromView(queryObjednavka);

            var objednavkaList = new List<ListViewItem>();

            foreach (var row in dataObjednavka)
            {
                var item = new ListViewItem(new[]
                {
                row["DATUM_ZALOZENI"].ToString(),
                row["CENA"].ToString(),
                row["ZAKAZNIK"].ToString(),
                row["FAKTURA"].ToString()
            });
                item.Tag = row["ID"];
                objednavkaList.Add(item);
            }

            return objednavkaList;
        }

    }
}
