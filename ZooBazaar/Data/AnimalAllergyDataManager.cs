using Logic.Animals.Classes;
using Logic.Animals.Enums;
using Logic.Classes.Animal.Allergy;
using Logic.Enums.Animal;
using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.DalInterfaces;

namespace Data
{
    public class AnimalAllergyDataManager : IAnimalAllergyDataManager
    {
        private string connectionString = "Server=mssqlstud.fhict.local;Database=dbi489597;User Id=dbi489597;Password=Group4Project;";

        public AnimalAllergy ReadAnimalAllergyId(int? id)
        {
            if (id == null)
            {
                id = -1;
            }

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            string query = " select id, name from animal_allergies where id=@id";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@id", id);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                AnimalAllergy animalAllergy = new AnimalAllergy(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1));

                return animalAllergy;
            }

            sqlConnection.Close();

            return null;
        }

        public List<AnimalAllergy> ReadAnimalAllergies()
        {
            List<AnimalAllergy> animalAllergies = new List<AnimalAllergy>();

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string query = " select * from animal_allergies";
            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                AnimalAllergy animalAllergy = new AnimalAllergy(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1));

                animalAllergies.Add(animalAllergy);
            }
            return animalAllergies;
        }
    }
}
