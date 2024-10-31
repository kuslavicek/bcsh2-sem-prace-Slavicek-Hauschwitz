using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Models
    {
public class Adresa
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(32)]
        public string Ulice { get; set; }
        [Required, MaxLength(32)]
        public string Mesto { get; set; }
        [Required]
        public int Psc { get; set; }
        [Required]
        public int CisloPopisne { get; set; }
        [Required, MaxLength(32)]
        public string Stat { get; set; }
    }

    public class Akce
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int PocetOsob { get; set; }
        [Required]
        public DateTime Datum { get; set; }
        [ForeignKey("TypAkce")]
        public int IdTypAkce { get; set; }
        [ForeignKey("Objednavka")]
        public int IdObjednavka { get; set; }
    }

    public class Cider
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(255)]
        public string OdrudaJablek { get; set; }
    }

    public class Faktura
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public byte[] FakturaData { get; set; } // For BLOB
        [Required, MaxLength(255)]
        public string NazevSouboru { get; set; }
        [Required]
        public DateTime DatumVlozeni { get; set; }
    }

    public class Logs
    {
        [Key]
        public DateTime Datum { get; set; }
        [MaxLength(2000)]
        public string Text { get; set; }
    }

    public class ObjednaneZbozi
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Mnozstvi { get; set; }
        [ForeignKey("Objednavka")]
        public int IdObjednavka { get; set; }
        [ForeignKey("Zbozi")]
        public int IdZbozi { get; set; }
    }

    public class Objednavka
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime DatumZalozeni { get; set; }
        [Required]
        public decimal Cena { get; set; }
        [ForeignKey("Zakaznik")]
        public int IdZakaznik { get; set; }
        [ForeignKey("Faktura")]
        public int IdFaktura { get; set; }
    }

    public class Pivo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Stupnovitost { get; set; }
    }

    public class PracovniPozice
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(32)]
        public string Nazev { get; set; }
        [Required]
        public decimal Plat { get; set; }
    }

    public class Provozovna
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(32)]
        public string Nazev { get; set; }
        [Required]
        public int PocetZamestnancu { get; set; }
        [ForeignKey("Adresa")]
        public int IdAdresa { get; set; }
    }

    public class Sklad
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public decimal UzitnaPlocha { get; set; }
        [ForeignKey("Adresa")]
        public int IdAdresa { get; set; }
        [Required, MaxLength(255)]
        public string Nazev { get; set; }
    }

    public class Surovina
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(32)]
        public string Nazev { get; set; }
        [Required]
        public int Mnozstvi { get; set; }
        [ForeignKey("Sklad")]
        public int IdSklad { get; set; }
    }

    public class TypAkce
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(32)]
        public string Nazev { get; set; }
    }

    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string Jmeno { get; set; }
        [Required, MaxLength(50)]
        public string Heslo { get; set; }
        [Required, MaxLength(50)]
        public string Role { get; set; }
        [Required]
        public int NezobrazovatOs { get; set; } = 0;
        [ForeignKey("Zamestnanec")]
        public int IdZamestnanec { get; set; }
    }

    public class Zakaznik
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(32)]
        public string Jmeno { get; set; }
        public int? Telefon { get; set; }
        [MaxLength(32)]
        public string Email { get; set; }
        [ForeignKey("Adresa")]
        public int IdAdresa { get; set; }
    }

    public class Zamestnanec
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(32)]
        public string Jmeno { get; set; }
        [Required, MaxLength(32)]
        public string Prijmeni { get; set; }
        [MaxLength(32)]
        public string Email { get; set; }
        public int? Telefon { get; set; }
        [ForeignKey("Provozovna")]
        public int IdProvozovna { get; set; }
        [ForeignKey("PracovniPozice")]
        public int IdPracovniPozice { get; set; }
        [ForeignKey("Zamestnanec")]
        public int? IdNadrizeny { get; set; }
    }

    public class Zbozi
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(255)]
        public string Nazev { get; set; }
        [Required]
        public decimal ObsahAlkoholu { get; set; }
        [Required]
        public decimal Cena { get; set; }
        [ForeignKey("Sklad")]
        public int IdSklad { get; set; }
        [Required, MaxLength(1)]
        public char Typ { get; set; }
    }

}
}
