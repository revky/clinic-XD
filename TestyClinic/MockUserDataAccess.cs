using Dapper;
using formsClinicProject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace TestyClinic
{
    class MockUserDataAccess
    {

        public static IDbConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=den1.mssql8.gear.host;Initial Catalog=clinic4;Persist Security Info=True;User ID=clinic4;Password=Adminkliniki%");
        }

        //Funkcja logowania, sprawdza czy istnieje użytkownik z podanym loginem i hasłem, jeżeli nie to zwraca null
        public static User LoginUser(string login, string password)
        {
            using (GetConnection())
            {
                return GetConnection().QuerySingleOrDefault<User>($"SELECT * FROM [dbo].[User] where login = '{login}' and password = '{password}';");
            }
        }

        //Funkcja dodania użytkownika do bazy danych
        public static void InputUser(User user)
        {
            using (GetConnection())
            {
                GetConnection().Execute($"INSERT INTO [dbo].[User] VALUES ( '{user.Login}', '{user.Password}', 1, '{user.Id_permission}')");
            }
        }

        //Funkcja aktualizowania danych użytkownika na podstawie jego Id
        public static void UpdateUser(User user)
        {
            using (GetConnection())
            {
                GetConnection().Execute($"UPDATE [dbo].[User] SET [login]= '{user.Login}', [id_permission] = {user.Id_permission} WHERE [id_user]= {user.Id_user}");
            }
        }

        public static User ForgotPassword(string login, string email_address)
        {
            using (GetConnection())
            {
                return GetConnection().QuerySingleOrDefault<User>($"SELECT empl.email, usr.login FROM[dbo].[employee] empl INNER JOIN[dbo].[User] usr ON empl.id_user = usr.id_user WHERE empl.email = '{email_address}' and usr.login = '{login}'");
            }
        }

        //Funckja do zmiany hasło
        public static void ResetPassword(string newPassword, int userId)
        {
            using (GetConnection())
            {
                GetConnection().Execute($"UPDATE [dbo].[User] SET password = '{newPassword}' WHERE [id_user] = {userId};");
            }

        }
        public static void ChangePassword(string newPassword, string email, SqlConnection connection)
        {
            using (connection)
            {
                connection.Execute($"UPDATE usr SET password = '{newPassword}' FROM [dbo].[employee] empl INNER JOIN[dbo].[User] usr ON empl.id_user = usr.id_user WHERE  empl.email = '{email}'");
            }
        }

        //Dezaktywacja użytkownika
        public static void DeactivateUser(int id_user)
        {
            using (GetConnection())
            {
                GetConnection().Execute($"UPDATE [dbo].[User] SET [id_status] = 2 WHERE [id_user] = {id_user}");
            }
        }
        //Aktywacja użytkownika
        public static void ActivateUser(int id_user)
        {
            using (GetConnection())
            {
                GetConnection().Execute($"UPDATE [dbo].[User] SET [id_status] = 1 WHERE [id_user] = {id_user}");
            }
        }

        public static int GetUserStatus(int id_user)
        {
            using (GetConnection())
            {
                return (int)GetConnection().QuerySingle<int>($"SELECT [id_status] FROM [dbo].[User] WHERE [id_user]= {id_user}");
            }
        }

        //Pobiera użytkownika z bazy na podstawie id es
        public static User GetUserById(int id)
        {
            using (GetConnection())
            {
                return (User)GetConnection().QuerySingleOrDefault<User>($"SELECT * FROM [clinic4].[dbo].[User] WHERE [id_user] = {id}");
            }
        }

        public static User GetUserByLogin(string login, IDbConnection connection)
        {
            using (connection)
            {
                return (User)connection.QuerySingleOrDefault<User>($"SELECT * FROM [clinic4].[dbo].[User] WHERE [login] = '{login}'");
            }
        }

        public static int getUserStatusById(int id_user)
        {
            return GetConnection().QuerySingleOrDefault<int>($"SELECT id_status FROM [clinic4].[dbo].[User] WHERE id_user = {id_user}");
        }

        public static int getUserGroupOfPermissionsById(int id_user)
        {
            return GetConnection().QuerySingleOrDefault<int>($"SELECT id_permission FROM [clinic4].[dbo].[User] WHERE id_user = {id_user}");
        }


        //Funkcja ktora uzupełnia dataTable danymi z widoku, żeby wyświetlić listę użytkowników w ReviewUsersForm
        //Nie użyłem tutaj dappera bo nie ma klasy z obiektem którem odpowiadają pola z tego widoku
        //Może sie da ale ja tam nie wiem, kopiować to
        public static DataTable GetListOfUsersFromView()
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=den1.mssql8.gear.host;Initial Catalog=clinic4;Persist Security Info=True;User ID=clinic4;Password=Adminkliniki%");

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

        public static void deleteUser(User user)
        {
            using (GetConnection())
            {
                GetConnection().Execute($"DELETE FROM [dbo].[User] WHERE [login] = '{user.Login}' AND [password] = '{user.Password}' AND [id_permission] = {user.Id_permission} AND [id_status] = (SELECT [id_status] FROM [dbo].[Statuses] where [status]= 'Active')");
            }
        }
    }
}
