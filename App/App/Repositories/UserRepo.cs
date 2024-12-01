using App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public class UserRepo
    {
        private Database _database;

        public UserRepo() { 
            _database = new Database();
        }

        public List<User> Load()
        {
            string query = "SELECT * FROM view_users";
            var data = _database.GetDataFromView(query);

            List<User> usersList = new List<User>();

            foreach (var item in data)
            {
                User user = new User
                {
                    Id = Convert.ToInt32(item["ID"]),
                    Jmeno = item["JMENO"].ToString(),
                    Role = item["ROLE"].ToString(),
                    boolean = Convert.ToInt32(item["NEZOBRAZOVAT_OS"]),
                    IdZamestnanec = Convert.ToInt32(item["ID_ZAMESTNANEC"])
                };
                usersList.Add(user);
            }

            return usersList;
        }
    }
}
