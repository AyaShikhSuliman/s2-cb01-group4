using Logic.Classes.Employees;
using Logic.Classes.Shift;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces
{
    public interface IShiftManager
    {
        void AddShift(Shift shift);
        List<Shift> GetAllShifts();
        void DeleteAllShifts(List<Shift> shifts);
        List<Employee> GetAllEmployeeInfoNoDuplicateInShiftTable();
        Shift GetShiftsByEmployeeId(int id);
        Employee EmployeeById(int id);
        void updateShift(Shift shift);
        bool AddWorkPrefrences(int id, string date);
        List<string> GetWorkPrefrences(int id);
        bool AddVaccationRequest(int id,string date, int reason);
        List<Dictionary<int, string>> GetVaccationRequests(int id);
        bool CheckExistingShiftForAnEmployee(Shift shift);
        List<WorkingPreferenceDays> GetAllWorkPrefrences();
        List<WorkingPreferenceDays> GetAllVacations();
    }
}
