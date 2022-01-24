using System;
using System.Windows.Forms;
using formsClinicProject.DataAccess;

namespace formsClinicProject
{
    public partial class AddUserForm : Form
    {
        Employee employeeToRegister;

        public AddUserForm(Employee employeeToRegister)
        {
            InitializeComponent();

            comboBoxPermission.SelectedIndex = 0;
            this.employeeToRegister = employeeToRegister;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Dodawanie użytkownika do bazy danych
            try
            {
                Random rnd = new Random();

                User newUser = new User(txtboxLogin.Text, rnd.Next(10000000, 999999999).ToString(), comboBoxPermission.SelectedIndex + 1);

                UserDataAccess.InputUser(newUser);

                employeeToRegister.Id_user = UserDataAccess.LoginUser(newUser.Login, newUser.Password).Id_user; //No dramat to jest
                EmployeeDataAccess.UpdateUserIdForEmployee(employeeToRegister);

                newUser.SendEmailToUser(employeeToRegister.Email, "Welcome to .Net Medical Clinic System", $"Your account has been created.\nYour login: {newUser.Login}.\nBefore first logging in, chose Forgot Password option to set your password");

                MessageBox.Show("Dodano użytkownika");

                ReviewUsersForm ruf = new ReviewUsersForm(AdminPanelForm.loggedUserIdv2);
                DockHelper.putFormInDock(ruf, MdiParent);
            }
            catch (Exception)
            {
                MessageBox.Show("Użytkownik o podanym loginie istnieje już w bazie danych.", "Oopsie!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            openReviewUsersForm();
        }

        void openReviewUsersForm()
        {
            ReviewUsersForm ruf = new ReviewUsersForm(AdminPanelForm.loggedUserIdv2);
            DockHelper.putFormInDock(ruf, MdiParent);
        }
    }
}
