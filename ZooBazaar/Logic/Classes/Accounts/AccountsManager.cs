using Data.Interfaces;
using Logic.Classes.Employees;
using Logic.Enums;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.Accounts
{
    public class AccountsManager : ILoginManager
    {
        private Scheduler Scheduler = new Scheduler();
        private Admin admin = new Admin();
 
        public bool IsAdmin(string username, string password)
        {
            if (username == admin.Username && password == admin.Password)
            {
                return true;
            }
            return false;
        }

        public bool IsScheduler(string username, string password)
        {
            if (username == Scheduler.Username && password == Scheduler.Password)
            {
                return true;
            }
            return false;
        }

        public List<Employee> employees()
        {
            throw new NotImplementedException();
        }
    }
}
