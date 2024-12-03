using App.Model;
using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace App.Repositories
{
    public class ObjednavkaRepo
    {
        private Database _database;

        public ObjednavkaRepo()
        {
            _database = new Database();
        }

        public Objednavka GetObjednavkaById(int id)
        {
            var parameters = new Dictionary<string, object>
            {
                { "id", id }
            };
            string queryObjednavka = "SELECT id, datum_zalozeni, status,cena, zakaznik, faktura, id_faktura, id_zakaznik FROM v_objednavka WHERE id = :id";

            var dataObjednavka = _database.GetDataFromView(queryObjednavka,parameters);

            Objednavka objednavka = null;
            foreach (var row in dataObjednavka)
            {
                objednavka = new Objednavka(
                    Convert.ToInt32(row["ID"]),
                    DateTime.Parse(row["DATUM_ZALOZENI"].ToString()),
                    double.Parse(row["CENA"].ToString()),
                    Convert.ToInt32(row["ID_ZAKAZNIK"].ToString()),
                    Convert.ToInt32(row["STATUS"].ToString()),
                    Convert.ToInt32(row["ID_FAKTURA"].ToString())
                );
            }

            return objednavka;
        }

        public List<ListViewItem> Load()
        {
            string queryObjednavka = "SELECT id, datum_zalozeni, status,cena, zakaznik, faktura, id_faktura, id_zakaznik FROM v_objednavka";

            var dataObjednavka = _database.GetDataFromView(queryObjednavka);

            var objednavkaList = new List<ListViewItem>();

            foreach (var row in dataObjednavka)
            {
                var item = new ListViewItem(new[]
                {
                row["DATUM_ZALOZENI"].ToString(),
                row["CENA"].ToString(),
                row["ZAKAZNIK"].ToString(),
                row["FAKTURA"].ToString(),
                Convert.ToInt32(row["STATUS"])==1?"Vyřízená":"Zpracovává se"
                });
                item.SubItems[4].Tag = Convert.ToInt32(row["STATUS"]);
                item.SubItems[3].Tag = row["ID_FAKTURA"];
                item.SubItems[2].Tag = row["ID_ZAKAZNIK"];
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
                parameters.Add("p_status",objednavka.Status);

                parameters.Add("p_objednane_zbozi", ConvertZboziSeznamToJson(zbozi));

                parameters.Add("p_akce", ConvertAkceSeznamToJson(akce));

                _database.ExecuteProcedure("insert_update_pkg.update_objednavka", parameters);
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

                _database.ExecuteProcedure("insert_update_pkg.insert_objednavka", parameters);
            }
        }

        public void DeleteObjednavka(int id) {
            var parameters = new Dictionary<string, object> { { "p_id", id } };
            _database.ExecuteProcedure("delete_pkg.delete_objednavka", parameters);
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

        public OrderStatistics GetOrderStatistics()
        {
            OrderStatistics statistics = null;
            string query = "BEGIN :result := GET_ORDER_STATISTICS; END;";

            using (var connection = new OracleConnection(_database.ConnectionString))
            {
                connection.Open();
                using (var command = new OracleCommand(query, connection))
                {
                    var resultParam = new OracleParameter("result", OracleDbType.RefCursor) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(resultParam);

                    try
                    {
                        command.ExecuteNonQuery();

                        using (var reader = ((OracleRefCursor)resultParam.Value).GetDataReader())
                        {
                            if (reader.Read())
                            {
                                statistics = new OrderStatistics
                                {
                                    TotalOrders = reader.GetInt32(reader.GetOrdinal("total_orders")),
                                    AveragePrice = reader.GetDouble(reader.GetOrdinal("average_price")),
                                    TotalPrice = reader.GetDouble(reader.GetOrdinal("total_price")),
                                    CompletedOrders = reader.GetInt32(reader.GetOrdinal("completed_orders")),
                                    PendingOrders = reader.GetInt32(reader.GetOrdinal("pending_orders")),
                                    MostExpensiveOrder = reader.GetDouble(reader.GetOrdinal("most_expensive_order")),
                                    MostExpensiveCustomer = reader.GetString(reader.GetOrdinal("most_expensive_customer")),
                                    LeastExpensiveOrder = reader.GetDouble(reader.GetOrdinal("least_expensive_order")),
                                    LeastExpensiveCustomer = reader.GetString(reader.GetOrdinal("least_expensive_customer"))
                                };
                            }
                        }
                    }
                    catch (OracleException ex)
                    {
                        throw new Exception("Oracle exception occurred: " + ex.Message, ex);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("An error occurred: " + ex.Message, ex);
                    }
                }
            }

            return statistics;
        }
    }
}
