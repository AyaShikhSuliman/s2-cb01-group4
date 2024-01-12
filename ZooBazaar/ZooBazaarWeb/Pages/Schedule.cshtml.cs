using Data;
using Data.data;
using Logic.Classes.Employees;
using Logic.Classes.Shift;
using Logic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ZooBazaarWeb.Pages
{
    [Authorize]
    public class ScheduleModel : PageModel
    {
        public IShiftManager shiftManager = new ShiftManager(new ShiftDataManager());
        private IEmployeeManager employeeManager = new EmployeeManager(new EmployeeDataManager());
        public Shift shift { get; set; }
        public void OnGet()
        {
            shift = shiftManager.GetShiftsByEmployeeId(GetEmployee().id);
        }
        public Employee GetEmployee()
        {
            List<Employee> employees = employeeManager.ShowAll();
            foreach (Employee employee in employees)
            {
                if (employee.id == Convert.ToInt32(@User.FindFirst("id").Value))
                {
                    return employee;
                }
            }
            return null;
        }
    }
}
