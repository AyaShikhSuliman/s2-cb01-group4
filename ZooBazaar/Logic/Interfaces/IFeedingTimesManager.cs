using Logic.Animals.Classes;
using Logic.Animals.Enums;
using Logic.Classes.FeedingTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces
{
    public interface IFeedingTimesManager
    {
        void AddFeedingTime(FeedingTime feedingTime);
        void RemoveFeedingTime(FeedingTime feedingTime);
        int ReturnTotallFood(AnimalType animalType);
        int ReturnAmountOfChosenAnimalType(AnimalType animalType);
        int ReturnNeededTime(string animalType, AnimalType animalType1);
        Dictionary<string, int> AddTimeToDictinary();
        List<FeedingTime> ShowAllFeedingTimes();
    }
}
