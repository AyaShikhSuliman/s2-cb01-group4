using Logic.Classes.Employees;
using Logic.Classes.Shift;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces
{
    public interface IShiftDataManager
    {
        void AddShift(Shift shift);
        List<Shift> GetAllShifts();
        List<Employee> GetAllEmployeeInfoNoDuplicateInShiftTable();
        List<Employee> GetAvailableEmployeesByDate(DateTime date);
        Shift GetShiftsByEmployeeId(int id);
        void DeleteAllShifts(List<Shift> shifts);
        void updateShift(Shift shift);
        Employee EmployeeById(int id);
        void AddWorkPrefrences(int id, string date);
        List<string> GetWorkPrefrences(int id);
        void AddVaccationRequest(int id, string date, int reason);
        List<Dictionary<int, string>> GetVaccationRequests(int id);
        bool CheckExistingShiftForAnEmployee(Shift shift);
        List<WorkingPreferenceDays> GetAllVacations();
        List<WorkingPreferenceDays> GetAllWorkPrefrences();

    }
}
