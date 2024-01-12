using Logic.Animals.Enums;
using Logic.Classes.FeedingTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IFeedingTimeDataManager
    {
        void AddFeedingTimeToDB(FeedingTime feedingTime);
        void RemoveFeedingTimeFromDB(FeedingTime feedingTime);
        int ReturnTotallFood(AnimalType animalType);
        int ReturnAmountOfChosenAnimalType(AnimalType animalType);
        Dictionary<string, int> AddTimeToDictinary();
        List<FeedingTime> SaveFeedingTimesToListFromDB();
    }
}
