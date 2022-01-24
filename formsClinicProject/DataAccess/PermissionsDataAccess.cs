using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace formsClinicProject.DataAccess
{
    class PermissionsDataAccess
    {
        //Funkcja zwraca wszystkie uprawnienia przypisane do podanej nazwy grupy permisji
        //Jeżeli pobieramy permisje dla administratora to zwróci listę wszystkich możliwych
        public static List<string> GetPermissionsForGroup(string permissionGroup)
        {
            using (Helper.Connection())
            {
                List<string> allPermissions =  Helper.Connection().Query<string>($"SELECT [Permission] FROM [dbo].[Permission]").ToList();
                List<string> groupPermissions = Helper.Connection().Query<string>($"SELECT [Permission] FROM [dbo].[v_GROUPS_PERMISSIONS] WHERE [Group] = '{permissionGroup}'").ToList();

                if (groupPermissions.Count > 0)
                {
                    if (groupPermissions[0] == "*")
                    {
                        allPermissions.Remove("*");
                        return allPermissions;
                    }
                    else
                    {
                        groupPermissions.Remove("*");
                        return groupPermissions;
                    }
                }
                else
                    return new List<string>();

            }
        }

        //Funckja zwraca permisje które nie są przypisane do danej grupy permisji (tutaj wymagane jest id grupy)
        //Jeżeli pobieramy dostępne dla administratora permisje to zwraca pustą listę (ma przypisane wszystkie)
        public static List<string> GetPermissionsNotAssignedToGroup(int permissionGroupId)
        {
            using (Helper.Connection())
            {
                List<string> avaliblePermissions =  Helper.Connection().Query<string>($"SELECT [permission] FROM [dbo].[Permission] WHERE [id_permission] not in (SELECT [id_permission] FROM [dbo].[Permissions_list] WHERE [id_Group] = {permissionGroupId})").ToList();

                if (!avaliblePermissions.Contains("*"))
                    return new List<string>();
                else
                {
                    avaliblePermissions.Remove("*");
                    return avaliblePermissions;
                }

            }
        }

        //Pobiera Id permisji po jej nazwie
        public static int GetPermissionId(string permissionName)
        {
            using (Helper.Connection())
            {
                return Helper.Connection().QuerySingleOrDefault<int>($"SELECT [id_permission] FROM [dbo].[Permission] WHERE [permission] = @permissionName", new { permissionName });
            }
        }

        //Usuwa permisje z grupy permisji na podstawie jej nazwy i id grupy
        public static void DeletePermission(string permissionName, int permissionGroupId)
        {
            using (Helper.Connection())
            {
                int permissionId = GetPermissionId(permissionName);

                Helper.Connection().Execute($"DELETE FROM [dbo].[Permissions_list] WHERE [id_Group] = {permissionGroupId} and [id_permission] = {permissionId}");
            }
        }

        //Dodaje permisje do grupy permisji na podstawie jej nazwy i id grupy
        public static void AddPermission(string permissionName, int permissionGroupId)
        {
            using (Helper.Connection())
            {
                int permissionId = GetPermissionId(permissionName);

                Helper.Connection().Execute($"INSERT INTO [dbo].[Permissions_list] VALUES( {permissionId}, {permissionGroupId})");
            }
        }

    }
}
