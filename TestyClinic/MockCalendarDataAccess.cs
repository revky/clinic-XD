using Dapper;
using formsClinicProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using TestyClinic;

namespace formsClinicProject.DataAccess
{
    class MockCalendarDataAccess
    {
        public static IDbConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=den1.mssql8.gear.host;Initial Catalog=clinic4;Persist Security Info=True;User ID=clinic4;Password=Adminkliniki%");
        }

        public static void CreateCalendar(DateTime dateOfCalendar)
        {
            //pobieranko z wprowadzonego dateTime roku i miesiaca w liczbach
            //bo w takim formacie musimy to podać bazie łatwiutko
            int year = dateOfCalendar.Year;
            int month = dateOfCalendar.Month;

            using (GetConnection())
            {
                GetConnection().Execute("INSERT INTO [dbo].[Calendar] VALUES (1, @year, @month)", new { year, month });
            }
        }

        public static List<Calendar> AllCalendars()
        {
            using (GetConnection())
            {
                return GetConnection().Query<Calendar>("SELECT * FROM [dbo].[Calendar]").ToList().OrderBy(x => x.Year).ThenBy(x => x.Month).ToList();
            }
        }

        public static List<Term> TermsForOneEmployee(int id_employee, int id_calendar, DateTime date)
        {
            using (GetConnection())
            {
                return GetConnection().Query<Term>("EXEC [dbo].[DoctorsCalendar] @id_employee, @id_calendar, @term_date", new { @id_employee = id_employee, @id_calendar = id_calendar, @term_date = date.ToString("yyyy-MM-dd") }).ToList();
            }
        }

        public static void CreateTerms(DateTime date, int start_hour, int end_hour, int id_employee, int id_cabinet, int id_calendar)
        {
            using (GetConnection())
            {
                GetConnection().Execute("EXEC [dbo].[DoctorsCalendarAddHours] @day, @start_hour, @end_hour, @id_employee, @id_cabinet, @id_calendar", new { @day = date.ToString("yyyy-MM-dd"), @start_hour = start_hour, @end_hour = end_hour, @id_employee = id_employee, @id_cabinet = id_cabinet, @id_calendar = id_calendar });
            }
        }

        public static void DeleteTerms(DateTime date, int id_employee)
        {
            using (GetConnection())
            {
                GetConnection().Execute("DELETE FROM [dbo].[tbl_terms] WHERE [id_employee] = @id_employee and [date] = @date", new { @id_employee = id_employee, @date = date.ToString("yyyy-MM-dd") });
            }
        }

        public static void DeleteCalendar(int id_calendar)
        {
            using (GetConnection())
            {
                GetConnection().Execute("DELETE FROM [dbo].[tbl_terms] WHERE [id_calendar] = @id_calendar", new { @id_calendar = id_calendar });
                GetConnection().Execute("DELETE FROM [dbo].[Calendar] WHERE [id_calendar] = @id_calendar", new { @id_calendar = id_calendar });
            }
        }

        public static void CreateTermsWeekly(DateTime date, int id_employee, int id_calendar)
        {
            using (GetConnection())
            {
                GetConnection().Execute("EXEC [dbo].[WeeklyBasicTermsForAllDoctorsParam] @StartDate, @id_calendar, @id_employee", new { @StartDate = date.ToString("yyyy-MM-dd"), @id_employee = id_employee, @id_calendar = id_calendar });
            }
        }

        public static int GetIdCallendar(DateTime dt)
        {
            int year = dt.Year;
            int month = dt.Month;

            using (GetConnection())
            {
                return (int)GetConnection().QuerySingle<int>($"SELECT [id_calendar] FROM [dbo].[Calendar] WHERE [year] = {year} AND [month] = {month}");
            }
        }


        public static int GetTermId(DateTime dt, int id_employee, int cabinet_id)
        {
            
            using (GetConnection())
            {
                return (int)GetConnection().QuerySingleOrDefault<int>($"SELECT TOP 1 id_term from tbl_terms where id_employee = {id_employee} and date = '{dt.ToString("yyyy-MM-dd")}' and id_cabinet = {cabinet_id}");
            }
        }

        public static bool CheckIfEmployeeHavePlannedWork(int id_user)
        {
            using (GetConnection())
            {

                int? id_employee;

                List<Employee> listEmpl = MockEmployeeDataAccess.GetEmployeeDataBasedOnRole(10).ToList();

                if (listEmpl.Count > 0)
                    id_employee = listEmpl.FirstOrDefault(x => x.Id_user == id_user)?.Id_employee;
                else
                    return true;



                if (id_employee == null)
                    return false;

                List<Term> emplTerms = GetConnection().Query<Term>("SELECT * FROM [dbo].[tbl_terms] WHERE id_employee = @id_employee and date > @term_date", new { @id_employee = id_employee, @term_date = DateTime.Now.ToString("yyyy-MM-dd") }).ToList();

                if (emplTerms.Count < 1)
                {
                    return false;
                }

                return true;
            }
        }

        public static bool CheckIfCalendarHasTerms(int id_calendar)
        {
            using (GetConnection())
            {
                List<Term> calendarTerms = GetConnection().Query<Term>("SELECT * FROM [dbo].[tbl_terms] WHERE id_calendar = @id_calendar and date > @term_date", new { @id_calendar = id_calendar, @term_date = DateTime.Now.ToString("yyyy-MM-dd") }).ToList();

                if (calendarTerms.Count > 0)
                    return true;
                else
                    return false;
            }
        }
    }
}
