using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace formsClinicProject
{
    public class Employee
    {
        private string firstName, lastName, phoneNumber, mobile, email, specialization = null, role;
        private DateTime dateOfBirth;
        private int id_employee, id_user;

        public Employee()
        {

        }

        public Employee(string firstName, string lastName, string phoneNumber, string mobile, string email, string specialization, string role, DateTime dateOfBirth)
        {
            this.First_name = firstName;
            this.Last_name = lastName;
            this.Phone_number = phoneNumber;
            this.Mobile = mobile;
            this.Email = email;
            this.Id_doct_specialization = specialization;
            this.Id_employee_role = role;
            this.Date_of_birth = dateOfBirth;
        }

        public Employee(int id, string firstName, string lastName, string phoneNumber, string mobile, string email, string specialization, string role, DateTime dateOfBirth)
        {
            this.Id_employee = id;
            this.First_name = firstName;
            this.Last_name = lastName;
            this.Phone_number = phoneNumber;
            this.Mobile = mobile;
            this.Email = email;
            this.Id_doct_specialization = specialization;
            this.Id_employee_role = role;
            this.Date_of_birth = dateOfBirth;
        }

        //private void isNullValidation(string s)
        //{
        //    if (s == string.Empty)
        //        throw new ArgumentNullException("Empty input of the 'Mobile'. \n" +
        //            "Adding employee to the system database terminated.");
        //}

        private static Regex CreateValidEmailRegex()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }

        public string First_name
        {
            get => firstName;
            set
            {
                if (value == string.Empty)
                    throw new ArgumentNullException("Empty input of the 'First name'. \n" +
                        "Adding employee to the system database terminated.");
                if (!char.IsUpper(value[0]))
                    throw new ArgumentOutOfRangeException("Wrong input of the 'First name'. \n" +
                        "Adding employee to the system database terminated");
                if (value.Length < 3)
                    throw new ArgumentOutOfRangeException("Wrong input of the 'First name'. \n" +
                        "Adding employee to the system database terminated");
                firstName = value;
            }
        }

        public string Last_name
        {
            get => lastName;
            set
            {
                if (value == string.Empty)
                    throw new ArgumentNullException("Empty input of the 'Last name'. \n" +
                        "Adding employee to the system database terminated.");
                if (!char.IsUpper(value[0]))
                    throw new ArgumentOutOfRangeException("Wrong input of the 'Last name'. \n" +
                        "Adding employee to the system database terminated");
                if (value.Length < 3)
                    throw new ArgumentOutOfRangeException("Wrong input of the 'Last name'. \n" +
                        "Adding employee to the system database terminated");
                lastName = value;
            }
        }
        public string Phone_number
        {
            get => phoneNumber;
            set
            {
                if ((value.Length > 0 && value.Length < 9) || value.Length > 9)
                    throw new ArgumentOutOfRangeException("Wrong input of the 'Phone number'. \n" +
                        "Adding employee to the system database terminated.");
                if (String.IsNullOrWhiteSpace(value))
                    value = string.Empty;
                if (!value.All(char.IsDigit))
                    throw new ArgumentOutOfRangeException("Wrong input of the 'Phone number'. \n" +
                        "Adding employee to the system database terminated.");
                phoneNumber = value;
            }
        }
        public string Mobile
        {
            get => mobile;
            set
            {
                if (value == string.Empty)
                    throw new ArgumentNullException("Empty input of the 'Mobile'. \n" +
                        "Adding employee to the system database terminated.");
                if (value.Length != 11)
                    throw new ArgumentOutOfRangeException("Wrong input of the 'Mobile'. \n" +
                        "Adding employee to the system database terminated.");
                if (!value.All(char.IsDigit))
                    throw new ArgumentOutOfRangeException("Wrong input of the 'Mobile'. \n" +
                        "Adding employee to the system database terminated.");
                mobile = value;
            }
        }
        public string Email
        {
            get => email;
            set
            {
                if (value == string.Empty)
                    throw new ArgumentNullException("Empty input of the 'E-mail address'. \n" +
                        "Adding employee to the system database terminated.");
                if (!CreateValidEmailRegex().IsMatch(value))
                    throw new ArgumentOutOfRangeException("Wrong input of the 'E-mail address'. \n" +
                        "Adding employee to the system database terminated.");
                email = value;
            }
        }
        public string Id_doct_specialization
        {
            get => specialization;
            set
            {
                if (value == "")
                    throw new ArgumentNullException("Empty input of the 'Specialization'. \n" +
                        "Adding employee to the system database terminated.");
                specialization = value;
            }
        }
        public string Id_employee_role
        {
            get => role;
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Empty input of the 'Role'. \n" +
                        "Adding employee to the system database terminated.");
                role = value;
            }
        }
        public DateTime Date_of_birth
        {
            get => dateOfBirth;
            set
            {
                if (value == default(DateTime))
                    throw new ArgumentNullException("Empty input of the 'Date of birth'. \n" +
                        "Adding employee to the system database terminated.");
                if (value > DateTime.Now)
                    throw new ArgumentOutOfRangeException("Wrong input of the 'Date of birth'. \n" +
                        "Adding employee to the system database terminated.");
                if (value > DateTime.Now)
                    throw new ArgumentOutOfRangeException("Wrong input of the 'Date of birth'. \n" +
                        "Adding employee to the system database terminated.");
                dateOfBirth = value;
            }
        }
        public int Id_employee
        {
            get => id_employee;
            set
            {
                id_employee = value;
            }
        }
        public int Id_user
        {
            get => id_user;
            set
            {
                id_user = value;
            }
        }
    }
}
