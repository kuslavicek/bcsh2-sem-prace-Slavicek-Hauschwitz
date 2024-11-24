using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Jmeno { get; set; }
        public string Heslo { get; set; }
        public string Role { get; set; }
        public int boolean { get; set; }
        public int IdZamestnanec { get; set; }
    
        public static User ParseUser(object result)
        {
            // Assuming result is a comma-separated string from the PL/SQL function
            // Example: "1,JohnDoe,hashedpassword,Sekretářka,0,5"
            var data = result.ToString().Split(',');

            if (data.Length < 6)
                throw new FormatException("Unexpected format for user data.");

            return new User
            {
                Id = int.Parse(data[0]),
                Jmeno = data[1],
                Heslo = data[2],
                Role = data[3],
                boolean = int.Parse(data[4]),
                IdZamestnanec = int.Parse(data[5])
            };
        }
    }

}
