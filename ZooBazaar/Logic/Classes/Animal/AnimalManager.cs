using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Interfaces;
using Logic.Animals.Enums;
using Logic.Animals.Interfaces;
using Logic.Classes.Accounts;
using Logic.Enums;
using Logic.Interfaces;

namespace Logic.Animals.Classes
{
    public class AnimalManager : IAnimalManager
    {
        IAnimalDataManager animalDataManager;

        public AnimalManager(IAnimalDataManager animalDataManager)
        {
            this.animalDataManager = animalDataManager;
        }

        public void AddAnimal(Animal animal)
        {
            animalDataManager.AddAnimalToDB(animal);
        }

        public void EditAnimal(Animal animal)
        {
            animalDataManager.UpdateAnimal(animal);
        }

        public Animal GetAnimalById(int id)
        {
            Animal animal = animalDataManager.GetAnimalById(id);    
            if (animal.Id !=0)
            {
                return animal;
            }
            return new();           
        }

        public void RemoveAnimal(Animal animal)
        {
            animalDataManager.RemoveAnimalFromDB(animal);
        }

        public List<Animal> ShowAllAnimals()
        {
            return animalDataManager.SaveAnimalsToListFromDB();
        }
    }
}
