using App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            // Dotaz na view 'v_zakaznik', které již obsahuje spojení mezi zákazníkem a adresou
            string queryZakaznik = "SELECT id, jmeno, telefon, email, adresa FROM v_zakaznik";

            // Načteme data z view
            var dataZakaznik = _database.GetDataFromView(queryZakaznik);

            var zakaznikList = new List<Zakaznik>();

            // Procházení načtených řádků a vytváření seznamu zákazníků
            foreach (var row in dataZakaznik)
            {
                // Rozdělení adresy na jednotlivé části
                var adresaParts = row["ADRESA"].ToString()?.Split(new[] { ", " }, StringSplitOptions.None);

                // Předpokládáme, že adresa obsahuje město, ulici, číslo popisné a stát v tomto pořadí
                var adresa = new Adresa(
                    mesto: adresaParts[0],
                    ulice: adresaParts[1],
                    cisloPopisne: adresaParts[2],
                    stat: adresaParts[3]
                );

                // Vytvoření objektu Zakaznik s objektovou adresou
                var zakaznik = new Zakaznik(
                    id: Convert.ToInt32(row["ID"]),
                    jmeno: row["JMENO"].ToString(),
                    telefon: Convert.ToInt32(row["TELEFON"]),
                    email: row["EMAIL"].ToString(),
                    adresa: adresa  // Přiřazení objektu Adresa
                );
                zakaznikList.Add(zakaznik);
            }

            return zakaznikList;
        }
    }
}
