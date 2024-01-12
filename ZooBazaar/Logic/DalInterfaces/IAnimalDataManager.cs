using Logic.Animals.Classes;
using Logic.Classes.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IAnimalDataManager
    {
        void AddAnimalToDB(Animal animal);
        void RemoveAnimalFromDB(Animal animal);
        List<Animal> SaveAnimalsToListFromDB();
        void UpdateAnimal(Animal animal);
        Animal GetAnimalById(int id);
    }
}
