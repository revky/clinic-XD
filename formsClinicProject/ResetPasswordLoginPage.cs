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

namespace formsClinicProject
{
    public partial class ResetPasswordLoginPage : Form
    {
        string email = ForgotPasswordLoginPage.toWho;
        public ResetPasswordLoginPage()
        {
            InitializeComponent();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // czemu nie mogę użyć operatora "?"
            if(txtNewPassword.isPassword == false)
            {
                txtNewPassword.isPassword = true;
            }
            else
            {
                txtNewPassword.isPassword = false;
            }
                

        }

        private void bntAcceptPassword_Click(object sender, EventArgs e)
        {
            if(txtNewPassword.Text != txtNewPasswordConfirm.Text)
            {
                MessageBox.Show("Passwords are not equal");
            }
            else
            {
              //  UserDataAccess.ResetPassword(email, txtNewPassword.Text); //Kurcze trzeba to poprawic
                MessageBox.Show("Reset successful");
                this.Close();
            }
        }

        private void ResetPasswordLoginPage_Load(object sender, EventArgs e)
        {
            txtNewPassword.isPassword = true;
        }
    }
}
