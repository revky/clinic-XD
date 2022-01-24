using System;
using System.Windows.Forms;
using formsClinicProject.DataAccess;

namespace formsClinicProject
{
    public partial class ResetPasswordLoginPage : Form
    {
        string user_email;

        public ResetPasswordLoginPage(string email)
        {
            InitializeComponent();
            user_email = email;
        }

        private void bntAcceptPassword_Click(object sender, EventArgs e)
        {
            if (!User.PasswordValidation(textBoxNewPassword.Text))
            {
                MessageBox.Show("Password needs to have between 8 '&' 15 characters and contain one of:\n lowercase, uppercase, digital, special sign.");
                return;
            }

            if (textBoxNewPassword.Text != textBoxConfirmPassword.Text)
            {
                MessageBox.Show("Both fields must contain the same password!");
                return;
            }
            try
            {
                UserDataAccess.ChangePassword(textBoxNewPassword.Text, user_email);
                MessageBox.Show("Reset successful");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBoxNewPassword.PasswordChar = '\0';
                textBoxConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxNewPassword.PasswordChar = '*';
                textBoxConfirmPassword.PasswordChar = '*';
            }
        }
    }
}
