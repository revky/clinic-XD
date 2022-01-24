using System;
using System.Windows.Forms;
using formsClinicProject.DataAccess;

namespace formsClinicProject
{
    public partial class PasswordConfirmationForm : Form
    {
        int loggedUserId;
        public PasswordConfirmationForm(int loggedUserId, string labelText)
        {
            InitializeComponent();

            this.loggedUserId = loggedUserId;
            label1.Text = labelText;
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserDataAccess.GetUserById(loggedUserId).Password != txtPassword.Text)
                {
                    label2.Text = "Incorrect password!";
                    label2.Visible = true;
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
