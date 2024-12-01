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

        public void DeleteUser(int id)
        {
            var parameters = new Dictionary<string, object> { { "p_id", id } };
            _database.ExecuteProcedure("delete_user", parameters);
        }

        public void UpdateUser(User user)
        {
            var parameters = new Dictionary<string, object>();

            if (user.Id != null)
            {
                parameters.Add("p_id", user.Id);
            }

            parameters.Add("p_jmeno", user.Jmeno);
            parameters.Add("p_heslo", user.Heslo);
            parameters.Add("p_role", user.Role);
            parameters.Add("p_nezobrazovat_os", user.boolean);
            parameters.Add("p_id_zamestnanec", user.IdZamestnanec);

            if (user.Id == null)
            {
                _database.ExecuteProcedure("insert_user", parameters);
            }
            else
            {
                _database.ExecuteProcedure("update_user", parameters);
            }
        }
    }
}
