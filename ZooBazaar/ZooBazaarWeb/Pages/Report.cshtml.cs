using Data;
using Logic.Animals.Classes;
using Logic.Animals.Interfaces;
using Logic.Classes.Report;
using Logic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ZooBazaarWeb.Pages
{
    [Authorize]
    public class ReportModel : PageModel
    {
        IAnimalManager animalManager = new AnimalManager(new AnimalDataManager());
        private IReportManager reportManager = new ReportManager(new ReportDataManager());
        public Animal Animal { get; set; }
        [BindProperty]
        public string Description { get; set; }
        public ReportModel()
        {
            this.Animal = new Animal();
            this.Description = String.Empty;
        }
        public void OnGet(int id)
        {
            Animal = animalManager.GetAnimalById(id);
        }
        public void OnPost(int id)
        {
            if (ModelState.IsValid)
            {
                Report report = new Report();
                report.Date = DateTime.Now;
                report.Description = this.Description;
                this.Animal.Id = id;
                reportManager.AddReport(report, this.Animal);
                Response.Redirect("/Schedule");
            }
        }
    }
}
