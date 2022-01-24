using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace formsClinicProject
{
    //Autor: Mateusz
    public class User
    {
        private string _login, _password, _permission;
        private int _id;

        public User()
        {
        }

        //Konstruktor używany do dodawania użytkownika do bazy, wtedy nie używamy pola Id bo generuje je baza
        public User(string login, string permission)
        {
            this.Login = login;
            this.Permission = permission;
        }

        //Konstruktor używany przy edycji/usuwaniu użytkownika, wtedy używamy pola Id do identyfikacji użytkownika w bazie danych
        public User(int id, string login, string password, string permission)
        {
            this.Id = id;
            this.Login = login;
            this.Password = password;
            this.Permission = permission;
        }


        //Super funkcja do walidacji hasła, ładujesz w nią hasło i zwraca true jeżeli hasło jest miodzio
        public static Boolean PasswordValidation(string password)
        {
            string[] requiredSymbols = { "-", "_", "!", "#", "$", "*" };

            if (password.Length < 8 || password.Length > 15 || !password.Any(char.IsDigit) || !password.Any(char.IsUpper) || !password.Any(char.IsLower) || !requiredSymbols.Any(s => password.Contains(s)))
            {
                return false;
            }

            return true;
        }

        //Funkcja wysyłania emaila do użytkownika. Wymaga podania kolejno tematu maila i treści. Email jest pobierany z obiektu dla którego wykonujemy funkcję
        public void SendEmailToUser(string subject, string messageBody)
        {
            MailMessage message = new MailMessage();
            string toWho = "//TODO email z employee";
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
            
            try
            {
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string Login { get => _login; set => _login = value; }
        
        //Powoduje, że datagridview nie wyświetla pola hasła przy Datasource
        [System.ComponentModel.Browsable(false)]
        public string Password { get => _password; set => _password = value; }

        [System.ComponentModel.DisplayName("E-mail")]

        public string Permission { get => _permission; set => _permission = value; }

        [System.ComponentModel.DisplayName("Phone number")]

        [System.ComponentModel.Browsable(false)]
        public int Id { get => _id; set => _id = value; }
    }
}
