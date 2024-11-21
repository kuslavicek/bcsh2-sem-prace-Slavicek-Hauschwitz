using App.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Oracle.ManagedDataAccess.Types;

namespace App.Repositories
{
    public class ZakaznikRepo
    {
        private readonly Database _database;
        public ZakaznikRepo() {
            _database = new Database();
        }
        public List<Zakaznik> Load()
        {
            string queryZakaznik = "SELECT zakaznik_id, jmeno, telefon, email, id_adresa ,adresa FROM v_zakaznik";
            var dataZakaznik = _database.GetDataFromView(queryZakaznik);

            var zakaznikList = new List<Zakaznik>();

            foreach (var row in dataZakaznik)
            {
                var adresaParts = row["ADRESA"].ToString()?.Split(new[] { ", " }, StringSplitOptions.None);

                if (adresaParts != null && adresaParts.Length == 5)
                {
                    var adresa = new Adresa(
                        id: Convert.ToInt32(row["ID_ADRESA"]),
                        mesto: adresaParts[0],
                        psc: int.Parse(adresaParts[1]),
                        ulice: adresaParts[2],
                        cisloPopisne: int.Parse(adresaParts[3]),
                        stat: adresaParts[4]
                    );

                    var zakaznik = new Zakaznik(
                        id: Convert.ToInt32(row["ZAKAZNIK_ID"]),
                        jmeno: row["JMENO"].ToString(),
                        telefon: Convert.ToInt32(row["TELEFON"]),
                        email: row["EMAIL"].ToString(),
                        adresa: adresa,
                        null
                    );

                    zakaznikList.Add(zakaznik);
                }
                else
                {
                    throw new FormatException("Adresu není možné rozparsovat. Očekávaný formát: 'Mesto, PSC, Ulice, Cislo_popisne, Stat'.");
                }
            }

            return zakaznikList;
        }



        public void UpdateZakaznik(Zakaznik zakaznik)
        {
            var parameters = new Dictionary<string, object>();

            if (zakaznik.Id != null)
            {
                parameters.Add("p_id", zakaznik.Id);
            }

            parameters.Add("p_jmeno", zakaznik.Jmeno);
            parameters.Add("p_telefon", zakaznik.Telefon);
            parameters.Add("p_email", zakaznik.Email);

            parameters.Add("p_ulice", zakaznik.Adresa.Ulice);
            parameters.Add("p_mesto", zakaznik.Adresa.Mesto);
            parameters.Add("p_psc", zakaznik.Adresa.Psc);
            parameters.Add("p_cislo_popisne", zakaznik.Adresa.CisloPopisne);
            parameters.Add("p_stat", zakaznik.Adresa.Stat);

            if (zakaznik.Id == null)
            {
                _database.ExecuteProcedure("insert_zakaznik", parameters);
            }
            else
            {
                _database.ExecuteProcedure("update_zakaznik", parameters);
            }
        }

        public void DeleteZakaznik(int zakaznikId)
        {
            var parameters = new Dictionary<string, object> { { "p_id", zakaznikId } };
            _database.ExecuteProcedure("delete_zakaznik", parameters);
        }

        public Zakaznik GetZakaznikById(int id)
        {
            Zakaznik zakaznik = null;
            string query = "BEGIN :result := GetZakaznikById(:id); END;";

            using (var connection = new OracleConnection(_database.ConnectionString))
            {
                connection.Open();
                using (var command = new OracleCommand(query, connection))
                {
                    var resultParam = new OracleParameter("result", OracleDbType.RefCursor) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(resultParam);
                    command.Parameters.Add(new OracleParameter("id", OracleDbType.Int32) { Value = id });

                    try
                    {
                        command.ExecuteNonQuery();

                        using (var reader = ((OracleRefCursor)resultParam.Value).GetDataReader())
                        {
                            if (reader.Read())
                            {
                                zakaznik = new Zakaznik(
                                    reader.GetInt32(reader.GetOrdinal("id")),
                                    reader.GetString(reader.GetOrdinal("jmeno")),
                                    reader.GetDouble(reader.GetOrdinal("telefon")),
                                    reader.GetString(reader.GetOrdinal("email")),
                                    null,
                                    reader.GetInt32(reader.GetOrdinal("id_adresa"))
                                );
                            }
                        }
                    }
                    catch (OracleException ex)
                    {
                        throw ex;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }

            return zakaznik;
        }

    }
}
