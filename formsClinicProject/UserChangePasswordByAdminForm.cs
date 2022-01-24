using System;
using System.Windows.Forms;
using formsClinicProject.DataAccess;

namespace formsClinicProject
{
    public partial class UserChangePasswordByAdminForm : Form
    {
        User userForPasswordChange = new User();

        public UserChangePasswordByAdminForm(User user)
        {
            InitializeComponent();

            userForPasswordChange = user;
        }

        private void txtNewPassEnter(Object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text.Equals("Password"))
            {
                textBoxNewPassword.Text = "";
            }
        }
    

        private void txtNewPassLeave(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text.Equals(""))
            {
                textBoxNewPassword.Text = "Password";
            }

        }
     
        private void txtConfirmPassLeave(object sender, EventArgs e)
        {
            if (textBoxConfirmPassword.Text.Equals(""))
            {
                textBoxConfirmPassword.Text = "Password";

            }
        }
        private void txtConfirmPassEnter(object sender, EventArgs e)
        {
         

            if (textBoxConfirmPassword.Text.Equals("Password"))
            {
                textBoxConfirmPassword.Text = "";
            }
        }

    

            private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (!User.PasswordValidation(textBoxNewPassword.Text))
            {
                label3.Visible = true;
                label3.Text = "Password needs to have between 8 '&' 15 characters and contain one of:\n lowercase, uppercase, digital, special sign.";
                return;
            }

            if (textBoxNewPassword.Text != textBoxConfirmPassword.Text)
            {
                label3.Visible = true;
                label3.Text = "Both fields must contain the same password!";
                return;
            }

            try
            {
                UserDataAccess.ResetPassword(textBoxConfirmPassword.Text, userForPasswordChange.Id_user); //TODO nadać mail z employee

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //Customizowane inputy nie rozumieją PasswordChar i trzeba użyć isPassword
                textBoxNewPassword.isPassword = false;
                textBoxConfirmPassword.isPassword = false;

                /*
                textBoxNewPassword.PasswordChar = '\0';
                textBoxConfirmPassword.PasswordChar = '\0';
                */
            }
            else
            {
                textBoxNewPassword.isPassword = true;
                textBoxConfirmPassword.isPassword = true;
                /*
                textBoxNewPassword.PasswordChar = '*';
                textBoxConfirmPassword.PasswordChar = '*';
                */
            }
        }

     

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

    

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
