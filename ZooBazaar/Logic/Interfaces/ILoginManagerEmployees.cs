using Logic.Classes.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces
{
    public interface ILoginManagerEmployees
    {
        List<Employee> employees();
        bool IsEmployee(string username, string password);
    }
}
