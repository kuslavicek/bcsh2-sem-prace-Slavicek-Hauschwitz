using Newtonsoft.Json;
namespace WebApplication1.Models
{
    public class Adresa
    {
        public int IdAdresa { get; set; }
        public string Ulice { get; set; }
        public string Mesto { get; set; }
        public int Psc { get; set; }
        public int CisloPopisne { get; set; }
        public string Stat { get; set; }

        public static Adresa FromString(string jsonString)
        {
            return JsonConvert.DeserializeObject<Adresa>(jsonString);
    }
    }

    public class Akce
    {
        public int IdAkce { get; set; }
        public int PocetOsob { get; set; }
        public DateTime Datum { get; set; }
        public int IdTypAkce { get; set; }
        public int IdObjednavka { get; set; }
        public static Akce FromString(string jsonString)
        {
            return JsonConvert.DeserializeObject<Akce>(jsonString);
    }
    }

    public class Cider
    {
        public int IdCider { get; set; }
        public string OdrudaJablek { get; set; }

        public static Cider FromString(string jsonString)
        {
            return JsonConvert.DeserializeObject<Cider>(jsonString);
    }
    }

    public class ObjednaneZbozi
    {
        public int IdObjednaneZbozi { get; set; }
        public int Mnozstvi { get; set; }
        public int IdObjednavka { get; set; }
        public int IdZbozi { get; set; }

        public static ObjednaneZbozi FromString(string jsonString)
        {
            return JsonConvert.DeserializeObject<ObjednaneZbozi>(jsonString);
    }
    }

    public class Objednavka
    {
        public int IdObjednavka { get; set; }
        public DateTime DatumZalozeni { get; set; }
        public decimal Cena { get; set; }
        public int IdAdresa { get; set; }
        public int IdZakaznik { get; set; }
        public int IdZamestnanec { get; set; }
        public static Objednavka FromString(string jsonString)
        {
            return JsonConvert.DeserializeObject<Objednavka>(jsonString);
    }
    }

    public class Pivo
    {
        public int IdPivo { get; set; }
        public decimal Stupnovitost { get; set; }

        public static Pivo FromString(string jsonString)
        {
            return JsonConvert.DeserializeObject<Pivo>(jsonString);
    }
    }

    public class Pivovar
    {
        public int IdPivovar { get; set; }
        public string Nazev { get; set; }
        public string Kategorie { get; set; }
        public int IdAdresa { get; set; }

        public static Pivovar FromString(string jsonString)
        {
            return JsonConvert.DeserializeObject<Pivovar>(jsonString);
    }
    }

    public class PracovniPozice
    {
        public int IdPracovniPozice { get; set; }
        public string Nazev { get; set; }
        public decimal Plat { get; set; }

        public static PracovniPozice FromString(string jsonString)
        {
            return JsonConvert.DeserializeObject<PracovniPozice>(jsonString);
        }
    }

    public class Provozovna
    {
        public int IdProvozovna { get; set; }
        public string Nazev { get; set; }
        public int PocetZamestnancu { get; set; }
        public int IdAdresa { get; set; }
        public static Provozovna FromString(string jsonString)
        {
            return JsonConvert.DeserializeObject<Provozovna>(jsonString);
        }
    }

    public class Sklad
    {
        public int IdSklad { get; set; }
        public decimal UzitnaPlocha { get; set; }
        public int IdAdresa { get; set; }
        public static Sklad FromString(string jsonString)
        {
            return JsonConvert.DeserializeObject<Sklad>(jsonString);
        }
    }

    public class Surovina
    {
        public int IdSurovina { get; set; }
        public string Nazev { get; set; }
        public decimal Mnozstvi { get; set; }
        public int IdSklad { get; set; }
        public static Surovina FromString(string jsonString)
        {
            return JsonConvert.DeserializeObject<Surovina>(jsonString);
        }
    }

    public class TypAkce
    {
        public int IdTypAkce { get; set; }
        public string Nazev { get; set; }
        public static TypAkce FromString(string jsonString)
        {
            return JsonConvert.DeserializeObject<TypAkce>(jsonString);
        }
    }

    public class Zakaznik
    {
        public int IdZakaznik { get; set; }
        public string Jmeno { get; set; }
        public int Telefon { get; set; }
        public string Email { get; set; }
        public int IdAdresa { get; set; }
        public static Zakaznik FromString(string jsonString)
        {
            return JsonConvert.DeserializeObject<Zakaznik>(jsonString);
        }
    }

    public class Zamestnanec
    {
        public int IdZamestnanec { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Email { get; set; }
        public int Telefon { get; set; }
        public int IdProvozovna { get; set; }
        public int IdPracovniPozice { get; set; }
        public int IdAdresa { get; set; }
        public static Zamestnanec FromString(string jsonString)
        {
            return JsonConvert.DeserializeObject<Zamestnanec>(jsonString);
        }
    }

    public class Zbozi
    {
        public int IdZbozi { get; set; }
        public string Nazev { get; set; }
        public decimal ObsahAlkoholu { get; set; }
        public char Typ { get; set; }
        public decimal Cena { get; set; }
        public int IdSklad { get; set; }
        public static Zbozi FromString(string jsonString)
        {
            return JsonConvert.DeserializeObject<Zbozi>(jsonString);
        }
    }

}
