using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace formsClinicProject.DataAccess
{
    public class EmployeeDataAccess
    {
        //Dodawanie pracownika do bazy danych
        public static void InputEmployee(Employee employee)
        {
            using (Helper.Connection())
            {
                string specialty = employee.Id_doct_specialization == null ? "null" : $"(SELECT [id_doct_specialization] FROM [dbo].[Doctor_specialization] WHERE [specialization] = '{employee.Id_doct_specialization}')";
                Helper.Connection().Execute($"INSERT INTO [dbo].[employee] VALUES ( '{employee.First_name}', '{employee.Last_name}', '{employee.Phone_number}', '{employee.Mobile}', '{employee.Email}', '{employee.Date_of_birth.ToString("s")}', {specialty} , null, (SELECT [id_employee_role] FROM [dbo].[Employee_role] WHERE [role] = '{employee.Id_employee_role}'), 1)");
            }
        }

        //Edytowanie pracownika w bazie danych
        public static void UpdateEmployee(Employee employee)
        {

            using (Helper.Connection())
            {
                string specialty = employee.Id_doct_specialization == null ? "null" : $"(SELECT [id_doct_specialization] FROM [dbo].[Doctor_specialization] WHERE [specialization] = '{employee.Id_doct_specialization}')";
                Helper.Connection().Execute($"UPDATE [dbo].[employee] SET [first_name] = '{employee.First_name}', [last_name] = '{employee.Last_name}', [phone_number] = '{employee.Phone_number}', [mobile] = '{employee.Mobile}', [email] = '{employee.Email}', [date_of_birth] = '{employee.Date_of_birth.ToString("s")}', [id_doct_specialization] = {specialty}, [id_employee_role] = (SELECT [id_employee_role] FROM [dbo].[Employee_role] WHERE [role] = '{employee.Id_employee_role}') WHERE [id_employee] = {employee.Id_employee}");
            }
        }
        // Dla danego id zwraca dane pracownika.
        public static Employee GetEmployeeDataBasedOnId(int id)
        {
            using (Helper.Connection())
            {
                return Helper.Connection().QuerySingleOrDefault<Employee>($"SELECT empl.id_employee, empl.first_name, empl.last_name, empl.phone_number, empl.mobile, empl.email, empl.date_of_birth, empl_role.role, empl.id_user, spec.specialization FROM [dbo].[employee] empl  INNER JOIN [dbo].[Employee_role] empl_role ON empl.id_employee_role = empl_role.id_employee_role LEFT JOIN [dbo].[Doctor_specialization] spec ON empl.id_doct_specialization = spec.id_doct_specialization WHERE empl.id_employee = {id}");
            }
        }

        // Dla danego id zwraca dane pracownika.
        public static List<Employee> GetEmployeeDataBasedOnRole(int role_id)
        {
            using (Helper.Connection())
            {
                return Helper.Connection().Query<Employee>($"SELECT * FROM [dbo].[employee] WHERE [id_employee_role] = @id_role", new { id_role = role_id }).ToList();
            }
        }

        //Tymczasowa funkcja która przypisuje User_Id do employee. Uzywana przy tworzeniu nowego użytkownika
        public static void UpdateUserIdForEmployee(Employee employee)
        {
            using (Helper.Connection())
            {
                Helper.Connection().Execute($"UPDATE [dbo].[employee] SET [id_user]= {employee.Id_user} WHERE [email] = '{employee.Email}'");
            }
        }

        //Dezaktywacja pracownika
        public static void DeactivateEmployee(int employee_id)
        {
            using (Helper.Connection())
            {
                //dezaktywuje employee - zmienia jego status
                Helper.Connection().Execute($"UPDATE [dbo].[employee] SET [id_status] = 2 WHERE [id_employee] = {employee_id}");
                
                //pobiera całego użytkownika bo jak chce pobrać samo id, które może być nullem to krzyczy
                //nie mam psychy tego naprawiać inaczej
                Employee emp = (Employee)Helper.Connection().QuerySingleOrDefault<Employee>($"SELECT * FROM [dbo].[employee] WHERE [id_employee] = {employee_id}");

                //int aha = userId == null ? 0 : userId.Value;

                if (emp.Id_user != 0)
                    UserDataAccess.DeactivateUser(emp.Id_user);
            }
        }
        //Aktywacja pracownika
        public static void ActivateEmployee(int employee_id)
        {
            using (Helper.Connection())
            {
                Helper.Connection().Execute($"UPDATE [dbo].[employee] SET [id_status] = 1 WHERE [id_employee] = {employee_id}");
            }
        }

        public static DataTable GetListOfEmployeeFromView()
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=den1.mssql8.gear.host;Initial Catalog=clinic4;Persist Security Info=True;User ID=clinic4;Password=Adminkliniki%");

            try
            {
                DataTable dt = new DataTable();

                Employee matchingUser = new Employee();
                using (sqlCon)
                {
                    string oString = "SELECT * FROM [dbo].[v_EVERYONE]";
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

        public static List<string> ListOfRoles()
        {
            using (Helper.Connection())
            {
                List<string> Roles = Helper.Connection().Query<string>("SELECT role FROM [clinic4].[dbo].[Employee_role]").ToList();
                return Roles;
            }
        }

        public static List<string> ListOfSpecialities()
        {
            using (Helper.Connection())
            {
                List<string> Specialites = Helper.Connection().Query<string>("SELECT specialization FROM [clinic4].[dbo].[Doctor_specialization]").ToList();
                return Specialites;
            }
        }
    }
}
