using Logic.Classes.Employees;
using Logic.DalInterfaces;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.Accounts
{
    public class LoginManager : ILoginManagerEmployees
    {
        ILoginDataManager loginDataManager;
        public LoginManager(ILoginDataManager loginDataManager)
        {
            this.loginDataManager = loginDataManager;
        }

        public List<Employee> employees()
        {
           return loginDataManager.SaveEmployeesToListFromDB();
        }

        public bool IsEmployee(string username, string password)
        {
            foreach (Employee employee in employees())
            {
                if (username == employee.email && password == employee.password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
