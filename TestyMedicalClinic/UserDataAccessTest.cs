using formsClinicProject;
using System;
using formsClinicProject.DataAccess;
using System.Data.SqlClient;
using Xunit;

namespace TestyMedicalClinic
{
    public class UserDataAccessTest
    {
        [Fact]
        public void TestMethod1()
        {
            User expectedUser = new User(1, "admin", "admin", "admin@admin.com", "642814264", "Administrator");
            
            string login, haslo;

            login = "admin";
            haslo = "admin";

            Assert.Equal(expectedUser, UserDataAccess.LoginUser(login, haslo));
        }
    }
}
