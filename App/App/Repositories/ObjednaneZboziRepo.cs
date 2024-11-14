using App.Model;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public class ObjednaneZboziRepo
    {
        private readonly Database _database;

        public ObjednaneZboziRepo()
        {
            _database = new Database();
        }

        public List<KeyValuePair<ObjednaneZbozi, Zbozi>> GetObjednaneZboziByObjednavka(int id)
        {
            var objednaneZboziList = new List<KeyValuePair<ObjednaneZbozi, Zbozi>>();

            using (var connection = new OracleConnection(_database.ConnectionString))
            {
                connection.Open();

                using (var command = new OracleCommand("BEGIN :result := get_objednane_zbozi_by_objednavka(:id); END;", connection))
                {

                    OracleParameter refCursorParam = new OracleParameter("result", OracleDbType.RefCursor){Direction = ParameterDirection.Output};
                    command.Parameters.Add(refCursorParam);
                    command.Parameters.Add(new OracleParameter("id", OracleDbType.Int32) { Value = id });

                    try
                    {
                        command.ExecuteNonQuery();

                        using (var reader = ((OracleRefCursor)refCursorParam.Value).GetDataReader())
                        {
                            while (reader.Read())
                            {
                                var objednaneZbozi = new ObjednaneZbozi
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                                    Mnozstvi = reader.GetInt32(reader.GetOrdinal("mnozstvi")),
                                    IdObjednavka = reader.GetInt32(reader.GetOrdinal("id_objednavka")),
                                    IdZbozi = reader.GetInt32(reader.GetOrdinal("id_zbozi"))
                                };

                                var zbozi = new Zbozi
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("id_zbozi")),
                                    Nazev = reader.GetString(reader.GetOrdinal("nazev")),
                                    ObsahAlkoholu = reader.GetDouble(reader.GetOrdinal("obsah_alkoholu")),
                                    Cena = reader.GetDouble(reader.GetOrdinal("cena")),
                                    Typ = reader.GetString(reader.GetOrdinal("typ"))[0],
                                    SkladId = reader.GetInt32(reader.GetOrdinal("id_sklad")),
                                };

                                if (zbozi.Typ == 'c')
                                {
                                    zbozi.OdrudaJablek = reader.GetString(reader.GetOrdinal("odruda_jablek"));
                                }
                                else if (zbozi.Typ == 'p')
                                {
                                    zbozi.Stupnovitost = reader.GetDouble(reader.GetOrdinal("stupnovitost"));
                                }

                                objednaneZboziList.Add(new KeyValuePair<ObjednaneZbozi, Zbozi>(objednaneZbozi, zbozi));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Chyba při volání funkce: " + ex.Message);
                    }
                }
            }

            return objednaneZboziList;
        }

    }
}
