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
    }

    public class Akce
    {
        public int IdAkce { get; set; }
        public int PocetOsob { get; set; }
        public DateTime Datum { get; set; }
        public int IdTypAkce { get; set; }
        public int IdObjednavka { get; set; }
    }

    public class Cider
    {
        public int IdCider { get; set; }
        public string OdrudaJablek { get; set; }
    }

    public class ObjednaneZbozi
    {
        public int IdObjednaneZbozi { get; set; }
        public int Mnozstvi { get; set; }
        public int IdObjednavka { get; set; }
        public int IdZbozi { get; set; }
    }

    public class Objednavka
    {
        public int IdObjednavka { get; set; }
        public DateTime DatumZalozeni { get; set; }
        public decimal Cena { get; set; }
        public int IdAdresa { get; set; }
        public int IdZakaznik { get; set; }
        public int IdZamestnanec { get; set; }
    }

    public class Pivo
    {
        public int IdPivo { get; set; }
        public decimal Stupnovitost { get; set; }
    }

    public class Pivovar
    {
        public int IdPivovar { get; set; }
        public string Nazev { get; set; }
        public string Kategorie { get; set; }
        public int IdAdresa { get; set; }
    }

    public class PracovniPozice
    {
        public int IdPracovniPozice { get; set; }
        public string Nazev { get; set; }
        public decimal Plat { get; set; }
    }

    public class Provozovna
    {
        public int IdProvozovna { get; set; }
        public string Nazev { get; set; }
        public int PocetZamestnancu { get; set; }
        public int IdAdresa { get; set; }
    }

    public class Sklad
    {
        public int IdSklad { get; set; }
        public decimal UzitnaPlocha { get; set; }
        public int IdAdresa { get; set; }
    }

    public class Surovina
    {
        public int IdSurovina { get; set; }
        public string Nazev { get; set; }
        public decimal Mnozstvi { get; set; }
        public int IdSklad { get; set; }
    }

    public class TypAkce
    {
        public int IdTypAkce { get; set; }
        public string Nazev { get; set; }
    }

    public class Zakaznik
    {
        public int IdZakaznik { get; set; }
        public string Jmeno { get; set; }
        public int Telefon { get; set; }
        public string Email { get; set; }
        public int IdAdresa { get; set; }
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
    }

    public class Zbozi
    {
        public int IdZbozi { get; set; }
        public string Nazev { get; set; }
        public decimal ObsahAlkoholu { get; set; }
        public char Typ { get; set; }
        public decimal Cena { get; set; }
        public int IdSklad { get; set; }
    }
}
