using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using formsClinicProject;
using formsClinicProject.DataAccess;
using formsClinicProject.Model;
using System.Data;

namespace TestyClinic
{
    public class UnitTests_dev
    {
        //USR_1.1
        [Fact]
        public void USR_1_1()
        {
            Assert.Throws<ArgumentNullException>(() => new User(1, "", "!Cc123456789", 1));
        }

        //USR_1.2
        [Fact]
        public void USR_1_2()
        {
            Assert.Throws<ArgumentNullException>(() => new User(1, "test_user1", "", 1));
        }

        //USR_1.3
        [Fact]
        public void USR_1_3()
        {
            Assert.Throws<ArgumentNullException>(() => new User(1, "test_user1", "!Cc123456789", 0));
        }

        //USR_1.4
        [Fact]
        public void USR_1_4()
        {
            Assert.Throws<ArgumentException>(() => new User(1, "test_user1", "Cc!12456789BbD!?2222", 2));
        }

        //USR_1.5
        [Fact]
        public void USR_1_5()
        {
            Assert.Throws<ArgumentException>(() => new User(1, "test_user1", "Cc!12", 2));
        }

        //USR_1.6
        [Fact]
        public void USR_1_6()
        {
            Assert.Throws<ArgumentException>(() => new User(1, "test_user1", "2Cc123456789", 2));
        }

        //USR_1.7
        [Fact]
        public void USR_1_7()
        {
            Assert.Throws<ArgumentException>(() => new User(1, "test_user1", "Cc!ABCDEFG", 2));
        }

        //USR_1.8
        [Fact]
        public void USR_1_8()
        {
            User expectedUser = new User(1, "test_user1", "!Cc123456789", 2);
            Assert.NotNull(expectedUser);
        }

        //CAB_1.1
        [Fact]
        public void CAB_1_1()
        {
            Assert.Throws<ArgumentException>(() => new Cabinet(0));
        }

        //USR_2.1
        [Fact]
        public void USR_2_1()
        {
            int amountOfUsers = UserDataAccess.GetListOfUsersFromView().Rows.Count;

            Assert.True(amountOfUsers > 0);
        }

        //USR_2.2
        [Fact]
        public void USR_2_2()
        {
            User actualUser = MockUserDataAccess.ForgotPassword("NotG78", "notgozdzik@gmail.com");
            User expectedUser = new User(2, "NotG78", "531429547", 1);

            Assert.Equal(expectedUser.ToString(), actualUser.ToString());
        }

        //USR_2.3
        [Fact]
        public void USR_2_3()
        {
            User actualUser = MockUserDataAccess.ForgotPassword("NotG78", "notoleksik@gmail.com");

            Assert.Null(actualUser);
        }

        //USR_2.4
        [Fact]
        public void USR_2_4()
        {
            User actualUser = MockUserDataAccess.ForgotPassword("NotG780", "notgozdzik@gmail.com");

            Assert.Null(actualUser);
        }

        //USR_2.5
        [Fact]
        public void USR_2_5()
        {
            User actualUser = MockUserDataAccess.ForgotPassword("NotG780", "notoleksik@gmail.com");

            Assert.Null(actualUser);
        }


        //EMPL_1.1 {
        [Fact]
        public void EMPL_1_1()
        {
            Assert.Throws<ArgumentNullException>(() => new Employee(1, "", "Test", "828392940", "48019301920", "test@gmail.com", null, "3", new DateTime(1994, 08, 02)));
        }

        //EMPL_1.2 {
        [Fact]
        public void EMPL_1_2()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Employee(1, "janek", "Test", "828392940", "48019301920", "test@gmail.com", null, "3", new DateTime(1994, 08, 02)));
        }

        //EMPL_1.3 {
        [Fact]
        public void EMPL_1_3()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Employee(1, "Ja", "Test", "828392940", "48019301920", "test@gmail.com", null, "3", new DateTime(1994, 08, 02)));
        }

        //EMPL_1.4 {
        [Fact]
        public void EMPL_1_4()
        {
            Assert.Throws<ArgumentNullException>(() => new Employee(1, "Marek", "", "828392940", "48019301920", "test@gmail.com", null, "3", new DateTime(1994, 08, 02)));
        }

        //EMPL_1.5 {
        [Fact]
        public void EMPL_1_5()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Employee(1, "Marek", "test", "828392940", "48019301920", "test@gmail.com", null, "3", new DateTime(1994, 08, 02)));
        }

        //EMPL_1.6 {
        [Fact]
        public void EMPL_1_6()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Employee(1, "Marek", "Te", "828392940", "48019301920", "test@gmail.com", null, "3", new DateTime(1994, 08, 02)));
        }

        //EMPL_1.7 {
        [Fact]
        public void EMPL_1_7()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Employee(1, "Marek", "Test", "8283929", "48019301920", "test@gmail.com", null, "3", new DateTime(1994, 08, 02)));
        }

        //EMPL_1.8 {
        [Fact]
        public void EMPL_1_8()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Employee(1, "Marek", "Test", "8283929aa", "48019301920", "test@gmail.com", null, "3", new DateTime(1994, 08, 02)));
        }

        //EMPL_1.9 {
        [Fact]
        public void EMPL_1_9()
        {
            Assert.Throws<ArgumentNullException>(() => new Employee(1, "Marek", "Test", "828392944", "", "test@gmail.com", null, "3", new DateTime(1994, 08, 02)));
        }

        //EMPL_1.10 {
        [Fact]
        public void EMPL_1_10()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Employee(1, "Marek", "Test", "828392944", "222222", "test@gmail.com", null, "3", new DateTime(1994, 08, 02)));
        }

        //EMPL_1.11 {
        [Fact]
        public void EMPL_1_11()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Employee(1, "Marek", "Test", "828392944", "487aa81cc37", "test@gmail.com", null, "3", new DateTime(1994, 08, 02)));
        }

        //EMPL_1.12 {
        [Fact]
        public void EMPL_1_12()
        {
            Assert.Throws<ArgumentNullException>(() => new Employee(1, "Marek", "Test", "828392944", "48019312220", "", null, "3", new DateTime(1994, 08, 02)));
        }

        //EMPL_1.13 {
        [Fact]
        public void EMPL_1_13()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Employee(1, "Marek", "Test", "828392944", "48019312220", "test.gmail.com", null, "3", new DateTime(1994, 08, 02)));
        }

        //EMPL_1.14 {
        [Fact]
        public void EMPL_1_14()
        {
            Assert.Throws<ArgumentNullException>(() => new Employee(1, "Marek", "Test", "828392944", "48019312220", "test@gmail.com", null, null, new DateTime(1994, 08, 02)));
        }

        //EMPL_1.15 {
        [Fact]
        public void EMPL_1_15()
        {
            Assert.Throws<ArgumentNullException>(() => new Employee(1, "Marek", "Test", "828392944", "48019312220", "test@gmail.com", null, "3", new DateTime()));
        }

        //EMPL_1.16 {
        [Fact]
        public void EMPL_1_16()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Employee(1, "Marek", "Test", "828392944", "48019312220", "test@gmail.com", null, "3", DateTime.Now.AddDays(1)));
        }

        //CAL_1.1
        [Fact]
        public void CAL_1_1()
        {
            DateTime dt = new DateTime(2025,6,1);
            MockCalendarDataAccess.CreateCalendar(dt);
            int? id = MockCalendarDataAccess.GetIdCallendar(dt);
            Assert.NotNull(id);
            MockCalendarDataAccess.DeleteCalendar(id.GetValueOrDefault());
        }

        //CAL_1.3
        [Fact]
        public void CAL_1_3()
        {
            List<Calendar> calendars = MockCalendarDataAccess.AllCalendars();
            Assert.True(calendars.Count > 0);
        }

        //TERM_2.1
        [Fact]
        public void TERM_2_1()
        {
            List<Term> terms = MockCalendarDataAccess.TermsForOneEmployee(12, 9, new DateTime(2021, 6, 10));
            Assert.True(terms.Count > 0);
        }

        //CAL1.2
        [Fact]
        public void CAL_1_2()
        {
            DateTime dt = new DateTime(2024, 6, 1);
            MockCalendarDataAccess.CreateCalendar(dt);
            int? id = MockCalendarDataAccess.GetIdCallendar(dt);
            MockCalendarDataAccess.DeleteCalendar(id.GetValueOrDefault());
            Assert.Throws<InvalidOperationException>(() => MockCalendarDataAccess.GetIdCallendar(dt));
        }

        //CAL1.4
        [Fact]
        public void CAL_1_4()
        {
            DateTime dt = new DateTime(2024, 6, 1);
            MockCalendarDataAccess.CreateCalendar(dt);

            int id = MockCalendarDataAccess.GetIdCallendar(dt);
            bool status = MockCalendarDataAccess.CheckIfCalendarHasTerms(id);
            Assert.False(status);
            MockCalendarDataAccess.DeleteCalendar(id);
        }

        //TERM1.1
        [Fact]
        public void TERM_1_1()
        {
            DateTime dt = new DateTime(2023, 3, 1);
            MockCalendarDataAccess.CreateCalendar(dt);
            int? id = MockCalendarDataAccess.GetIdCallendar(dt);
            MockCalendarDataAccess.CreateTerms(dt, 7, 8, 12, 102, id.GetValueOrDefault());
            int? id_t = MockCalendarDataAccess.GetTermId(dt, 12, 102);


            Assert.NotNull(id_t);
            MockCalendarDataAccess.DeleteTerms(dt, 12);
            MockCalendarDataAccess.DeleteCalendar(id.GetValueOrDefault());
        }

        //TERM1.2
        [Fact]
        public void TERM_1_2()
        {
            DateTime dt = new DateTime(2023, 3, 1);
            MockCalendarDataAccess.CreateCalendar(dt);
            int? id = MockCalendarDataAccess.GetIdCallendar(dt);
            MockCalendarDataAccess.CreateTerms(dt, 7, 8, 12, 102, id.GetValueOrDefault());
            int? id_t = MockCalendarDataAccess.GetTermId(dt, 12, 102);


            MockCalendarDataAccess.DeleteTerms(dt, 12);
            MockCalendarDataAccess.DeleteCalendar(id.GetValueOrDefault());

            int? id_t_new = MockCalendarDataAccess.GetTermId(dt, 12, 102);
            Assert.NotEqual(id_t_new, id_t);
        }
        


        [Fact]
        //TERM_3.1
        public void TERM_3_1()
        {
            Assert.True(MockCalendarDataAccess.CheckIfEmployeeHavePlannedWork(5));
        }
        
        [Fact]
        //TERM_3.2
        public void TERM_3_2()
        {
            Assert.False(MockCalendarDataAccess.CheckIfEmployeeHavePlannedWork(41));
        }
    }
}
