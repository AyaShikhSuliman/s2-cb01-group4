using Logic.Classes.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DalInterfaces
{
    public interface ILoginDataManager
    {
        List<Employee> SaveEmployeesToListFromDB();
    }
}
