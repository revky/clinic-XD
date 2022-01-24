using Dapper;
using formsClinicProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formsClinicProject.DataAccess
{
    class CalendarDataAccess
    {
        public static void CreateCalendar(DateTime dateOfCalendar)
        {
            //pobieranko z wprowadzonego dateTime roku i miesiaca w liczbach
            //bo w takim formacie musimy to podać bazie łatwiutko
            int year = dateOfCalendar.Year;
            int month = dateOfCalendar.Month;

            using (Helper.Connection())
            {
                Helper.Connection().Execute("INSERT INTO [dbo].[Calendar] VALUES (1, @year, @month)", new { year, month });
            }
        }

        public static List<Calendar> AllCalendars()
        {
            using (Helper.Connection())
            {
                return Helper.Connection().Query<Calendar>("  SELECT [id_calendar], [year], [month], [status] FROM [dbo].[Calendar] LEFT JOIN [dbo].[Calendar_status] ON [id_status]=[id_cal_status]").ToList().OrderBy(x => x.Year).ThenBy(x => x.Month).ToList();
            }
        }

        public static List<Term> TermsForOneEmployee(int id_employee, int id_calendar, DateTime date)
        {
            using (Helper.Connection())
            {
                return Helper.Connection().Query<Term>("EXEC [dbo].[DoctorsCalendar] @id_employee, @id_calendar, @term_date", new { @id_employee = id_employee, @id_calendar = id_calendar, @term_date = date.ToString("yyyy-MM-dd") }).ToList();
            }
        }

        public static bool CheckIfCalendarHasTerms(int id_calendar)
        {
            using (Helper.Connection())
            {
                List<Term> calendarTerms = Helper.Connection().Query<Term>("SELECT * FROM [dbo].[tbl_terms] WHERE id_calendar = @id_calendar and date > @term_date", new { @id_calendar = id_calendar, @term_date = DateTime.Now.ToString("yyyy-MM-dd") }).ToList();

                if (calendarTerms.Count > 0)
                    return true;
                else
                    return false;
            }
        }

        public static bool CheckIfEmployeeHavePlannedWork(int id_user)
        {
            using (Helper.Connection())
            {

                int? id_employee;

                List<Employee> listEmpl = EmployeeDataAccess.GetEmployeeDataBasedOnRole(10).ToList();

                if (listEmpl.Count > 0)
                    id_employee = listEmpl.FirstOrDefault(x => x.Id_user == id_user)?.Id_employee;
                else
                    return true;



                if (id_employee == null)
                    return false;

                List<Term> emplTerms = Helper.Connection().Query<Term>("SELECT * FROM [dbo].[tbl_terms] WHERE id_employee = @id_employee and date > @term_date", new { @id_employee = id_employee, @term_date = DateTime.Now.ToString("yyyy-MM-dd") }).ToList();

                if (emplTerms.Count < 1)
                {
                    return false;
                }

                return true;
            }
        }

        public static void CreateTerms(DateTime date, int start_hour, int end_hour, int id_employee, int id_cabinet, int id_calendar)
        {
            using (Helper.Connection())
            {
                Helper.Connection().Execute("EXEC [dbo].[DoctorsCalendarAddHours] @day, @start_hour, @end_hour, @id_employee, @id_cabinet, @id_calendar", new { @day = date.ToString("yyyy-MM-dd"), @start_hour = start_hour, @end_hour = end_hour, @id_employee = id_employee, @id_cabinet = id_cabinet, @id_calendar = id_calendar});
            }
        }

        //Usuwanie wizyt z całego dnia
        public static void DeleteTerms(DateTime date, int id_employee)
        {
            using (Helper.Connection())
            {
                Helper.Connection().Execute("DELETE FROM [dbo].[tbl_terms] WHERE [id_employee] = @id_employee and [date] = @date", new { @id_employee = id_employee, @date = date.ToString("yyyy-MM-dd")});
            }
        }

        //Usuwanie kalendarza, wraz z usuwaniem wizyt tego kalendarza
        public static void DeleteCalendar(int id_calendar)
        {
            using (Helper.Connection())
            {
                Helper.Connection().Execute("DELETE FROM [dbo].[tbl_terms] WHERE [id_calendar] = @id_calendar", new { @id_calendar = id_calendar });
                Helper.Connection().Execute("DELETE FROM [dbo].[Calendar] WHERE [id_calendar] = @id_calendar", new { @id_calendar = id_calendar });
            }
        }

        //Skrypt do tworzenia automatycznie kalendarza z domyślnymi godzinami
        public static void CreateTermsWeekly(DateTime date, int id_employee, int id_calendar)
        {
            using (Helper.Connection())
            {
                Helper.Connection().Execute("EXEC [dbo].[WeeklyBasicTermsForAllDoctorsParam] @StartDate, @id_calendar, @id_employee", new { @StartDate = date.ToString("yyyy-MM-dd"), @id_employee = id_employee, @id_calendar = id_calendar });
            }
        }
    }
}
