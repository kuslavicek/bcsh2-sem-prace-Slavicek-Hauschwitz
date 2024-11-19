using App.Model;
using Devart.Data.Oracle;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
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
            string queryObjednavka = "SELECT id, datum_zalozeni, cena, zakaznik, faktura, id_faktura, id_zakaznik FROM v_objednavka";

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
                item.SubItems[2].Tag = row["ID_FAKTURA"];
                item.SubItems[3].Tag = row["ID_ZAKAZNIK"];
                item.Tag = row["ID"];
                objednavkaList.Add(item);
            }

            return objednavkaList;
        }

        public void Save(Objednavka objednavka, Faktura faktura, List<KeyValuePair<ObjednaneZbozi, Zbozi>> zbozi, List<Akce> akce)
        {
            var parameters = new Dictionary<string, object>();

            if (objednavka.Id != 0)
            {
                parameters.Add("p_id_objednavka", objednavka.Id);
                parameters.Add("p_datum_zalozeni", objednavka.DatumZalozeni);
                parameters.Add("p_cena", objednavka.Cena);
                parameters.Add("p_id_zakaznik", objednavka.IdZakaznik);
                parameters.Add("p_faktura_data", faktura.FakturaBlob);
                parameters.Add("p_nazev_souboru", faktura.NazevSouboru);

                parameters.Add("p_objednane_zbozi", ConvertZboziSeznamToJson(zbozi));

                parameters.Add("p_akce", ConvertAkceSeznamToJson(akce));

                _database.ExecuteProcedure("update_objednavka", parameters);
            }
            else
            {
                parameters.Add("p_datum_zalozeni", objednavka.DatumZalozeni);
                parameters.Add("p_cena", objednavka.Cena);
                parameters.Add("p_id_zakaznik", objednavka.IdZakaznik);
                parameters.Add("p_faktura_data", faktura.FakturaBlob);
                parameters.Add("p_nazev_souboru", faktura.NazevSouboru);

                parameters.Add("p_objednane_zbozi", ConvertZboziSeznamToJson(zbozi));

                parameters.Add("p_akce", ConvertAkceSeznamToJson(akce));

                _database.ExecuteProcedure("insert_objednavka", parameters);
            }
        }

        public void DeleteObjednavka(int id) {
            var parameters = new Dictionary<string, object> { { "p_id", id } };
            _database.ExecuteProcedure("delete_objednavka", parameters);
        }

        private string ConvertZboziSeznamToJson(List<KeyValuePair<ObjednaneZbozi, Zbozi>> zboziSeznam) {
            var data = zboziSeznam.Select(zbozi => new {
                id_zbozi = zbozi.Value.Id,
                mnozstvi = zbozi.Key.Mnozstvi
            }).ToList();

            string jsonData = JsonConvert.SerializeObject(data);
            return jsonData;
        }

        private string ConvertAkceSeznamToJson(List<Akce> akceSeznam)
        {
            var data = akceSeznam.Select(akce => new {
                pocet_osob = akce.PocetOsob,
                datum = akce.Datum,
                id_typ_akce = akce.IdTypAkce
            }).ToList();

            string jsonData = JsonConvert.SerializeObject(data);
            return jsonData;
        }

    }
}
