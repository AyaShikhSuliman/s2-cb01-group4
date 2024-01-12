using Logic.Animals.Classes;
using Logic.Animals.Enums;
using Logic.Enums.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.FeedingTime
{
	public class FeedingTime
	{
		public int FeedingTimeId { get; set; }
		public string TimesToBeFeed { get; set; }
		public AnimalFoodType animalFoodType { get; set; }
		public AnimalType animalType { get; set; }
		public int animalAmountOfFood { get; set; }
		public int Time { get; set; }

		//Constructor for getting from database
		public FeedingTime(int feedingTimeId, string timesToBeFeed, AnimalType animalType,
			AnimalFoodType animalFoodType,
			int animalAmountOfFood)
		{
			FeedingTimeId = feedingTimeId;
			TimesToBeFeed = timesToBeFeed;
			this.animalType = animalType;
			this.animalFoodType = animalFoodType;
			this.animalAmountOfFood = animalAmountOfFood;
		}

		//Constructor for adding to database
		public FeedingTime(string timesToBeFeed, AnimalType animalType,
			AnimalFoodType animalFoodType,
			int animalAmountOfFood, int time)
		{
			TimesToBeFeed = timesToBeFeed;
			this.animalFoodType = animalFoodType;
			this.animalType = animalType;
			this.animalAmountOfFood = animalAmountOfFood;
			this.Time = time;
		}
	}
}
