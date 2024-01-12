using Logic.Classes.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Logic.Interfaces
{
    public interface IEmployeeManager
    {
        void EditEmployee(Employee employee);
        void RemoveEmployee(Employee employee);
        void AddEmployee(Employee employee);
        void PromoteEmployee(Employee employee);
        Employee GetEmployeeById(int id);
        List<Employee> ShowAll();

    }
}
