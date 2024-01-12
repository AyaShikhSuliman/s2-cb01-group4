using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Enums;

namespace Logic.Classes.Employees
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        [Required]
        public string email { get; set; }
        public Gender gender { get; set; }
        public string phoneNumber { get; set; }
        [Required]
        public string password { get; set; }
        public string adress { get; set; }
        public EmployeeRole position { get; set; }

        //public int GetID() => id;
        //public string GetName() => name;
        //public int GetAge() => age;
        //public string GetEmail() => email;
        //public string GetPhoneNumber() => phoneNumber;
        //public string GetPassword() => password;
        //public string GetAdress() => adress;
        //public EmployeeRole GetPosition() => position;
        //public Gender GetGender() => gender;

        public Employee()
        {

        }
        public Employee(int Id, string Name, int Age, string Email, Gender Gender,
            string PhoneNumber, string Password, string Adress, EmployeeRole Position)
        {
            id = Id;
            name = Name;
            age = Age;
            email = Email;
            gender = Gender;
            phoneNumber = PhoneNumber;
            password = Password;
            adress = Adress;
            position = Position;
        }
        public Employee(string Name, int Age, string Email, Gender Gender,
           string PhoneNumber, string Password, string Adress, EmployeeRole Position)
        {
            name = Name;
            age = Age;
            email = Email;
            gender = Gender;
            phoneNumber = PhoneNumber;
            password = Password;
            adress = Adress;
            position = Position;
        }
        public Employee(int Id, string Name, int Age, string Email, Gender Gender,
          string PhoneNumber, string Password, EmployeeRole Position)
        {
            id = Id;
            name = Name;
            age = Age;
            email = Email;
            gender = Gender;
            phoneNumber = PhoneNumber;
            password = Password;
            position = Position;
            this.adress = String.Empty;
        }

        public void SetPosition(Employee employee)
        {
            if (employee.position != EmployeeRole.Administrator)
            {
                employee.position = employee.position + 1;

            }
        }
        public override string ToString()
        {
            string res = $"Name: {name} ID: {id} Email {email}" + ",";
            return res;
        }
    }
}
