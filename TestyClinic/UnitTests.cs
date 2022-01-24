using formsClinicProject;
using System;
using System.Data;
using System.Data.SqlClient;
using Xunit;

namespace TestyClinic
{
    public class UnitTests
    {

        private formsClinicProject.DataAccess.UserDataAccess userDataAccess;

        public UnitTests()
        {
            userDataAccess = new formsClinicProject.DataAccess.UserDataAccess();
        }

        SqlConnection sqlCon = new SqlConnection(@"Data Source=den1.mssql8.gear.host;Initial Catalog=clinic4;Persist Security Info=True;User ID=clinic4;Password=Adminkliniki%");

        public static IDbConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=den1.mssql8.gear.host;Initial Catalog=clinic4;Persist Security Info=True;User ID=clinic4;Password=Adminkliniki%");
        }

        //LOG_1.2
        [Fact]
        public void LOG_1_2()
        {

            User expectedUser = null;

            User loggedUser = MockUserDataAccess.LoginUser("zajacj", "any text string");

            Assert.Equal(expectedUser, loggedUser);
        }

        //LOG_1.3
        [Fact]
        public void LOG_1_3()
        {

            SqlConnection sqlCon = new SqlConnection(@"Data Source=den1.mssql8.gear.host;Initial Catalog=clinic4;Persist Security Info=True;User ID=clinic4;Password=Adminkliniki%");

            User expectedUser = null;

            User loggedUser = MockUserDataAccess.LoginUser("jzajac", "1111");

            Assert.Equal(expectedUser, loggedUser);
        }

        //LOG_1.4
        [Fact]
        public void LOG_1_4()
        {

            SqlConnection sqlCon = new SqlConnection(@"Data Source=den1.mssql8.gear.host;Initial Catalog=clinic4;Persist Security Info=True;User ID=clinic4;Password=Adminkliniki%");

            User expectedUser = null;

            User loggedUser = MockUserDataAccess.LoginUser("", "");

            Assert.Equal(expectedUser, loggedUser);
        }

        //LOG_3.1
        [Fact]
        public void LOG_3_1()
        {

            User user = new User();

            bool expectedResult = user.SendEmailToUser("222oleksikmateusz@gmail.com", "Welcome to .Net Medical Clinic System", $"Your account has been created.\nYour login: Before first logging in, chose Forgot Password option to set your password");

            Assert.True(expectedResult);
        }

        //LOG_4.2
        [Fact]
        public void LOG_4_2()
        {
            Assert.True(User.PasswordValidation("!Aa1234567"));
        }

        //LOG_4.5
        [Fact]
        public void LOG_4_5()
        {
            Assert.False(User.PasswordValidation("Cc!123"));
        }

        //LOG_4.6
        [Fact]
        public void LOG_4_6()
        {
            Assert.False(User.PasswordValidation("Cc!12456789BbD!?"));
        }

        //LOG_4.7
        [Fact]
        public void LOG_4_7()
        {
            Assert.False(User.PasswordValidation("Marmolada23"));
        }

        //LOG_4.8
        [Fact]
        public void LOG_4_8()
        {
            Assert.False(User.PasswordValidation("Marmolada!?"));
        }

        //LOG_4.9
        [Fact]
        public void LOG_4_9()
        {
            Assert.False(User.PasswordValidation(""));
        }

        //LOG_13.1
        [Fact]
        public void LOG_13_1()
        {
            //Ustawia użytkownikowi login na Daroo123
            User expectedUser = MockUserDataAccess.GetUserByLogin("Daroo125", GetConnection());
            expectedUser.Login = "Daroo123";
            MockUserDataAccess.UpdateUser(expectedUser);

            //Zmienia użytkownikowi login na Daroo125
            expectedUser = MockUserDataAccess.GetUserByLogin("Daroo123", GetConnection());
            expectedUser.Login = "Daroo125";
            MockUserDataAccess.UpdateUser(expectedUser);

            User actualUser = MockUserDataAccess.GetUserByLogin("Daroo125", GetConnection());

            Assert.Equal(expectedUser.ToString(), actualUser.ToString());
        }

        //LOG_13.3
        [Fact]
        public void LOG_13_3()
        {
            //Ustawia użytkownika na aktywnego bo tego wymaga test
            MockUserDataAccess.ActivateUser(6);

            //Dezaktywuje użytkownika - to jest cel testu
            MockUserDataAccess.DeactivateUser(6);

            int actualResult = MockUserDataAccess.GetUserStatus(6);
            int expectedResult = 2;

            Assert.Equal(expectedResult, actualResult);
        }

        //LOG_13.4
        [Fact]
        public void LOG_13_4()
        {
            //Ustawia użytkownika na nieaktywnego bo tego wymaga test
            MockUserDataAccess.DeactivateUser(6);

            //Aktywuje użytkownika - to jest cel testu
            MockUserDataAccess.ActivateUser(6);

            int actualResult = MockUserDataAccess.GetUserStatus(6);
            int expectedResult = 1;

            Assert.Equal(expectedResult, actualResult);
        }

        //LOG_13.6
        [Fact]
        public void LOG_13_6()
        {
            User origianlUser = MockUserDataAccess.GetUserById(16);
            origianlUser.Id_permission = 3;
            MockUserDataAccess.UpdateUser(origianlUser);

            User editedUser = MockUserDataAccess.GetUserById(16);
            editedUser.Id_permission = 4;
            MockUserDataAccess.UpdateUser(editedUser);

            int expectedPermission = 4;
            int actualPermission = MockUserDataAccess.GetUserById(16).Id_permission;

            Assert.Equal(expectedPermission, actualPermission);
        }

        //LOG_20.1
        [Fact]
        public void LOG_20_1()
        {
            MockUserDataAccess.ResetPassword("!Cc123456789", 16);

            string expectedPassword = "!Cc123456789";
            string actualPassword = MockUserDataAccess.GetUserById(16).Password;

            Assert.Equal(expectedPassword, actualPassword);
        }




        //LOG_7.1
        [Fact]
        public void LOG_7_1()
        {
            Employee employee = new Employee("Marek", "Karasiński", "505805105", "04267313935", "marek23@gmail.com", null, "Nurse", new DateTime(1968, 7, 5));
            MockEmployeeDataAccess.InputEmployee(employee);
            bool result = MockEmployeeDataAccess.doesEmployeeExist(employee);
            if (result == true)
                MockEmployeeDataAccess.deleteEmployee(employee);

            Assert.True(result);
        }

        //LOG_7.2
        [Fact]
        public void LOG_7_2()
        {
            Employee employee = new Employee("Marek", "Karasiński", "505805105", "04267313935", "marek23@gmail.com", "Dermatology", "Doctor", new DateTime(1968, 7, 5));
            MockEmployeeDataAccess.InputEmployee(employee);
            bool result = MockEmployeeDataAccess.doesEmployeeExist(employee);
            if (result == true)
                MockEmployeeDataAccess.deleteEmployee(employee);

            Assert.True(result);
        }


        //LOG_7.3
        [Fact]
        public void LOG_7_3()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Employee("Marek", "Karasiński", "505805105", "04267313935", "marek23gmail.com", "Dermatology", "Doctor", new DateTime(1968, 7, 5)));
        }

        //LOG_7.4
        [Fact]
        public void LOG_7_4()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Employee("Marek", "Karasiński", "50580510", "04267313935", "marek23gmail.com", "Dermatology", "Doctor", new DateTime(1968, 7, 5)));
        }

        //LOG_7.5
        [Fact]
        public void LOG_7_5()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Employee("Marek", "Karasiński", "505805105", "042673935", "marek23gmail.com", "Dermatology", "Doctor", new DateTime(1968, 7, 5)));
        }

        //LOG_7.7
        [Fact]
        public void LOG_7_7()
        {
            Random rnd = new Random();
            Employee employee = new Employee("Marek", "Karasiński", "505805105", "04267313935", "marek23@gmail.com", null, "Nurse", new DateTime(1968, 7, 5));
            MockEmployeeDataAccess.InputEmployee(employee);

            User user = new User("marek25", rnd.Next(10000000, 999999999).ToString(), 3);
            MockUserDataAccess.InputUser(user);

            employee.Id_user = MockUserDataAccess.LoginUser(user.Login, user.Password).Id_user;
            MockEmployeeDataAccess.UpdateUserIdForEmployee(employee);

            bool result = MockEmployeeDataAccess.doesEmployeeWithUserExist(employee);
            if (result == true)
            {
                MockEmployeeDataAccess.deleteEmployeeWithUser(employee);
                MockUserDataAccess.deleteUser(user);
            }

            Assert.True(result);
        }

        //LOG_7.9
        [Fact]
        public void LOG_7_9()
        {
            Assert.Throws<ArgumentNullException>(() => new Employee("Marek", "", "505805105", "042673935", "", "Dermatology", "Doctor", new DateTime(1968, 7, 5)));
        }

        //LOG_8_1
        [Fact]
        public void LOG_8_1()
        {
            Employee employee = new Employee("Marek", "Karasiński", "505805105", "04267313935", "marek23@gmail.com", null, "Nurse", new DateTime(1968, 7, 5));
            MockEmployeeDataAccess.InputEmployee(employee);
            Employee editedEmployee = new Employee("Marek", "Karasiński", "505805105", "04267313935", "marek24@gmail.com", null, "Nurse", new DateTime(1968, 7, 5));
            editedEmployee.Id_employee = MockEmployeeDataAccess.GetEmployeeIdBasedOnData(employee);
            MockEmployeeDataAccess.UpdateEmployee(editedEmployee);
            bool result = MockEmployeeDataAccess.doesEmployeeExist(editedEmployee);
            if (result == true)
                MockEmployeeDataAccess.deleteEmployee(editedEmployee);

            Assert.True(result);
        }

        //LOG_8_5
        [Fact]
        public void LOG_8_5()
        {
            Employee employee = new Employee("Marek", "Karasiński", "505805105", "04267313935", "marek23@gmail.com", null, "Nurse", new DateTime(1968, 7, 5));
            MockEmployeeDataAccess.InputEmployee(employee);
            Employee editedEmployee = new Employee("Marek", "Karasiński", "505805105", "04267313935", "marek23@gmail.com", null, "Employee of registration", new DateTime(1968, 7, 5));
            editedEmployee.Id_employee = MockEmployeeDataAccess.GetEmployeeIdBasedOnData(employee);
            MockEmployeeDataAccess.UpdateEmployee(editedEmployee);
            bool result = MockEmployeeDataAccess.doesEmployeeExist(editedEmployee);
            if (result == true)
                MockEmployeeDataAccess.deleteEmployee(editedEmployee);

            Assert.True(result);
        }

        //LOG_9.1
        [Fact]
        public void LOG_9_1()
        {
            int expectedEmployeeId = 19;


            MockEmployeeDataAccess.DeactivateEmployee(expectedEmployeeId);

            int changed_status = MockEmployeeDataAccess.GetEmployeeStatusBasedOnId(expectedEmployeeId);

            Assert.Equal(2, changed_status);
        }

        //LOG_9.5
        [Fact]
        public void LOG_9_5()
        {
            int expectedEmployeeId = 19;
            int expectedUserId = MockEmployeeDataAccess.GetIdUserByEmployeeId(expectedEmployeeId);

            MockEmployeeDataAccess.DeactivateEmployee(expectedEmployeeId);

            int changed_emp_status = MockEmployeeDataAccess.GetEmployeeStatusBasedOnId(expectedEmployeeId);
            int changed_user_status = MockUserDataAccess.getUserStatusById(expectedUserId);

            var T1 = new Tuple<int, int>(changed_emp_status, changed_user_status);
            var T2 = new Tuple<int, int>(2, 2);

            Assert.Equal(T2, T1);
        }




        //LOG_21.1
        [Fact]
        public void LOG_21_1()
        {
            int expectedCabinetNumber = 6;
            Cabinet expectedCabinet = new Cabinet(expectedCabinetNumber);

            MockCabinetDataAccess.InputCabinet(expectedCabinet);
            bool result = MockCabinetDataAccess.doesCabinetExist(expectedCabinet);
            if (result == true)
                MockCabinetDataAccess.DeleteCabinet(expectedCabinet);

            Assert.True(result);
        }

        //LOG_21.3
        [Fact]
        public void LOG_21_3()
        {
            int expectedCabinetNumber = 21;
            Cabinet expectedCabinet = new Cabinet(expectedCabinetNumber);

            bool result = MockCabinetDataAccess.InputCabinet(expectedCabinet);
            if (result == true)
                MockCabinetDataAccess.DeleteCabinet(expectedCabinet);

            Assert.False(result);
        }


        //LOG_22.1
        [Fact]
        public void LOG_22_1()
        {
            int expectedCabinetNumber = 22;
            Cabinet expectedCabinet = new Cabinet(expectedCabinetNumber);

            MockCabinetDataAccess.DeleteCabinet(expectedCabinet);
            bool result = MockCabinetDataAccess.doesCabinetExist(expectedCabinet);


            Assert.False(result);
        }




        //LOG_22.2
        [Fact]
        public void LOG_22_2()
        {
            int expectedCabinetNumber = 1;
            Cabinet expectedCabinet = new Cabinet(expectedCabinetNumber);

            MockCabinetDataAccess.DeleteCabinet(expectedCabinet);
            bool result = MockCabinetDataAccess.doesCabinetExist(expectedCabinet);


            Assert.True(result);
        }

        //LOG_19.1
        [Fact]
        public void LOG_19_1()
        {
            int id_permission_group = 3;
            int id_user = 36;
            string login = "darkson1";

            User user = new User(id_user, login, id_permission_group);
            MockUserDataAccess.UpdateUser(user);

            int result = MockUserDataAccess.getUserGroupOfPermissionsById(id_user);

            Assert.Equal(id_permission_group, result);

        }

            //LOG_11.5
            [Fact]
            public void LOG_11_5()
            {
                int expectedEmployeeId = 19;
                MockEmployeeDataAccess.ActivateEmployee(expectedEmployeeId);

                int changed_status = MockEmployeeDataAccess.GetEmployeeStatusBasedOnId(expectedEmployeeId);

                Assert.Equal(1, changed_status);
            }
        }
    }

