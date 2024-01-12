using Logic.Classes.Employees;
using Logic.Classes.Shift;
using Logic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Data.data;

namespace ZooBazaarWeb.Pages
{
    [Authorize]
    public class AccountModel : PageModel
    {
        private EmployeeManager employeeManager = new EmployeeManager(new EmployeeDataManager());
        private readonly IShiftManager shiftManager = new ShiftManager(new ShiftDataManager());

        [BindProperty]
        public DateTime DateReserved { get; set; }
        [BindProperty]
        public DateTime DateReservedVaccation { get; set; }
        [BindProperty]
        public int VaccationReason { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPostPrefrences()
        {
            if (shiftManager.AddWorkPrefrences(GetEmployee().id, DateReserved.ToString()))
            {
                TempData["Success"] = "Success";
                return new RedirectToPageResult("/Account");
            }
            else
            {
                TempData["Alert"] = "Alert";
                return new RedirectToPageResult("/Account");
            }
        }
        public IActionResult OnPostDayoff()
        {
            if (shiftManager.AddVaccationRequest(GetEmployee().id, DateReservedVaccation.ToString(),VaccationReason))
            {
                TempData["Success"] = "Success";
                return new RedirectToPageResult("/Account");
            }
            else
            {
                TempData["Alert"] = "Alert";
                return new RedirectToPageResult("/Account");
            }
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
