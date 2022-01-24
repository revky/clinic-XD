using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using formsClinicProject.DataAccess;

namespace formsClinicProject.Reviews
{
    public partial class ReviewPermissions : Form
    {
        public ReviewPermissions()
        {
            InitializeComponent();


        }

        private void ReviewPermissions_Load(object sender, EventArgs e)
        {
            comboBoxPermissionGroup.SelectedIndex = 0;
            loadDataGridViewListOfAssignedPermissions();
        }

        //Ładuje datagridview permisjami przypisanymi do grupy
        private void loadDataGridViewListOfAssignedPermissions()
        {
            dataGridViewListOfPermissions.Rows.Clear();

            List<string> permissionsList = PermissionsDataAccess.GetPermissionsForGroup(comboBoxPermissionGroup.SelectedItem.ToString());

            for (int i = 0; i < permissionsList.Count(); i++)
            {
                dataGridViewListOfPermissions.Rows.Add(permissionsList[i]);
            }

            dataGridViewListOfPermissions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        //Ładuje datagridview permisjami dostępnymi dla grupy (nieprzypisanych do niej)
        private void loadDataGridViewListOfAvaliblePermissions()
        {
            dataGridViewAvaliblePermissions.Rows.Clear();

            List<string> permissionsList = PermissionsDataAccess.GetPermissionsNotAssignedToGroup(comboBoxPermissionGroup.SelectedIndex + 1);

            if (permissionsList.Count > 0)
            {
                for (int i = 0; i < permissionsList.Count(); i++)
                {
                    dataGridViewAvaliblePermissions.Rows.Add(permissionsList[i]);
                }

                dataGridViewAvaliblePermissions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataGridViewListOfAssignedPermissions();
            loadDataGridViewListOfAvaliblePermissions();

            if(comboBoxPermissionGroup.SelectedItem.ToString() == "Administrator")
            {
                btnAddPermission.Visible = false;
                buttonDeletePermission.Visible = false;
            }
            else
            {
                btnAddPermission.Visible = true;
                buttonDeletePermission.Visible = true;
            }
        }

        //button od usuwania permisji
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string permissionName = permissionNameFromDataGridView(dataGridViewListOfPermissions);

                PermissionsDataAccess.DeletePermission(permissionName, comboBoxPermissionGroup.SelectedIndex + 1);

                loadDataGridViewListOfAssignedPermissions();
                loadDataGridViewListOfAvaliblePermissions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //button od dodawania permisji
        private void btnShowPermissions_Click(object sender, EventArgs e)
        {
            try
            {
                string permissionName = permissionNameFromDataGridView(dataGridViewAvaliblePermissions);

                PermissionsDataAccess.AddPermission(permissionName, comboBoxPermissionGroup.SelectedIndex + 1);

                loadDataGridViewListOfAssignedPermissions();
                loadDataGridViewListOfAvaliblePermissions();
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("One permission has to be selected");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Funkcja pobiera nazwę permisji z datagridview
        //Trzeba jej podać datagridview z którego chcemy pobrać nazwę
        private string permissionNameFromDataGridView(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0 || dgv.SelectedRows.Count != 1)
                throw new ArgumentNullException("One permission has to be selected");

            return dgv.CurrentRow.Cells[0].Value.ToString().Trim();

        }
    }
}
