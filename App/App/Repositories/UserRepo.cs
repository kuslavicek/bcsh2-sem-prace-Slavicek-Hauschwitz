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
    }
}
