using Logic.Classes.Employees;
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
    public class LoginDataManager : ILoginDataManager
    {
        private string connectionString = "Server=mssqlstud.fhict.local;Database=dbi489597;User Id=dbi489597;Password=Group4Project;";
        public List<Employee> SaveEmployeesToListFromDB()
        {
            List<Employee> employees = new List<Employee>();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = " select * from employee";
            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                Gender gender = Enum.Parse<Gender>(dr.GetInt32(4).ToString());
                EmployeeRole Role = Enum.Parse<EmployeeRole>(dr.GetInt32(7).ToString());
                Employee employee = new Employee(dr.GetInt32(0), dr.GetString(1), dr.GetInt32(2), dr.GetString(3), gender, dr.GetString(5), dr.GetString(6), Role);
                employees.Add(employee);
            }
            return employees;
        }
    }
}
