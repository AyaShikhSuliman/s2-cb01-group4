using Logic.Animals.Classes;
using Logic.Animals.Interfaces;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ZooBazaarWeb.Pages
{
    public class Our_AnimalsModel : PageModel
    {
        public Animal Animal { get; set; }
        public List<Animal> AllAnimals { get; set; }
        IAnimalManager animalManager;
        public Our_AnimalsModel()
        {
            Animal = new Animal();
            animalManager = new AnimalManager(new AnimalDataManager());
        }
        public void OnGet()
        {
            AllAnimals = animalManager.ShowAllAnimals();
        }
    }
}
