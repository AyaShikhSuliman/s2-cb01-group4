using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic.Enums;
using Logic.Classes.Shift;
using Data;
using Logic.Classes.Employees;
using Data.data;

namespace DesktopApplication.Scheduler.Employees
{
    public partial class Create_Employee_Schedule : Form
    {
        List<Employee> employees = new List<Employee>();
        ShiftManager sm = new ShiftManager(new ShiftDataManager());
        EmployeeManager em = new EmployeeManager(new EmployeeDataManager());
        int selection = -2;
      
        public Create_Employee_Schedule()
        {
            InitializeComponent();
            Employee employee1 = new Employee(1, "One one", 11, "One@One.one", Gender.Male, "0987654321", "password", "address", EmployeeRole.Care_Taker);
            Employee employee2 = new Employee(1, "Two two", 11, "One@One.one", Gender.Male, "0987654321", "password", "address", EmployeeRole.Care_Taker);
            Employee employee3 = new Employee(1, "Three three", 11, "One@One.one", Gender.Male, "0987654321", "password", "address", EmployeeRole.Care_Taker);
            Employee employee4 = new Employee(1, "Three three", 11, "One@One.one", Gender.Male, "0987654321", "password", "address", EmployeeRole.Care_Taker);
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            UpdateShiftListbox();
        }

        private void CreateShift()
        {
            if (string.IsNullOrEmpty(cbShiftType.Text))
            {
                MessageBox.Show($"Please sellect shift type");
            }
            else
            {
                List<Employee> employeesOnShift = new List<Employee>();
                List<int> index = new List<int>();
                if (lbEmployeesForShift.SelectedItems.Count >= 0)
                {
                    for (int i = 0; i < lbEmployeesForShift.SelectedItems.Count; i++)
                    {
                        index.Add(lbEmployeesForShift.SelectedIndices[i]);
                    }
                }

                foreach (int i in index)
                {
                    // employeesOnShift.Add();

                    DateTime date = dateTimePickerShifts.Value;
                    string typeString = $"{date.DayOfWeek}_{cbShiftType.Text}";
                    ShiftType shiftType = (ShiftType)Enum.Parse(typeof(ShiftType), typeString);
                    Shift shift = new Shift(employees[i], shiftType, date);
                    //  sdb.AddShift(edb.GetEmployeesbyID(i), shiftType, date);
                    //sm._shifts.Add(shift);

                }


            }
        }

        private void EditShift()
        {
            string shiftCheck = lbShifts.SelectedItem.ToString();
            List<Shift> shiftsForEdit = new List<Shift>();
            DateTime time = dateTimePickerShifts.Value;
            string typeString = $"{time.DayOfWeek}_{cbShiftType.Text}";
            ShiftType shiftType = (ShiftType)Enum.Parse(typeof(ShiftType), typeString);

            //foreach (Shift s in sm._shifts)
            //{

            //    if (shiftCheck.Contains($"{s.ShiftType} on {s.Date.Day}/{s.Date.Month}/{s.Date.Year}"))
            //    {
            //        shiftsForEdit.Add(s);
            //    }
            //}
            //puts all shifts for the edit and passes it to the method
            List<Employee> emp = new List<Employee>();
            List<int> index = new List<int>();
            if (lbEmployeesForShift.SelectedItems.Count >= 0)
            {
                for (int i = 0; i < lbEmployeesForShift.SelectedItems.Count; i++)
                {
                    index.Add(lbEmployeesForShift.SelectedIndices[i]);
                }
            }

            foreach (int i in index)
            {
                emp.Add(employees[i]);
            }
            //puts all employees needed for the edited shifts and passes it to the method
            //sm.EditShift(shiftsForEdit, emp, shiftType, time);
        }

        private void UpdateShiftListbox()
        {
            lbShifts.Items.Clear();
            lbEmployeesForShift.Items.Clear();
            //List<Shift> Temp = sm._shifts;
            //foreach (Shift s1 in Temp)
            //{
            //    string employeesOnShift = "";
            //    int i = 0;
            //    foreach (Shift s2 in Temp)
            //    {
            //        if (s1.Date.Year == s2.Date.Year && s1.Date.DayOfYear == s2.Date.DayOfYear && s1.ShiftType == s2.ShiftType)
            //        {

            //            employeesOnShift += $"{s2.ToString()}({s2.Employee.id}), ";
            //            i++;
            //        }
            //    }


            //    if (!lbShifts.Items.Contains($"{s1.ShiftType} on {s1.Date.Day}/{s1.Date.Month}/{s1.Date.Year} is assigned to: {employeesOnShift}"))
            //    {
            //        lbShifts.Items.Add($"{s1.ShiftType} on {s1.Date.Day}/{s1.Date.Month}/{s1.Date.Year} is assigned to: {employeesOnShift}");
            //    }

            //}

            foreach (Employee e in employees)
            {
                lbEmployeesForShift.Items.Add($" {e.name}, {e.id}");
            }
        }

       

        private void btnCreateShift_Click(object sender, EventArgs e)
        {
            if (lbEmployeesForShift.SelectedItems.Count >= 1)
            {
                CreateShift();
                UpdateShiftListbox();
            }
            else
            {
                MessageBox.Show("Please select employees!");
            }

        }

        private void btnEditShift_Click(object sender, EventArgs e)
        {
            EditShift();
            UpdateShiftListbox();
        }

        private void btnDeleteShift_Click(object sender, EventArgs e)
        {
            List<Shift> shiftsToBeDeleted = new List<Shift>();
            //List<Shift> shifts = sm._shifts;
    
            selection = lbShifts.SelectedIndex;
            lbEmployeesForShift.SelectedIndex = -1;
            string shiftCheck = lbShifts.SelectedItem.ToString();

            //foreach (Shift s in shifts)
            //{
            //    if (shiftCheck.Contains(s.ToString()))

            //    {
            //    //    sm.DeleteShift(s.Id);

            //    }//
            //}
            //  }
            UpdateShiftListbox();
        }

        private void Create_Employee_Schedule_Load(object sender, EventArgs e)
        {
            cbShiftType.Items.Add("Morning");
            cbShiftType.Items.Add("Afternoon");
            cbShiftType.Items.Add("Evening");
        }

        private void Create_Employee_Schedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm loginForm = new LoginForm(new AccountTypes());
            loginForm.Show();
            this.Hide();
        }

        private void lbEmployeesForShift_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
