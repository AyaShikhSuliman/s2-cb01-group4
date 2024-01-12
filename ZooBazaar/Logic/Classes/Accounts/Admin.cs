using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.Accounts
{
    public class Admin
    {
        private string username;
        private string password;

        public Admin()
        {
            username = "admin";
            password = "admin";
        }

        public string Username { get { return username; } }
        public string Password { get { return password; } }
    }
}

