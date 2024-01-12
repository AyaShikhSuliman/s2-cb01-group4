using DesktopApplication.Adminstration.Animals;
using DesktopApplication.Adminstration.Clients.Tickets;
using DesktopApplication.Adminstration.Employees;
using DesktopApplication.CommonForms.Animals;
using Logic.Enums;
using System.Drawing.Text;

namespace DesktopApplication
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            Application.Run(new LoginForm(new AccountTypes()));
        }
    }
}