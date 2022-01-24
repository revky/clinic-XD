using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace formsClinicProject.DataAccess
{
    //Autor: Mateusz
    //Helper zawiera gotowe, stałe elementy potrzebne do łączenia z bazą SQL Server
    public class Helper
    {
        //Zwraca connection string z pliku konfiguracyjnego na podstawie podanej nazwy
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        //Tworzy połączenie z bazą danych na podstawie connection string
        public static IDbConnection Connection()
        {
            return new System.Data.SqlClient.SqlConnection(Helper.CnnVal("formsClinicProject.Properties.Settings.Ustawienie"));
        }

        //Dla unit test
        public IDbConnection Connection2()
        {
            return new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["formsClinicProject.Properties.Settings.Ustawienie"].ConnectionString);
        }
    }
}
