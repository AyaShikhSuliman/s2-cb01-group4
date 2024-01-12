using Logic.Animals.Classes;
using Logic.Classes.Employees;
using Logic.Classes.Report;
using Logic.DalInterfaces;
using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ReportDataManager: IReportDataManager
    {
        private string connectionString = "Server=mssqlstud.fhict.local;Database=dbi489597;User Id=dbi489597;Password=Group4Project;";

        public void CreateReport(Report report, Animal animal)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "insert into report values (@animal_id, @date, @description)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@animal_id", animal.Id);
            command.Parameters.AddWithValue("@date", report.Date);
            command.Parameters.AddWithValue("@description", report.Description);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteReport(Report report)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string query = "Delete From report where id=@report.id";

            SqlCommand sqlCommand = new SqlCommand(query, connection);

            sqlCommand.Parameters.AddWithValue("@report.id", report.Id);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        public List<Report> ReadReports()
        {
            List<Report> reports = new List<Report>();

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string query = " select * from report";

            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Report report = new Report(dr.GetInt32(0), dr.GetInt32(1), dr.GetDateTime(2), dr.GetString(3));
                reports.Add(report);
            }

            connection.Close();

            return reports;
        }

        public void UpdateReport(Report report)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string query = "Update report SET date=@date,description=@description where id=@report.Id";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@report.id", report.Id);
            command.Parameters.AddWithValue("@date", report.Date);
            command.Parameters.AddWithValue("@description", report.Description);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}

