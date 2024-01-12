using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Classes.Employees;
using Logic.Enums;
using Logic.Interfaces;

namespace Logic.Classes.Shift
{
    public class ShiftManager: IShiftManager
    {
        IShiftDataManager dataManager;

        public ShiftManager(IShiftDataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public void AddShift(Shift shift)
        {
           dataManager.AddShift(shift);
        }
        public List<Employee> GetAllEmployeeInfoNoDuplicateInShiftTable()
        {
            return dataManager.GetAllEmployeeInfoNoDuplicateInShiftTable();
        }
        public Shift GetShiftsByEmployeeId(int id)
        {
            return dataManager.GetShiftsByEmployeeId(id);
        }

        public void DeleteAllShifts(List<Shift> shifts)
        {
            dataManager.DeleteAllShifts(shifts);
        }
        public Employee EmployeeById(int id)
        {
          return dataManager.EmployeeById(id);
        }

        public List<Shift> GetAllShifts()
        {
            return dataManager.GetAllShifts();
        }

        public void updateShift(Shift shift)
        {
           dataManager.updateShift(shift);
        }
        public bool AddWorkPrefrences(int id, string date)
        {
            foreach (string item in GetWorkPrefrences(id))
            {
                if (item == date)
                {
                    return false;
                }
            }
            dataManager.AddWorkPrefrences(id, date);
            return true;
        }
        public List<string> GetWorkPrefrences(int id)
        {
            return dataManager.GetWorkPrefrences(id);
        }

        public bool AddVaccationRequest(int id, string date, int reason)
        {
            foreach (var item in GetVaccationRequests(id))
            {
                if (item.ContainsKey(reason) && item.ContainsValue(date) )
                {
                    return false;
                }
            }
            dataManager.AddVaccationRequest(id,date,reason);
            return true;
        }

        public List<Dictionary<int, string>> GetVaccationRequests(int id)
        {
            return dataManager.GetVaccationRequests(id);
        }

        public bool CheckExistingShiftForAnEmployee(Shift shift)
        {
          return dataManager.CheckExistingShiftForAnEmployee(shift);
        }

        public List<WorkingPreferenceDays> GetAllWorkPrefrences()
        {
            return dataManager.GetAllWorkPrefrences();
        }

        public List<WorkingPreferenceDays> GetAllVacations()
        {
          return dataManager.GetAllVacations();
        }
    }
}


