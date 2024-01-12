using Logic.Animals.Enums;
using Logic.Classes;
using Logic.Classes.FeedingTime;
using Logic.Enums;
using System.Reflection;
using System.Xml.Linq;
using Logic.Enums.Animal;
using Logic.Classes.Animal.Allergy;
using Logic.Classes.Report;

namespace Logic.Animals.Classes
{
    public class Animal
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Gender Gender { get; set; }
        public int Weight { get; set; }
        public AnimalType AnimalType { get; set; }
        public AnimalFoodType AnimalFoodType { get; set; }
        public AnimalAmountOfFood AnimalAmountOfFood { get; set; }
        public AnimalLocation animalLocation { get; set; }
        public AnimalAllergy? animalAllergy { get; set; }
        public string? Sicknesses { get; set; }

        public Animal()
        {
            Name = String.Empty;
            Sicknesses = String.Empty;
        }

        public Animal(int id, string? name, Gender gender, int weight, AnimalType animalType, AnimalAllergy? allergies,
            string? sicknesses, AnimalLocation animalLocation, AnimalFoodType animalFoodType,
            AnimalAmountOfFood animalAmountOfFood)
        {
            Id = id;
            Name = name;
            this.Gender = gender;
            Weight = weight;
            this.AnimalType = animalType;
            this.animalLocation = animalLocation;
            this.animalAllergy = allergies;
            Sicknesses = sicknesses;
            AnimalFoodType = animalFoodType;
            AnimalAmountOfFood = animalAmountOfFood;
        }

        public Animal(string? name, Gender gender, int weight, AnimalType animalType, AnimalAllergy? allergies,
            string? sicknesses, AnimalLocation animalLocation, AnimalFoodType animalFoodType,
            AnimalAmountOfFood animalAmountOfFood)
        {

            Name = name;
            this.Gender = gender;
            Weight = weight;
            this.AnimalType = animalType;
            this.animalLocation = animalLocation;
            this.animalAllergy = allergies;
            Sicknesses = sicknesses;
            AnimalFoodType = animalFoodType;
            AnimalAmountOfFood = animalAmountOfFood;
        }

        public override string ToString()
        {
            if (Name == "")
            {
                return $"{Id}";
            }
            else
            {
                return Name;
            }
        }
    }
}