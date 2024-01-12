using Logic.Animals.Classes;
using Logic.Animals.Enums;
using Logic.Classes.Accounts;
using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Animals.Interfaces
{
    public interface IAnimalManager
    {
        void EditAnimal(Animal animal);
        void RemoveAnimal(Animal animal);
        void AddAnimal(Animal animal);
        Animal GetAnimalById(int id);
        List<Animal> ShowAllAnimals();
    }
}
