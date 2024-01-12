using Data.Interfaces;
using Logic.Animals.Classes;
using Logic.Animals.Enums;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.FeedingTime
{
    public class FeedingTimesManager: IFeedingTimesManager
    {
        private IFeedingTimeDataManager feedingTimeDataManager;
        public FeedingTimesManager(IFeedingTimeDataManager feedingTimeDataManager)
        {
            this.feedingTimeDataManager = feedingTimeDataManager;
        }

        public void AddFeedingTime(FeedingTime feedingTime)
        {
            feedingTimeDataManager.AddFeedingTimeToDB(feedingTime);
        }

        public void RemoveFeedingTime(FeedingTime feedingTime)
        {
            feedingTimeDataManager.RemoveFeedingTimeFromDB(feedingTime);
        }

        public List<FeedingTime> ShowAllFeedingTimes()
        {
            return feedingTimeDataManager.SaveFeedingTimesToListFromDB();
        }
        public int ReturnTotallFood(AnimalType animalType)
        {
          return   feedingTimeDataManager.ReturnTotallFood(animalType);

        }

        public int ReturnAmountOfChosenAnimalType(AnimalType animalType)
        {
            return feedingTimeDataManager.ReturnAmountOfChosenAnimalType(animalType);
        }

        public Dictionary<string, int> AddTimeToDictinary()
        {
            return feedingTimeDataManager.AddTimeToDictinary();
        }

        public int ReturnNeededTime(string animalType,AnimalType animalType1)
        {
            int NeededTime = 0;
            foreach (KeyValuePair<string, int> keyValuePair in AddTimeToDictinary())
            {
                if(keyValuePair.Key == animalType)
                {
                    NeededTime = keyValuePair.Value * ReturnAmountOfChosenAnimalType(animalType1);
                    return NeededTime;
                }
            }
            return NeededTime;
        }
        

        
    }
}
