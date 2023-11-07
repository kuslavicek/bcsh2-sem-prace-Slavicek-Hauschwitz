using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace WebApplication1.Models
{
    public class Adresa
    {
        [JsonProperty("ID_ADRESA")]
        public int IdAdresa { get; set; }
        public string Ulice { get; set; }
        public string Mesto { get; set; }
        public int Psc { get; set; }
        [JsonProperty("CISLO_POPISNE")]
        public int CisloPopisne { get; set; }
        public string Stat { get; set; }

        public static Adresa FromString(string jsonString)
        {
            return JsonConvert.DeserializeObject<Adresa>(jsonString);
    }
    }

    public class Akce
    {
        [JsonProperty("id_akce")]
        public int IdAkce { get; set; }
        [JsonProperty("pocet_osob")]
        public int PocetOsob { get; set; }
        public DateTime Datum { get; set; }
        [JsonProperty("id_typ_akce")]
        public int IdTypAkce { get; set; }
        [JsonProperty("id_objednavka")]
        public int IdObjednavka { get; set; }
        public static Akce FromString(string jsonString)
        {
            return JsonConvert.DeserializeObject<Akce>(jsonString);
    }
    }

    public class Cider
    {
        [JsonProperty("id_cider")]
        public int IdCider { get; set; }
        [JsonProperty("odruda_jablek")]
        public string OdrudaJablek { get; set; }

        public static Cider FromString(string jsonString)
        {
            return JsonConvert.DeserializeObject<Cider>(jsonString);
    }
    }

    public class ObjednaneZbozi
    {
        [JsonProperty("id_objednane_zbozi")]
        public int IdObjednaneZbozi { get; set; }
        public int Mnozstvi { get; set; }
        [JsonProperty("id_objednavka")]
        public int IdObjednavka { get; set; }
        [JsonProperty("id_zbozi")]
        public int IdZbozi { get; set; }

        public static ObjednaneZbozi FromString(string jsonString)
        {
            return JsonConvert.DeserializeObject<ObjednaneZbozi>(jsonString);
    }
    }

    public class Objednavka
    {
        [JsonProperty("id_objednavka")]
        public int IdObjednavka { get; set; }
        [JsonProperty("datum_zalozeni")]
        public DateTime DatumZalozeni { get; set; }
        public decimal Cena { get; set; }
        [JsonProperty("id_adresa")]
        public int IdAdresa { get; set; }
        [JsonProperty("id_zakaznik")]
        public int IdZakaznik { get; set; }
        [JsonProperty("id_zamestnanec")]
        public int IdZamestnanec { get; set; }
        public static Objednavka FromString(string jsonString)
        {
            return JsonConvert.DeserializeObject<Objednavka>(jsonString);
    }
    }

    public class Pivo
    {
        [JsonProperty("id_pivo")]
        public int IdPivo { get; set; }
        public decimal Stupnovitost { get; set; }

        public static Pivo FromString(string jsonString)
        {
            return JsonConvert.DeserializeObject<Pivo>(jsonString);
    }
    }

    public class Pivovar
    {
        [JsonProperty("id_pivovar")]
        public int IdPivovar { get; set; }
        public string Nazev { get; set; }
        public string Kategorie { get; set; }
        [JsonProperty("id_adresa")]
        public int IdAdresa { get; set; }

        public static Pivovar FromString(string jsonString)
        {
            return JsonConvert.DeserializeObject<Pivovar>(jsonString);
    }
    }

    public class PracovniPozice
    {
        [JsonProperty("id_pracovni_pozice")]
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
        [JsonProperty("id_provozovna")]
        public int IdProvozovna { get; set; }
        public string Nazev { get; set; }
        [JsonProperty("pocet_zamestnancu")]
        public int PocetZamestnancu { get; set; }
        [JsonProperty("id_adresa")]
        public int IdAdresa { get; set; }
        public static Provozovna FromString(string jsonString)
        {
            return JsonConvert.DeserializeObject<Provozovna>(jsonString);
        }
    }

    public class Sklad
    {
        [JsonProperty("id_sklad")]
        public int IdSklad { get; set; }
        [JsonProperty("uzitna_plocha")]
        public decimal UzitnaPlocha { get; set; }
        [JsonProperty("id_adresa")]
        public int IdAdresa { get; set; }
        public static Sklad FromString(string jsonString)
        {
            return JsonConvert.DeserializeObject<Sklad>(jsonString);
        }
    }

    public class Surovina
    {
        [JsonProperty("id_surovina")]
        public int IdSurovina { get; set; }
        public string Nazev { get; set; }
        public decimal Mnozstvi { get; set; }
        [JsonProperty("id_sklad")]
        public int IdSklad { get; set; }
        public static Surovina FromString(string jsonString)
        {
            return JsonConvert.DeserializeObject<Surovina>(jsonString);
        }
    }

    public class TypAkce
    {
        [JsonProperty("id_typ_akce")]
        public int IdTypAkce { get; set; }
        public string Nazev { get; set; }
        public static TypAkce FromString(string jsonString)
        {
            return JsonConvert.DeserializeObject<TypAkce>(jsonString);
        }
    }

    public class Zakaznik
    {
        [JsonProperty("ID_ZAKAZNIK")]
        public int IdZakaznik { get; set; }
        public string Jmeno { get; set; }
        public int Telefon { get; set; }
        public string Email { get; set; }
        [JsonProperty("ID_ADRESA")]
        public int IdAdresa { get; set; }
        public static Zakaznik FromString(string jsonString)
        {
            return JsonConvert.DeserializeObject<Zakaznik>(jsonString);
        }
    }

    public class Zamestnanec
    {
        [JsonProperty("id_zamestnanec")]
        public int IdZamestnanec { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Email { get; set; }
        public Int64 Telefon { get; set; }
        [JsonProperty("id_provozovna")]
        public int IdProvozovna { get; set; }
        [JsonProperty("id_pracovni_pozice")]
        public int IdPracovniPozice { get; set; }
        [JsonProperty("id_adresa")]
        public int IdAdresa { get; set; }
        public static Zamestnanec FromString(string jsonString)
        {
            return JsonConvert.DeserializeObject<Zamestnanec>(jsonString);
        }
    }

    public class Zbozi
    {
        [JsonProperty("id_zbozi")]
        public int IdZbozi { get; set; }
        public string Nazev { get; set; }
        [JsonProperty("obsah_alkoholu")]
        public decimal ObsahAlkoholu { get; set; }
        public char Typ { get; set; }
        public decimal Cena { get; set; }
        [JsonProperty("id_sklad")]
        public int IdSklad { get; set; }
        public static Zbozi FromString(string jsonString)
        {
            return JsonConvert.DeserializeObject<Zbozi>(jsonString);
        }
    }

}
