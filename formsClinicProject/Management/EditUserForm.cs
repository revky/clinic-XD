using System;
using System.Windows.Forms;
using formsClinicProject.DataAccess;

namespace formsClinicProject
{
    public partial class EditUserForm : Form
    {

        int editedUserId;

        public EditUserForm(User editedUser)
        {
            InitializeComponent();

            editedUserId = editedUser.Id_user;
            txtboxLogin.Text = editedUser.Login;
            comboBoxPermissions.SelectedIndex = editedUser.Id_permission - 1;
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User(editedUserId, txtboxLogin.Text, comboBoxPermissions.SelectedIndex + 1);
                UserDataAccess.UpdateUser(user);
                MessageBox.Show("User's data changed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ReviewUsersForm louf = new ReviewUsersForm(AdminPanelForm.loggedUserIdv2);
            DockHelper.putFormInDock(louf, MdiParent);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReviewUsersForm louf = new ReviewUsersForm(AdminPanelForm.loggedUserIdv2);
            DockHelper.putFormInDock(louf, MdiParent);
        }
    }
}
