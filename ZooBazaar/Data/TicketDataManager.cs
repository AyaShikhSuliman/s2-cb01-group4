using Logic.Animals.Classes;
using Logic.Classes.Ticket;
using Logic.DalInterfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class TicketDataManager : ITicketDataManager
    {
        private string connectionString = "Server=mssqlstud.fhict.local;Database=dbi489597;User Id=dbi489597;Password=Group4Project;";
        public void AddTicket(Ticket ticket)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO Tickets" +
                                     "( adult, children, date, email) VALUES" +
                                     "( @adult, @children, @date,@email )";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@adult", ticket.Adult);
            command.Parameters.AddWithValue("@children", ticket.Children);
            command.Parameters.AddWithValue("@date", ticket.Date);
            command.Parameters.AddWithValue("@email", ticket.Email.ToString());

            command.ExecuteNonQuery();
            connection.Close();
        }

        public List<Ticket> ReadTickets()
        {
            List<Ticket> tickets = new List<Ticket>();
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string query = " select * from Tickets";
            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string dateTimeString = dr.GetString(3);
                DateTime dateTime = DateTime.Parse(dateTimeString);

                Ticket ticket = new Ticket(dr.GetInt32(0), dr.GetInt32(1), dr.GetInt32(2), dateTime, dr.GetString(4));
                tickets.Add(ticket);
            }
            return tickets;
        }
    }
}
