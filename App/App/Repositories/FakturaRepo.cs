using App.Model;

namespace App.Repositories
{
    public class FakturaRepo
    {
        private readonly Database _database;

        public FakturaRepo()
        {
            _database = new Database();
        }

        public List<Faktura> Load()
        {
            var list = new List<Faktura>();

            try
            {
                var data = _database.GetDataFromView("SELECT * FROM v_faktura");


                foreach (var row in data)
                {
                    byte[] FakturaBlob = null;

                    if (row["FAKTURA"] != DBNull.Value)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            byte[] fakturaBytes = (byte[])row["FAKTURA"];
                            memoryStream.Write(fakturaBytes, 0, fakturaBytes.Length);
                            FakturaBlob = memoryStream.ToArray();
                        }
                    }
                    var faktura = new Faktura
                    {
                        Id = Convert.ToInt32(row["ID"]),
                        NazevSouboru = row["NAZEV_SOUBORU"].ToString(),
                        DatumVlozeni = Convert.ToDateTime(row["DATUM_VLOZENI"]),
                        FakturaBlob = FakturaBlob
                    };

                    list.Add(faktura);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Chyba při načítání objednaného zboží: " + ex.Message);
            }

            return list;
        }

        public Faktura GetFakturaById(int id)
        {
            var faktura=new Faktura();

            try
            {
                var parameters = new Dictionary<string, object>
                {
                    { "id", id }
                };

                var data = _database.GetDataFromView("SELECT * FROM v_faktura WHERE id = :id", parameters);


                foreach (var row in data)
                {
                    byte[] FakturaBlob = null;

                    if (row["FAKTURA"] != DBNull.Value)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            byte[] fakturaBytes = (byte[])row["FAKTURA"];
                            memoryStream.Write(fakturaBytes, 0, fakturaBytes.Length);
                            FakturaBlob = memoryStream.ToArray();
                        }
                    }
                    faktura = new Faktura
                    {
                        Id = Convert.ToInt32(row["ID"]),
                        NazevSouboru = row["NAZEV_SOUBORU"].ToString(),
                        DatumVlozeni = Convert.ToDateTime(row["DATUM_VLOZENI"]),
                        FakturaBlob = FakturaBlob
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Chyba při načítání objednaného zboží: " + ex.Message);
            }

            return faktura;
        }
    }
}
