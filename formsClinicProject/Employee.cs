using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formsClinicProject
{
    class Employee
    {
        private string firstName, lastName, phoneNumber, mobile, email, specialty, role;
        private DateTime dateOfBirth;

        public Employee(string firstName, string lastName, string phoneNumber, string mobile, string email, string specialty, string role, DateTime dateOfBirth)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.mobile = mobile;
            this.email = email;
            this.specialty = specialty;
            this.role = role;
            this.dateOfBirth = dateOfBirth;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Mobile { get => mobile; set => mobile = value; }
        public string Email { get => email; set => email = value; }
        public string Specialty { get => specialty; set => specialty = value; }
        public string Role { get => role; set => role = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
    }
}
