using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Interfaces;
using Logic.Interfaces;

namespace Logic.Classes.Employees
{
    public class EmployeeManager : IEmployeeManager
    {
        IEmployeeDataManager employeeDataManager;
        public EmployeeManager(IEmployeeDataManager employeeDataManager)
        {
            this.employeeDataManager = employeeDataManager;
        }
       

        public void AddEmployee(Employee employee)
        {
            employeeDataManager.AddEmployeeToDB(employee);
        }

        public void EditEmployee(Employee employee)
        {
            employeeDataManager.UpdateEmployee(employee);
        }

        public void PromoteEmployee(Employee employee)
        {
            foreach (Employee p in employeeDataManager.SaveEmployeesToListFromDB())
            {
                if (p.id == employee.id)
                {
                    p.SetPosition(p);
                    employeeDataManager.UpdateEmployee(p);
                }
            }
        }

        public void RemoveEmployee(Employee employee)
        {
            employeeDataManager.RemoveEmployeeFromDB(employee);
        }

        public List<Employee> ShowAll()
        {
            return employeeDataManager.SaveEmployeesToListFromDB();

        }

        public Employee GetEmployeeById(int id)
        {
            foreach (Employee p in employeeDataManager.SaveEmployeesToListFromDB())
            {
                if (p.id== id)
                {
                    return p;
                }
            }
            return null;
        }
    }
}
