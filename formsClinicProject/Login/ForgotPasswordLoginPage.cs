using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using formsClinicProject.DataAccess;

namespace formsClinicProject
{
    public partial class ForgotPasswordLoginPage : Form
    {
        string userCode;
        public static string toWho;
        string fromWho, password, messageBody;

        public ForgotPasswordLoginPage()
        {
            InitializeComponent();
        }

        private void bntSendEmail_Click(object sender, EventArgs e)
        {

            if (UserDataAccess.ForgotPassword(txtUsername.Text, txtEmail.Text) == null)
            {
                MessageBox.Show("Invalid data");
            }
            else
            {
                // generowanie losowego kodu dzięki któremu będzie można przeprowadzić walidację
                Random rand = new Random();
                userCode = (rand.Next(999999)).ToString();

                // konfiguracja wiadomości email

                MailMessage message = new MailMessage();
                toWho = (txtEmail.Text).ToString();
                fromWho = "clinicroot04@gmail.com";
                password = "Adminkliniki%";
                messageBody = "Your reset code is " + userCode;
                message.To.Add(toWho);
                message.From = new MailAddress(fromWho);
                message.Body = messageBody;
                message.Subject = "Password reseting code";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(fromWho, password);
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Code send successfully");
                    txtCode.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("Username"))
            {
                txtUsername.Text = "";
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {
                txtUsername.Text = "Username";
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text.Equals("Email"))
            {
                txtEmail.Text = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text.Equals(""))
            {
                txtEmail.Text = "Email";
            }
        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            if (txtCode.Text.Equals("Code"))
            {
                txtCode.Text = "";
            }
        }

        private void buttonBackToLogin_Click(object sender, EventArgs e)
        {

        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            if (txtCode.Text.Equals(""))
            {
                txtCode.Text = "Code";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userCode != (txtCode.Text).ToString())
            {
                MessageBox.Show("Wrong code!");
            }
            else
            {
                ResetPasswordLoginPage RPLP = new ResetPasswordLoginPage(toWho);
                RPLP.ShowDialog();
                this.Close();
            }
        }
    }
}
