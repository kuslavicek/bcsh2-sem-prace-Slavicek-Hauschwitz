using App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public class ZamestnanecRepo
    {
        private readonly Database _database;

        public ZamestnanecRepo() {
            _database = new Database();
        }

        public Zamestnanec GetZamestnanecByID(int id)
        {
            var parameters = new Dictionary<string, object>
                {
                    { "id", id }
                };
            string query = "SELECT id, jmeno, prijmeni, email, telefon, id_provozovna, id_pracovni_pozice, id_nadrizeny, nezobrazovat_os FROM v_zamestnanec WHERE id= :id";
            var data = _database.GetDataFromView(query,parameters);

            Zamestnanec empl = new Zamestnanec();

            foreach (var item in data)
            {
                empl = new Zamestnanec
                {
                    Id = Convert.ToInt32(item["ID"]),
                    Jmeno = item["JMENO"].ToString(),
                    Prijmeni = item["PRIJMENI"].ToString(),
                    Email = item["EMAIL"].ToString(),
                    Telefon = double.Parse(item["TELEFON"].ToString()),
                    IdProvozovna = Convert.ToInt32(item["ID_PROVOZOVNA"]),
                    IdPracovniPozice = Convert.ToInt32(item["ID_PRACOVNI_POZICE"]),
                    IdNadrizeny = item["ID_NADRIZENY"] != null ? Convert.ToInt32(item["ID_NADRIZENY"]) : null,
                    Nezobrazovat = Convert.ToInt32(item["NEZOBRAZOVAT_OS"])
                };
            }

            return empl;
        }

        public List<Zamestnanec> Load()
        {
            string query = "SELECT id, jmeno, prijmeni, email, telefon, id_provozovna, id_pracovni_pozice, id_nadrizeny, nezobrazovat_os FROM v_zamestnanec";
            var data = _database.GetDataFromView(query);

            List<Zamestnanec> zamestnanecList = new List<Zamestnanec>();

            foreach (var item in data)
            {
                Zamestnanec empl = new Zamestnanec
                {
                    Id = Convert.ToInt32(item["ID"]),
                    Jmeno = item["JMENO"].ToString(),
                    Prijmeni = item["PRIJMENI"].ToString(),
                    Email = item["EMAIL"].ToString(),
                    Telefon = double.Parse(item["TELEFON"].ToString()),
                    IdProvozovna = Convert.ToInt32(item["ID_PROVOZOVNA"]),
                    IdPracovniPozice = Convert.ToInt32(item["ID_PRACOVNI_POZICE"]),
                    IdNadrizeny = item["ID_NADRIZENY"]!=null? Convert.ToInt32(item["ID_NADRIZENY"]):null,
                    Nezobrazovat = Convert.ToInt32(item["NEZOBRAZOVAT_OS"])
                };
                zamestnanecList.Add(empl);
            }

            return zamestnanecList;
        }

        public Zamestnanec GetNadrizeny(int? id)
        {
            if (id!=null) {
                var parameters = new Dictionary<string, object>
                {
                    { "id", id }
                };
                string query = "SELECT id, jmeno, prijmeni, email, telefon, id_provozovna, id_pracovni_pozice, id_nadrizeny FROM v_zamestnanec WHERE id = :id";
                var data = _database.GetDataFromView(query,parameters);
                Zamestnanec empl = new Zamestnanec();

                foreach (var item in data)
                {
                    empl = new Zamestnanec
                    {
                        Id = Convert.ToInt32(item["ID"]),
                        Jmeno = item["JMENO"].ToString(),
                        Prijmeni = item["PRIJMENI"].ToString(),
                        Email = item["EMAIL"].ToString(),
                        Telefon = double.Parse(item["TELEFON"].ToString()),
                        IdProvozovna = Convert.ToInt32(item["ID_PROVOZOVNA"]),
                        IdPracovniPozice = Convert.ToInt32(item["ID_PRACOVNI_POZICE"]),
                        IdNadrizeny = item["ID_NADRIZENY"] != null ? Convert.ToInt32(item["ID_NADRIZENY"]) : null
                    };
                }

                return empl;
            }
            return null;
        }

        public void UpdateZamestnanec(Zamestnanec emp) {
            var parameters = new Dictionary<string, object>();

            if (emp.Id != null)
            {
                parameters.Add("p_id", emp.Id);
            }

            parameters.Add("p_jmeno", emp.Jmeno);
            parameters.Add("p_prijmeni", emp.Prijmeni);
            parameters.Add("p_email", emp.Email);
            parameters.Add("p_telefon", emp.Telefon);
            parameters.Add("p_id_provozovna", emp.IdProvozovna);
            parameters.Add("p_id_pozice", emp.IdPracovniPozice);
            parameters.Add("p_idNadrizeny", emp.IdNadrizeny);


            if (emp.Id == null)
            {
                _database.ExecuteProcedure("insert_update_pkg.insert_zamestnanec", parameters);
            }
            else
            {
                _database.ExecuteProcedure("insert_update_pkg.update_zamestnanec", parameters);
            }
        }

        public void DeleteZamestnanec(int id) {
            var parameters = new Dictionary<string, object> { { "p_id", id } };
            _database.ExecuteProcedure("delete_pkg.delete_zamestnanec", parameters);
        }
    }
}
