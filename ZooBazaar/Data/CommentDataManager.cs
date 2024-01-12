using Logic.Animals.Classes;
using Logic.Animals.Enums;
using Logic.Classes;
using Logic.DalInterfaces;
using Logic.Enums.Animal;
using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class CommentDataManager : ICommentDataManager
    {
        private string connectionString = "Server=mssqlstud.fhict.local;Database=dbi489597;User Id=dbi489597;Password=Group4Project;";
        public void AddComment(string msg)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO Comments" +
                                     "( message) VALUES" +
                                     "( @message)";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@message", msg);

            command.ExecuteNonQuery();
            connection.Close();
        }

        public List<string> GetComments()
        {
            List<string> messages = new List<string>();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = " select * from Comments";
            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                messages.Add(dr.GetString(1));
            }
            return messages;
        }
    }
}
