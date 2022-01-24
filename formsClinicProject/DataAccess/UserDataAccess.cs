using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace formsClinicProject.DataAccess
{
    //Autor: Mateusz
    public class UserDataAccess
    {
        //Funkcja logowania, sprawdza czy istnieje użytkownik z podanym loginem i hasłem, jeżeli nie to zwraca null
        public static User LoginUser(string login, string password)
        {
            using (Helper.Connection())
            {
                return (User)Helper.Connection().QuerySingleOrDefault<User>($"SELECT * FROM [dbo].[User] where login = '{login}' and password = '{password}';");
            }
        }

        //Funkcja dodania użytkownika do bazy danych
        public static void InputUser(User user)
        {
            using (Helper.Connection())
            {
                Helper.Connection().Execute($"INSERT INTO [dbo].[User] VALUES ( '{user.Login}', '{user.Password}','{user.Id_permission}', 1)");
            }
        }

        //Funkcja aktualizowania danych użytkownika na podstawie jego Id
        public static void UpdateUser(User user)
        {
            using (Helper.Connection())
            {
                Helper.Connection().Execute($"UPDATE [dbo].[User] SET [login]= '{user.Login}', [id_permission] = {user.Id_permission} WHERE [id_user]= {user.Id_user}");
            }
        }

        public static User ForgotPassword(string login, string email_address)
        {
            using (Helper.Connection())
            {
                return Helper.Connection().QuerySingleOrDefault<User>($"SELECT empl.email, usr.login FROM[dbo].[employee] empl INNER JOIN[dbo].[User] usr ON empl.id_user = usr.id_user WHERE empl.email = '{email_address}' and usr.login = '{login}'");
            }
        }

        //Funckja do zmiany hasło
        public static void ResetPassword(string newPassword, int userId)
        {
            using (Helper.Connection())
            {
                Helper.Connection().Execute($"UPDATE [dbo].[User] SET password = '{newPassword}' WHERE [id_user] = {userId};");
            }
        }
        public static void ChangePassword(string newPassword, string email)
        {
            using (Helper.Connection())
            {
                Helper.Connection().Execute($"UPDATE usr SET password = '{newPassword}' FROM[dbo].[employee] empl INNER JOIN[dbo].[User] usr ON empl.id_user = usr.id_user WHERE  empl.email = '{email}'");
            }
        }

        //Funkcja pobierające wszystkich użytkowników z bazy. Zwraca ich w postaci listy
        public static List<User> ListOfUsers()
        {
            using (Helper.Connection())
            {
                return Helper.Connection().Query<User>("SELECT * FROM [clinic4].[dbo].[User]").ToList();
            }
        }
        //Dezaktywacja użytkownika
        public static void DeactivateUser(int id_user)
        {
            using (Helper.Connection())
            {
                Helper.Connection().Execute($"UPDATE [dbo].[User] SET [id_status] = 2 WHERE [id_user] = {id_user}");
            }
        }
        //Aktywacja użytkownika
        public static void ActivateUser(int id_user)
        {
            using (Helper.Connection())
            {
                Helper.Connection().Execute($"UPDATE [dbo].[User] SET [id_status] = 1 WHERE [id_user] = {id_user}");
            }
        }

        //Pobiera użytkownika z bazy na podstawie id es
        public static User GetUserById(int id)
        {
            using (Helper.Connection())
            {
                return (User)Helper.Connection().QuerySingleOrDefault<User>($"SELECT * FROM [clinic4].[dbo].[User] WHERE [id_user] = {id}");
            }
        }

        //Funkcja ktora uzupełnia dataTable danymi z widoku, żeby wyświetlić listę użytkowników w ReviewUsersForm
        //Nie użyłem tutaj dappera bo nie ma klasy z obiektem którem odpowiadają pola z tego widoku
        //Może sie da ale ja tam nie wiem, kopiować to
        public static DataTable GetListOfUsersFromView()
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=den1.mssql8.gear.host;Initial Catalog=clinic4;Persist Security Info=True;User ID=clinic4;Password=Adminkliniki%");

            try
            {
                DataTable dt = new DataTable();

                User matchingUser = new User();
                using (sqlCon)
                {
                    string oString = "SELECT * FROM [dbo].[v_USERS]";
                    SqlCommand oCmd = new SqlCommand(oString, sqlCon);
                    sqlCon.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {

                        dt.Load(oReader);

                        sqlCon.Close();
                    }
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Pobranie użytkownika z bazy używając dappera, z modyfikacją argumentów
        //Dodaje argument SqlConnection, ktory trzeba mu podać w unit test bo ma autyzm i nie może wywołać połączenia z naszych funkcji zawartych w Helper :')
        public static User LoginUservForUnitTest(string login, string password, SqlConnection connection)
        {
            using (connection)
            {
                return connection.QuerySingleOrDefault<User>($"SELECT * FROM [dbo].[User] WHERE login = '{login}' and password = '{password}';");
            }
        }

        public static List<User> ListOfUsersForUnitTest(SqlConnection connection)
        {
            using (connection)
            {
                return connection.Query<User>("SELECT * FROM [clinic4].[dbo].[User]").ToList();
            }
        }
    }
}
