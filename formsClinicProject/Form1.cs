using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using formsClinicProject.DataAccess;

namespace formsClinicProject
{
    public partial class Form1 : Form
    {
        //zmienne globalne służące do blokady panelu logowania po trzech nieudanych próbach
        //time left - czas pozostały do odblokowania systemu, attempts - ilość pozostałych prób
        DateTime timeLeft = new DateTime();
        int attempts = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtUserEnter(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("Username"))
            {
                txtUsername.Text = "";
            }
        }

        private void txtUserLeave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {
                txtUsername.Text = "Username";
            }
        }

        private void txtPassEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Password"))
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = "Password";
            }
        }

        //Timer, którego akcja jest wywowyłana po takim czasie, na jaki jest ustawiona blokada, po określonym czasie odblokowywuje odpowiednie elementy formatki
        private void timer_Tick(object sender, EventArgs e)
        {
            attempts = 3;

            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            bntLogin.Enabled = true;
            label2.Visible = false;

            timerBlock.Enabled = false;
            timerShowTime.Enabled = false;

        }

        //Timer, którego akcja jest wywoływana co sekunde aby wyświetlać pozostały czas blokady
        private void timerShowTime_Tick(object sender, EventArgs e)
        {
            timeLeft = timeLeft.AddSeconds(-1);

            label2.Text = $"Three failed attempts. System locked for: {timeLeft.ToString("mm:ss")}";
        }

        private void buttonCloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntLogin_Click_1(object sender, EventArgs e)
        {
            //Weryfikacja wprowadzonych danych, jeżeli funkcja nie odnajdzie użyktownika w bazie zwraca null
            //Jeżeli zwróci null, odliczane są próby logowania
            if (UserDataAccess.LoginUser(txtUsername.Text, txtPassword.Text) == null)
            {
                attempts -= 1;

                if (attempts == 0) //Po trzech nieudanych próbach odpala timer'y i nakłada blokady, które zostaną zdjęte przez timer po określonym czasie.
                {
                    timeLeft = timeLeft.AddMinutes(2);

                    timerBlock.Enabled = true;
                    timerShowTime.Enabled = true;

                    txtUsername.Enabled = false;
                    txtPassword.Enabled = false;
                    bntLogin.Enabled = false;
                }
                else
                {
                    label2.Visible = true;
                    label2.Text = $"Incorrect login or password. Attempts left: {attempts}";
                }
            }
            else
            {
                AdminPanelForm apf = new AdminPanelForm(txtUsername.Text, UserDataAccess.LoginUser(txtUsername.Text, txtPassword.Text).Id_user);

                //Ukrywa formatke logowania
                Hide();

                apf.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ForgotPasswordLoginPage fplp = new ForgotPasswordLoginPage();
            fplp.ShowDialog();
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminPanelForm apf = new AdminPanelForm("ale leniuszek", 5);

            //Ukrywa formatke logowania
            Hide();

            apf.ShowDialog();
        }

   
    }
}
