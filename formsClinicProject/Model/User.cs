using System;
using System.Linq;
using System.Net;
using System.Net.Mail;

namespace formsClinicProject
{
    //Autor: Mateusz
    public class User
    {
        private string _login, _password;
        private int _id_user, _permission;

        public User()
        {
        }

        public User(string login, int permission)
        {
            this.Login = login;
            this.Id_permission = permission;
        }

        //Konstruktor używany do dodawania użytkownika do bazy, wtedy nie używamy pola Id bo generuje je baza
        public User(string login, string password, int permission)
        {
            this.Login = login;
            this.Password = password;
            this.Id_permission = permission;
        }

        //Konstruktor używany przy edycji/usuwaniu użytkownika, wtedy używamy pola Id do identyfikacji użytkownika w bazie danych
        public User(int id, string login, int permission)
        {
            this.Id_user = id;
            this.Login = login;
            this.Id_permission = permission;
        }

        //Używany przy tworzeniu nowego użytkownika
        public User(int id, string login, string password, int permission)
        {
            this.Id_user = id;
            this.Login = login;
            this.Password = password;
            this.Id_permission = permission;
        }

        //Super funkcja do walidacji hasła, ładujesz w nią hasło i zwraca true jeżeli hasło jest miodzio
        public static Boolean PasswordValidation(string password)
        {
            string[] requiredSymbols = { "-", "_", "!", "#", "$", "*", "@", ".", ">", "?", "<" };

            if (password.Length < 8 || password.Length > 15 || !password.Any(char.IsDigit) || !password.Any(char.IsUpper) || !password.Any(char.IsLower) || !requiredSymbols.Any(s => password.Contains(s)))
            {
                return false;
            }
            return true;

        }


        //Funkcja wysyłania emaila do użytkownika. Wymaga podania kolejno tematu maila i treści. Email jest pobierany z obiektu dla którego wykonujemy funkcję
        public bool SendEmailToUser(string email, string subject, string messageBody)
        {
            try
            {
                if (email.Length < 5)
                    throw new ArgumentNullException("No email provided");

                MailMessage message = new MailMessage();
                string toWho = email; //EmployeeDataAccess.GetEmployeeByUserId(this.Id).Email; //eh
                string fromWho = "clinicroot04@gmail.com";
                string password = "Adminkliniki%";
                message.To.Add(toWho);
                message.From = new MailAddress(fromWho);
                message.Subject = subject;
                message.Body = messageBody;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(fromWho, password);

                smtp.Send(message);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;   
            }
        }

        public string Login { 
            get => _login; 
            set 
            {
                if (value == string.Empty)
                    throw new ArgumentNullException("Empty input of the 'Login'.");
                _login = value; 
            } 
        }

        //Powoduje, że datagridview nie wyświetla pola hasła przy Datasource
        [System.ComponentModel.Browsable(false)]
        public string Password 
        { 
            get => _password; 
            set 
            {
                if (value.Length == 0)
                    throw new ArgumentNullException("Empty input of the 'Password'.");

                bool isNumeric = int.TryParse(value, out int b);

                if (!isNumeric)
                {
                    if (!PasswordValidation(value))
                        throw new ArgumentException("Password doesn't meet the policy");
                }
                
                _password = value;

            } 
        }

        public int Id_permission 
        { 
            get => _permission; set 
            { 
                if(value == 0)
                {
                    throw new ArgumentNullException("No permission group provided");
                }

                _permission = value; 
            } 
        }

        //[System.ComponentModel.Browsable(false)]
        public int Id_user { get => _id_user; set => _id_user = value; }
    }
}
