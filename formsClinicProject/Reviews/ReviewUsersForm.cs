using System;
using System.Windows.Forms;
using formsClinicProject.DataAccess;

namespace formsClinicProject
{
    public partial class ReviewUsersForm : Form
    {
        int loggedUserId;

        public ReviewUsersForm(int loggedUserId)
        {
            InitializeComponent();

            this.loggedUserId = loggedUserId;
        }

        private void btnDeactivatelUser_Click(object sender, EventArgs e)
        {
            try
            {
                PasswordConfirmationForm pcf = new PasswordConfirmationForm(loggedUserId, "Confirm your password to change user's status");

                if (pcf.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                else
                {
                    int userId = (int)dataGridViewListOfUsers.CurrentRow.Cells[0].Value;

                    if (btnDeactivatelUser.Text == "Deactivate user")
                    {
                        if (CalendarDataAccess.CheckIfEmployeeHavePlannedWork(userId))
                            MessageBox.Show("You can't deactivate user with planned work");
                        else
                            UserDataAccess.DeactivateUser(userId);
                    }
                    else
                        UserDataAccess.ActivateUser(userId);

                    dataGridViewListOfUsers.DataSource = UserDataAccess.GetListOfUsersFromView();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Edytuje wybranego w datagridview użytkownika
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            try
            {
                int userId = (int)dataGridViewListOfUsers.CurrentRow.Cells[0].Value;
                User user = UserDataAccess.GetUserById(userId);
                EditUserForm euf = new EditUserForm(user);
                euf.MdiParent = MdiParent;
                euf.Show();
                euf.Dock = DockStyle.Fill;
                euf.FormBorderStyle = FormBorderStyle.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Otwiera formatkę do zmiany hasła dla wybranego w datagridview user'a
        private void btnSetChangePasswordUser_Click(object sender, EventArgs e)
        {
            try
            {
                int userId = (int)dataGridViewListOfUsers.CurrentRow.Cells[0].Value;
                User user = UserDataAccess.GetUserById(userId);

                UserChangePasswordByAdminForm newForm = new UserChangePasswordByAdminForm(user);
                newForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReviewUsersForm_Load(object sender, EventArgs e)
        {
            //Przypisuje dane do datagridview z funkcji GetListOfUsersFromView()
            //Ta funkcja zwraca DataTable z widoku w bazie danych
            dataGridViewListOfUsers.DataSource = UserDataAccess.GetListOfUsersFromView();
            dataGridViewListOfUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewListOfUsers.Columns[0].HeaderText = "User Id";
            dataGridViewListOfUsers.Columns[1].HeaderText = "Login";
            dataGridViewListOfUsers.Columns[2].HeaderText = "First name";
            dataGridViewListOfUsers.Columns[3].HeaderText = "Last name";
            dataGridViewListOfUsers.Columns[4].HeaderText = "Email";
            dataGridViewListOfUsers.Columns[5].HeaderText = "Permission group";
        }

        private void dataGridViewListOfUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewListOfUsers.CurrentRow != null)
            {
                string userStatus = dataGridViewListOfUsers.CurrentRow.Cells[6].Value.ToString().Trim();

                if (userStatus == "Active")
                    btnDeactivatelUser.Text = "Deactivate user";
                else
                    btnDeactivatelUser.Text = "Activate user";
            }
        }

        private void dataGridViewListOfUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
