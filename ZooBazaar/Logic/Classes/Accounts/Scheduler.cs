using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.Accounts
{
    public class Scheduler
    {
        private string username;
        private string password;

        public Scheduler()
        {
            username = "scheduler";
            password = "scheduler";
        }
        public string Username { get { return username; } }
        public string Password { get { return password; } }
    }
}

