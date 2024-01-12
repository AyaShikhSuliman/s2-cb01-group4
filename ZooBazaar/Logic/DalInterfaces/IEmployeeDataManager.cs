using Logic.Classes.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IEmployeeDataManager
    {
        void AddEmployeeToDB(Employee employee);
        void RemoveEmployeeFromDB(Employee employee);
        List<Employee> SaveEmployeesToListFromDB();
        void UpdateEmployee(Employee employee);
    }
}
