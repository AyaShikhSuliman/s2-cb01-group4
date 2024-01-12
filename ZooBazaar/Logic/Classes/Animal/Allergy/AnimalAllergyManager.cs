using Logic.DalInterfaces;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.Animal.Allergy
{
    public class AnimalAllergyManager: IAnimalAllergyManager
    {
        private IAnimalAllergyDataManager AnimalAllergyDataManager;

        public AnimalAllergyManager(IAnimalAllergyDataManager animalAllergyDataManager)
        {
            AnimalAllergyDataManager = animalAllergyDataManager;
        }

        public List<AnimalAllergy> GetAnimalAllergies()
        {
           return AnimalAllergyDataManager.ReadAnimalAllergies();
        }
    }
}
