using Logic.Animals.Classes;
using Logic.Animals.Enums;
using Logic.Classes.Employees;
using Logic.Classes.Shift;
using Logic.Enums.Animal;
using Logic.Enums;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.data;

namespace Data.data
{
    public class ShiftDataManager: IShiftDataManager
    {
        private string connectionString = "Server=mssqlstud.fhict.local;Database=dbi489597;User Id=dbi489597;Password=Group4Project;";

        public void AddShift(Shift shift)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "insert into shift values (@employee_id,@shift_type_id,@shift_date)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@employee_id",shift.Employee.id);
            command.Parameters.AddWithValue("@shift_type_id",shift.AddShiftType);
            command.Parameters.AddWithValue("@shift_date",shift.DateTime);

            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteAllShifts(List<Shift> shifts)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "Delete From animal";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
                connection.Close();
            }

        }
        public List<Employee> GetAllEmployeeInfoNoDuplicateInShiftTable()
        {
            List<Employee> employees = new List<Employee>();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = " select distinct employee_id from shift";
            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int id = dr.GetInt32(0);
                Employee emp = EmployeeById(id);
                employees.Add(emp);

            }
            return employees;
        }
        public List<Employee> GetAvailableEmployeesByDate(DateTime date)
        {
            List<Employee> employees = new List<Employee>();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = " select distinct employee_id from shift where shift_date=@date";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@date", date);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int id = dr.GetInt32(0);
                Employee emp = EmployeeById(id);
                employees.Add(emp);

            }
            return employees;
        }
        public Shift GetShiftsByEmployeeId(int id)
        {
            Shift shift = new Shift();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = " select * from shift where employee_id=@Id;";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int shiftType = dr.GetInt32(2);
                shift.AddShift(shiftType);
                DateTime dateTime = dr.GetDateTime(3);
                shift.AddDate(dateTime);
            }
            return shift;
        }

        public Employee EmployeeById(int id)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = " select * from employee where employee_id=@id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Gender genderId = Enum.Parse<Gender>(dr.GetInt32(4).ToString());
                EmployeeRole employeeRole = Enum.Parse<EmployeeRole>(dr.GetInt32(7).ToString());
  


                Employee employee = new Employee(dr.GetInt32(0),dr.GetString(1),dr.GetInt32(2),dr.GetString(3),genderId,dr.GetString(5),dr.GetString(6), employeeRole);


                return employee;
            }
            return new();
        }

        public List<Shift> GetAllShifts()
        {
            List<Shift> shifts = new List<Shift>();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = " select * from shift";
            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Employee emp = EmployeeById(dr.GetInt32(1));
                ShiftType shiftType = Enum.Parse<ShiftType>(dr.GetInt32(2).ToString());
                DateTime date= dr.GetDateTime(3);
                Shift shift = new Shift(dr.GetInt32(0),emp, shiftType, date);
                shifts.Add(shift);

                
            }
            return shifts;
        }

        public void updateShift(Shift shift)
        {
            throw new NotImplementedException();
        }
        public void AddWorkPrefrences(int id, string date)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "insert into Work_prefrences values (@employee_id,@date)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@employee_id", id);
            cmd.Parameters.AddWithValue("@date", date);

            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public List<string> GetWorkPrefrences(int id)
        {
            List<string> workPrefrences = new List<string>();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = " select date from Work_prefrences where employee_id=@employeeId";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@employeeId",id);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                workPrefrences.Add(dr.GetString(0));
            }
            return workPrefrences;
        }
        public List<WorkingPreferenceDays> GetAllWorkPrefrences()
        {
            List<WorkingPreferenceDays> workPrefrences = new List<WorkingPreferenceDays>();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = " select * from Work_prefrences";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                WorkingPreferenceDays day = new WorkingPreferenceDays(dr.GetInt32(0), dr.GetString(2), dr.GetInt32(1));
                workPrefrences.Add(day);
            }
            return workPrefrences;
        }
        public List<WorkingPreferenceDays> GetAllVacations()
        {
            List<WorkingPreferenceDays> workPrefrences = new List<WorkingPreferenceDays>();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = " select * from Vaccation_requests";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                WorkingPreferenceDays day = new WorkingPreferenceDays(dr.GetInt32(0), dr.GetString(2), dr.GetInt32(1),dr.GetInt32(3));
                workPrefrences.Add(day);
            }
            return workPrefrences;
        }

        public void AddVaccationRequest(int id, string date, int reason)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "insert into Vaccation_requests values (@employee_id,@date,@vaccation_type)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@employee_id", id);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@vaccation_type", reason);

            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public List<Dictionary<int, string>> GetVaccationRequests(int id)
        {
            List<Dictionary<int, string>> requests = new List<Dictionary<int, string>>();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = " select * from Vaccation_requests where employee_id=@employeeId";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@employeeId", id);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Dictionary<int, string> vaccationRequest = new Dictionary<int, string>();
                vaccationRequest.Add(dr.GetInt32(3), dr.GetString(2));
                requests.Add(vaccationRequest);
            }
            return requests;
        }
        public bool CheckExistingShiftForAnEmployee(Shift shift)
        {
            int id = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = " select employee_id from shift where employee_id=@empId And shift_type_id=@shiftId";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@empId", shift.Employee.id);
            cmd.Parameters.AddWithValue("@shiftId", shift.AddShiftType);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
             id= dr.GetInt32(0);
                if (id == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
