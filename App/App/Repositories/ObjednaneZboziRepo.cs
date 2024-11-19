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

            string query = "SELECT * FROM v_objednane_zbozi WHERE id_objednavka = :id";

            try
            {
                var parameters = new Dictionary<string, object>
                {
                    { "id_objednavka", id }
                };

                var data = _database.GetDataFromView("SELECT * FROM v_objednane_zbozi WHERE id_objednavka = :id_objednavka", parameters);

                foreach (var row in data)
                {
                    var objednaneZbozi = new ObjednaneZbozi
                    {
                        Id = Convert.ToInt32(row["OBJEDNANE_ZBOZI_ID"]),
                        Mnozstvi = Convert.ToInt32(row["MNOZSTVI"]),
                        IdObjednavka = Convert.ToInt32(row["ID_OBJEDNAVKA"]),
                        IdZbozi = Convert.ToInt32(row["ID_ZBOZI"])
                    };

                    var zbozi = new Zbozi
                    {
                        Id = Convert.ToInt32(row["ID_ZBOZI"]),
                        Nazev = row["NAZEV"].ToString(),
                        ObsahAlkoholu = Convert.ToDouble(row["OBSAH_ALKOHOLU"]),
                        Cena = Convert.ToDouble(row["CENA"]),
                        Typ = row["TYP"].ToString()[0],
                        SkladId = Convert.ToInt32(row["ID_SKLAD"])
                    };

                    // Specifické údaje podle typu
                    if (zbozi.Typ == 'c' && row["ODRUDA_JABLEK"] != DBNull.Value)
                    {
                        zbozi.OdrudaJablek = row["ODRUDA_JABLEK"].ToString();
                    }
                    else if (zbozi.Typ == 'p' && row["STUPNOVITOST"] != DBNull.Value)
                    {
                        zbozi.Stupnovitost = Convert.ToDouble(row["STUPNOVITOST"]);
                    }

                    objednaneZboziList.Add(new KeyValuePair<ObjednaneZbozi, Zbozi>(objednaneZbozi, zbozi));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Chyba při načítání objednaného zboží: " + ex.Message);
            }

            return objednaneZboziList;
        }

        public void DeleteObjednaneZbozi(int id) {
            var parameters = new Dictionary<string, object> { { "p_id", id } };
            _database.ExecuteProcedure("delete_objednane_zbozi", parameters);
        }


    }
}
