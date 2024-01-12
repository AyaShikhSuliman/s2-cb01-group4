using Logic.Classes.Animal.Allergy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces
{
    public interface IAnimalAllergyManager
    {
        List<AnimalAllergy> GetAnimalAllergies();
    }
}
