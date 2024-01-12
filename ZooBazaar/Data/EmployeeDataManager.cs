using Data.Interfaces;
using Logic.Classes.Employees;
using Logic.Enums;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class EmployeeDataManager : IEmployeeDataManager
    {
        private string connectionString = "Server=mssqlstud.fhict.local;Database=dbi489597;User Id=dbi489597;Password=Group4Project;";
        public void AddEmployeeToDB(Employee employee)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "insert into employee values (@name,@age,@email,@gender_id,@phone_number,@password,@role_id)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", employee.name);
            command.Parameters.AddWithValue("@age", employee.age);
            command.Parameters.AddWithValue("@email", employee.email);
            command.Parameters.AddWithValue("@gender_id", employee.gender);
            command.Parameters.AddWithValue("@phone_number", employee.phoneNumber);
            command.Parameters.AddWithValue("@password", employee.password);
            command.Parameters.AddWithValue("@role_id", employee.position);

            command.ExecuteNonQuery();
            connection.Close();
        }

        public void RemoveEmployeeFromDB(Employee employee)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "Delete From employee where employee_id ='" + employee.id + "'";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

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

        public void UpdateEmployee(Employee employee)
        {
            foreach (Employee employee1 in SaveEmployeesToListFromDB())
            {
                if (employee1.id == employee.id)
                {
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    string query = "Update employee SET name=@name,age=@age,email=@email,gender_id=@gender_id,phone_number=@phone_number,password=@password,role_id=@role_id where employee_id='" + employee.id + "'";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", employee.name);
                    command.Parameters.AddWithValue("@age", employee.age);
                    command.Parameters.AddWithValue("@email", employee.email);
                    command.Parameters.AddWithValue("@gender_id", employee.gender);
                    command.Parameters.AddWithValue("@phone_number", employee.phoneNumber);
                    command.Parameters.AddWithValue("@password", employee.password);
                    command.Parameters.AddWithValue("@role_id", employee.position);

                    command.ExecuteNonQuery();
                    connection.Close();

                }
            }
        }
    }
}
