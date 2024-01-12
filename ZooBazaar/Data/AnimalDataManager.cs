using Data.Interfaces;
using Logic.Animals.Classes;
using Logic.Animals.Enums;
using Logic.Classes.Accounts;
using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Enums.Animal;
using Logic.Classes.Animal.Allergy;
using System.Runtime.CompilerServices;
using System.Reflection.PortableExecutable;
using System.Data;
using System.Data.SqlTypes;

namespace Data
{
    public class AnimalDataManager : IAnimalDataManager
    {
        private string connectionString = "Server=mssqlstud.fhict.local;Database=dbi489597;User Id=dbi489597;Password=Group4Project;";
        private AnimalAllergyDataManager AnimalAllergyDataManager = new AnimalAllergyDataManager();

        public void AddAnimalToDB(Animal animal)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "insert into animal values (@name, @gender_id, @weight,@type_id,@animal_allergy_id,@sickness,@animal_location_id, @animal_food_type_id,@food_amount_id)";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@name", animal.Name);
            command.Parameters.AddWithValue("@gender_id", animal.Gender);
            command.Parameters.AddWithValue("@weight", animal.Weight);
            command.Parameters.AddWithValue("@type_id", animal.AnimalType);
            command.Parameters.AddWithValue("@animal_allergy_id", animal.animalAllergy.Id);
            command.Parameters.AddWithValue("@sickness", animal.Sicknesses);
            command.Parameters.AddWithValue("@animal_location_id", animal.animalLocation);
            command.Parameters.AddWithValue("@animal_food_type_id", animal.AnimalFoodType);
            command.Parameters.AddWithValue("@food_amount_id", animal.AnimalAmountOfFood);

            command.ExecuteNonQuery();
            connection.Close();
        }

        public void RemoveAnimalFromDB(Animal animal)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "Delete From animal where animal_id ='" + animal.Id + "'";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public List<Animal> SaveAnimalsToListFromDB()
        {
            List<Animal> animals = new List<Animal>();
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string query = " select * from animal";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Gender genderId = Enum.Parse<Gender>(dr.GetInt32(2).ToString());
                AnimalType typeId = Enum.Parse<AnimalType>(dr.GetInt32(4).ToString());
                AnimalLocation locationId = Enum.Parse<AnimalLocation>(dr.GetInt32(7).ToString());
                AnimalFoodType foodType = Enum.Parse<AnimalFoodType>(dr.GetInt32(8).ToString());
                AnimalAmountOfFood animalAmountOfFood = Enum.Parse<AnimalAmountOfFood>(dr.GetInt32(9).ToString());

                object obj = dr["name"];
                string name;

                if (obj == DBNull.Value)
                {
                    name = "";
                }
                else
                {
                    name = (string)obj;
                }

                object obj2 = dr["sickness"];
                string sickness;

                if (obj == DBNull.Value)
                {
                    sickness = "";
                }
                else
                {
                    sickness = (string)obj2;
                }

                int? someValue = dr.IsDBNull(5) ? null : dr.GetInt32(5);

                Animal animal = new Animal(dr.GetInt32(0), name, genderId, dr.GetInt32(3), typeId,
                   AnimalAllergyDataManager.ReadAnimalAllergyId(someValue), sickness, locationId, foodType,
                    animalAmountOfFood);

                animals.Add(animal);
            }

            return animals;
        }


        public void UpdateAnimal(Animal animal)
        {
            foreach (Animal animal1 in SaveAnimalsToListFromDB())
            {
                if (animal1.Id == animal.Id)
                {
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    string query = "Update animal SET name=@name," +
                        "gender_id=@gender_id, weight=@weight," +
                        "type_id=@type_id,animal_location_id=@animal_location_id," +
                        "animal_allergy_id=@animal_allergy_id, sickness=@sickness where animal_id='" + animal.Id + "'";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", animal.Name);
                    command.Parameters.AddWithValue("@gender_id", animal.Gender);
                    command.Parameters.AddWithValue("@weight", animal.Weight);
                    command.Parameters.AddWithValue("@type_id", animal.AnimalType);
                    command.Parameters.AddWithValue("@animal_location_id", animal.animalLocation);
                    command.Parameters.AddWithValue("@animal_allergy_id", animal.animalAllergy);
                    command.Parameters.AddWithValue("@sickness", animal.Sicknesses);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public Animal GetAnimalById(int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = " select * from animal where animal_id=@id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Gender genderId = Enum.Parse<Gender>(dr.GetInt32(2).ToString());
                AnimalType typeId = Enum.Parse<AnimalType>(dr.GetInt32(4).ToString());
                AnimalLocation locationId = Enum.Parse<AnimalLocation>(dr.GetInt32(7).ToString());
                AnimalFoodType foodType = Enum.Parse<AnimalFoodType>(dr.GetInt32(8).ToString());
                AnimalAmountOfFood animalAmountOfFood = Enum.Parse<AnimalAmountOfFood>(dr.GetInt32(9).ToString());

                int? someValue = dr.IsDBNull(5) ? null : dr.GetInt32(5);

                Animal animal = new Animal(dr.GetInt32(0), dr.GetString(1),
                   genderId, dr.GetInt32(3), typeId, AnimalAllergyDataManager.ReadAnimalAllergyId(someValue), dr.GetString(6),
                   locationId, foodType, animalAmountOfFood);


                return animal;
            }
            return new();
        }
    }
}
