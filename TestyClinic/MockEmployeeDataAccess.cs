using Dapper;
using formsClinicProject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestyClinic
{
    class MockEmployeeDataAccess
    {

        public static IDbConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=den1.mssql8.gear.host;Initial Catalog=clinic4;Persist Security Info=True;User ID=clinic4;Password=Adminkliniki%");
        }

        public static void InputEmployee(Employee employee)
        {
            using (GetConnection())
            {
                string specialty = employee.Id_doct_specialization == null ? "null" : $"(SELECT [id_doct_specialization] FROM [dbo].[Doctor_specialization] WHERE [specialization] = '{employee.Id_doct_specialization}')";
                GetConnection().Execute($"INSERT INTO [dbo].[employee] VALUES ( '{employee.First_name}', '{employee.Last_name}', '{employee.Phone_number}', '{employee.Mobile}', '{employee.Email}', '{employee.Date_of_birth.ToString("s")}', {specialty} , null, (SELECT [id_employee_role] FROM [dbo].[Employee_role] WHERE [role] = '{employee.Id_employee_role}'), (SELECT [id_status] FROM [dbo].[Statuses] where [status] = 'Active'))");
            }
        }
        public static Employee GetEmployeeDataBasedOnId(int id, SqlConnection connection)
        {
            using (connection)
            {
                return connection.QuerySingleOrDefault<Employee>($"SELECT empl.id_employee, empl.first_name, empl.last_name, empl.phone_number, empl.mobile, empl.email, empl.date_of_birth, empl_role.role, empl.id_user, spec.specialization FROM [dbo].[employee] empl  INNER JOIN [dbo].[Employee_role] empl_role ON empl.id_employee_role = empl_role.id_employee_role LEFT JOIN [dbo].[Doctor_specialization] spec ON empl.id_doct_specialization = spec.id_doct_specialization WHERE empl.id_employee = {id}");
            }
        }

        //Edytowanie pracownika w bazie danych
        public static void UpdateEmployee(Employee editedEmployee)
        {
            using (GetConnection())
            {
                string specialty = editedEmployee.Id_doct_specialization == null ? "null" : $"(SELECT [id_doct_specialization] FROM [dbo].[Doctor_specialization] WHERE [specialization] = '{editedEmployee.Id_doct_specialization}')";
                GetConnection().Execute($"UPDATE [dbo].[employee] SET [first_name] = '{editedEmployee.First_name}', [last_name] = '{editedEmployee.Last_name}', [phone_number] = '{editedEmployee.Phone_number}', [mobile] = '{editedEmployee.Mobile}', [email] = '{editedEmployee.Email}', [date_of_birth] = '{editedEmployee.Date_of_birth.ToString("s")}', [id_doct_specialization] = {specialty}, [id_employee_role] = (SELECT [id_employee_role] FROM [dbo].[Employee_role] WHERE [role] = '{editedEmployee.Id_employee_role}') WHERE [id_employee] = {editedEmployee.Id_employee}");
            }
        }

        //Tymczasowa funkcja która przypisuje User_Id do employee. Uzywana przy tworzeniu nowego użytkownika
        public static void UpdateUserIdForEmployee(Employee employee)
        {
            using (GetConnection())
            {
                GetConnection().Execute($"UPDATE [dbo].[employee] SET [id_user]= {employee.Id_user} WHERE [email] = '{employee.Email}'");
            }
        }

        //Dezaktywacja pracownika
        public static void DeactivateEmployee(int employee_id)
        {
            using (GetConnection())
            {
                //dezaktywuje employee - zmienia jego status
                GetConnection().Execute($"UPDATE [dbo].[employee] SET [id_status] = 2 WHERE [id_employee] = {employee_id}");

                //pobiera user_id tego employee (jeżeli nie posiada żadnego to zwraca 0)
                int userId = GetIdUserByEmployeeId(employee_id);

                if (userId != 0)
                    MockUserDataAccess.DeactivateUser(userId);
            }
        }
        //Aktywacja pracownika
        public static void ActivateEmployee(int employee_id)
        {
            using (GetConnection())
            {
                GetConnection().Execute($"UPDATE [dbo].[employee] SET [id_status] = 1 WHERE [id_employee] = {employee_id}");
            }
        }

        public static bool doesEmployeeExist(Employee employee)
        {
            using (GetConnection())
            {
                string specialty = employee.Id_doct_specialization == null ? "is null" : $"= (SELECT [id_doct_specialization] FROM [dbo].[Doctor_specialization] WHERE [specialization] = '{employee.Id_doct_specialization}')";
                Employee empl = (Employee)GetConnection().QueryFirstOrDefault<Employee>($"SELECT * FROM  [dbo].[employee] WHERE [first_name] = '{employee.First_name}' AND [last_name] = '{employee.Last_name}' AND [phone_number]= '{employee.Phone_number}' AND [mobile] = '{employee.Mobile}' AND [email] = '{employee.Email}' AND [date_of_birth] = '{employee.Date_of_birth.ToString("s")}' AND [id_doct_specialization] {specialty} AND [id_user] is null AND [id_employee_role] = (SELECT [id_employee_role] FROM [dbo].[Employee_role] WHERE [role] = '{employee.Id_employee_role}') AND [id_status] = (SELECT [id_status] FROM [dbo].[Statuses] where [status]= 'Active')");
                if (empl == null)
                    return false;
                else
                    return true;
            }
        }

        public static bool doesEmployeeWithUserExist(Employee employee)
        {
            using (GetConnection())
            {
                string specialty = employee.Id_doct_specialization == null ? "is null" : $"= (SELECT [id_doct_specialization] FROM [dbo].[Doctor_specialization] WHERE [specialization] = '{employee.Id_doct_specialization}')";
                Employee employeeWithUser = (Employee)GetConnection().QueryFirstOrDefault<Employee>($"SELECT * FROM [dbo].[employee] WHERE [first_name] = '{employee.First_name}' AND [last_name] = '{employee.Last_name}' AND [phone_number] = '{employee.Phone_number}' AND [mobile] = '{employee.Mobile}' AND [email] = '{employee.Email}' AND [date_of_birth] = '{employee.Date_of_birth.ToString("s")}' AND [id_doct_specialization] {specialty} AND [id_user] = {employee.Id_user} AND [id_employee_role] = (SELECT [id_employee_role] FROM [dbo].[Employee_role] WHERE [role] = '{employee.Id_employee_role}') AND [id_status] = (SELECT [id_status] FROM [dbo].[Statuses] WHERE [status]= 'Active')");
                if (employeeWithUser == null)
                    return false;
                else
                    return true;
            }
        }

        public static void deleteEmployee(Employee employee)
        {
            using (GetConnection())
            {
                string specialty = employee.Id_doct_specialization == null ? "is null" : $"= (SELECT [id_doct_specialization] FROM [dbo].[Doctor_specialization] WHERE [specialization] = '{employee.Id_doct_specialization}')";
                GetConnection().Execute($"DELETE FROM  [dbo].[employee] WHERE [first_name] = '{employee.First_name}' AND [last_name] = '{employee.Last_name}' AND [phone_number]= '{employee.Phone_number}' AND [mobile] = '{employee.Mobile}' AND [email] = '{employee.Email}' AND [date_of_birth] = '{employee.Date_of_birth.ToString("s")}' AND [id_doct_specialization] {specialty} AND [id_user] is null AND [id_employee_role] = (SELECT [id_employee_role] FROM [dbo].[Employee_role] WHERE [role] = '{employee.Id_employee_role}') AND [id_status] = (SELECT [id_status] FROM [dbo].[Statuses] where [status]= 'Active')");
            }
        }

        public static void deleteEmployeeWithUser(Employee employee)
        {
            using (GetConnection())
            {
                string specialty = employee.Id_doct_specialization == null ? "is null" : $"= (SELECT [id_doct_specialization] FROM [dbo].[Doctor_specialization] WHERE [specialization] = '{employee.Id_doct_specialization}')";
                GetConnection().Execute($"DELETE FROM  [dbo].[employee] WHERE [first_name] = '{employee.First_name}' AND [last_name] = '{employee.Last_name}' AND [phone_number]= '{employee.Phone_number}' AND [mobile] = '{employee.Mobile}' AND [email] = '{employee.Email}' AND [date_of_birth] = '{employee.Date_of_birth.ToString("s")}' AND [id_doct_specialization] {specialty} AND [id_user] = {employee.Id_user} AND [id_employee_role] = (SELECT [id_employee_role] FROM [dbo].[Employee_role] WHERE [role] = '{employee.Id_employee_role}') AND [id_status] = (SELECT [id_status] FROM [dbo].[Statuses] where [status]= 'Active')");
            }
        }

        public static int GetEmployeeStatusBasedOnId(int id)
        {
            using (GetConnection())
            {
                return GetConnection().QuerySingleOrDefault<int>($"SELECT id_status FROM employee WHERE id_employee = {id}");
            }
        }

        public static int GetIdUserByEmployeeId(int id_employee)
        {
            return GetConnection().QuerySingle<int>($"SELECT [id_user] FROM [dbo].[employee] WHERE [id_employee] = {id_employee}");
        }

        public static int GetEmployeeIdBasedOnData(Employee employee)
        {
            string specialty = employee.Id_doct_specialization == null ? "is null" : $"= (SELECT [id_doct_specialization] FROM [dbo].[Doctor_specialization] WHERE [specialization] = '{employee.Id_doct_specialization}')";
            return GetConnection().QuerySingle<int>($"SELECT [id_employee] FROM [dbo].[employee] WHERE [first_name] = '{employee.First_name}' AND [last_name] = '{employee.Last_name}' AND [phone_number] = '{employee.Phone_number}' AND [mobile] = '{employee.Mobile}' AND [email] = '{employee.Email}' AND [date_of_birth] = '{employee.Date_of_birth.ToString("s")}' AND [id_doct_specialization] {specialty} AND [id_user] is null AND [id_employee_role] = (SELECT [id_employee_role] FROM [dbo].[Employee_role] WHERE [role] = '{employee.Id_employee_role}') AND [id_status] = (SELECT [id_status] FROM [dbo].[Statuses] WHERE [status]= 'Active')");
        }

        public static List<Employee> GetEmployeeDataBasedOnRole(int role_id)
        {
            using (GetConnection())
            {
                return GetConnection().Query<Employee>($"SELECT * FROM [dbo].[employee] WHERE [id_employee_role] = @id_role", new { id_role = role_id }).ToList();
            }
        }
    }
}
