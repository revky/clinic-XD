using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;

namespace formsClinicProject.DataAccess
{
    public class CabinetDataAccess
    {
        //Dodawanie gabinetu do bazy danych
        public static void InputCabinet(Cabinet cabinet)
        {
            using (Helper.Connection())
            {
                Helper.Connection().Execute($"INSERT INTO [dbo].[cabinet] VALUES ( '{cabinet.Number}' )");
            }
        }


        //Edytowanie gabinetu w bazie danych
        public static void UpdateCabinet(Cabinet cabinet)
        {
            using (Helper.Connection())
            {
                Helper.Connection().Execute($"UPDATE [dbo].[cabinet] SET [number] = '{cabinet.Number}' WHERE [id_office] = '{cabinet.Id}'");

            }
        }

        //Usuwanie gabinetu z bazy danych
        public static void DeleteCabinet(Cabinet cabinet)
        {
            using (Helper.Connection())
            {
                Helper.Connection().Execute($"DELETE FROM [dbo].[cabinet] WHERE [number] = '{cabinet.Number}'");

            }
        }

        public static List<Cabinet> ListOfCabinets()
        {
            using (Helper.Connection())
            {
                List<Cabinet> Cabinetes = Helper.Connection().Query<Cabinet>("SELECT * FROM [clinic4].[dbo].[Cabinet]").ToList();
                List<Cabinet> SortedList = Cabinetes.OrderBy(o => o.Number).ToList();
                return SortedList;
            }
        }



        //Pobiera gabinet z bazy na podstawie numeru
        public static Cabinet GetCabinetByNum(int number)
        {
            using (Helper.Connection())
            {
                return (Cabinet)Helper.Connection().QuerySingleOrDefault<Cabinet>($"SELECT * FROM [clinic4].[dbo].[Cabinet] WHERE [number] = {number}");
            }
        }

        public static bool IsCabinetAvailable(int number, string dataSet)
        {
            using (Helper.Connection())
            {
                Cabinet cab =  (Cabinet)Helper.Connection().QuerySingleOrDefault<Cabinet>($"SELECT * FROM [clinic4].[dbo].[{dataSet}] WHERE [number] = {number}");
                if (cab != null) return true;
                else return false;
                
            }
        }

        public static bool IsCabinetAvailableDaily(int id_cabinet, DateTime term)
        {
            string date = "'" + term.ToString("yyyy-MM-dd") + "'";

            using (Helper.Connection())
            {
                int result = (int)Helper.Connection().QuerySingleOrDefault<int>($"SELECT COUNT(*) FROM [clinic4].[dbo].[tbl_terms] WHERE [id_cabinet] = {id_cabinet} and [date] = " + date + "  ");
                if (result > 0) return false;
                else return true;



            }
        }
        public static bool CanIAddCabinet()
        {
            using (Helper.Connection())
            {
                int cabinetNumber = (int)Helper.Connection().QuerySingleOrDefault<int>($"SELECT COUNT(*) FROM [clinic4].[dbo].[Cabinet]");
                if (cabinetNumber >= 20) return false;
                else { return true; }
            }
        }
        //zwraca listę dostępnych dla danego dnia gabinetów
        public static List<Cabinet> ListOfAvalibleCabinets(DateTime term)
        {
            using (Helper.Connection())
            {
                List<Cabinet> Cabinetes = Helper.Connection().Query<Cabinet>("SELECT * FROM [clinic4].[dbo].[Cabinet]").ToList();
                List<Cabinet> SortedList = Cabinetes.OrderBy(o => o.Number).Where(x => IsCabinetAvailableDaily(x.Id, term) == true).ToList();
                return SortedList;
            }
        }








    }
}


