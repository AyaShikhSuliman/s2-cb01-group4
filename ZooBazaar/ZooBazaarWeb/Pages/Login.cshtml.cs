using Google.Apis.Admin.Directory.directory_v1.Data;
using Logic.Classes.Accounts;
using Logic.Classes.Employees;
using Data;
using Logic.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace ZooBazaarWeb.Pages
{
    public class LoginModel : PageModel
    {
        //AccountsManager accoountManager = new AccountsManager();
        //private EmployeeManager employeeManager = new EmployeeManager(new EmployeeDataManager());
        private ILoginManagerEmployees employeesManager;
        [BindProperty]
        public Employee Employee { get; set; }
        public LoginModel()
        {
            Employee = new Employee();
            employeesManager = new LoginManager(new LoginDataManager());
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (employeesManager.IsEmployee(Employee.email, Employee.password))
            {
                Employee employee = GetEmployee();
                List<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, employee.name));
                claims.Add(new Claim("id", employee.id.ToString()));

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));
                return new RedirectToPageResult("Schedule");
            }
            return Page();
        }
        public Employee GetEmployee()
        {
            List<Employee> employees = employeesManager.employees();
            foreach (Employee employee in employees)
            {
                if (Employee.email == employee.email && Employee.password == employee.password)
                {
                    return employee;
                }
            }
            return null;
        }
    }
}
