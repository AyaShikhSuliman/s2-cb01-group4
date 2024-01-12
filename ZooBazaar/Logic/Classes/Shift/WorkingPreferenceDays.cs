using Logic.Classes.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Logic.Classes.Shift
{
    public class WorkingPreferenceDays
    {
        public int GetId { get; set; }
        public string Date { get; set; }
        public int EmployeeId { get; set; }
        public int VacationType { get; set; }
        public WorkingPreferenceDays(int getId, string date, int employeeId)
        {
            GetId = getId;
            Date = date;
            EmployeeId = employeeId;
        }
        public WorkingPreferenceDays(int getId, string date, int employeeId,int vacation)
        {
            GetId = getId;
            Date = date;
            EmployeeId = employeeId;
            VacationType = vacation;
        }

        public override string ToString()
        {
            string res = $" Employee Id: {EmployeeId} Date: {Date}" + ",";
            return res;
        }


    }
}
