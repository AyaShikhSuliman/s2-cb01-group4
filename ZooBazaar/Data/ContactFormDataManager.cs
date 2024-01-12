using Logic.Animals.Classes;
using Logic.Animals.Enums;
using Logic.Classes.ContactForm;
using Logic.DalInterfaces;
using Logic.Enums.Animal;
using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Data
{
    public class ContactFormDataManager : IContactFormDataManager
    {
        private string connectionString = "Server=mssqlstud.fhict.local;Database=dbi489597;User Id=dbi489597;Password=Group4Project;";

        public void CreateContactForm(ContactForm contactForm)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "insert into contact_form values (@name, @phone_number, @email_address, @message, @answer)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@name", contactForm.Name);
            command.Parameters.AddWithValue("@phone_number", contactForm.PhoneNumber);
            command.Parameters.AddWithValue("@email_address", contactForm.EmailAddress);
            command.Parameters.AddWithValue("@message", contactForm.Message);
            command.Parameters.AddWithValue("@answer", DBNull.Value);


            command.ExecuteNonQuery();
            connection.Close();
        }

        public List<ContactForm> ReadContacts()
        {
            List<ContactForm> contactForms = new List<ContactForm>();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "select * from contact_form";

            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                object obj = dr["answer"];
                string myString;

                if (obj == DBNull.Value)
                {
                    myString = "";
                }
                else
                {
                    myString = (string)obj;
                }
                ContactForm contactForm = new ContactForm(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), myString);

                contactForms.Add(contactForm);
            }

            return contactForms;
        }

        public void UpdateContactForm(ContactForm contactForm)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "Update contact_form SET name=@name, phone_number=@phone_number, email_address=@email_address, message=@message, answer=@answer where id='" + contactForm.Id + "'";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@name", contactForm.Name);
            command.Parameters.AddWithValue("@phone_number", contactForm.PhoneNumber);
            command.Parameters.AddWithValue("@email_address", contactForm.EmailAddress);
            command.Parameters.AddWithValue("@message", contactForm.Message);
            command.Parameters.AddWithValue("@answer", contactForm.Answer);

            command.ExecuteNonQuery();
            connection.Close();
        }

        public ContactForm GetContactForm(int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = " select * from contact_form where id=@id";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                object obj = dr["answer"];
                string myString;

                if (obj == DBNull.Value)
                {
                    myString = "";
                }
                else
                {
                    myString = (string)obj;
                }

                ContactForm contactForm = new ContactForm(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), myString);

                return contactForm;
            }

            return new();
        }
    }
}
