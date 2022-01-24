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
    class MockCabinetDataAccess
    {

        public static IDbConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=den1.mssql8.gear.host;Initial Catalog=clinic4;Persist Security Info=True;User ID=clinic4;Password=Adminkliniki%");
        }

        public static bool doesCabinetExist(Cabinet cabinet)
        {
            using (GetConnection())
            {


                Cabinet cab = (Cabinet)GetConnection().QuerySingleOrDefault<Cabinet>($"SELECT * FROM [clinic4].[dbo].[Cabinet] WHERE [number] = {cabinet.Number}");
                if (cab != null) return true;
                else return false;
            }
        }
        public static bool IsCabinetAvailable(int number, string dataSet)
        {
            using (GetConnection())
            {

                Cabinet cab = (Cabinet)GetConnection().QuerySingleOrDefault<Cabinet>($"SELECT * FROM [clinic4].[dbo].[{dataSet}] WHERE [number] = {number}");
                if (cab != null) return true;
                else return false;

            }
        }




        //Dodawanie gabinetu do bazy danych
        public static bool InputCabinet(Cabinet cabinet)
            {
            if (!doesCabinetExist(cabinet))
            {
                using (GetConnection())
                {
                    GetConnection().Execute($"INSERT INTO [dbo].[cabinet] VALUES ( '{cabinet.Number}' )");
                    return true;
                }
            }
            else
            {
                return false;
            }
           
            }


            //Edytowanie gabinetu w bazie danych
            public static void UpdateCabinet(Cabinet cabinet)
            {
                using ( GetConnection())
                {
                     GetConnection().Execute($"UPDATE [dbo].[cabinet] SET [number] = '{cabinet.Number}' WHERE [id_office] = '{cabinet.Id}'");

                }
            }

            //Usuwanie gabinetu z bazy danych
            public static void DeleteCabinet(Cabinet cabinet)
            {
            if (IsCabinetAvailable(cabinet.Number, "v_FREE_CABINETS"))
            {


                using (GetConnection())
                {
                    GetConnection().Execute($"DELETE FROM [dbo].[cabinet] WHERE [number] = '{cabinet.Number}'");

                }
           
            }
            else
            {
         
            }
            }

            public static List<Cabinet> ListOfCabinets()
            {
                using ( GetConnection())
                {
                    List<Cabinet> Cabinetes =  GetConnection().Query<Cabinet>("SELECT * FROM [clinic4].[dbo].[Cabinet]").ToList();
                    List<Cabinet> SortedList = Cabinetes.OrderBy(o => o.Number).ToList();
                    return SortedList;
                }
            }

        


            //Pobiera gabinet z bazy na podstawie numeru
            public static Cabinet GetCabinetByNum(int number)
            {
                using ( GetConnection())
                {
                    return (Cabinet) GetConnection().QuerySingleOrDefault<Cabinet>($"SELECT * FROM [clinic4].[dbo].[Cabinet] WHERE [number] = {number}");
                }
            }

    














    }
    }
