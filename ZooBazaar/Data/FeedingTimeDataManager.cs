using Data.Interfaces;
using Logic.Animals.Classes;
using Logic.Animals.Enums;
using Logic.Classes.FeedingTime;
using Logic.Enums;
using Logic.Enums.Animal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class FeedingTimeDataManager : IFeedingTimeDataManager
    {
        private string connectionString = "Server=mssqlstud.fhict.local;Database=dbi489597;User Id=dbi489597;Password=Group4Project;";

        public void AddFeedingTimeToDB(FeedingTime feedingTime)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "insert into feeding_time values (@times_to_be_feed,@type_id,@food_type_id,@food_amount)";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@times_to_be_feed", feedingTime.TimesToBeFeed);
            command.Parameters.AddWithValue("@type_id", feedingTime.animalType);
            command.Parameters.AddWithValue("@food_type_id", feedingTime.animalFoodType);
            command.Parameters.AddWithValue("@food_amount", feedingTime.animalAmountOfFood);

            command.ExecuteNonQuery();
            connection.Close();
        }
        public Dictionary<string, int> AddTimeToDictinary()
        {
            Dictionary<string, int> times = new Dictionary<string, int>();
            List<string> keys = new List<string>();
            List<int> values = new List<int>();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "Select TimeKey, time from TimeInMinutes";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string key = dr.GetString(0);
                int value = dr.GetInt32(1);
                times.Add(key, value);

            }
            return times;
        }


        public void RemoveFeedingTimeFromDB(FeedingTime feedingTime)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "Delete From feeding_time where feeding_time_id ='" + feedingTime.FeedingTimeId + "'";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public int ReturnTotallFood(AnimalType animalType)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            int animalId = Convert.ToInt32(animalType);
            cmd.CommandText = "Select SUM(food_amount_id) From animal where type_id ='" + animalId + "'";

            var obj = cmd.ExecuteScalar();
            int result = obj != null ? (int)obj : 0;
            connection.Close();
            return result;



        }
        public int ReturnAmountOfChosenAnimalType(AnimalType animalType)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            int animalId = Convert.ToInt32(animalType);
            cmd.CommandText = "Select Count(food_amount_id) From animal where type_id ='" + animalId + "'";

            var obj = cmd.ExecuteScalar();
            int result = obj != null ? (int)obj : 0;
            connection.Close();
            return result;

        }

        public List<FeedingTime> SaveFeedingTimesToListFromDB()
        {
            List<FeedingTime> feedingTimes = new List<FeedingTime>();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = " select feeding_time_id,  times_to_be_feed,  type_id, animal_food_type_id,food_amount from feeding_time order by times_to_be_feed asc";
            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                AnimalType typeId = Enum.Parse<AnimalType>(dr.GetInt32(2).ToString());
                AnimalFoodType foodType = Enum.Parse<AnimalFoodType>(dr.GetInt32(3).ToString());
                int animalAmountOfFood = dr.GetInt32(4);

                FeedingTime feedingTime = new FeedingTime(dr.GetInt32(0), dr.GetString(1),
                    typeId, foodType, animalAmountOfFood);

                feedingTimes.Add(feedingTime);
            }

            return feedingTimes;
        }
    }
}
