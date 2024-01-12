using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Classes.Employees;
using Logic.Enums;

namespace Logic.Classes.Shift
{
    public class Shift
    {
        private static int idSeeder = 10000;
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public ShiftType AddShiftType { get; set; }
        public List<int> ShiftType { get; set; }
        public List<DateTime> Date { get; set; }
        public DateTime DateTime { get; set; }
        //constructor
        public Shift(Employee employee)
        {
            Employee = employee;
            //ShiftType = shiftType;
            //Date = date;

        }
        public Shift(Employee employee, ShiftType shiftType, DateTime date)
        {
            Employee = employee;
            AddShiftType = shiftType;
            DateTime = date;

        }

        public Shift(int id, Employee employee, ShiftType shiftType, DateTime date)
        {
            Id = id;
            Employee = employee;
            //ShiftType = shiftType;
            //Date = date;

        }
        public Shift()
        {
            ShiftType = new List<int>();
            Date = new List<DateTime>();
        }
        public void AddShift(int shiftType)
        {
            ShiftType.Add(shiftType);
        }
        public void AddDate(DateTime date)
        {
            Date.Add(date);
        }
        //add shift
        //public void AddShift(Employee employee, Logic.ShiftType shiftType, DateTime date) {
        //    Shift shift = new Shift(employee, shiftType, date);
        //    shifts.Add(shift);
        //}
        //edit shift
        //public void EditShift(List<Shift> shifts, List<Employee> employees, Logic.ShiftType shiftType)
        //{

        //    foreach (Employee e in employees)
        //    {
        //        if () { }
        //    }
        //}



        //public void DeleteShift(int id)
        //{
        //    Shift shift = shifts.Find(x => x.Id == id);
        //    shifts.Re(shift);
        //}


        //public string ShiftInfo()
        //{


        //    return $"{ShiftType} on {Date.Day}/{Date.Month}/{Date.Year} is assigned to: {Employee}! ";
        //}

        //public override string ToString()
        //{
        //    return $"{ShiftType} on {Date.Day}/{Date.Month}/{Date.Year}";
        //}

        //public string EmployeesOnShift(DateTime date) {
        //    string employeesOnShift = "";

        //    }

        //    return employeesOnShift;
        //}



    }
}
